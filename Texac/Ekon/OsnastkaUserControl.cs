using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Texac.Ekon
{
    public partial class OsnastkaUserControl : UserControl
    {
        List<int> orders = new List<int>();
        List<OsnastkaEntity> list = new List<OsnastkaEntity>();

        public OsnastkaUserControl()
        {
            InitializeComponent();
            DateTime now = DateTime.Today;
            now = now.AddMonths(-2);
            DateTime date = new DateTime(now.Year, now.Month, 1);
            dtpStart.Value = date;
            date = date.AddMonths(1);
            date = date.AddSeconds(-1);
            dtpEnd.Value = date;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            DateTime start = dtpStart.Value.Date;
            DateTime end   = dtpEnd.Value.Date;
            end = end.AddDays(1);

            string queryString = "SELECT Заказы.NППЗаказа, IIf([NЗаказаЗавода]=\"24/5\",[Заказы.NППзаказа],[NЗаказаЗавода]) AS Номер, КодыНаименованийТО.НаименованиеТО, Заказы.ОбозначениеТО, НеодновременноВыполняемыеЗаказы.Ф_Кол_во, Заказы.ПланТрудоемкость AS НЧ, [ПланТрудоемкость]*[ФКол_во] AS НЧвсего, Заказы.КодТО, НеодновременноВыполняемыеЗаказы.ФактДатаИзготовления " +
"FROM КодыНаименованийТО INNER JOIN (Заказы INNER JOIN НеодновременноВыполняемыеЗаказы ON Заказы.NППЗаказа = НеодновременноВыполняемыеЗаказы.NППЗаказа) ON КодыНаименованийТО.КодТО = Заказы.КодТО " + 
" WHERE НеодновременноВыполняемыеЗаказы.ФактДатаИзготовления Between ? And ? ";

            this.Cursor = Cursors.WaitCursor;

            orders.Clear();
            list.Clear();
            using (OleDbConnection connection = new OleDbConnection(Texac.Properties.Settings.Default.connStr))
            {
                OleDbCommand command = new OleDbCommand(queryString, connection);
                command.Parameters.AddWithValue("@StartDate", start);
                command.Parameters.AddWithValue("@EndDate", end);
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    orders.Add(id);
                    string number = reader.GetString(1);
                    string name = reader.GetString(2);
                    string obozTO = reader.GetString(3);
                    double amount = reader.GetInt32(4);

                    double? normaV = null;
                    if (DBNull.Value != reader[5])
                        normaV = reader.GetDouble(5);

                    double? normaT = null;
                    if (DBNull.Value != reader[6])
                        normaT = reader.GetDouble(6);

                    int kodTO = reader.GetInt16(7);
                    list.Add(new OsnastkaEntity(id, number, name, obozTO, amount, normaV, normaT, kodTO));
                }
                reader.Close();
            }

            queryString = "SELECT Заказы.NППЗаказа, IIf([NЗаказаЗавода]=\"24/5\",[NППзаказа],[NЗаказаЗавода]) AS Номер, КодыНаименованийТО.НаименованиеТО, Заказы.ОбозначениеТО, Заказы.ФКол_во, Заказы.ПланТрудоемкость AS НЧ, [ПланТрудоемкость]*[ФКол_во] AS НЧвсего, Заказы.КодТО, Заказы.ФактДатаИзготовления " + 
                          "FROM КодыНаименованийТО INNER JOIN Заказы ON КодыНаименованийТО.КодТО = Заказы.КодТО " + 
                          "WHERE Заказы.ФактДатаИзготовления Between ? And ? ";

            using (OleDbConnection connection = new OleDbConnection(Texac.Properties.Settings.Default.connStr))
            {
                OleDbCommand command = new OleDbCommand(queryString, connection);
                command.Parameters.AddWithValue("@StartDate", start);
                command.Parameters.AddWithValue("@EndDate", end);
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);

                    if (orders.Contains(id) == true)
                        continue;

                    string number = reader.GetString(1);
                    string name = reader.GetString(2);
                    string obozTO = reader.GetString(3);
                    double amount = reader.GetInt32(4);

                    double? normaV = null;
                    if (DBNull.Value != reader[5])
                         normaV = reader.GetDouble(5);

                    double? normaT = null;
                    if (DBNull.Value != reader[6])
                        normaT = reader.GetDouble(6);

                    int kodTO = reader.GetInt16(7);

                    list.Add(new OsnastkaEntity(id, number, name, obozTO, amount, normaV, normaT, kodTO));
                }
                reader.Close();
            }

            list.Sort(delegate (OsnastkaEntity o1, OsnastkaEntity o2)
            {
                if(o1.kodTO == o2.kodTO)
                    return 0;
                if (o1.kodTO < o2.kodTO)
                    return -1;
                else
                    return 1;
            });

            bsOsnastka.DataSource = list;
            dgvOsnastka.Focus();
            this.Cursor = Cursors.Default;
        }
    }
}
