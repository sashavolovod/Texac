using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Texac.Common;

namespace Texac.Request
{
    public class DbHelper
    {

        public static async Task<List<ComboBoxEntity>> GetMasterListAsync()
        {
            return await GetEmployeeListAsync("SELECT [NТабельный], [ФИО] FROM [РаботникиЦеха] WHERE [работает] = true AND [ПрофессияДолжность] IN (250, 252, 389) ORDER BY [ФИО]");
        }

        public static async Task<List<ComboBoxEntity>> GetProcessEngineerListAsync()
        {
            return await GetEmployeeListAsync("SELECT [NТабельный], [ФИО] FROM [РаботникиЦеха] WHERE [работает] = true AND [ПрофессияДолжность] IN (40, 188, 189, 190) ORDER BY [ФИО]");
        }



        private static async Task<List<ComboBoxEntity>> GetEmployeeListAsync(string queryString)
        {
            List<ComboBoxEntity> list = new List<ComboBoxEntity>();

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
                            int id = reader.GetInt32(0);
                            string employeeName = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
                            if (!string.IsNullOrEmpty(employeeName))
                                list.Add(new ComboBoxEntity(id, employeeName));
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

        public static async Task<RequestEntity> GetRequestEntityAsync(int orderId)
        {
            RequestEntity requestEntity = new RequestEntity();

            string sql = @"
SELECT 
    Заказы.NППЗаказа AS OrderId,
    Заказы.NЗаказаЗавода + '-' + CStr(Заказы.NППЗаказа) AS OrderNumber,
    НаименованиеТО + ' «' + ОбозначениеТО +   '» ('+ Заказы.NДетали  + ' деталь «' + НаименованиеДетали +  '»)'   AS Description,
    Заказы.Кол_во AS Qty,
    НомераЦехов.Цех AS Customer,
    Технолог as Employee,
    Слесарь as Master,
    СодержаниеЗаявки as ScopeOfWork
FROM 
    (КодыНаименованийТО 
        INNER JOIN 
            (Детали 
                INNER JOIN Заказы 
                ON Детали.NДетали = Заказы.NДетали
            ) 
        ON КодыНаименованийТО.КодТО = Заказы.КодТО
    )
    INNER JOIN НомераЦехов 
    ON Заказы.Заказчик = НомераЦехов.NЦеха
WHERE 
    Заказы.NППЗаказа = @OrderId;
";

            using (OleDbConnection connection = new OleDbConnection(Texac.Properties.Settings.Default.connStr))
            using (var cmd = new OleDbCommand(sql, connection))
            {
                cmd.Parameters.AddWithValue("@OrderId", orderId);
                connection.Open();
                //using (var reader = cmd.ExecuteReader())
                using (OleDbDataReader reader = (OleDbDataReader)await cmd.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        requestEntity.OrderId = Int32.Parse(reader["OrderId"].ToString());
                        requestEntity.OrderNumber = reader["OrderNumber"] == DBNull.Value ? "" : reader["OrderNumber"].ToString();
                        requestEntity.Description = reader["Description"] == DBNull.Value ? "" : reader["Description"].ToString();
                        requestEntity.Customer = reader["Customer"] == DBNull.Value ? "" : reader["Customer"].ToString();
                        requestEntity.EmployeeId = reader["Employee"] == DBNull.Value ? -1 : Int32.Parse(reader["Employee"].ToString());
                        requestEntity.MasterId = reader["Master"] == DBNull.Value ? -1 : Int32.Parse(reader["Master"].ToString());
                        requestEntity.Qty = reader["Qty"] == DBNull.Value ? 1 : Int32.Parse(reader["Qty"].ToString());
                        requestEntity.ScopeOfWork = reader["ScopeOfWork"] == DBNull.Value ? "" : reader["ScopeOfWork"].ToString();
                        requestEntity.RequestDate = DateTime.Now;
                    }
                }
            }

            return requestEntity;
        }
    }
}
