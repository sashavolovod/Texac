
// INSERT INTO Заказы(NЗаказаЗавода, NЗаказа, ВидГрафика, ОснованиеЗаказа, ДатаПолученияЗаказа, ОбозначениеТО, КодТО, NИзделия, NДетали, Кол_во, Заказчик) VALUES("24/5", "24/5", 1, 11,  31/12/2099, "1723-4039", 1120, "ВО-01.00.00", "ВО-01.00.21", 999, 70)

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.OleDb;
using Texac.Common;
using Newtonsoft.Json;
using Texac.Domain;

namespace Texac.PlanOrders
{
    public partial class PlanOrdersControl : UserControl
    {
        private List<ComboBoxEntity> graphics = new List<ComboBoxEntity>();
        private List<ComboBoxEntity> employees = new List<ComboBoxEntity>();
        private List<ComboBoxEntity> orderBased = new List<ComboBoxEntity>();
        private List<ComboBoxEntity> priorities = new List<ComboBoxEntity>();
        private List<ComboBoxEntity> graphicTypes = new List<ComboBoxEntity>();
        private List<ComboBoxEntity> shops = new List<ComboBoxEntity>();
        private List<ToTypes> toTypes = new List<ToTypes>();
        private List<ComboBoxEntity> techEmps = new List<ComboBoxEntity>();
        Dictionary<string, Decimal> tnvedMap = new Dictionary<string, Decimal>();

        OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.connStr);

        Dictionary<string, ToEntity> dict = new Dictionary<string, ToEntity>();

        public PlanOrdersControl()
        {
            InitializeComponent();

            tbStartOrderNumber.Text = Properties.Settings.Default.StartOrderNumber.ToString(); 
            dtpOrder.Value = DateTime.Today;
            dtpPlan.Value = DateTime.MinValue;
            dtpPlanTP.Value = DateTime.MinValue;

            initTOCache();
            graphics.Sort();
            employees.Sort();
            orderBased.Sort();
            priorities.Sort();

            cbGraphic.DataSource = graphics;
            cbGraphic.DisplayMember = "title";
            cbGraphic.ValueMember = "id";
            cbGraphic.SelectedValue = 0;

            cbReasonOrder.DataSource = orderBased;
            cbReasonOrder.DisplayMember = "title";
            cbReasonOrder.ValueMember = "id";
            cbReasonOrder.SelectedValue = 31;

            cbPriorities.DataSource = priorities;
            cbPriorities.DisplayMember = "title";
            cbPriorities.ValueMember = "id";
            cbPriorities.SelectedValue = 5;

            cbGraphicType.DataSource = graphicTypes;
            cbGraphicType.DisplayMember = "title";
            cbGraphicType.ValueMember = "id";
            cbGraphicType.SelectedValue = 6;

            BindingSource bsCustomeShops = new BindingSource();
            bsCustomeShops.DataSource = shops;
            BindingSource bsProducerShops = new BindingSource();
            bsProducerShops.DataSource = shops;

            cbCustomerShop.DataSource = bsCustomeShops;
            cbCustomerShop.DisplayMember = "title";
            cbCustomerShop.ValueMember = "id";
            cbCustomerShop.SelectedValue = 0;

            cbProducerShop.DataSource = bsProducerShops;
            cbProducerShop.DisplayMember = "title";
            cbProducerShop.ValueMember = "id";
            cbProducerShop.SelectedValue = 70;

            colCodeTo.ValueMember = "codeTo";
            colCodeTo.DisplayMember = "title";
            colCodeTo.DataSource = toTypes;

            colTitleTo.ValueMember = "codeTo";
            colTitleTo.DisplayMember = "titleTo";
            colTitleTo.DataSource = toTypes;

            colTypeTo.ValueMember = "codeTo";
            colTypeTo.DisplayMember = "codeTypeTo";
            colTypeTo.DataSource = toTypes;

            colTechEmp.DisplayMember = "title";
            colTechEmp.ValueMember = "id";
            colTechEmp.DataSource = techEmps;

        }
        private void dgv_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            int colIndex = dgv.CurrentCell.ColumnIndex;
            if (dgv.Columns[colIndex].Name == "colCodeTo" && e.Control is ComboBox)
            {
                ComboBox comboBox = e.Control as ComboBox;
                comboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            }
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            dgv.Rows[dgv.CurrentCell.RowIndex].Cells["colTitleTo"].Value = comboBox.SelectedValue;
            dgv.Rows[dgv.CurrentCell.RowIndex].Cells["colTypeTo"].Value = comboBox.SelectedValue;
        }

        private void initTOCache()
        {
            int id;
            string title;

            dict.Clear();
            string queryString = "SELECT [ОбозначениеТО], [КодТО], [NИзделия], [NДетали] FROM Заказы";
            using (OleDbConnection connection = new OleDbConnection(Texac.Properties.Settings.Default.connStr))
            {
                OleDbCommand command = new OleDbCommand(queryString, connection);
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string codeTO = reader.GetString(0);
                    int typeTO = reader.GetInt16(1);
                    string itemNo = reader.GetString(2);
                    string detailNo = reader.GetString(3);

                    ToEntity toEntity = new ToEntity(codeTO, typeTO, itemNo, detailNo);
                    if (dict.ContainsKey(codeTO))
                        dict[codeTO] = toEntity;
                    else
                        dict.Add(codeTO, toEntity);
                }
                reader.Close();

                command.CommandText = "SELECT [ГрафикN], [Nдокумента] FROM [ГрафикиМероприятий] WHERE [Nдокумента] Is Not Null";
                reader = command.ExecuteReader();
                graphics.Clear();
                graphics.Add(new ComboBoxEntity(0, ""));
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                    title = reader.IsDBNull(1) ? "" : reader.GetString(1);
                    graphics.Add(new ComboBoxEntity(id, title));
                }
                reader.Close();

                command.CommandText = "SELECT [NТабельный], [ФИО] FROM [РаботникиЦеха] WHERE [Операция]=\"Инженер - технолог\" AND [Работает]=True";
                reader = command.ExecuteReader();
                employees.Clear();
                employees.Add(new ComboBoxEntity(0, ""));
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                    title = reader.IsDBNull(1) ? "" : reader.GetString(1);
                    employees.Add(new ComboBoxEntity(id, title));
                }
                reader.Close();

                command.CommandText = "SELECT [КодОснованияЗаказа], [ОснованиеЗаказа] FROM [ОснованияДляОткрытияЗаказов]";
                reader = command.ExecuteReader();
                orderBased.Clear();
                orderBased.Add(new ComboBoxEntity(0, ""));
                while (reader.Read())
                {
                    id = reader.GetByte(0);
                    title = reader.IsDBNull(1) ? "" : reader.GetString(1);
                    orderBased.Add(new ComboBoxEntity(id, title));
                }
                reader.Close();

                command.CommandText = "SELECT [КодПриоритета], [КодПриоритета] & \". \" & [НазвПриоритета] FROM [ПриоритетыЗаказов]";
                reader = command.ExecuteReader();
                priorities.Clear();
                priorities.Add(new ComboBoxEntity(0, ""));
                while (reader.Read())
                {
                    id = reader.GetByte(0);
                    title = reader.IsDBNull(1) ? "" : reader.GetString(1);
                    priorities.Add(new ComboBoxEntity(id, title));
                }
                reader.Close();

                command.CommandText = "SELECT [КодВидаГрафика], [КодВидаГрафика] & \". \" & [ВидГрафика] FROM [ВидГрафика]";
                reader = command.ExecuteReader();
                graphicTypes.Clear();
                graphicTypes.Add(new ComboBoxEntity(0, ""));
                while (reader.Read())
                {
                    id = reader.GetByte(0);
                    title = reader.IsDBNull(1) ? "" : reader.GetString(1).Trim();
                    graphicTypes.Add(new ComboBoxEntity(id, title));
                }
                reader.Close();

                
                command.CommandText = "SELECT [NЦеха], [НаименованиеЦеха] FROM [НомераЦехов]";
                reader = command.ExecuteReader();
                shops.Clear();
                shops.Add(new ComboBoxEntity(0, ""));
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                    title = reader.IsDBNull(1) ? "" : reader.GetString(1);
                    shops.Add(new ComboBoxEntity(id, id.ToString() + " " + title));
                }
                reader.Close();

                command.CommandText = "SELECT КодТО, НаименованиеТО, КодВидаТО FROM КодыНаименованийТО";
                reader = command.ExecuteReader();
                toTypes.Clear();
                while (reader.Read())
                {
                    ToTypes to = new ToTypes();
                    to.codeTo = reader.GetInt16(0);
                    to.titleTo = reader.GetString(1);
                    to.codeTypeTo = reader.GetByte(2);
                    toTypes.Add(to);
                }
                reader.Close();

                command.CommandText = "SELECT [NТабельный], [ФИО] FROM [РаботникиЦеха] WHERE [Работает]=true AND [Операция] Like \"%Инженер-технолог%\"";
                reader = command.ExecuteReader();
                techEmps.Clear();
                techEmps.Add(new ComboBoxEntity(0, ""));
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                    title = reader.IsDBNull(1) ? "" : reader.GetString(1);
                    techEmps.Add(new ComboBoxEntity(id, title));
                }
                reader.Close();

                command.CommandText = "SELECT [Наименование], [ТНВЭД] FROM [КодыТНВЭД]";
                reader = command.ExecuteReader();
                tnvedMap.Clear();
                
                while (reader.Read())
                {
                    title = reader.GetString(0);
                    if (reader[1] != DBNull.Value && tnvedMap.ContainsKey(title) == false) 
                    {
                        Decimal codeTnved = codeTnved = reader.GetDecimal(1);
                        tnvedMap.Add(title, codeTnved);
                    }
                }
                reader.Close();

        }
    }

        private void tsbPaste_Click(object sender, EventArgs e)
        {
            DataObject o = (DataObject)Clipboard.GetDataObject();
            if (o.GetDataPresent(DataFormats.StringFormat))
            {
                string[] pastedRows = Regex.Split(o.GetData(DataFormats.StringFormat).ToString().TrimEnd("\r\n".ToCharArray()), "\r");
                int j = 0;
                try { j = dgv.CurrentRow.Index; } catch { }
                foreach (string pastedRow in pastedRows)
                {
                    DataGridViewRow r = new DataGridViewRow();
                    r.CreateCells(dgv, pastedRow.Split(new char[] { '\t' }));
                    dgv.Rows.Insert(j, r);
                    j++;
                }
            }
        }

        private void dgv_MouseDown(object sender, MouseEventArgs e)
        {
            var hti = dgv.HitTest(e.X, e.Y);
            if (hti.RowIndex >= 0 && hti.ColumnIndex >= 0)
            {
                if (dgv.SelectedCells.Contains(dgv[hti.ColumnIndex, hti.RowIndex])==false)
                {
                    dgv.ClearSelection();
                    dgv.CurrentCell = dgv[hti.ColumnIndex, hti.RowIndex];
                }
            }
        }

        private void tsbCopy_Click(object sender, EventArgs e)
        {
            var newline = System.Environment.NewLine;
            var tab = "\t";
            var clipboard_string = new StringBuilder();

            foreach (DataGridViewRow row in dgv.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    if (i == (row.Cells.Count - 1))
                        clipboard_string.Append(row.Cells[i].Value + newline);
                    else
                        clipboard_string.Append(row.Cells[i].Value + tab);
                }
            }

            Clipboard.SetText(clipboard_string.ToString());
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv.RowCount; i++)
            {
                object obozTo = dgv.Rows[i].Cells["colObozTo1"].Value;
                if (obozTo != null)
                {
                    int qty = 0;
                    string s = dgv.Rows[i].Cells["colQty"].Value == null ? "" : dgv.Rows[i].Cells["colQty"].Value.ToString();
                    Int32.TryParse(s, out qty);



                    Order order = getOrderByObozTo(obozTo.ToString().Trim());
                    // если нашли отдельный заказ
                    if (order.orderId > 0)
                    {
                        dgv.Rows[i].Cells["colObozTo2"].Value = order.obozTo;
                        dgv.Rows[i].Cells["colCodeTo"].Value = order.codeTo;
                        dgv.Rows[i].Cells["colTitleTo"].Value = order.codeTo;
                        dgv.Rows[i].Cells["colTypeTo"].Value = order.codeTo;
                        dgv.Rows[i].Cells["colWorkHours"].Value = order.planNv;
                        dgv.Rows[i].Cells["colWorkHoursTotal"].Value = order.planNv * qty;
                        dgv.Rows[i].Cells["colItemNo"].Value = order.itemNo;
                        dgv.Rows[i].Cells["colDetailNo"].Value = order.detailNo;

                        if (techEmps.Find(item => item.id == order.techEmpId) != null)
                            dgv.Rows[i].Cells["colTechEmp"].Value = (int)order.techEmpId;

                        if (i == 0)
                        {
                            if (order.reasonOrder != null)
                                cbReasonOrder.SelectedValue = (int)order.reasonOrder;
                            /*
                            if (order.customerId != null)
                                cbCustomerShop.SelectedValue = (int)order.customerId;
                            */
                        }
                    }
                    else
                    {
                        dgv.Rows[i].Cells["colObozTo2"].Value = dgv.Rows[i].Cells["colObozTo1"].Value;
                        dgv.Rows[i].Cells["colItemNo"].Value = "000";
                        dgv.Rows[i].Cells["colDetailNo"].Value = "000";

                        string toTitle = dgv.Rows[i].Cells["colTitle"].Value.ToString().TrimStart('\n');
                        ToTypes t = toTypes.Find(item => item.titleTo == toTitle);
                        if(t!=null)
                            dgv.Rows[i].Cells["colCodeTo"].Value = t.codeTo;
                    }

                    string title = dgv.Rows[i].Cells["colTitle"].Value.ToString().Trim();
                    if (tnvedMap.ContainsKey(title) && tbOrderType.Text.StartsWith("208"))
                    {
                        dgv.Rows[i].Cells["colTnved"].Value = tnvedMap[title];
                    }
                    else
                    {
                        dgv.Rows[i].Cells["colTnved"].Value = 0;
                    }

                }
            }
        }

        private void btnWorkHours_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv.RowCount; i++)
            {
                object obozTo = dgv.Rows[i].Cells["colObozTo1"].Value;
                object hours = dgv.Rows[i].Cells["colWorkHours"].Value;
                if (obozTo != null && hours==null)
                {
                    int qty = 0;
                    string s = dgv.Rows[i].Cells["colQty"].Value == null ? "" : dgv.Rows[i].Cells["colQty"].Value.ToString();
                    Int32.TryParse(s, out qty);
                    double h = getWorkHoursByObozTo(obozTo.ToString());
                    if (h > 0.0)
                    {
                        dgv.Rows[i].Cells["colWorkHours"].Value = h;
                        dgv.Rows[i].Cells["colWorkHoursTotal"].Value = h * qty;
                    }
                }
            }
            MessageBox.Show("Готово");
        }

        private Order getOrderByObozTo(string obozTo)
        {
            Order o =  new Order();

            using (OleDbConnection connection = new OleDbConnection(Texac.Properties.Settings.Default.connStr))
            {
                string queryString = "SELECT NППЗаказа, NЗаказаЗавода, NЗаказа, ГрафикN, ВидГрафика, ОснованиеЗаказа, ДатаПолученияЗаказа, ОбозначениеТО, КодТО, NИзделия, NДетали, Кол_во, ФКол_во, Заказчик, ПланДатаИзготовления, КодПриоритета, ПланТП, ДатаТП, ДатаПоступленияЦех, ФактДатаИзготовления, ПланТрудоемкость, ЦехИсполнитель, Отчет, ДатаОтчета, Технолог, Слесарь, СодержаниеЗаявки, ФактТрудоемкость, NНакладной, NАкта, СкладПолуч, НеодноврВыпЗак, Конструктор, p_unit, pause, OrderCards, Life, Lifeday, ObjectType, Quckly, MaterialDate, Запчасть, Стойкость, Доп_заказ, TNVED, PriceDate, PeoDate, OtizDate, Weight FROM Заказы WHERE ОбозначениеТО = @obozTo ORDER BY [NППЗаказа] DESC";
                OleDbCommand command = new OleDbCommand(queryString, connection);
                command.Parameters.AddWithValue("@obozTo", obozTo);
                connection.Open();
                OleDbDataReader r = command.ExecuteReader();
                if(r.Read())
                {
                    o.orderId = r.GetInt32(0);
                    o.orderNumber = r.GetString(1);
                    o.orderFullNumber = r.GetString(2);
                    if (r[3] != DBNull.Value)
                        o.graphId = r.GetInt32(3);
                    if (r[4] != DBNull.Value)
                        o.graphTypeId = r.GetByte(4);
                    if (r[5] != DBNull.Value)
                        o.reasonOrder = r.GetByte(5);
                    if (r[6] != DBNull.Value)
                        o.orderDate = r.GetDateTime(6);
                    if (r[7] != DBNull.Value)
                        o.obozTo = r.GetString(7);
                    if (r[8] != DBNull.Value)
                        o.codeTo = r.GetInt16(8);
                    o.itemNo = r.GetString(9);
                    o.detailNo = r.GetString(10);
                    if (r[11] != DBNull.Value)
                        o.qty = r.GetInt32(11);
                    if (r[12] != DBNull.Value)
                        o.realQty = r.GetInt32(12);
                    if (r[13] != DBNull.Value)
                        o.customerId = r.GetInt32(13);
                    if (r[14] != DBNull.Value)
                        o.planDate = r.GetDateTime(14);
                    if (r[15] != DBNull.Value)
                        o.priorityId = r.GetByte(15);
                    if (r[16] != DBNull.Value)
                        o.planTechDate = r.GetDateTime(16);
                    if (r[17] != DBNull.Value)
                        o.techDate = r.GetDateTime(17);
                    if (r[18] != DBNull.Value)
                        o.shopDate = r.GetDateTime(18);
                    if (r[19] != DBNull.Value)
                        o.factReadyDate = r.GetDateTime(19);
                    if (r[20] != DBNull.Value)
                        o.planNv= r.GetDouble(20);
                    if (r[21] != DBNull.Value)
                        o.performerShop = r.GetInt32(21);
                    if (r[22] != DBNull.Value)
                        o.includeInReport = r.GetBoolean(22);
                    if (r[23] != DBNull.Value)
                        o.reportDate = r.GetDateTime(23);
                    if (r[24] != DBNull.Value)
                        o.techEmpId = r.GetInt32(24);
                    if (r[25] != DBNull.Value)
                        o.locksmithId = r.GetInt32(25);
                    if (r[26] != DBNull.Value)
                        o.orderNote = r.GetString(26);
                    if (r[27] != DBNull.Value)
                        o.factNv = r.GetDouble(27);
                    if (r[28] != DBNull.Value)
                        o.consignmentNote = r.GetString(28);
                    if (r[29] != DBNull.Value)
                        o.actNumber = r.GetString(29);
                    if (r[30] != DBNull.Value)
                        o.destinationStore = r.GetString(30);
                    if (r[31] != DBNull.Value)
                        o.anotherTimeReady = r.GetBoolean(31);
/*
                    if (r[32] != DBNull.Value)
                        o.designerName = r.GetString(32);
                    if (r[33] != DBNull.Value)
                        o.unitOfMeasure = r.GetString(33);
*/
                    if (r[34] != DBNull.Value)
                        o.stopped = r.GetBoolean(34);
                    if (r[35] != DBNull.Value)
                        o.orderCard = r.GetInt32(35);
                    if (r[36] != DBNull.Value)
                        o.serviceLifeYear = r.GetInt16(36);
                    if (r[37] != DBNull.Value)
                        o.serviceLifeDay = r.GetInt32(37);
                    if (r[38] != DBNull.Value)
                        o.objectType = r.GetByte(38);
                    if (r[39] != DBNull.Value)
                        o.urgent = r.GetBoolean(39);
                    if (r[40] != DBNull.Value)
                        o.materialDate = r.GetDateTime(40);
                    if (r[41] != DBNull.Value)
                        o.spare = r.GetBoolean(41);
                    if (r[42] != DBNull.Value)
                        o.resistance = r.GetInt32(42);
                    if (r[43] != DBNull.Value)
                        o.additionalOrder = r.GetBoolean(43);
                    if (r[44] != DBNull.Value)
                        o.classifier = r.GetDecimal(44).ToString();
                    if (r[45] != DBNull.Value)
                        o.priceDate = r.GetDateTime(45);
                    if (r[46] != DBNull.Value)
                        o.peoDate = r.GetDateTime(46);
                    if (r[47] != DBNull.Value)
                        o.otizDate = r.GetDateTime(47);
                    if (r[48] != DBNull.Value)
                        o.weight = r.GetInt32(48);
                }
                r.Close();
            }
            /*
            string json = JsonConvert.SerializeObject(order);
            MessageBox.Show(json);
            */  
            return o;
        }



        private void dgv_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private double getWorkHoursByObozTo(string obozTo)
        {
            int orderId = 0;
            double workHours = 0.0;
            int leftDotPos = obozTo.IndexOf(".");
            if (leftDotPos == -1)
                return 0.0;

            string item = obozTo.Substring(0, leftDotPos);
            string detail = obozTo.Substring(leftDotPos + 1);
            //MessageBox.Show("item: " + item + "\r\ndetail: " + detail);

            using (OleDbConnection connection = new OleDbConnection(Texac.Properties.Settings.Default.connStr))
            {
                string queryString = "SELECT [NППЗаказа], [NЗаказа] FROM [Заказы] WHERE ([NЗаказа] Like '208%' OR [NЗаказа] Like '23-%') AND [ОбозначениеТО]=@obozTo AND [КодТО]<10000";
                OleDbCommand command = new OleDbCommand(queryString, connection);
                command.Parameters.AddWithValue("@obozTo", item);
                connection.Open();
                OleDbDataReader r = command.ExecuteReader();
                while (r.Read())
                {
                    if (r.IsDBNull(0) == false && r.GetString(1).IndexOf(".") == -1)
                    {
                        orderId = r.GetInt32(0);
                    }
                }
                r.Close();
            }

            if (orderId == 0)
                return 0.0;

            using (OleDbConnection connection = new OleDbConnection(Texac.Properties.Settings.Default.connStr))
            {
                string queryString = "SELECT НормаВремени * КоличествоДеталей as work_hours FROM МатериальнаяКарта as m INNER JOIN ТехнологияИзготовления t ON m.NППДетали = t.NППДетали AND m.NППЗаказа = t.NППЗаказа WHERE m.NППЗаказа = @orderId AND(NДеталиОснастки = @detailPart1 OR NДеталиОснастки = @detailPart2)";
                OleDbCommand command = new OleDbCommand(queryString, connection);
                command.Parameters.AddWithValue("@orderId", orderId);
                command.Parameters.AddWithValue("@detailPart1", detail);

                int leftMinusPos = item.IndexOf("-");
                string deteilPart2 = item.Substring(leftMinusPos + 1) + "." + detail;
                command.Parameters.AddWithValue("@detailPart2", deteilPart2);

                connection.Open();
                OleDbDataReader r = command.ExecuteReader();
                while (r.Read())
                {
                    if (r.IsDBNull(0) == false)
                    {
                        workHours += r.GetDouble(0);
                    }
                }
                r.Close();
            }

            return workHours;
        }

        private void btnSaveOrders_Click(object sender, EventArgs e)
        {

            if ((int)cbGraphic.SelectedValue == 0)
            {
                if (MessageBox.Show("Поле 'График' не заполнено. Продолжить?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;
            }

            if(dgv.SelectedRows.Count==0)
            {
                if (MessageBox.Show("Необходимо произвести выделение строк в таблице, которые требуется сохранить", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;
            }

            int count = 0;
            foreach (DataGridViewRow r in dgv.SelectedRows)
            { 

                using (OleDbConnection connection = new OleDbConnection(Texac.Properties.Settings.Default.connStr))
                {
                    try {

                        string queryString = "INSERT INTO Заказы(NЗаказаЗавода, NЗаказа, ВидГрафика, ОснованиеЗаказа, ДатаПолученияЗаказа, ОбозначениеТО, КодТО, NИзделия, NДетали, Кол_во, Заказчик, ЦехИсполнитель, Технолог, ПланДатаИзготовления, ПланТП, ГрафикN, TNVED, КодПриоритета, Запчасть) " +
                        " VALUES(@orderType, @orderType, @graphTypeId, @reasonOrder, @orderDate, @obozTo, @codeTo,  @itemNo, @detailNo, @qty, @customerShop, @producerShop, @techEmpId, @planDate, @planTechDate, @graphId, @TNVED, @priority, @spareParts)";
                        OleDbCommand command = new OleDbCommand(queryString, connection);

                        Byte graphTypeId = (Byte)((Int32)cbGraphicType.SelectedValue);
                        Byte reasonOrder = (Byte)((Int32)cbReasonOrder.SelectedValue);

                        command.Parameters.AddWithValue("@orderType", tbOrderType.Text);
                        command.Parameters.AddWithValue("@graphTypeId", graphTypeId);
                        command.Parameters.AddWithValue("@reasonOrder", reasonOrder);

                        command.Parameters.AddWithValue("@orderDate", dtpOrder.Value);

                        string s = r.Cells["colObozTo2"].Value.ToString();
                        command.Parameters.AddWithValue("@obozTo", s);

                        int codeTo = Convert.ToInt32(r.Cells["colCodeTo"].Value);
                        command.Parameters.AddWithValue("@codeTo", codeTo);

                        string itemNo = r.Cells["colItemNo"].Value.ToString();
                        command.Parameters.AddWithValue("@itemNo", itemNo);

                        string detailNo = r.Cells["colDetailNo"].Value.ToString();
                        command.Parameters.AddWithValue("@detailNo", detailNo);

                        int qty = Convert.ToInt32(r.Cells["colQty"].Value);
                        command.Parameters.AddWithValue("@qty", qty);

                        int customerShop = (int)cbCustomerShop.SelectedValue;
                        command.Parameters.AddWithValue("@customerShop", customerShop);

                        int producerShop = (int)cbProducerShop.SelectedValue;
                        command.Parameters.AddWithValue("@producerShop", producerShop);
                        
                        int techEmpId = Convert.ToInt32(r.Cells["colTechEmp"].Value);
                        if (techEmpId > 0)
                            command.Parameters.AddWithValue("@techEmpId", techEmpId);
                        else
                            command.Parameters.AddWithValue("@techEmpId", DBNull.Value);

                        if(dtpPlan.Value == DateTime.MinValue)
                        {
                            command.Parameters.AddWithValue("@planDate", DBNull.Value);
                        } else
                        {
                            command.Parameters.AddWithValue("@planDate", dtpPlan.Value.Date);
                        }

                        if (dtpPlanTP.Value == DateTime.MinValue)
                        {
                            command.Parameters.AddWithValue("@planTechDate", DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@planTechDate", dtpPlanTP.Value);
                        }

                        if((int)cbGraphic.SelectedValue == 0)
                        {
                            command.Parameters.AddWithValue("@graphId", DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@graphId", (int)cbGraphic.SelectedValue);
                        }

                        Decimal tnved = Convert.ToDecimal(r.Cells["colTnved"].Value);
                        command.Parameters.AddWithValue("@TNVED", tnved);

                        Byte priority = (Byte)((Int32)cbPriorities.SelectedValue);
                        command.Parameters.AddWithValue("@priority", priority);

                        Boolean spareParts = chSparePart.Checked;
                        command.Parameters.AddWithValue("@spareParts", spareParts);

                        connection.Open();
                        command.ExecuteNonQuery();

                        OleDbCommand cmdIdentity = new OleDbCommand("Select @@Identity", connection);
                        int newOrderId = (int)cmdIdentity.ExecuteScalar();

                        r.Cells["colOrderId"].Value = newOrderId;

                        string orderFullNumber;
                        string orderNumber;
                        int startOrderNumber;
                        if (tbOrderType.Text == "24/5")
                        {
                            orderFullNumber = tbOrderType.Text + "-" + newOrderId.ToString();
                            orderNumber = "24/5";
                        }
                        else
                        {
                            startOrderNumber = Convert.ToInt32(tbStartOrderNumber.Text);
                            orderFullNumber = tbOrderType.Text + "/" + startOrderNumber.ToString() + "-" + newOrderId.ToString();
                            orderNumber = tbOrderType.Text + "/" + startOrderNumber.ToString();
                            tbStartOrderNumber.Text = (++startOrderNumber).ToString();
                            Properties.Settings.Default.StartOrderNumber = startOrderNumber;
                            Properties.Settings.Default.Save();
                        }

                        string cmpUpdate = "Update [Заказы] Set [NЗаказа]=\"" + orderFullNumber + "\" , [NЗаказаЗавода]=\"" + orderNumber + "\" WHERE [NППЗаказа]=@orderId";
                        OleDbCommand cmdChangeOrderFullNumber = new OleDbCommand(cmpUpdate, connection);
                        cmdChangeOrderFullNumber.Parameters.AddWithValue("@orderId", newOrderId);

                        cmdChangeOrderFullNumber.ExecuteScalar();
                        count++;

                    } catch (Exception ex) {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            MessageBox.Show(string.Format("Сохранено {0} записей", count));
        }
        
    }
}
