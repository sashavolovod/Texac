namespace Texac
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ssStatusStrip = new System.Windows.Forms.StatusStrip();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.miFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.miOperation = new System.Windows.Forms.ToolStripMenuItem();
            this.заказыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miDictionary = new System.Windows.Forms.ToolStripMenuItem();
            this.работникиЦехаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.единицыИзмеренияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miDocs = new System.Windows.Forms.ToolStripMenuItem();
            this.miTrebovaniya = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miMaterialreport = new System.Windows.Forms.ToolStripMenuItem();
            this.miHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvEmploeyes = new System.Windows.Forms.DataGridView();
            this.NТабельный = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ФИО = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Должность = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nТабельныйDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сокрНазваниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.работаетDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.подраздDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsEmployee = new System.Windows.Forms.BindingSource(this.components);
            this.dataDataSet = new Texac.dataDataSet();
            this.bnEmployee = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cbEmployee = new System.Windows.Forms.ToolStripComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvTrebovania = new System.Windows.Forms.DataGridView();
            this.trebovanieIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scladDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zakazchikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsTrebovaniaDgv = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miOpenTrebovanie = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьТребованияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьПустоеТребованиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actDelTrebovanie = new System.Windows.Forms.ToolStripMenuItem();
            this.bsTrebovania = new System.Windows.Forms.BindingSource(this.components);
            this.bnTrebovania = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.taEmployee = new Texac.dataDataSetTableAdapters.РаботникиViewTableAdapter();
            this.tableAdapterManager = new Texac.dataDataSetTableAdapters.TableAdapterManager();
            this.taTrebovania = new Texac.dataDataSetTableAdapters.TrebovaniaViewTableAdapter();
            this.mnuMain.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmploeyes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnEmployee)).BeginInit();
            this.bnEmployee.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrebovania)).BeginInit();
            this.cmsTrebovaniaDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsTrebovania)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnTrebovania)).BeginInit();
            this.bnTrebovania.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssStatusStrip
            // 
            this.ssStatusStrip.Location = new System.Drawing.Point(0, 524);
            this.ssStatusStrip.Name = "ssStatusStrip";
            this.ssStatusStrip.Size = new System.Drawing.Size(850, 22);
            this.ssStatusStrip.TabIndex = 0;
            this.ssStatusStrip.Text = "statusStrip1";
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFile,
            this.miOperation,
            this.miDictionary,
            this.miDocs,
            this.отчетыToolStripMenuItem,
            this.miHelp});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(850, 24);
            this.mnuMain.TabIndex = 1;
            this.mnuMain.Text = "menuStrip1";
            // 
            // miFile
            // 
            this.miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.miExit});
            this.miFile.Name = "miFile";
            this.miFile.Size = new System.Drawing.Size(48, 20);
            this.miFile.Text = "Файл";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(105, 6);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(108, 22);
            this.miExit.Text = "Выход";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // miOperation
            // 
            this.miOperation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заказыToolStripMenuItem});
            this.miOperation.Name = "miOperation";
            this.miOperation.Size = new System.Drawing.Size(75, 20);
            this.miOperation.Text = "Операции";
            // 
            // заказыToolStripMenuItem
            // 
            this.заказыToolStripMenuItem.Name = "заказыToolStripMenuItem";
            this.заказыToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.заказыToolStripMenuItem.Text = "Заказы";
            // 
            // miDictionary
            // 
            this.miDictionary.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.работникиЦехаToolStripMenuItem,
            this.единицыИзмеренияToolStripMenuItem});
            this.miDictionary.Name = "miDictionary";
            this.miDictionary.Size = new System.Drawing.Size(94, 20);
            this.miDictionary.Text = "Справочники";
            // 
            // работникиЦехаToolStripMenuItem
            // 
            this.работникиЦехаToolStripMenuItem.Name = "работникиЦехаToolStripMenuItem";
            this.работникиЦехаToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.работникиЦехаToolStripMenuItem.Text = "Работники цеха";
            // 
            // единицыИзмеренияToolStripMenuItem
            // 
            this.единицыИзмеренияToolStripMenuItem.Name = "единицыИзмеренияToolStripMenuItem";
            this.единицыИзмеренияToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.единицыИзмеренияToolStripMenuItem.Text = "Единицы измерения";
            // 
            // miDocs
            // 
            this.miDocs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miTrebovaniya});
            this.miDocs.Name = "miDocs";
            this.miDocs.Size = new System.Drawing.Size(82, 20);
            this.miDocs.Text = "Документы";
            // 
            // miTrebovaniya
            // 
            this.miTrebovaniya.Name = "miTrebovaniya";
            this.miTrebovaniya.Size = new System.Drawing.Size(140, 22);
            this.miTrebovaniya.Text = "Требования";
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miMaterialreport});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // miMaterialreport
            // 
            this.miMaterialreport.Name = "miMaterialreport";
            this.miMaterialreport.Size = new System.Drawing.Size(180, 22);
            this.miMaterialreport.Text = "Расход материалов";
            this.miMaterialreport.Click += new System.EventHandler(this.miMaterialreport_Click);
            // 
            // miHelp
            // 
            this.miHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAbout});
            this.miHelp.Name = "miHelp";
            this.miHelp.Size = new System.Drawing.Size(68, 20);
            this.miHelp.Text = "Помощь";
            // 
            // miAbout
            // 
            this.miAbout.Name = "miAbout";
            this.miAbout.Size = new System.Drawing.Size(149, 22);
            this.miAbout.Text = "О программе";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(850, 500);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(842, 474);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Главная панель";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvEmploeyes);
            this.tabPage2.Controls.Add(this.bnEmployee);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(842, 474);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Работники цеха";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvEmploeyes
            // 
            this.dgvEmploeyes.AllowUserToAddRows = false;
            this.dgvEmploeyes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvEmploeyes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmploeyes.AutoGenerateColumns = false;
            this.dgvEmploeyes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmploeyes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NТабельный,
            this.ФИО,
            this.Должность,
            this.nТабельныйDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.сокрНазваниеDataGridViewTextBoxColumn,
            this.работаетDataGridViewCheckBoxColumn,
            this.подраздDataGridViewTextBoxColumn});
            this.dgvEmploeyes.DataSource = this.bsEmployee;
            this.dgvEmploeyes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmploeyes.Location = new System.Drawing.Point(3, 28);
            this.dgvEmploeyes.MultiSelect = false;
            this.dgvEmploeyes.Name = "dgvEmploeyes";
            this.dgvEmploeyes.ReadOnly = true;
            this.dgvEmploeyes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmploeyes.Size = new System.Drawing.Size(836, 443);
            this.dgvEmploeyes.TabIndex = 0;
            // 
            // NТабельный
            // 
            this.NТабельный.DataPropertyName = "NТабельный";
            this.NТабельный.HeaderText = "№ Таб.";
            this.NТабельный.Name = "NТабельный";
            this.NТабельный.ReadOnly = true;
            // 
            // ФИО
            // 
            this.ФИО.DataPropertyName = "ФИО";
            this.ФИО.HeaderText = "Фамилия И.О.";
            this.ФИО.Name = "ФИО";
            this.ФИО.ReadOnly = true;
            this.ФИО.Width = 150;
            // 
            // Должность
            // 
            this.Должность.DataPropertyName = "Название";
            this.Должность.HeaderText = "Должность";
            this.Должность.Name = "Должность";
            this.Должность.ReadOnly = true;
            // 
            // nТабельныйDataGridViewTextBoxColumn
            // 
            this.nТабельныйDataGridViewTextBoxColumn.DataPropertyName = "NТабельный";
            this.nТабельныйDataGridViewTextBoxColumn.HeaderText = "NТабельный";
            this.nТабельныйDataGridViewTextBoxColumn.Name = "nТабельныйDataGridViewTextBoxColumn";
            this.nТабельныйDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            this.фИОDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            this.названиеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // сокрНазваниеDataGridViewTextBoxColumn
            // 
            this.сокрНазваниеDataGridViewTextBoxColumn.DataPropertyName = "СокрНазвание";
            this.сокрНазваниеDataGridViewTextBoxColumn.HeaderText = "СокрНазвание";
            this.сокрНазваниеDataGridViewTextBoxColumn.Name = "сокрНазваниеDataGridViewTextBoxColumn";
            this.сокрНазваниеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // работаетDataGridViewCheckBoxColumn
            // 
            this.работаетDataGridViewCheckBoxColumn.DataPropertyName = "Работает";
            this.работаетDataGridViewCheckBoxColumn.HeaderText = "Работает";
            this.работаетDataGridViewCheckBoxColumn.Name = "работаетDataGridViewCheckBoxColumn";
            this.работаетDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // подраздDataGridViewTextBoxColumn
            // 
            this.подраздDataGridViewTextBoxColumn.DataPropertyName = "Подразд";
            this.подраздDataGridViewTextBoxColumn.HeaderText = "Подразд";
            this.подраздDataGridViewTextBoxColumn.Name = "подраздDataGridViewTextBoxColumn";
            this.подраздDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsEmployee
            // 
            this.bsEmployee.DataMember = "РаботникиView";
            this.bsEmployee.DataSource = this.dataDataSet;
            // 
            // dataDataSet
            // 
            this.dataDataSet.DataSetName = "dataDataSet";
            this.dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bnEmployee
            // 
            this.bnEmployee.AddNewItem = null;
            this.bnEmployee.BindingSource = this.bsEmployee;
            this.bnEmployee.CountItem = this.bindingNavigatorCountItem;
            this.bnEmployee.DeleteItem = null;
            this.bnEmployee.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.cbEmployee});
            this.bnEmployee.Location = new System.Drawing.Point(3, 3);
            this.bnEmployee.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnEmployee.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnEmployee.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnEmployee.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnEmployee.Name = "bnEmployee";
            this.bnEmployee.PositionItem = this.bindingNavigatorPositionItem;
            this.bnEmployee.Size = new System.Drawing.Size(836, 25);
            this.bnEmployee.TabIndex = 4;
            this.bnEmployee.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // cbEmployee
            // 
            this.cbEmployee.Margin = new System.Windows.Forms.Padding(20, 0, 1, 0);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(80, 25);
            this.cbEmployee.SelectedIndexChanged += new System.EventHandler(this.cbEmployee_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvTrebovania);
            this.tabPage3.Controls.Add(this.bnTrebovania);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(842, 474);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Требования";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvTrebovania
            // 
            this.dgvTrebovania.AllowUserToAddRows = false;
            this.dgvTrebovania.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTrebovania.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTrebovania.AutoGenerateColumns = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTrebovania.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTrebovania.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrebovania.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trebovanieIdDataGridViewTextBoxColumn,
            this.docNumberDataGridViewTextBoxColumn,
            this.docDateDataGridViewTextBoxColumn,
            this.scladDataGridViewTextBoxColumn,
            this.zakazchikDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.OrderNumber});
            this.dgvTrebovania.ContextMenuStrip = this.cmsTrebovaniaDgv;
            this.dgvTrebovania.DataSource = this.bsTrebovania;
            this.dgvTrebovania.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTrebovania.Location = new System.Drawing.Point(3, 28);
            this.dgvTrebovania.Name = "dgvTrebovania";
            this.dgvTrebovania.ReadOnly = true;
            this.dgvTrebovania.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTrebovania.Size = new System.Drawing.Size(836, 443);
            this.dgvTrebovania.TabIndex = 5;
            this.dgvTrebovania.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrebovania_CellDoubleClick);
            this.dgvTrebovania.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvTrebovania_MouseDown);
            // 
            // trebovanieIdDataGridViewTextBoxColumn
            // 
            this.trebovanieIdDataGridViewTextBoxColumn.DataPropertyName = "TrebovanieId";
            this.trebovanieIdDataGridViewTextBoxColumn.HeaderText = "№";
            this.trebovanieIdDataGridViewTextBoxColumn.Name = "trebovanieIdDataGridViewTextBoxColumn";
            this.trebovanieIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // docNumberDataGridViewTextBoxColumn
            // 
            this.docNumberDataGridViewTextBoxColumn.DataPropertyName = "DocNumber";
            this.docNumberDataGridViewTextBoxColumn.HeaderText = "Номер требования";
            this.docNumberDataGridViewTextBoxColumn.Name = "docNumberDataGridViewTextBoxColumn";
            this.docNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // docDateDataGridViewTextBoxColumn
            // 
            this.docDateDataGridViewTextBoxColumn.DataPropertyName = "DocDate";
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.docDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.docDateDataGridViewTextBoxColumn.HeaderText = "Дата требования";
            this.docDateDataGridViewTextBoxColumn.Name = "docDateDataGridViewTextBoxColumn";
            this.docDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // scladDataGridViewTextBoxColumn
            // 
            this.scladDataGridViewTextBoxColumn.DataPropertyName = "Sclad";
            this.scladDataGridViewTextBoxColumn.HeaderText = "Склад";
            this.scladDataGridViewTextBoxColumn.Name = "scladDataGridViewTextBoxColumn";
            this.scladDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zakazchikDataGridViewTextBoxColumn
            // 
            this.zakazchikDataGridViewTextBoxColumn.DataPropertyName = "Zakazchik";
            this.zakazchikDataGridViewTextBoxColumn.HeaderText = "Заказчик";
            this.zakazchikDataGridViewTextBoxColumn.Name = "zakazchikDataGridViewTextBoxColumn";
            this.zakazchikDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Visible = false;
            // 
            // OrderNumber
            // 
            this.OrderNumber.DataPropertyName = "OrderNumber";
            this.OrderNumber.HeaderText = "№ заказа";
            this.OrderNumber.Name = "OrderNumber";
            this.OrderNumber.ReadOnly = true;
            // 
            // cmsTrebovaniaDgv
            // 
            this.cmsTrebovaniaDgv.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miOpenTrebovanie,
            this.добавитьТребованияToolStripMenuItem,
            this.создатьПустоеТребованиеToolStripMenuItem,
            this.actDelTrebovanie});
            this.cmsTrebovaniaDgv.Name = "cmsTrebovaniaDgv";
            this.cmsTrebovaniaDgv.Size = new System.Drawing.Size(225, 92);
            // 
            // miOpenTrebovanie
            // 
            this.miOpenTrebovanie.Name = "miOpenTrebovanie";
            this.miOpenTrebovanie.Size = new System.Drawing.Size(224, 22);
            this.miOpenTrebovanie.Text = "Открыть...";
            // 
            // добавитьТребованияToolStripMenuItem
            // 
            this.добавитьТребованияToolStripMenuItem.Name = "добавитьТребованияToolStripMenuItem";
            this.добавитьТребованияToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.добавитьТребованияToolStripMenuItem.Text = "Добавить требования";
            this.добавитьТребованияToolStripMenuItem.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // создатьПустоеТребованиеToolStripMenuItem
            // 
            this.создатьПустоеТребованиеToolStripMenuItem.Name = "создатьПустоеТребованиеToolStripMenuItem";
            this.создатьПустоеТребованиеToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.создатьПустоеТребованиеToolStripMenuItem.Text = "Создать пустое требование";
            // 
            // actDelTrebovanie
            // 
            this.actDelTrebovanie.Name = "actDelTrebovanie";
            this.actDelTrebovanie.Size = new System.Drawing.Size(224, 22);
            this.actDelTrebovanie.Text = "Удалить требование...";
            this.actDelTrebovanie.Click += new System.EventHandler(this.actDelTrebovanie_Click);
            // 
            // bsTrebovania
            // 
            this.bsTrebovania.DataMember = "TrebovaniaView";
            this.bsTrebovania.DataSource = this.dataDataSet;
            // 
            // bnTrebovania
            // 
            this.bnTrebovania.AddNewItem = null;
            this.bnTrebovania.BindingSource = this.bsTrebovania;
            this.bnTrebovania.CountItem = this.bindingNavigatorCountItem1;
            this.bnTrebovania.DeleteItem = null;
            this.bnTrebovania.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.btnAdd});
            this.bnTrebovania.Location = new System.Drawing.Point(3, 3);
            this.bnTrebovania.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bnTrebovania.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bnTrebovania.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bnTrebovania.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bnTrebovania.Name = "bnTrebovania";
            this.bnTrebovania.PositionItem = this.bindingNavigatorPositionItem1;
            this.bnTrebovania.Size = new System.Drawing.Size(836, 25);
            this.bnTrebovania.TabIndex = 4;
            this.bnTrebovania.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem1.Text = "of {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "Move previous";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Position";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "Move last";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 22);
            this.btnAdd.Text = "Добавить требования";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // taEmployee
            // 
            this.taEmployee.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.TrebovanieDetailsTableAdapter = null;
            this.tableAdapterManager.TrebovanieTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Texac.dataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ВидыПрофессиийTableAdapter = null;
            this.tableAdapterManager.РаботникиЦехаTableAdapter = null;
            // 
            // taTrebovania
            // 
            this.taTrebovania.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 546);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ssStatusStrip);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Name = "MainForm";
            this.Text = "Техас";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmploeyes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnEmployee)).EndInit();
            this.bnEmployee.ResumeLayout(false);
            this.bnEmployee.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrebovania)).EndInit();
            this.cmsTrebovaniaDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsTrebovania)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnTrebovania)).EndInit();
            this.bnTrebovania.ResumeLayout(false);
            this.bnTrebovania.PerformLayout();
            ((System.Configuration.IPersistComponentSettings)(this)).LoadComponentSettings();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ssStatusStrip;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem miFile;
        private System.Windows.Forms.ToolStripMenuItem miOperation;
        private System.Windows.Forms.ToolStripMenuItem заказыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miDictionary;
        private System.Windows.Forms.ToolStripMenuItem работникиЦехаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem единицыИзмеренияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miHelp;
        private System.Windows.Forms.ToolStripMenuItem miAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private dataDataSet dataDataSet;
        private System.Windows.Forms.BindingSource bsEmployee;
        private dataDataSetTableAdapters.РаботникиViewTableAdapter taEmployee;
        private dataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvEmploeyes;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.BindingNavigator bnEmployee;
        private System.Windows.Forms.ToolStripComboBox cbEmployee;
        private System.Windows.Forms.ToolStripMenuItem miDocs;
        private System.Windows.Forms.ToolStripMenuItem miTrebovaniya;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miMaterialreport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Должность;
        private System.Windows.Forms.DataGridViewTextBoxColumn ФИО;
        private System.Windows.Forms.DataGridViewTextBoxColumn NТабельный;
        private System.Windows.Forms.DataGridViewTextBoxColumn nТабельныйDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn сокрНазваниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn работаетDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn подраздDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvTrebovania;
        private System.Windows.Forms.BindingSource bsTrebovania;
        private System.Windows.Forms.BindingNavigator bnTrebovania;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private dataDataSetTableAdapters.TrebovaniaViewTableAdapter taTrebovania;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zakazchikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scladDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trebovanieIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip cmsTrebovaniaDgv;
        private System.Windows.Forms.ToolStripMenuItem miOpenTrebovanie;
        private System.Windows.Forms.ToolStripMenuItem добавитьТребованияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьПустоеТребованиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actDelTrebovanie;
    }
}

