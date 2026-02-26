using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Texac.ToolingDesign
{
    public class DbHelper
    {
        public static async Task<List<JobOrderReportMaster>> GetOrderReportDtoListAsync()
        {
            List<JobOrderReportMaster> list = new List<JobOrderReportMaster>();

            string queryString = @"
SELECT 
    Заказы.NППЗаказа AS OrderId,
    Заказы.NЗаказаЗавода AS OrderNumber,
    Заказы.ОбозначениеТО + "" "" + КодыНаименованийТО.НаименованиеТО,
    Заказы.NИзделия + "" "" + Изделия.НаименованиеИзделия,
    Заказы.NДетали + "" "" + Детали.НаименованиеДетали,
    Заказы.Кол_во,
    Заказы.p_unit,
    НомераЦехов.НаименованиеЦеха AS Customer,
    РаботникиЦеха_1.ФИО AS Технолог,
    Заказы.ПланДатаИзготовления,
    Заказы.СодержаниеЗаявки, 
    Заказы.Life,
    Заказы.Lifeday,
    Заказы.ObjectType,
    Заказы.Quckly,
    Заказы.ГрафикN,
    Заказы.TNVED,
    Заказы.CustomerMaterial
FROM НомераЦехов RIGHT JOIN 
    (КодыНаименованийТО INNER JOIN (Изделия INNER JOIN (Детали INNER JOIN (РаботникиЦеха AS РаботникиЦеха_1 RIGHT JOIN Заказы ON РаботникиЦеха_1.NТабельный = Заказы.Технолог) ON Детали.NДетали = Заказы.NДетали) ON Изделия.NИзделия = Заказы.NИзделия) ON КодыНаименованийТО.КодТО = Заказы.КодТО) ON НомераЦехов.NЦеха = Заказы.Заказчик
WHERE (((Заказы.NППЗаказа)=108821))
ORDER BY Заказы.NППЗаказа;

";
            using (OleDbConnection connection = new OleDbConnection(Texac.Properties.Settings.Default.connStr))
            {
                try
                {
                    await connection.OpenAsync();
                    using (OleDbCommand command = new OleDbCommand(queryString, connection))
                    using (OleDbDataReader reader = (OleDbDataReader)await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            int OrderId = reader.GetInt32(0);
                            string OrderNumber = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
                            string Tooling = reader.IsDBNull(2) ? string.Empty : reader.GetString(2);
                            string Item = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                            string Part = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);
                            int TotalQuantity = reader.GetInt32(5);
                            string Unit = reader.IsDBNull(6) ? string.Empty : reader.GetString(6);
                            string Customer = reader.IsDBNull(7) ? string.Empty : reader.GetString(7);
                            string EmployeeName = reader.IsDBNull(8) ? string.Empty : reader.GetString(8);
                            DateTime OrderDate = reader.GetDateTime(9);
                            string OrderDescription = reader.IsDBNull(10) ? string.Empty : reader.GetString(10);
                            int ServiceLifeYear = reader.GetInt16(11);
                            int ServiceLifeDay = reader.GetInt32(12);
                            int ObjectType = reader.GetByte(13);

                            JobOrderReportMaster jobDto = new JobOrderReportMaster()
                            {
                                OrderId = OrderId,
                                OrderNumber = OrderNumber,

                                OrderDate = OrderDate
                            };


                            list.Add(jobDto);

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return list;
        }
    }
}
