using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Texac.TTN
{
    public partial class InputOrderNumberForm : Form
    {
        public InputOrderNumberForm()
        {
            InitializeComponent();
        }

        

        private void InputOrderNumberForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                int id = 0;
                if (int.TryParse(tbOrderNumber.Text, out id) == false)
                {
                    return;
                }

                /*
                PsnPositionEntity order = DAL.GetOrderById(id);
                if (order.OrderId != 0)
                {
                    _orderList.Add(order);
                }
                else
                {
                    MessageBox.Show("Заказ с номером " + tbOrderNumber.Text + " не найден.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                */
                
            }
        }

        private async DeliveryNoteEntity getDeliveryNoteEntityAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(Texac.Properties.Settings.Default.api_path);
                client.DefaultRequestHeaders.Add("User-Agent", "TexacHttpClient");
                try
                {
                    HttpResponseMessage response = client.GetAsync("/api/").Result;
                    string responseBody = await response.Content.ReadAsStringAsync();
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        MessageBox.Show(responseBody, "Ошибка при получении номера документа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                catch (HttpRequestException e)
                {
                    MessageBox.Show(e.Message, "Ошибка при выполнении HTTP-запроса", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
