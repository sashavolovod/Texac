namespace Texac
{
    partial class TrebovanieForm
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
            System.Windows.Forms.Label nЦехаLabel;
            System.Windows.Forms.Label scladLabel;
            System.Windows.Forms.Label docDateLabel;
            System.Windows.Forms.Label docNumberLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrebovanieForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bsTrebovanie = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new Texac.dataDataSet1();
            this.bsTrebovanieDetails = new System.Windows.Forms.BindingSource(this.components);
            this.taTrebovanie = new Texac.dataDataSet1TableAdapters.TrebovanieTableAdapter();
            this.tableAdapterManager = new Texac.dataDataSet1TableAdapters.TableAdapterManager();
            this.taTrebovanieDetails = new Texac.dataDataSet1TableAdapters.TrebovanieDetailsTableAdapter();
            this.taDepartmentsView = new Texac.dataDataSet1TableAdapters.DepartmentsViewTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbPoluchil = new System.Windows.Forms.TextBox();
            this.tbZatreboval = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.scladTextBox = new System.Windows.Forms.TextBox();
            this.dtpDocDate = new System.Windows.Forms.DateTimePicker();
            this.tbTrebovanieNumber = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvTrebovanieDetails = new System.Windows.Forms.DataGridView();
            this.colMatCartId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaterialCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ASUPCODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKol1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKol2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bnTrebovanieDetails = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCheck = new System.Windows.Forms.ToolStripButton();
            this.trebovaniaViewTableAdapter1 = new Texac.dataDataSet1TableAdapters.TrebovaniaViewTableAdapter();
            nЦехаLabel = new System.Windows.Forms.Label();
            scladLabel = new System.Windows.Forms.Label();
            docDateLabel = new System.Windows.Forms.Label();
            docNumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsTrebovanie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTrebovanieDetails)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrebovanieDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnTrebovanieDetails)).BeginInit();
            this.bnTrebovanieDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // nЦехаLabel
            // 
            nЦехаLabel.AutoSize = true;
            nЦехаLabel.Location = new System.Drawing.Point(478, 13);
            nЦехаLabel.Name = "nЦехаLabel";
            nЦехаLabel.Size = new System.Drawing.Size(58, 13);
            nЦехаLabel.TabIndex = 18;
            nЦехаLabel.Text = "Заказчик:";
            // 
            // scladLabel
            // 
            scladLabel.AutoSize = true;
            scladLabel.Location = new System.Drawing.Point(301, 13);
            scladLabel.Name = "scladLabel";
            scladLabel.Size = new System.Drawing.Size(83, 13);
            scladLabel.TabIndex = 16;
            scladLabel.Text = "Номер склада:";
            // 
            // docDateLabel
            // 
            docDateLabel.AutoSize = true;
            docDateLabel.Location = new System.Drawing.Point(101, 13);
            docDateLabel.Name = "docDateLabel";
            docDateLabel.Size = new System.Drawing.Size(21, 13);
            docDateLabel.TabIndex = 14;
            docDateLabel.Text = "от:";
            // 
            // docNumberLabel
            // 
            docNumberLabel.AutoSize = true;
            docNumberLabel.Location = new System.Drawing.Point(20, 13);
            docNumberLabel.Name = "docNumberLabel";
            docNumberLabel.Size = new System.Drawing.Size(21, 13);
            docNumberLabel.TabIndex = 13;
            docNumberLabel.Text = "№:";
            // 
            // bsTrebovanie
            // 
            this.bsTrebovanie.DataMember = "Trebovanie";
            this.bsTrebovanie.DataSource = this.ds;
            // 
            // ds
            // 
            this.ds.DataSetName = "dataDataSet1";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsTrebovanieDetails
            // 
            this.bsTrebovanieDetails.DataMember = "tblTrebovanietblTrebovanieDetails";
            this.bsTrebovanieDetails.DataSource = this.bsTrebovanie;
            // 
            // taTrebovanie
            // 
            this.taTrebovanie.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TrebovanieDetailsTableAdapter = this.taTrebovanieDetails;
            this.tableAdapterManager.TrebovanieTableAdapter = this.taTrebovanie;
            this.tableAdapterManager.UpdateOrder = Texac.dataDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ВидыПрофессиийTableAdapter = null;
            this.tableAdapterManager.РаботникиЦехаTableAdapter = null;
            // 
            // taTrebovanieDetails
            // 
            this.taTrebovanieDetails.ClearBeforeFill = true;
            // 
            // taDepartmentsView
            // 
            this.taDepartmentsView.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbPoluchil);
            this.panel1.Controls.Add(this.tbZatreboval);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbCustomer);
            this.panel1.Controls.Add(nЦехаLabel);
            this.panel1.Controls.Add(scladLabel);
            this.panel1.Controls.Add(this.scladTextBox);
            this.panel1.Controls.Add(docDateLabel);
            this.panel1.Controls.Add(this.dtpDocDate);
            this.panel1.Controls.Add(docNumberLabel);
            this.panel1.Controls.Add(this.tbTrebovanieNumber);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 80);
            this.panel1.TabIndex = 13;
            // 
            // tbPoluchil
            // 
            this.tbPoluchil.Location = new System.Drawing.Point(347, 50);
            this.tbPoluchil.Name = "tbPoluchil";
            this.tbPoluchil.Size = new System.Drawing.Size(177, 20);
            this.tbPoluchil.TabIndex = 22;
            // 
            // tbZatreboval
            // 
            this.tbZatreboval.Location = new System.Drawing.Point(92, 50);
            this.tbZatreboval.Name = "tbZatreboval";
            this.tbZatreboval.Size = new System.Drawing.Size(177, 20);
            this.tbZatreboval.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Получил:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Затребовал:";
            // 
            // cbCustomer
            // 
            this.cbCustomer.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsTrebovanie, "NЦеха", true));
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(542, 10);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(201, 21);
            this.cbCustomer.TabIndex = 20;
            // 
            // scladTextBox
            // 
            this.scladTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTrebovanie, "Sclad", true));
            this.scladTextBox.Location = new System.Drawing.Point(390, 10);
            this.scladTextBox.Name = "scladTextBox";
            this.scladTextBox.Size = new System.Drawing.Size(59, 20);
            this.scladTextBox.TabIndex = 19;
            // 
            // dtpDocDate
            // 
            this.dtpDocDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsTrebovanie, "DocDate", true));
            this.dtpDocDate.Location = new System.Drawing.Point(128, 10);
            this.dtpDocDate.Name = "dtpDocDate";
            this.dtpDocDate.Size = new System.Drawing.Size(141, 20);
            this.dtpDocDate.TabIndex = 17;
            // 
            // tbTrebovanieNumber
            // 
            this.tbTrebovanieNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTrebovanie, "DocNumber", true));
            this.tbTrebovanieNumber.Location = new System.Drawing.Point(47, 10);
            this.tbTrebovanieNumber.Name = "tbTrebovanieNumber";
            this.tbTrebovanieNumber.Size = new System.Drawing.Size(48, 20);
            this.tbTrebovanieNumber.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnPrint);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 384);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(881, 56);
            this.panel2.TabIndex = 14;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(619, 13);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCancel.Size = new System.Drawing.Size(111, 31);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(739, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSave.Size = new System.Drawing.Size(130, 31);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(12, 13);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPrint.Size = new System.Drawing.Size(114, 31);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Печать";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvTrebovanieDetails);
            this.panel3.Controls.Add(this.bnTrebovanieDetails);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(881, 304);
            this.panel3.TabIndex = 15;
            // 
            // dgvTrebovanieDetails
            // 
            this.dgvTrebovanieDetails.AllowUserToAddRows = false;
            this.dgvTrebovanieDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTrebovanieDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTrebovanieDetails.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTrebovanieDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTrebovanieDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrebovanieDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMatCartId,
            this.colMaterialCode,
            this.ASUPCODE,
            this.colMaterial,
            this.colEd,
            this.colKol1,
            this.colKol2});
            this.dgvTrebovanieDetails.DataSource = this.bsTrebovanieDetails;
            this.dgvTrebovanieDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTrebovanieDetails.Location = new System.Drawing.Point(0, 25);
            this.dgvTrebovanieDetails.Name = "dgvTrebovanieDetails";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTrebovanieDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTrebovanieDetails.Size = new System.Drawing.Size(881, 279);
            this.dgvTrebovanieDetails.TabIndex = 12;
            this.dgvTrebovanieDetails.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvTrebovanieDetails_EditingControlShowing);
            // 
            // colMatCartId
            // 
            this.colMatCartId.DataPropertyName = "MatCartId";
            this.colMatCartId.HeaderText = "MatCartId";
            this.colMatCartId.Name = "colMatCartId";
            this.colMatCartId.Visible = false;
            // 
            // colMaterialCode
            // 
            this.colMaterialCode.DataPropertyName = "MaterialCode";
            this.colMaterialCode.HeaderText = "Код материала";
            this.colMaterialCode.Name = "colMaterialCode";
            this.colMaterialCode.Width = 75;
            // 
            // ASUPCODE
            // 
            this.ASUPCODE.DataPropertyName = "ASUPCODE";
            this.ASUPCODE.HeaderText = "Номер карточки";
            this.ASUPCODE.Name = "ASUPCODE";
            // 
            // colMaterial
            // 
            this.colMaterial.DataPropertyName = "Material";
            this.colMaterial.HeaderText = "Наименование материала";
            this.colMaterial.Name = "colMaterial";
            this.colMaterial.Width = 400;
            // 
            // colEd
            // 
            this.colEd.DataPropertyName = "Ed";
            this.colEd.HeaderText = "Ед. изм.";
            this.colEd.Name = "colEd";
            this.colEd.Width = 35;
            // 
            // colKol1
            // 
            this.colKol1.DataPropertyName = "Kol1";
            this.colKol1.HeaderText = "Затребовано";
            this.colKol1.Name = "colKol1";
            // 
            // colKol2
            // 
            this.colKol2.DataPropertyName = "Kol2";
            this.colKol2.HeaderText = "Получено";
            this.colKol2.Name = "colKol2";
            // 
            // bnTrebovanieDetails
            // 
            this.bnTrebovanieDetails.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bnTrebovanieDetails.BindingSource = this.bsTrebovanieDetails;
            this.bnTrebovanieDetails.CountItem = this.bindingNavigatorCountItem;
            this.bnTrebovanieDetails.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bnTrebovanieDetails.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tsbCheck});
            this.bnTrebovanieDetails.Location = new System.Drawing.Point(0, 0);
            this.bnTrebovanieDetails.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnTrebovanieDetails.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnTrebovanieDetails.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnTrebovanieDetails.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnTrebovanieDetails.Name = "bnTrebovanieDetails";
            this.bnTrebovanieDetails.PositionItem = this.bindingNavigatorPositionItem;
            this.bnTrebovanieDetails.Size = new System.Drawing.Size(881, 25);
            this.bnTrebovanieDetails.TabIndex = 13;
            this.bnTrebovanieDetails.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            // tsbCheck
            // 
            this.tsbCheck.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbCheck.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCheck.Image = ((System.Drawing.Image)(resources.GetObject("tsbCheck.Image")));
            this.tsbCheck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCheck.Name = "tsbCheck";
            this.tsbCheck.Size = new System.Drawing.Size(23, 22);
            this.tsbCheck.Text = "toolStripButton1";
            this.tsbCheck.ToolTipText = "Ввести полученные материалы";
            this.tsbCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // trebovaniaViewTableAdapter1
            // 
            this.trebovaniaViewTableAdapter1.ClearBeforeFill = true;
            // 
            // TrebovanieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 440);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TrebovanieForm";
            this.Text = "Требование - ";
            this.Load += new System.EventHandler(this.TrebovanieForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsTrebovanie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTrebovanieDetails)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrebovanieDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnTrebovanieDetails)).EndInit();
            this.bnTrebovanieDetails.ResumeLayout(false);
            this.bnTrebovanieDetails.PerformLayout();
            ((System.Configuration.IPersistComponentSettings)(this)).LoadComponentSettings();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bsTrebovanie;
        private dataDataSet1TableAdapters.TrebovanieTableAdapter taTrebovanie;
        private dataDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private dataDataSet1 ds;
        private System.Windows.Forms.BindingSource bsTrebovanieDetails;
        private dataDataSet1TableAdapters.TrebovanieDetailsTableAdapter taTrebovanieDetails;
        private dataDataSet1TableAdapters.DepartmentsViewTableAdapter taDepartmentsView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.TextBox scladTextBox;
        private System.Windows.Forms.DateTimePicker dtpDocDate;
        private System.Windows.Forms.TextBox tbTrebovanieNumber;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvTrebovanieDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrebovanieDetailId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrebovanielId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMatCartId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaterialCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ASUPCODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKol1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKol2;
        private System.Windows.Forms.BindingNavigator bnTrebovanieDetails;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox tbPoluchil;
        private System.Windows.Forms.TextBox tbZatreboval;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton tsbCheck;
        private dataDataSet1TableAdapters.TrebovaniaViewTableAdapter trebovaniaViewTableAdapter1;
    }
}