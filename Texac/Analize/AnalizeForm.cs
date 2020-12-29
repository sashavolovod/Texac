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

            string queryString = "SELECT [NППЗаказа], [ФактДатаИзготовления] FROM Заказы WHERE [ОбозначениеТО]=?";
            using (OleDbConnection connection = new OleDbConnection(Texac.Properties.Settings.Default.connStr))
            {
                OleDbCommand command = new OleDbCommand(queryString, connection);
                command.Parameters.AddWithValue("@[ОбозначениеТО]", tbNaimTO.Text.Trim());
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                DateTime lastDate = new DateTime();
                tbOrderNumbers.Text = "";
                while (reader.Read())
                {

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
                                 " HAVING  [Операция] In (\"К.р.с.\", \"К.р.с.(Mikr.)\",\"HAAS\", \"Гор.раст.\",\"Гор.р(MAF45)\",\"Hauser\",\"Hauser(партия)\",\"Micromat\",\"Micromat(партия)\",\"Micron скор.\",\"Hermle\",\"ЭЭВ\",\"ЭЭП\",\"ЭЭП(супер)\") " +
                                 " ORDER BY [Операция]";


            Cursor = Cursors.WaitCursor;
            using (OleDbConnection connection = new OleDbConnection(Texac.Properties.Settings.Default.connStr))
            {
                List<EqupmentByTOEntity> list = new List<EqupmentByTOEntity>();

                OleDbCommand command = new OleDbCommand(queryString, connection);
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (DBNull.Value != reader[1])
                    {
                        string op = reader.GetString(0);
                        double h = reader.GetDouble(1);
                        list.Add(new EqupmentByTOEntity(op, h));
                    }
                }
                reader.Close();

                bsEqupmentByTO.DataSource = list;
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
    }
}
