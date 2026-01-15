using Microsoft.Reporting.WinForms;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;

namespace Texac.TTN
{
    public partial class ToolingHandoverNoteReportForm : Form
    {
        private ReportParameter[] parameters;
        public ToolingHandoverNoteReportForm(ReportParameter[] parameters)
        {
            this.parameters = parameters;
            InitializeComponent();
            this.reportViewer1.LocalReport.SetParameters(parameters);
        }

        private void ToolingHandoverNoteReportForm_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_PrintingBegin(object sender, ReportPrintEventArgs e)
        {
            
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(Texac.Properties.Settings.Default.api_path);
                client.DefaultRequestHeaders.Add("User-Agent", "TexacHttpClient");
                try
                {
                    PsnEntityDTO p = new PsnEntityDTO();
                    p.docNumber = parameters[9].Values[0];
                    p.docDate = DateTime.Now;
                    p.orderId = Int32.Parse(parameters[10].Values[0]);
                    p.orderNumber = parameters[2].Values[0];
                    p.orderDescription = parameters[1].Values[0] + "  " + parameters[3].Values[0];
                    p.customer = parameters[0].Values[0];
                    p.qty = 1;
                    p.unitName = "шт";
                    p.computerName = System.Environment.MachineName;

                    // Настройка JsonSerializer для ISO 8601
                    var settings = new JsonSerializerSettings
                    {
                        DateFormatString = "yyyy-MM-dd'T'HH:mm:ss",
                    };

                    string psnDtoJson = JsonConvert.SerializeObject(p, settings);

                    var postData = new StringContent(psnDtoJson, System.Text.Encoding.UTF8, "application/json");
                    HttpResponseMessage response = client.PostAsync("/api/psn_entities", postData).Result;
                    string responseBody = response.Content.ReadAsStringAsync().Result;
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        MessageBox.Show(responseBody, "Ошибка при отправке HTTP-запроса", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true; // отменяем печать
                    }
                }
                catch (AggregateException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка при отправке HTTP-запроса", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true; // отменяем печать
                }
            }
        }
    }
}
