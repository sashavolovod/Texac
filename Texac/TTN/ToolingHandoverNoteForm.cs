using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Texac.TTN
{
    public partial class ToolingHandoverNoteForm : Form
    {
        public ToolingHandoverNoteForm()
        {
            InitializeComponent();
        }

        private void GetHandoverNoteInfo(int orderId)
        {
            string sql = @"
SELECT 
    Заказы.NППЗаказа AS OrderId,
    Заказы.NЗаказаЗавода + '-' + CStr(Заказы.NППЗаказа) AS OrderNumber,
    Детали.НаименованиеДетали AS PartName,
    Заказы.NДетали AS PartNumber,
    Заказы.ОбозначениеТО AS ToolingCode,
    КодыНаименованийТО.НаименованиеТО AS ToolingName,
    Заказы.Кол_во AS Qty,
    Заказы.p_unit AS UnitName,
    НомераЦехов.Цех AS Customer,
    IIf([Стойкость] Is Null, '', CStr([Стойкость])) AS ToolLife
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
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        tbOrderId.Text = reader["OrderId"] == DBNull.Value ? "" : reader["OrderId"].ToString();
                        tbOrderNumber.Text = reader["OrderNumber"] == DBNull.Value ? "" : reader["OrderNumber"].ToString();
                        tbPartName.Text = reader["PartName"] == DBNull.Value ? "" : reader["PartName"].ToString();
                        tbPartNumber.Text = reader["PartNumber"] == DBNull.Value ? "" : reader["PartNumber"].ToString();
                        tbCustomer.Text = reader["Customer"] == DBNull.Value ? "" : reader["Customer"].ToString();
                        tbToolingCode.Text = reader["ToolingCode"] == DBNull.Value ? "" : reader["ToolingCode"].ToString();
                        tbToolingName.Text = reader["ToolingName"] == DBNull.Value ? "" : reader["ToolingName"].ToString();
                        tbToolLife.Text = reader["ToolLife"] == DBNull.Value ? "" : reader["ToolLife"].ToString();
                    }
                }
            }
            btnPreview.Focus();
        }


        private void tbOrderId_KeyDown(object sender, KeyEventArgs e)
        {
            int orderId;
            if (e.KeyCode == Keys.Enter)
            {
                // Получаем значение из TextBox
                string input = tbOrderId.Text.Trim();

                // Проверка на пустое поле
                if (string.IsNullOrEmpty(input))
                {
                    MessageBox.Show("Поле 'Номер заказа' не может быть пустым.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbOrderId.Focus(); // Возвращаем фокус на поле
                    e.Handled = true; // Предотвращаем дальнейшую обработку Enter
                    return;
                }

                // Проверка, что введено целое число
                if (!int.TryParse(input, out orderId))
                {
                    MessageBox.Show("Введите корректное целое число для номера заказа.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbOrderId.Focus();
                    e.Handled = true;
                    return;
                }

                // Проверка, что число положительное
                if (orderId <= 0)
                {
                    MessageBox.Show("Номер заказа должен быть положительным числом.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbOrderId.Focus();
                    e.Handled = true;
                    return;
                }

                // Если проверка прошла успешно, можно, например, переместить фокус на следующее поле
                tbOrderNumber.Focus(); // Или другое поле формы
                e.Handled = true;
                e.SuppressKeyPress = true; // Предотвращаем звуковой сигнал при нажатии Enter
                GetHandoverNoteInfo(orderId);
            }
        }

        private string getNextDocNumber()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(Texac.Properties.Settings.Default.api_path);
                client.DefaultRequestHeaders.Add("User-Agent", "TexacHttpClient");
                try
                {
                    HttpResponseMessage response = client.GetAsync("/api/psn-order-number").Result;
                    string responseBody = response.Content.ReadAsStringAsync().Result;
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        MessageBox.Show(responseBody, "Ошибка при получении номера документа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return responseBody;
                }
                catch (AggregateException ex)
                {
                    MessageBox.Show("Ошибка при получении номера документа." + ex.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return "";
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            ReportParameter[] parameters = new ReportParameter[12];
            parameters[0] = new ReportParameter("parCustomer", tbCustomer.Text);
            parameters[1] = new ReportParameter("parToolingCode", tbToolingCode.Text);
            parameters[2] = new ReportParameter("parOrderNumber", tbOrderNumber.Text);
            parameters[3] = new ReportParameter("parToolingName", tbToolingName.Text);
            parameters[4] = new ReportParameter("parToolLife", tbToolLife.Text);
            parameters[5] = new ReportParameter("parPartName", tbPartName.Text);
            parameters[6] = new ReportParameter("parPartNumber", tbPartNumber.Text);
            parameters[7] = new ReportParameter("parIssued", tbIssued.Text);
            parameters[8] = new ReportParameter("parReceived", tbReceived.Text);
            parameters[9] = new ReportParameter("parNoteNumber", getNextDocNumber());
            parameters[10] = new ReportParameter("parOrderId", tbOrderId.Text);
            parameters[11] = new ReportParameter("parReceivedPost", tbReceivedPost.Text);
            var report = new ToolingHandoverNoteReportForm(parameters);
            report.Show();
        }
    }
}
