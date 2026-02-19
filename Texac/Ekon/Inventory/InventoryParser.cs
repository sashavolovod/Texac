using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Texac.Ekon.Inventory
{
    public class InventoryParser
    {
        public class OrderInfo
        {
            public int OrderId { get; set; }
            public int RemainingQty { get; set; }
            public double Completed { get; set; }
            public DateTime? FactReadyDate { get; set; }
            public string Employee { get; set; }
            public string ObozTO { get; set; }
        }

        public static async Task<InventoryEntity> ParseInventoryData(string fileContent)
        {
            InventoryEntity inventory = new InventoryEntity();
            inventory.entries = new List<InventoryEntry>();

            var lines = fileContent.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            bool dataStarted = false;
            string currentOrderNumber = null;

            string src = lines[2];

            inventory.period = src
                .Replace("\t", "")
                .Replace("Период:", "")
                .Trim();

            var ru = new CultureInfo("ru-RU");

            inventory.startDate = DateTime.ParseExact(
                inventory.period,
                "MMMM yyyy 'г.'",
                ru
            );

            inventory.endDate = inventory.startDate.AddMonths(1).AddSeconds(-1);

            List<InventoryStore> storeItems = new List<InventoryStore>();


            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i].TrimEnd();
                if (string.IsNullOrWhiteSpace(line)) continue;

                if (!dataStarted)
                {
                    // Пропускаем заголовки до начала данных
                    if (line.Contains("Количество") && line.Contains("Стоимость, руб."))
                    {
                        dataStarted = true;
                    }
                    continue;
                }

                // Останавливаемся на "Итого:"
                if (line.Contains("Итого:") || line.Contains("002.1") || line.Contains("003.1")) break;

                // Разделяем по табам
                string[] fields = line.Split('\t');

                // Проверяем, является ли строка номером заказа
                string field1 = fields[1].Trim();
                string field3 = fields[3].Trim();
                if (string.IsNullOrWhiteSpace(field3) && !string.IsNullOrWhiteSpace(field1) && (Regex.IsMatch(field1, @"^\d+$") || field1.EndsWith("/233") || field1.EndsWith("/23")))
                {
                    currentOrderNumber = field1;
                    continue;
                }

                // Проверяем, является ли строка материалом (признак "х" в fields[4])
                string field4 = fields[4].Trim();
                if (field4 == "х")
                {
                    try
                    {
                        var entry = new InventoryEntry();
                        entry.orderNumber = currentOrderNumber;
                        entry.code = fields[1].Trim();
                        entry.name = fields[2].Trim();
                        entry.unit = field3;
                        entry.startQuantity = ParseDouble(fields[5]);
                        entry.startCost = ParseDouble(fields[6]);
                        entry.debitQuantity = ParseDouble(fields[7]);
                        entry.debitCost = ParseDouble(fields[8]);
                        entry.creditQuantity = ParseDouble(fields[9]);
                        entry.creditCost = ParseDouble(fields[10]);
                        entry.endQuantity = ParseDouble(fields[11]);
                        if (fields.Length > 12)
                            entry.endCost = ParseDouble(fields[12]);
                        inventory.entries.Add(entry);



                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + line);
                    }
                }
                // Пропускаем служебные строки и строки ТТН (они не содержат "х" в fields[4])
            }

            using (OleDbConnection connection = new OleDbConnection(Properties.Settings.Default.connStr))
            {
                try
                {
                    connection.Open();

                    Dictionary<string, OrderInfo> orderDict = new Dictionary<string, OrderInfo>();
                    Dictionary<string, double> materialOrderDict = new Dictionary<string, double>();

                    // Собираем все трансформированные номера заказов
                    List<string> transformedNumbers = inventory.entries
                        .Select(e => TransformOrderNumber(e.orderNumber))
                        .Distinct()
                        .ToList();

                    if (transformedNumbers.Count > 0)
                    {
                        // Формируем IN clause с параметрами
                        string inClause = string.Join(",", Enumerable.Range(0, transformedNumbers.Count).Select(i => "?"));

                        string query = string.Format(@"
    SELECT 
        z.[NЗаказаЗавода], 
        z.[NППЗаказа], 
        z.[Кол_во]-IIF(IsNull(z.[ФКол_во]),0,z.[ФКол_во]) AS remaining_qty,
        IIF(
        IsNull(
            Sum(
                IIF(v.[ДатаОкончанияРаботы] < ?, 
                    v.[КоличОкончРаб] * v.[НормаВремени], 
                    0)
            )
        ),
        0,
        Sum(
            IIF(v.[ДатаОкончанияРаботы] < ?, 
                v.[КоличОкончРаб] * v.[НормаВремени], 
                0)
        )
    ) AS Выполнено,
        z.[ФактДатаИзготовления],
        e.[ФИО],
        z.[ОбозначениеТО]
    FROM ([Заказы] AS z 
    LEFT JOIN [РаботникиЦеха] e ON z.[Технолог] = e.[NТабельный])
    LEFT JOIN [ВыполнениеЗаказа] AS v ON z.[NППЗаказа] = v.[NППЗаказа]
    WHERE z.[NЗаказаЗавода] IN ({0})
    GROUP BY z.[NЗаказаЗавода], z.[NППЗаказа], z.[Кол_во], z.[ФКол_во], z.[ФактДатаИзготовления], e.[ФИО], z.[ОбозначениеТО]",
    inClause);

                        using (OleDbCommand command = new OleDbCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("?", inventory.endDate);
                            command.Parameters.AddWithValue("?", inventory.endDate);
                            // Добавляем все параметры
                            foreach (string number in transformedNumbers)
                            {
                                command.Parameters.AddWithValue("?", number);
                            }


                            // Читаем все результаты в словарь
                            using (OleDbDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string orderNumber = reader[0].ToString();
                                    int orderId = Convert.ToInt32(reader[1]);
                                    int remainingQty = reader[2] == DBNull.Value ? 0 : Convert.ToInt32(reader[2]);
                                    double completed = reader[3] == DBNull.Value ? 0 : Convert.ToDouble(reader[3]);
                                    DateTime? factReadyDate = reader[4] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader[4]);
                                    string emp = reader[5].ToString();
                                    string obozTO = reader[6].ToString();

                                    orderDict[orderNumber] = new OrderInfo
                                    {
                                        OrderId = orderId,
                                        RemainingQty = remainingQty,
                                        Completed = completed,
                                        FactReadyDate = factReadyDate,
                                        Employee = emp,
                                        ObozTO = obozTO
                                    };
                                }
                            }
                        }


                        query = string.Format(@"
SELECT 
    o.NППЗаказа,
	CardNum,
	Материа,
	Sum([ВесВсего]*[Кол_во]) AS Norm
FROM Заказы o 
INNER JOIN МатериальнаяКарта m ON o.NППЗаказа = m.NППЗаказа
WHERE o.[NЗаказаЗавода] IN ({0}) AND CardNum<>0 
GROUP BY o.NППЗаказа, CardNum, Материа",
                        inClause);

                        using (OleDbCommand command = new OleDbCommand(query, connection))
                        {
                            // Добавляем все параметры
                            foreach (string number in transformedNumbers)
                            {
                                command.Parameters.AddWithValue("?", number);
                            }


                            using (OleDbDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    int orderId = Convert.ToInt32(reader[0]);
                                    int cardNum = reader[1] == DBNull.Value ? 0 : Convert.ToInt32(reader[1]);
                                    double norm = reader[3] == DBNull.Value ? 0 : Convert.ToDouble(reader[3]);
                                    materialOrderDict[String.Format("{0}-{1}", orderId, cardNum)] = norm;
                                }
                            }
                        }

                    }

                    // Проставляем OrderId из словаря
                    foreach (InventoryEntry entry in inventory.entries)
                    {
                        string transformedNumber = TransformOrderNumber(entry.orderNumber);
                        if (orderDict.ContainsKey(transformedNumber))
                        {
                            entry.orderId = orderDict[transformedNumber].OrderId;
                            entry.remainingQty = orderDict[transformedNumber].RemainingQty;
                            entry.completed = orderDict[transformedNumber].Completed;
                            entry.factReadyDate = orderDict[transformedNumber].FactReadyDate;
                            entry.obozTO = orderDict[transformedNumber].ObozTO;
                            entry.employee = orderDict[transformedNumber].Employee;
                        }

                        string materialOrderKey = String.Format("{0}-{1}", entry.orderId, entry.code);
                        if (materialOrderDict.ContainsKey(materialOrderKey))
                        {
                            entry.normQuantity = materialOrderDict[materialOrderKey];
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка выполнения запроса: " + ex.Message);
                }
            }


            // списание материалов
            foreach (InventoryEntry entry in inventory.entries)
            {
                if ((entry.remainingQty > 0 && entry.completed > 0) ||
                     (entry.remainingQty == 0 && (entry.factReadyDate != null && (entry.factReadyDate >= inventory.startDate && entry.factReadyDate <= inventory.endDate))))
                {
                    // if (entry.startQuantity + entry.debitQuantity <= Math.Round(entry.normQuantity, 3))
                    //{
                    //entry.creditQuantity = entry.startQuantity + entry.debitQuantity;
                    entry.creditQuantity = entry.endQuantity;
                    entry.creditCost = entry.endCost;
                    entry.endQuantity = 0.0;
                    entry.endCost = 0.0;
                    //}
                }
                else
                {
                    entry.normQuantity = 0.0;
                }


                int cardNum = 0;

                int.TryParse(entry.code, out cardNum);

                if (cardNum > 0 && entry.debitQuantity > 0)
                {
                    storeItems.Add(new InventoryStore
                    {
                        period = inventory.startDate,
                        cardNumber = cardNum,
                        orderId = entry.orderId,
                        debitQuantity = entry.debitQuantity
                    });
                }
            }


            if (storeItems.Count > 0)
                try
                {
                    await SaveInventoryListAsync(storeItems);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }


            return inventory;
        }

        public static Task SaveInventoryListAsync(List<InventoryStore> items)
        {
            return Task.Run(() =>
            {
                using (var connection =
                    new OleDbConnection(Properties.Settings.Default.connStr))
                {
                    connection.Open();

                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            string updateSql = @"UPDATE InventoryStore 
                                         SET debitQuantity = ? 
                                         WHERE period = ? AND cardNumber = ?  AND orderId = ?";

                            string insertSql = @"INSERT INTO InventoryStore
                                         (period, cardNumber, orderId, debitQuantity)
                                         VALUES (?, ?, ?, ?)";

                            using (var updateCmd = new OleDbCommand(updateSql, connection, transaction))
                            using (var insertCmd = new OleDbCommand(insertSql, connection, transaction))
                            {
                                // Параметры создаём один раз
                                updateCmd.Parameters.Add("?", OleDbType.Double);
                                updateCmd.Parameters.Add("?", OleDbType.VarChar);
                                updateCmd.Parameters.Add("?", OleDbType.Integer);
                                updateCmd.Parameters.Add("?", OleDbType.Integer);

                                insertCmd.Parameters.Add("?", OleDbType.VarChar);
                                insertCmd.Parameters.Add("?", OleDbType.Integer);
                                insertCmd.Parameters.Add("?", OleDbType.Integer);
                                insertCmd.Parameters.Add("?", OleDbType.Double);

                                foreach (var item in items)
                                {
                                    // UPDATE
                                    updateCmd.Parameters[0].Value = item.debitQuantity;
                                    updateCmd.Parameters[1].Value = item.period;
                                    updateCmd.Parameters[2].Value = item.cardNumber;
                                    updateCmd.Parameters[3].Value = item.orderId;

                                    int rows = updateCmd.ExecuteNonQuery();

                                    // INSERT если не обновилось
                                    if (rows == 0)
                                    {
                                        insertCmd.Parameters[0].Value = item.period;
                                        insertCmd.Parameters[1].Value = item.cardNumber;
                                        insertCmd.Parameters[2].Value = item.orderId;
                                        insertCmd.Parameters[3].Value = item.debitQuantity;

                                        insertCmd.ExecuteNonQuery();
                                    }
                                }
                            }

                            transaction.Commit();
                        }
                        catch
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
            });
        }

        private static double ParseDouble(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return 0.0;
            s = s.Trim().Replace(",", ".");
            double value;
            double.TryParse(s, NumberStyles.Any, CultureInfo.InvariantCulture, out value);
            return value;
        }

        public static string TransformOrderNumber(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            // Удаляем пробелы в начале и конце
            input = input.Trim();

            // Проверяем, содержит ли строка '/'
            if (input.Contains("/"))
            {
                string[] parts = input.Split('/');

                if (parts.Length == 2)
                {
                    string leftPart = parts[0].Trim();
                    string rightPart = parts[1].Trim();

                    // Проверяем длину правой части
                    if (rightPart.Length == 2)
                    {
                        // Если правая часть состоит из 2 символов, используем '-'
                        return rightPart + "-" + leftPart;
                    }
                    else
                    {
                        // В остальных случаях меняем местами и оставляем '/'
                        return rightPart + "/" + leftPart;
                    }
                }
            }
            else
            {
                // Если нет '/', добавляем '208/' в начало
                return "208/" + input;
            }

            return input;
        }
    }
}
