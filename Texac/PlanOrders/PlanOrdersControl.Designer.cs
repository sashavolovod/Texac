namespace Texac.PlanOrders
{
    partial class PlanOrdersControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlanOrdersControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbStartOrderNumber = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbProducerShop = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbPriorities = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpPlanTP = new DateTimePickerEx();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpPlan = new DateTimePickerEx();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpOrder = new DateTimePickerEx();
            this.cbCustomerShop = new System.Windows.Forms.ComboBox();
            this.cbGraphicType = new System.Windows.Forms.ComboBox();
            this.cbReasonOrder = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbGraphic = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbOrderType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFill = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSaveOrders = new System.Windows.Forms.Button();
            this.btnWorkHours = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colObozTo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colObozTo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodeTo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colTitleTo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colTnved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTypeTo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colItemNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetailNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTechEmp = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colWorkHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWorkHoursTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnuContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsbCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.myToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.chSparePart = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.mnuContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.chSparePart);
            this.panel1.Controls.Add(this.tbStartOrderNumber);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.cbProducerShop);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.cbPriorities);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.dtpPlanTP);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dtpPlan);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dtpOrder);
            this.panel1.Controls.Add(this.cbCustomerShop);
            this.panel1.Controls.Add(this.cbGraphicType);
            this.panel1.Controls.Add(this.cbReasonOrder);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbGraphic);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbOrderType);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 196);
            this.panel1.TabIndex = 0;
            // 
            // tbStartOrderNumber
            // 
            this.tbStartOrderNumber.Location = new System.Drawing.Point(278, 23);
            this.tbStartOrderNumber.Name = "tbStartOrderNumber";
            this.tbStartOrderNumber.Size = new System.Drawing.Size(92, 25);
            this.tbStartOrderNumber.TabIndex = 11;
            this.tbStartOrderNumber.Text = "7777";
            this.tbStartOrderNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.myToolTip.SetToolTip(this.tbStartOrderNumber, "Начальный заводской номер заказа");
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(203, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "№ по бух:";
            this.myToolTip.SetToolTip(this.label11, "Номер заказа завода");
            // 
            // cbProducerShop
            // 
            this.cbProducerShop.FormattingEnabled = true;
            this.cbProducerShop.Location = new System.Drawing.Point(467, 116);
            this.cbProducerShop.Name = "cbProducerShop";
            this.cbProducerShop.Size = new System.Drawing.Size(309, 25);
            this.cbProducerShop.TabIndex = 9;
            this.myToolTip.SetToolTip(this.cbProducerShop, "Цех исполнителя");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(379, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Цех исполн:";
            this.myToolTip.SetToolTip(this.label10, "Цех исполнителя");
            // 
            // cbPriorities
            // 
            this.cbPriorities.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbPriorities.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPriorities.FormattingEnabled = true;
            this.cbPriorities.Location = new System.Drawing.Point(105, 147);
            this.cbPriorities.Name = "cbPriorities";
            this.cbPriorities.Size = new System.Drawing.Size(265, 25);
            this.cbPriorities.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Приоритет:";
            // 
            // dtpPlanTP
            // 
            this.dtpPlanTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPlanTP.Location = new System.Drawing.Point(674, 23);
            this.dtpPlanTP.Name = "dtpPlanTP";
            this.dtpPlanTP.Size = new System.Drawing.Size(102, 25);
            this.dtpPlanTP.TabIndex = 7;
            this.myToolTip.SetToolTip(this.dtpPlanTP, "Плановая дата техпроцесса");
            this.dtpPlanTP.Value = new System.DateTime(2022, 7, 12, 13, 37, 39, 595);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(588, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Пл. дата ТП:";
            this.myToolTip.SetToolTip(this.label8, "Плановая дата техпроцесса");
            // 
            // dtpPlan
            // 
            this.dtpPlan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPlan.Location = new System.Drawing.Point(470, 23);
            this.dtpPlan.Name = "dtpPlan";
            this.dtpPlan.Size = new System.Drawing.Size(102, 25);
            this.dtpPlan.TabIndex = 5;
            this.myToolTip.SetToolTip(this.dtpPlan, "Плановая дата изготовления");
            this.dtpPlan.Value = new System.DateTime(2022, 7, 12, 13, 37, 39, 595);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(379, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Пл. дата изг.:";
            this.myToolTip.SetToolTip(this.label7, "Плановая дата изготовления");
            // 
            // dtpOrder
            // 
            this.dtpOrder.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrder.Location = new System.Drawing.Point(105, 54);
            this.dtpOrder.Name = "dtpOrder";
            this.dtpOrder.Size = new System.Drawing.Size(265, 25);
            this.dtpOrder.TabIndex = 3;
            this.dtpOrder.Value = new System.DateTime(2022, 7, 12, 13, 37, 39, 595);
            // 
            // cbCustomerShop
            // 
            this.cbCustomerShop.FormattingEnabled = true;
            this.cbCustomerShop.Location = new System.Drawing.Point(467, 85);
            this.cbCustomerShop.Name = "cbCustomerShop";
            this.cbCustomerShop.Size = new System.Drawing.Size(309, 25);
            this.cbCustomerShop.TabIndex = 2;
            // 
            // cbGraphicType
            // 
            this.cbGraphicType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbGraphicType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbGraphicType.FormattingEnabled = true;
            this.cbGraphicType.Location = new System.Drawing.Point(467, 54);
            this.cbGraphicType.Name = "cbGraphicType";
            this.cbGraphicType.Size = new System.Drawing.Size(309, 25);
            this.cbGraphicType.TabIndex = 2;
            // 
            // cbReasonOrder
            // 
            this.cbReasonOrder.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbReasonOrder.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbReasonOrder.FormattingEnabled = true;
            this.cbReasonOrder.Location = new System.Drawing.Point(105, 116);
            this.cbReasonOrder.Name = "cbReasonOrder";
            this.cbReasonOrder.Size = new System.Drawing.Size(265, 25);
            this.cbReasonOrder.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(379, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Заказчик:";
            // 
            // cbGraphic
            // 
            this.cbGraphic.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbGraphic.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbGraphic.FormattingEnabled = true;
            this.cbGraphic.Location = new System.Drawing.Point(105, 85);
            this.cbGraphic.Name = "cbGraphic";
            this.cbGraphic.Size = new System.Drawing.Size(265, 25);
            this.cbGraphic.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(379, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Вид графика:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Осн. заказа:";
            // 
            // tbOrderType
            // 
            this.tbOrderType.Location = new System.Drawing.Point(105, 23);
            this.tbOrderType.Name = "tbOrderType";
            this.tbOrderType.Size = new System.Drawing.Size(64, 25);
            this.tbOrderType.TabIndex = 1;
            this.tbOrderType.Text = "208";
            this.tbOrderType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.myToolTip.SetToolTip(this.tbOrderType, "Номер заказа завода (например: 24/5, 208, 233 и т.п.)");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "График:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Дата заказа:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "№ зак. зав.:";
            this.myToolTip.SetToolTip(this.label1, "Номер заказа завода (например: 24/5, 208, 233 и т.п.)");
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(3, 25);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(150, 45);
            this.btnFill.TabIndex = 10;
            this.btnFill.Text = "Поиск существующих заказов";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSaveOrders);
            this.panel2.Controls.Add(this.btnWorkHours);
            this.panel2.Controls.Add(this.btnFill);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 570);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 94);
            this.panel2.TabIndex = 1;
            // 
            // btnSaveOrders
            // 
            this.btnSaveOrders.Location = new System.Drawing.Point(182, 25);
            this.btnSaveOrders.Name = "btnSaveOrders";
            this.btnSaveOrders.Size = new System.Drawing.Size(142, 45);
            this.btnSaveOrders.TabIndex = 11;
            this.btnSaveOrders.Text = "Сохранить";
            this.myToolTip.SetToolTip(this.btnSaveOrders, "Поиск трудоёмкости оснастики, входящей в другие заказы");
            this.btnSaveOrders.UseVisualStyleBackColor = true;
            this.btnSaveOrders.Click += new System.EventHandler(this.btnSaveOrders_Click);
            // 
            // btnWorkHours
            // 
            this.btnWorkHours.Enabled = false;
            this.btnWorkHours.Location = new System.Drawing.Point(1007, 25);
            this.btnWorkHours.Name = "btnWorkHours";
            this.btnWorkHours.Size = new System.Drawing.Size(142, 45);
            this.btnWorkHours.TabIndex = 10;
            this.btnWorkHours.Text = "Трудоёмкость";
            this.myToolTip.SetToolTip(this.btnWorkHours, "Поиск трудоёмкости оснастики, входящей в другие заказы");
            this.btnWorkHours.UseVisualStyleBackColor = true;
            this.btnWorkHours.Click += new System.EventHandler(this.btnWorkHours_Click);
            // 
            // dgv
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTitle,
            this.colObozTo1,
            this.colQty,
            this.colOrderId,
            this.colObozTo2,
            this.colCodeTo,
            this.colTitleTo,
            this.colTnved,
            this.colTypeTo,
            this.colItemNo,
            this.colDetailNo,
            this.colTechEmp,
            this.colWorkHours,
            this.colWorkHoursTotal});
            this.dgv.ContextMenuStrip = this.mnuContext;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 196);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(1200, 374);
            this.dgv.TabIndex = 2;
            this.dgv.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgv_DataError);
            this.dgv.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgv_EditingControlShowing);
            this.dgv.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgv_MouseDown);
            // 
            // colTitle
            // 
            this.colTitle.HeaderText = "Наименование оснастки";
            this.colTitle.Name = "colTitle";
            this.colTitle.Width = 120;
            // 
            // colObozTo1
            // 
            this.colObozTo1.HeaderText = "Шифр оснастки";
            this.colObozTo1.Name = "colObozTo1";
            this.colObozTo1.Width = 180;
            // 
            // colQty
            // 
            this.colQty.HeaderText = "Количество на год";
            this.colQty.Name = "colQty";
            // 
            // colOrderId
            // 
            this.colOrderId.HeaderText = "NППЗаказа";
            this.colOrderId.Name = "colOrderId";
            this.colOrderId.ReadOnly = true;
            this.colOrderId.Width = 85;
            // 
            // colObozTo2
            // 
            this.colObozTo2.HeaderText = "Обозначение ТО";
            this.colObozTo2.Name = "colObozTo2";
            // 
            // colCodeTo
            // 
            this.colCodeTo.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colCodeTo.HeaderText = "Код ТО";
            this.colCodeTo.Name = "colCodeTo";
            this.colCodeTo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCodeTo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colCodeTo.Width = 150;
            // 
            // colTitleTo
            // 
            this.colTitleTo.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colTitleTo.HeaderText = "Наименование ТО";
            this.colTitleTo.Name = "colTitleTo";
            this.colTitleTo.ReadOnly = true;
            this.colTitleTo.Width = 150;
            // 
            // colTnved
            // 
            this.colTnved.HeaderText = "ТНВЭД";
            this.colTnved.Name = "colTnved";
            // 
            // colTypeTo
            // 
            this.colTypeTo.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colTypeTo.HeaderText = "Код вида ТО";
            this.colTypeTo.Name = "colTypeTo";
            this.colTypeTo.ReadOnly = true;
            this.colTypeTo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTypeTo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colItemNo
            // 
            this.colItemNo.HeaderText = "Номер изделия";
            this.colItemNo.Name = "colItemNo";
            // 
            // colDetailNo
            // 
            this.colDetailNo.HeaderText = "Номер детали";
            this.colDetailNo.Name = "colDetailNo";
            // 
            // colTechEmp
            // 
            this.colTechEmp.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colTechEmp.HeaderText = "Технолог";
            this.colTechEmp.Name = "colTechEmp";
            this.colTechEmp.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTechEmp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colTechEmp.Width = 130;
            // 
            // colWorkHours
            // 
            this.colWorkHours.HeaderText = "Трудоёмкость, н/ч";
            this.colWorkHours.Name = "colWorkHours";
            // 
            // colWorkHoursTotal
            // 
            this.colWorkHoursTotal.HeaderText = "Трудоёмкость всего, н/ч";
            this.colWorkHoursTotal.Name = "colWorkHoursTotal";
            // 
            // mnuContext
            // 
            this.mnuContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCopy,
            this.tsbPaste});
            this.mnuContext.Name = "mnuContext";
            this.mnuContext.Size = new System.Drawing.Size(140, 48);
            // 
            // tsbCopy
            // 
            this.tsbCopy.Image = ((System.Drawing.Image)(resources.GetObject("tsbCopy.Image")));
            this.tsbCopy.Name = "tsbCopy";
            this.tsbCopy.Size = new System.Drawing.Size(139, 22);
            this.tsbCopy.Text = "Копировать";
            this.tsbCopy.Click += new System.EventHandler(this.tsbCopy_Click);
            // 
            // tsbPaste
            // 
            this.tsbPaste.Image = ((System.Drawing.Image)(resources.GetObject("tsbPaste.Image")));
            this.tsbPaste.Name = "tsbPaste";
            this.tsbPaste.Size = new System.Drawing.Size(139, 22);
            this.tsbPaste.Text = "Вставить";
            this.tsbPaste.Click += new System.EventHandler(this.tsbPaste_Click);
            // 
            // chSparePart
            // 
            this.chSparePart.AutoSize = true;
            this.chSparePart.Checked = true;
            this.chSparePart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chSparePart.Location = new System.Drawing.Point(470, 152);
            this.chSparePart.Name = "chSparePart";
            this.chSparePart.Size = new System.Drawing.Size(15, 14);
            this.chSparePart.TabIndex = 12;
            this.chSparePart.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(379, 150);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 17);
            this.label12.TabIndex = 13;
            this.label12.Text = "Запчасть:";
            this.myToolTip.SetToolTip(this.label12, "Цех исполнителя");
            // 
            // PlanOrdersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PlanOrdersControl";
            this.Size = new System.Drawing.Size(1200, 664);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.mnuContext.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ContextMenuStrip mnuContext;
        private System.Windows.Forms.ToolStripMenuItem tsbCopy;
        private System.Windows.Forms.ToolStripMenuItem tsbPaste;
        private System.Windows.Forms.ComboBox cbPriorities;
        private System.Windows.Forms.Label label9;
        private DateTimePickerEx dtpPlanTP;
        private System.Windows.Forms.Label label8;
        private DateTimePickerEx dtpPlan;
        private System.Windows.Forms.Label label7;
        private DateTimePickerEx dtpOrder;
        private System.Windows.Forms.ComboBox cbCustomerShop;
        private System.Windows.Forms.ComboBox cbGraphicType;
        private System.Windows.Forms.ComboBox cbReasonOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbGraphic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbOrderType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbProducerShop;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.ToolTip myToolTip;
        private System.Windows.Forms.Button btnWorkHours;
        private System.Windows.Forms.Button btnSaveOrders;
        private System.Windows.Forms.TextBox tbStartOrderNumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObozTo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObozTo2;
        private System.Windows.Forms.DataGridViewComboBoxColumn colCodeTo;
        private System.Windows.Forms.DataGridViewComboBoxColumn colTitleTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTnved;
        private System.Windows.Forms.DataGridViewComboBoxColumn colTypeTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetailNo;
        private System.Windows.Forms.DataGridViewComboBoxColumn colTechEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWorkHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWorkHoursTotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox chSparePart;
    }
}
