using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Texac.Analize
{
    public partial class AnalizeForm : Form
    {
        public AnalizeForm()
        {
            InitializeComponent();
        }

        private void btnFindOrderNumbers_Click(object sender, EventArgs e)
        {
            if (tbNaimTO.Text.Trim().Length == 0)
            {
                MessageBox.Show("Поле 'Наменование ТО' должно быть заполнено");
                return;
            }

            //string queryString = "SELECT [NППЗаказа], [ФактДатаИзготовления], [NЗаказаЗавода] FROM Заказы WHERE [ОбозначениеТО]=?";
            string queryString = "SELECT [NППЗаказа], [ФактДатаИзготовления] FROM Заказы WHERE [ОбозначениеТО]=?";
            using (OleDbConnection connection = new OleDbConnection(Texac.Properties.Settings.Default.connStr))
            {
                OleDbCommand command = new OleDbCommand(queryString, connection);
                command.Parameters.AddWithValue("@[ОбозначениеТО]", tbNaimTO.Text.Trim());
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                DateTime lastDate = new DateTime();

                tbOrderNumbers.Text = "";
               // List<OrderEntity> orderList = new List<OrderEntity>();

                while (reader.Read())
                {
                    /*
                    if (DBNull.Value != reader[1])
                    {
                        orderList.Add(new OrderEntity(reader.GetInt32(0), reader.GetString(2), reader.GetDateTime(1)));

                    }
                    */
                    
                    if (DBNull.Value != reader[1])
                    {
                        int orderId = reader.GetInt32(0);
                        DateTime d = reader.GetDateTime(1);
                        if (lastDate.Year == 1)
                        {
                            lastDate = d;
                            tbOrderNumbers.Text += orderId.ToString();
                        }
                        else
                        {
                            if (d < lastDate)
                            {
                                tbOrderNumbers.Text += " ";
                                tbOrderNumbers.Text += orderId.ToString();
                            }
                        }
                    }
                }
                reader.Close();
                /*
                // поиск последнего 23 или 208 заказа
                int startIndex=0;
                for(int i = 0; i < orderList.Count; i++)
                {
                    if(
                        (orderList[i].orderNumber.StartsWith("23-") || orderList[i].orderNumber.StartsWith("208"))

                        && !(orderList[i].orderNumber.Contains(".") || 
                             orderList[i].orderNumber.Contains(",") || 
                             orderList[i].orderNumber.Contains(" ")
                            )

                        )
                        startIndex = i;
                }
                /*
                for(int i=startIndex; i < orderList.Count; i++)
                {
                    if (lastDate.Year == 1)
                    {
                        lastDate = orderList[i].orderDate;
                        tbOrderNumbers.Text += orderList[i].orderId.ToString();
                    }
                    else
                    {
                        if (orderList[i].orderDate < lastDate)
                        {
                            tbOrderNumbers.Text += " ";
                            tbOrderNumbers.Text += orderList[i].orderId.ToString();
                        }
                    }
                }
                */
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {

            if (tbOrderNumbers.Text.Trim().Length == 0)
            {
                MessageBox.Show("Поле 'Номера заказов' должно быть заполнено");
                return;
            }
            string orders = tbOrderNumbers.Text.Trim();
            orders = "In (" + orders.Replace(' ', ',') + ")";

            string queryString = " SELECT [Операция], Sum([НормаВремени]*[КоличОкончРаб]) AS [Затрачено часов] FROM [ВыполнениеЗаказа] " +
                                 " WHERE [NППЗаказа] " + orders +
                                 " GROUP BY [Операция] " +
                                 " HAVING  [Операция] In (\"Коорд.шл.\",\"Опт.шл.\",\"К.р.с.\", \"К.р.с.(Mikr.)\",\"HAAS\", \"Гор.раст.\",\"Гор.р(MAF45)\",\"Hauser\",\"Hauser(партия)\",\"Micromat\",\"Micromat(партия)\",\"Micron скор.\",\"Hermle\",\"ЭЭВ\",\"ЭЭП\",\"ЭЭП(супер)\") " +
                                 " ORDER BY [Операция]";


            Cursor = Cursors.WaitCursor;
            using (OleDbConnection connection = new OleDbConnection(Texac.Properties.Settings.Default.connStr))
            {
                List<EqupmentByTOEntity> list = new List<EqupmentByTOEntity>();

                OleDbCommand command = new OleDbCommand(queryString, connection);
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                Dictionary<string, EqupmentByTOEntity> dict = new Dictionary<string, EqupmentByTOEntity>();

                dict.Add("Коорд.шл.", new EqupmentByTOEntity("Коорд.шл.", 0.0));
                dict.Add("Опт.шл.", new EqupmentByTOEntity("Опт.шл.", 0.0));
                dict.Add("К.р.с.", new EqupmentByTOEntity("К.р.с.", 0.0));
                dict.Add("К.р.с.(Mikr.)", new EqupmentByTOEntity("К.р.с.(Mikr.)", 0.0));
                dict.Add("HAAS", new EqupmentByTOEntity("HAAS", 0.0));
                dict.Add("Гор.раст.", new EqupmentByTOEntity("Гор.раст.", 0.0));
                dict.Add("Гор.р(MAF45)", new EqupmentByTOEntity("Гор.р(MAF45)", 0.0));
                dict.Add("Hauser", new EqupmentByTOEntity("Hauser", 0.0));
                dict.Add("Hauser(партия)", new EqupmentByTOEntity("Hauser(партия)", 0.0));
                dict.Add("Micromat", new EqupmentByTOEntity("Micromat", 0.0));
                dict.Add("Micromat(партия)", new EqupmentByTOEntity("Micromat(партия)", 0.0));
                dict.Add("Micron скор.", new EqupmentByTOEntity("Micron скор.", 0.0));
                dict.Add("Hermle", new EqupmentByTOEntity("Hermle", 0.0));
                dict.Add("ЭЭВ", new EqupmentByTOEntity("ЭЭВ", 0.0));
                dict.Add("ЭЭП", new EqupmentByTOEntity("ЭЭП", 0.0));
                dict.Add("ЭЭП(супер)", new EqupmentByTOEntity("ЭЭП(супер)", 0.0));

                while (reader.Read())
                {
                    if (DBNull.Value != reader[1])
                    {
                        string op = reader.GetString(0);
                        double h = reader.GetDouble(1);
                        dict[op].hours = h;
                    }
                }
                reader.Close();


                foreach (KeyValuePair<string, EqupmentByTOEntity> entry in dict)
                {
                    list.Add(entry.Value);
                }


                bsEqupmentByTO.DataSource = list;


                // bsEqupmentByTO.DataSource = dict;
            }
            Cursor = Cursors.Default;

        }

        private void AnalizeForm_Load(object sender, EventArgs e)
        {
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            tbNaimTO.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tbNaimTO.AutoCompleteSource = AutoCompleteSource.CustomSource;

            string queryString = "SELECT distinct [ОбозначениеТО] FROM [Заказы]";
            Cursor = Cursors.WaitCursor;
            using (OleDbConnection connection = new OleDbConnection(Texac.Properties.Settings.Default.connStr))
            {
                OleDbCommand command = new OleDbCommand(queryString, connection);
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (DBNull.Value != reader[0])
                    {
                        collection.Add(reader.GetString(0));
                    }
                }
                reader.Close();
            }

            tbNaimTO.AutoCompleteCustomSource = collection;
            Cursor = Cursors.Default;
        }

        private void tbNaimTO_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnFindOrderNumbers_Click(null, null);
            }
        }
    }
}
