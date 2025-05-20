using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Texac.Common;
using System.Net.Http;
using System.Net;

namespace Texac.TTN
{
    public partial class DeliveryNoteControl : UserControl
    {
        private BindingList<DeliveryNotePositionEntity> notesList;
        private NullableBindingDateTimePicker dtpOrderDate;

        public DeliveryNoteControl()
        {
            InitializeComponent();
            getNextDocNumber();
            dtpOrderDate = new NullableBindingDateTimePicker();
            dtpOrderDate.Width = 140;
            dtpOrderDate.Format = DateTimePickerFormat.Short;
            dtpOrderDate.Value = DateTime.Today;
            tsMain.Items.Add(new ToolStripControlHost(dtpOrderDate));
        }

        private async void getNextDocNumber()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(Texac.Properties.Settings.Default.api_path);
                client.DefaultRequestHeaders.Add("User-Agent", "TexacHttpClient");
                try
                {
                    HttpResponseMessage response = client.GetAsync("/api/psn-order-number").Result;
                    string responseBody = await response.Content.ReadAsStringAsync();
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        MessageBox.Show(responseBody, "Ошибка при получении номера документа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    tbDocsNumber.Text = responseBody;
                }
                catch (HttpRequestException e)
                {
                    MessageBox.Show(e.Message, "Ошибка при выполнении HTTP-запроса", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tsbAddOrder_Click(object sender, EventArgs e)
        {
            InputOrderNumberForm frm = new InputOrderNumberForm();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(frm.tbOrderNumber.Text);
            }
        }

        private void tsbClear_Click(object sender, EventArgs e)
        {

        }
    }
}
