using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;

namespace Texac.PsnHistory
{
    public partial class PsnListControl : UserControl
    {
        private SortableBindingList<PsnEntity> allData;

        public PsnListControl()
        {
            InitializeComponent();
            GetPsnListAsync();
            
        }

        public async void GetPsnListAsync()
        {
            List<PsnEntity> list = new List<PsnEntity>();
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(Texac.Properties.Settings.Default.api_path);
                client.DefaultRequestHeaders.Add("User-Agent", "TexacHttpClient");
                try
                {
                    // Асинхронный GET-запрос
                    HttpResponseMessage response = await client.GetAsync("/api/psn_entities_view");
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    list = JsonConvert.DeserializeObject<List<PsnEntity>>(responseBody);
                    allData = new SortableBindingList<PsnEntity>(list);
                    bs.DataSource = allData;
                    dgv.Sort(colDocDate, ListSortDirection.Descending);
                }
                catch (HttpRequestException e)
                {
                    MessageBox.Show(e.Message, "Ошибка при выполнении HTTP-запроса");
                }
            }
        }

        private void tsbDeleteFilter_Click(object sender, EventArgs e)
        {
            tsbFilter.Checked = false;
            tstbFilter.Text = "";
            allData.RemoveFilter();
        }

        private void tstbFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tsbFilter.Checked == true)
                {
                    tsbFilter_CheckedChanged(null, null);
                }
                else
                {
                    tsbFilter.Checked = true;
                }
            }
        }

        private void tsbFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (tsbFilter.Checked == true)
            {
                int f;
                if (Int32.TryParse(tstbFilter.Text, out f))
                {
                    allData.ApplyFilter(p => p.orderId == f);
                }
                else
                {
                    allData.ApplyFilter(p =>
                            p.docNumber.Contains(tstbFilter.Text) ||
                            p.orderNumber.Contains(tstbFilter.Text) ||
                            p.orderDescription.Contains(tstbFilter.Text) ||
                            p.customer.Contains(tstbFilter.Text)
                        );
                }
            }
            else
            {
                allData.RemoveFilter();
            }
        }
    }
}
