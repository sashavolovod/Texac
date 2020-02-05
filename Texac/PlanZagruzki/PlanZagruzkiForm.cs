using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Texac.PlanZagruzki
{
    public partial class PlanZagruzkiForm : Form
    {
        private BindingList<PlanZagruzkiEntity> list = new BindingList<PlanZagruzkiEntity>();
        private List<GrafikEntity> grafikList = new List<GrafikEntity>();

        public PlanZagruzkiForm()
        {
            InitializeComponent();
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            double z;
            list.Clear();
            string grafikNumbers = "";

            for (int i = 0; i < lvGrafik.Items.Count; i++)
            {
                if (lvGrafik.Items[i].Checked == true)
                {
                    if (grafikNumbers.Length > 0)
                        grafikNumbers += ", ";
                    grafikNumbers += lvGrafik.Items[i].Text;
                }
            }

            string queryString = 
@"SELECT  Операция, Sum(Часов) as Время FROM
(
SELECT ГрафикN, Операция, [КоличествоДеталей] *[Кол_во] *[НормаВремени] AS Часов
FROM(Заказы INNER JOIN МатериальнаяКарта ON Заказы.NППЗаказа = МатериальнаяКарта.NППЗаказа) INNER JOIN ТехнологияИзготовления ON(МатериальнаяКарта.NППДетали = ТехнологияИзготовления.NППДетали) AND(МатериальнаяКарта.NППЗаказа = ТехнологияИзготовления.NППЗаказа)
WHERE Заказы.ГрафикN In( " + grafikNumbers + @")
UNION ALL
SELECT ГрафикN, Операция, -[НормаВремени] *[КоличОкончРаб] AS Часов
FROM Заказы INNER JOIN ВыполнениеЗаказа ON Заказы.NППЗаказа = ВыполнениеЗаказа.NППЗаказа
WHERE Заказы.ГрафикN In(" + grafikNumbers + @")
)
GROUP BY Операция
ORDER BY Sum(Часов)DESC";

            this.Cursor = Cursors.WaitCursor;

            using (OleDbConnection connection = new OleDbConnection(Texac.Properties.Settings.Default.connStr))
            {
                OleDbCommand command = new OleDbCommand(queryString, connection);
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string o = reader.GetString(0);
                    if (DBNull.Value != reader[1])
                        z = reader.GetDouble(1);
                    else
                        z = 0.0;
                    list.Add( new PlanZagruzkiEntity(o,z));
                }
                reader.Close();
            }
            dgvPlanZagruzki.DataSource = list;
            this.Cursor = Cursors.Default;
        }

        private void PlanZagruzkiForm_Load(object sender, EventArgs e)
        {
            string queryString = "SELECT ГрафикN, Nдокумента, Дата, СрокВыполнения, ДатаВыполнения FROM ГрафикиМероприятий";
            int grafikId;
            string grafikName;
            DateTime ?grafikDate;
            DateTime ?srok;
            DateTime? dataVypolneniya;

            grafikList.Clear();
            using (OleDbConnection connection = new OleDbConnection(Texac.Properties.Settings.Default.connStr))
            {
                OleDbCommand command = new OleDbCommand(queryString, connection);
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    grafikId = reader.GetInt32(0);

                    if (DBNull.Value != reader[1])
                        grafikName = reader.GetString(1);
                    else
                        grafikName = "";

                    if (DBNull.Value != reader[2])
                        grafikDate = reader.GetDateTime(2);
                    else
                        grafikDate = null;

                    if (DBNull.Value != reader[3])
                        srok = reader.GetDateTime(3);
                    else
                        srok = null;

                    if (DBNull.Value != reader[4])
                        dataVypolneniya = reader.GetDateTime(4);
                    else
                        dataVypolneniya = null;

                    grafikList.Add(new GrafikEntity(grafikId, grafikName, grafikDate, srok, dataVypolneniya));
                }
                reader.Close();
            }
            cbNotReady_CheckedChanged(null, null);
        }

        private void cbNotReady_CheckedChanged(object sender, EventArgs e)
        {
            lvGrafik.Items.Clear();
            Cursor = Cursors.WaitCursor;
            lvGrafik.BeginUpdate();
            for (int i=0;i<grafikList.Count;i++)
            {
                GrafikEntity ge = grafikList[i];
                if((cbNotReady.CheckState == CheckState.Checked && ge.dataVypolneniya==null) 
                    || cbNotReady.CheckState == CheckState.Unchecked)
                {
                    ListViewItem lvi = new ListViewItem(ge.grafikId.ToString());
                    lvi.SubItems.Add(ge.grafikName);
                    lvi.SubItems.Add(ge.grafikDate == null ? " " : ge.grafikDate.Value.ToShortDateString());
                    lvi.SubItems.Add(ge.srok == null ? " " : ge.srok.Value.ToShortDateString());
                    lvGrafik.Items.Add(lvi);
                }
            }
            lvGrafik.EndUpdate();
            Cursor = Cursors.Default;
        }

        private void lvGrafik_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            int ch = lvGrafik.CheckedItems.Count;
            int total = lvGrafik.Items.Count;

            lbSelectCount.Text = string.Format("Выбрано {0} из {1}", ch, total);
            btnBuild.Enabled = (ch > 0);
            btnUncheck.Enabled = (ch > 0);
        }

        private void btnUncheck_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lvGrafik.Items.Count; i++)
            {
                if (lvGrafik.Items[i].Checked == true)
                {
                    lvGrafik.Items[i].Checked = false;
                }
            }
        }
    }
}
