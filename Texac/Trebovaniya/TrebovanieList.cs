using System;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Texac.Trebovaniya
{
    public partial class TrebovanieList : UserControl
    {
        private Dictionary<int, List<OrderNumberEntity>> orderByYear = new Dictionary<int, List<OrderNumberEntity>>();

        private Dictionary<int, string> orderNumbers = new Dictionary<int, string>();

        private Dictionary<int, string> storeTitles = new Dictionary<int, string>();

        OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.connStr);

        public TrebovanieList()
        {
            InitializeComponent();
            dgvTrebovania.AutoGenerateColumns = false;
            LoadData();
        }

        private void LoadData()
        {
            LoadDataFromDb();
        }

 /*      
        private async void LoadData()
        {
            Cursor = Cursors.WaitCursor;
            await LoadDataAsync();
            Cursor = Cursors.Default;
        }
*/        
        private async Task LoadDataAsync()
        {
            await Task.Run(() => LoadDataFromDb());
        }

        private void LoadDataFromDb()
        {
            OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.connStr);
            conn.Open();
            taTrebovaniaView.Connection = conn;
            taTrebovaniaView.Fill(this.dataDataSet.TrebovaniaView);

            // получим номера заказов            
            orderNumbers.Clear();
            OleDbCommand cmd = new OleDbCommand("select tblTrebovanielId, OrderId from tblTrebovanieDetails where OrderId>0", conn);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (DBNull.Value != reader[0] && DBNull.Value != reader[1])
                {
                    int trebovanielId = reader.GetInt32(0);
                    int OrderId = reader.GetInt32(1);
                    if (orderNumbers.ContainsKey(trebovanielId))
                    {
                        string newOrderNumbers = orderNumbers[trebovanielId];
                        if (newOrderNumbers.Contains(OrderId.ToString()) == false)
                        {
                            newOrderNumbers = newOrderNumbers + " " + OrderId.ToString();
                            orderNumbers[trebovanielId] = newOrderNumbers;
                        }
                    }
                    else
                    {
                        orderNumbers.Add(trebovanielId, OrderId.ToString());
                    }
                }
            }

            orderByYear.Clear();
            foreach (dataDataSet1.TrebovaniaViewRow r in dataDataSet.TrebovaniaView.Rows)
            {

                if(orderNumbers.ContainsKey(r.TrebovanieId))
                {
                    r.OrderIdList = orderNumbers[r.TrebovanieId];
                }
                else
                {
                    r.OrderIdList = "";
                }

                int year = r.DocDate.Year;
                if (orderByYear.ContainsKey(year) == false) 
                    orderByYear[year] = new List<OrderNumberEntity>();

                orderByYear[year].Add(new OrderNumberEntity(r.TrebovanieId, r.DocNumber));
            }

            reader.Close();
            
            // получим названия цехов из производства
            storeTitles.Clear();
            cmd = new OleDbCommand("select whID, whPdoTitle from WH where whPdoTitle<>''", conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int storeId = reader.GetInt32(0);
                string storePgoTitle = reader.GetString(1);
                storeTitles.Add(storeId, storePgoTitle);
            }
            reader.Close();
            conn.Close();
        }

        private void TrebovanieForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (((Form)sender).DialogResult == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddTrebovaniyaForm form = new AddTrebovaniyaForm();
            form.ShowDialog();
            //taTrebovania.Fill(dataDataSet.TrebovaniaView);
            LoadData();
        }

        private void actDelTrebovanie_Click(object sender, EventArgs e)
        {
            if (bsTrebovania.Position >= 0)
            {
                dataDataSet1.TrebovaniaViewRow row = (dataDataSet1.TrebovaniaViewRow)((DataRowView)bsTrebovania.Current).Row;
                if (MessageBox.Show("Вы действительно хотите удалить требование " + row.DocNumber.ToString() + "?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    OleDbCommand cmd = new OleDbCommand("DELETE FROM tblTrebovanie WHERE TrebovanieId = ?", conn);
                    cmd.Parameters.AddWithValue("TrebovanieId", row.TrebovanieId);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    LoadData(); 
                }
            }
        }
        private void dgvTrebovania_MouseDown(object sender, MouseEventArgs e)
        {
            
            var hti = dgvTrebovania.HitTest(e.X, e.Y);
            if (hti.RowIndex >= 0 && hti.ColumnIndex >= 0)
            {
                if(dgvTrebovania.SelectedRows.Count == 1)
                    dgvTrebovania.CurrentCell = dgvTrebovania[hti.ColumnIndex, hti.RowIndex];
            }
            
        }

        private void openDocument(bool copy=false)
        {
            if (bsTrebovania.Position >= 0)
            {
                dataDataSet1.TrebovaniaViewRow row = (dataDataSet1.TrebovaniaViewRow)((DataRowView)bsTrebovania.Current).Row;
                TrebovanieForm form = new TrebovanieForm(row.TrebovanieId, copy, orderByYear);
                form.FormClosing += TrebovanieForm_FormClosing;
                form.Show();
            }
        }

        private void dgvTrebovania_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            openDocument();
        }

        private void miOpenTrebovanie_Click(object sender, EventArgs e)
        {
            openDocument();
        }

        private void tsbAddEmpty_Click(object sender, EventArgs e)
        {
            new TrebovanieForm(-1, false, orderByYear).ShowDialog();
            taTrebovaniaView.Fill(dataDataSet.TrebovaniaView);
        }

        private void miCopy_Click(object sender, EventArgs e)
        {
            openDocument(true);
        }

        private void tsbFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (tsbFilter.Checked == true)
            {
                int f;
                string rowFilter;
                if (Int32.TryParse(tstbFilter.Text, out f))
                {
                    rowFilter = string.Format("[{1}] = '{0}' or [{2}] = '{0}' or [{3}] like '%{0}%' or [{4}] like '%{0}%'",
                                      tstbFilter.Text, "DocNumber", "TrebovanieId", "OrderNumber", "OrderIdList");
                }
                else
                {
                    rowFilter = string.Format("[{1}] like '%{0}%' or [{2}] like '%{0}%'", tstbFilter.Text, "OrderNumber", "OrderIdList");
                }

                DataView dv = new DataView(dataDataSet.TrebovaniaView);
                dv.RowFilter = rowFilter;
                bsTrebovania.DataSource = dv;
            }
            else
            {
                bsTrebovania.DataSource = dataDataSet.TrebovaniaView;
            }
        }

        private void tsbDeleteFilter_Click(object sender, EventArgs e)
        {
            tsbFilter.Checked = false;
            tstbFilter.Text = "";
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

        private void miPdo_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Требования");
            Directory.CreateDirectory(path);

            dataDataSet1 ds = new dataDataSet1();
            dataDataSet1TableAdapters.TrebovanieTableAdapter taTrebovanie = new dataDataSet1TableAdapters.TrebovanieTableAdapter();
            dataDataSet1TableAdapters.TrebovanieDetailsTableAdapter taTrebovanieDetails = new dataDataSet1TableAdapters.TrebovanieDetailsTableAdapter();
            StringBuilder sb = new StringBuilder();

            for (int j = 0; j < dgvTrebovania.SelectedRows.Count; j++)
            {
                int id = (int)dgvTrebovania.SelectedRows[j].Cells[0].Value;
                string storePdoTitle = "";

                taTrebovanie.FillById(ds.Trebovanie, id);
                taTrebovanieDetails.FillByIdWithGroup(ds.TrebovanieDetails, id);

                dataDataSet1.TrebovanieRow row = (dataDataSet1.TrebovanieRow)ds.Trebovanie.Rows[0];
                if (storeTitles.ContainsKey(row.Sclad))
                {
                    storePdoTitle = storeTitles[row.Sclad];
                }
                else
                {
                    MessageBox.Show($"В требовании {row.DocNumber} указан некоррректный номер склада ({row.Sclad})", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continue;
                }

                if(row.WorkshopCode.Trim().Length == 0)
                {
                    MessageBox.Show($"В требовании {row.DocNumber} не указан получаталь", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continue;
                }

                if(row.IsOsnovanieNull())
                {
                    MessageBox.Show($"В требовании {row.DocNumber} не указано основание", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continue;
                }

                sb.Clear();
                sb.AppendLine("<?xml version=\"1.0\" encoding=\"windows-1251\"?>");
                sb.AppendLine("<REQUEST_DATA>");
                sb.AppendLine("");
                sb.AppendLine("<REQUEST_HEAD>");
                sb.AppendLine("");
                sb.AppendLine("<VID_DOC>Требование</VID_DOC>");
                sb.AppendLine($"<NUM_DOC>{row.DocNumber}</NUM_DOC>");
                sb.AppendLine($"<DATE_DOC>{row.DocDate.ToString("dd.MM.yyyy")}</DATE_DOC>");
                sb.AppendLine($"<DATE_OP>{row.DocDate.ToString("dd.MM.yyyy")}</DATE_OP>");
                sb.AppendLine("<SMENA></SMENA>");
                sb.AppendLine($"<OSNOVANIE>{row.Osnovanie}</OSNOVANIE>");
                if (row.IsDescriptionNull() == false)
                    sb.AppendLine($"<REM>{row.Description}</REM>");
                sb.AppendLine("<CONCERN>БЗГА</CONCERN>");
                sb.AppendLine($"<REM_CONTENT></REM_CONTENT>");
                sb.AppendLine($"<ID_GUIDE_TMC_FROM>{storePdoTitle}</ID_GUIDE_TMC_FROM>");
                sb.AppendLine($"<ID_GUIDE_TMC_TO>{row.WorkshopCode}</ID_GUIDE_TMC_TO>");
                sb.AppendLine($"<USER_MOL>{row.Recipient}</USER_MOL>");
                sb.AppendLine($"<USER_RUK>{row.Customer}</USER_RUK>");
                sb.AppendLine($"<USER_SOGL1></USER_SOGL1>");
                sb.AppendLine($"<USER_SOGL2></USER_SOGL2>");
                sb.AppendLine($"<USER_SOGL3></USER_SOGL3>");
                sb.AppendLine($"<UTV_AUTO>Да</UTV_AUTO>");
                sb.AppendLine($"");

                sb.AppendLine($"</REQUEST_HEAD>");
                sb.AppendLine($"");

                for (int i = 0; i < ds.TrebovanieDetails.Rows.Count; ++i)
                {
                    dataDataSet1.TrebovanieDetailsRow det = (dataDataSet1.TrebovanieDetailsRow)ds.TrebovanieDetails.Rows[i];

                    sb.AppendLine($"<REQUEST_CONTENT>");
                    sb.AppendLine($"<ID_SKLAD_KARD></ID_SKLAD_KARD>");
                    sb.AppendLine($"<SKLAD_KARD>{det.ASUPCODE}</SKLAD_KARD>");
                    sb.AppendLine($"<CNT>{det.Kol1}</CNT>");
                    sb.AppendLine($"<REM_CONTENT></REM_CONTENT>");
                    sb.AppendLine($"<SKLAD_KARD_NAME></SKLAD_KARD_NAME>");
                    sb.AppendLine($"<ADD_DATE></ADD_DATE>");
                    sb.AppendLine($"<ED_UCH>{det.Ed}</ED_UCH>");
                    sb.AppendLine($"");
                    sb.AppendLine($"</REQUEST_CONTENT>");
                    sb.AppendLine($"");
                }
                sb.AppendLine($"</REQUEST_DATA>");
                using (System.IO.StreamWriter file = new System.IO.StreamWriter($"{path}/{row.DocNumber}.xml", false, Encoding.GetEncoding("windows-1251")))
                {
                    file.WriteLine(sb.ToString());
                }
                row.PdoDate = DateTime.Now;
                taTrebovanie.Update(ds.Trebovanie);
            }
            Process.Start("explorer.exe", path);
            LoadData(); 
        }

        private void tsbCheckAvailability_Click(object sender, EventArgs e)
        {
            StringBuilder ids = new StringBuilder("(");
            int rowCount = dgvTrebovania.SelectedRows.Count;
            for (int j = 0; j < rowCount; j++)
            {
                ids.Append(dgvTrebovania.SelectedRows[j].Cells[0].Value);
                if (j != rowCount - 1)
                    ids.Append(",");
            }
            ids.Append(")");
            new MaterialAvailabilityForm(ids.ToString()).Show();
        }
    }
}
