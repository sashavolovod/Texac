namespace Texac.Ekon.Inventory
{
    partial class InventoryControl
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
            System.Windows.Forms.Label orderIdLabel;
            System.Windows.Forms.Label factReadyDateLabel;
            System.Windows.Forms.Label employeeLabel;
            System.Windows.Forms.Label obozToLabel;
            System.Windows.Forms.Label completedLabel;
            System.Windows.Forms.Label remainingQtyLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bnInventory = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbImportFromInventory = new System.Windows.Forms.ToolStripButton();
            this.tsbReport = new System.Windows.Forms.ToolStripButton();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.remainingQtyTextBox = new System.Windows.Forms.TextBox();
            this.completedTextBox = new System.Windows.Forms.TextBox();
            this.obozToTextBox = new System.Windows.Forms.TextBox();
            this.employeeTextBox = new System.Windows.Forms.TextBox();
            this.tbFactDateReady = new System.Windows.Forms.TextBox();
            this.orderIdTextBox = new System.Windows.Forms.TextBox();
            this.orderNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debitQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.normQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsInventory = new System.Windows.Forms.BindingSource(this.components);
            orderIdLabel = new System.Windows.Forms.Label();
            factReadyDateLabel = new System.Windows.Forms.Label();
            employeeLabel = new System.Windows.Forms.Label();
            obozToLabel = new System.Windows.Forms.Label();
            completedLabel = new System.Windows.Forms.Label();
            remainingQtyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bnInventory)).BeginInit();
            this.bnInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // orderIdLabel
            // 
            orderIdLabel.AutoSize = true;
            orderIdLabel.Location = new System.Drawing.Point(17, 21);
            orderIdLabel.Name = "orderIdLabel";
            orderIdLabel.Size = new System.Drawing.Size(91, 20);
            orderIdLabel.TabIndex = 0;
            orderIdLabel.Text = "NППЗаказа:";
            // 
            // factReadyDateLabel
            // 
            factReadyDateLabel.AutoSize = true;
            factReadyDateLabel.Location = new System.Drawing.Point(17, 234);
            factReadyDateLabel.Name = "factReadyDateLabel";
            factReadyDateLabel.Size = new System.Drawing.Size(181, 20);
            factReadyDateLabel.TabIndex = 2;
            factReadyDateLabel.Text = "Факт. дата изготовления:";
            // 
            // employeeLabel
            // 
            employeeLabel.AutoSize = true;
            employeeLabel.Location = new System.Drawing.Point(17, 163);
            employeeLabel.Name = "employeeLabel";
            employeeLabel.Size = new System.Drawing.Size(76, 20);
            employeeLabel.TabIndex = 4;
            employeeLabel.Text = "Технолог:";
            // 
            // obozToLabel
            // 
            obozToLabel.AutoSize = true;
            obozToLabel.Location = new System.Drawing.Point(17, 92);
            obozToLabel.Name = "obozToLabel";
            obozToLabel.Size = new System.Drawing.Size(130, 20);
            obozToLabel.TabIndex = 6;
            obozToLabel.Text = "Обозначение ТО:";
            // 
            // completedLabel
            // 
            completedLabel.AutoSize = true;
            completedLabel.Location = new System.Drawing.Point(17, 305);
            completedLabel.Name = "completedLabel";
            completedLabel.Size = new System.Drawing.Size(108, 20);
            completedLabel.TabIndex = 8;
            completedLabel.Text = "Выполнено, ч:";
            // 
            // remainingQtyLabel
            // 
            remainingQtyLabel.AutoSize = true;
            remainingQtyLabel.Location = new System.Drawing.Point(17, 376);
            remainingQtyLabel.Name = "remainingQtyLabel";
            remainingQtyLabel.Size = new System.Drawing.Size(101, 20);
            remainingQtyLabel.TabIndex = 10;
            remainingQtyLabel.Text = "Не сдано, шт:";
            // 
            // bnInventory
            // 
            this.bnInventory.AddNewItem = null;
            this.bnInventory.BindingSource = this.bsInventory;
            this.bnInventory.CountItem = this.bindingNavigatorCountItem;
            this.bnInventory.DeleteItem = null;
            this.bnInventory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.tsbImportFromInventory,
            this.tsbReport});
            this.bnInventory.Location = new System.Drawing.Point(0, 0);
            this.bnInventory.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnInventory.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnInventory.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnInventory.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnInventory.Name = "bnInventory";
            this.bnInventory.PositionItem = this.bindingNavigatorPositionItem;
            this.bnInventory.Size = new System.Drawing.Size(1275, 25);
            this.bnInventory.TabIndex = 0;
            this.bnInventory.Text = "bindingNavigator1";
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
            // tsbImportFromInventory
            // 
            this.tsbImportFromInventory.Image = ((System.Drawing.Image)(resources.GetObject("tsbImportFromInventory.Image")));
            this.tsbImportFromInventory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbImportFromInventory.Name = "tsbImportFromInventory";
            this.tsbImportFromInventory.Size = new System.Drawing.Size(81, 22);
            this.tsbImportFromInventory.Text = "Загрузить";
            this.tsbImportFromInventory.ToolTipText = "Загрузить из оборотной ведомости";
            this.tsbImportFromInventory.Click += new System.EventHandler(this.tsbImportFromInventory_Click);
            // 
            // tsbReport
            // 
            this.tsbReport.Enabled = false;
            this.tsbReport.Image = ((System.Drawing.Image)(resources.GetObject("tsbReport.Image")));
            this.tsbReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReport.Name = "tsbReport";
            this.tsbReport.Size = new System.Drawing.Size(144, 22);
            this.tsbReport.Text = "Сформировать отчет";
            this.tsbReport.Click += new System.EventHandler(this.tsbReport_Click);
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvInventory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInventory.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderNumberDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.startQuantityDataGridViewTextBoxColumn,
            this.debitQuantityDataGridViewTextBoxColumn,
            this.normQuantityDataGridViewTextBoxColumn,
            this.creditQuantityDataGridViewTextBoxColumn,
            this.endQuantityDataGridViewTextBoxColumn});
            this.dgvInventory.DataSource = this.bsInventory;
            this.dgvInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInventory.Location = new System.Drawing.Point(0, 25);
            this.dgvInventory.Name = "dgvInventory";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventory.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvInventory.RowTemplate.Height = 28;
            this.dgvInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventory.Size = new System.Drawing.Size(1032, 542);
            this.dgvInventory.TabIndex = 1;
            this.dgvInventory.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvInventory_RowPrePaint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(remainingQtyLabel);
            this.panel1.Controls.Add(this.remainingQtyTextBox);
            this.panel1.Controls.Add(completedLabel);
            this.panel1.Controls.Add(this.completedTextBox);
            this.panel1.Controls.Add(obozToLabel);
            this.panel1.Controls.Add(this.obozToTextBox);
            this.panel1.Controls.Add(employeeLabel);
            this.panel1.Controls.Add(this.employeeTextBox);
            this.panel1.Controls.Add(this.tbFactDateReady);
            this.panel1.Controls.Add(factReadyDateLabel);
            this.panel1.Controls.Add(orderIdLabel);
            this.panel1.Controls.Add(this.orderIdTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1032, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 542);
            this.panel1.TabIndex = 2;
            // 
            // remainingQtyTextBox
            // 
            this.remainingQtyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInventory, "RemainingQty", true));
            this.remainingQtyTextBox.Location = new System.Drawing.Point(13, 399);
            this.remainingQtyTextBox.Name = "remainingQtyTextBox";
            this.remainingQtyTextBox.ReadOnly = true;
            this.remainingQtyTextBox.Size = new System.Drawing.Size(196, 27);
            this.remainingQtyTextBox.TabIndex = 11;
            // 
            // completedTextBox
            // 
            this.completedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInventory, "Completed", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "0.##"));
            this.completedTextBox.Location = new System.Drawing.Point(13, 328);
            this.completedTextBox.Name = "completedTextBox";
            this.completedTextBox.ReadOnly = true;
            this.completedTextBox.Size = new System.Drawing.Size(200, 27);
            this.completedTextBox.TabIndex = 9;
            // 
            // obozToTextBox
            // 
            this.obozToTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInventory, "ObozTo", true));
            this.obozToTextBox.Location = new System.Drawing.Point(13, 115);
            this.obozToTextBox.Name = "obozToTextBox";
            this.obozToTextBox.ReadOnly = true;
            this.obozToTextBox.Size = new System.Drawing.Size(204, 27);
            this.obozToTextBox.TabIndex = 2;
            // 
            // employeeTextBox
            // 
            this.employeeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInventory, "Employee", true));
            this.employeeTextBox.Location = new System.Drawing.Point(13, 186);
            this.employeeTextBox.Name = "employeeTextBox";
            this.employeeTextBox.ReadOnly = true;
            this.employeeTextBox.Size = new System.Drawing.Size(204, 27);
            this.employeeTextBox.TabIndex = 3;
            // 
            // tbFactDateReady
            // 
            this.tbFactDateReady.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInventory, "FactReadyDate", true));
            this.tbFactDateReady.Location = new System.Drawing.Point(17, 257);
            this.tbFactDateReady.Name = "tbFactDateReady";
            this.tbFactDateReady.ReadOnly = true;
            this.tbFactDateReady.Size = new System.Drawing.Size(204, 27);
            this.tbFactDateReady.TabIndex = 4;
            // 
            // orderIdTextBox
            // 
            this.orderIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInventory, "OrderId", true));
            this.orderIdTextBox.Location = new System.Drawing.Point(17, 44);
            this.orderIdTextBox.Name = "orderIdTextBox";
            this.orderIdTextBox.ReadOnly = true;
            this.orderIdTextBox.Size = new System.Drawing.Size(204, 27);
            this.orderIdTextBox.TabIndex = 1;
            // 
            // orderNumberDataGridViewTextBoxColumn
            // 
            this.orderNumberDataGridViewTextBoxColumn.DataPropertyName = "orderNumber";
            this.orderNumberDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.orderNumberDataGridViewTextBoxColumn.Name = "orderNumberDataGridViewTextBoxColumn";
            this.orderNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Код";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Наименование ТМЦ";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 300;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "Ед. изм.";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            this.unitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startQuantityDataGridViewTextBoxColumn
            // 
            this.startQuantityDataGridViewTextBoxColumn.DataPropertyName = "startQuantity";
            dataGridViewCellStyle3.Format = "#,0.###;-#,0.###;\'\'";
            dataGridViewCellStyle3.NullValue = null;
            this.startQuantityDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.startQuantityDataGridViewTextBoxColumn.HeaderText = "Остаток на начало периода";
            this.startQuantityDataGridViewTextBoxColumn.Name = "startQuantityDataGridViewTextBoxColumn";
            this.startQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.startQuantityDataGridViewTextBoxColumn.Width = 150;
            // 
            // debitQuantityDataGridViewTextBoxColumn
            // 
            this.debitQuantityDataGridViewTextBoxColumn.DataPropertyName = "debitQuantity";
            dataGridViewCellStyle4.Format = "#,0.###;-#,0.###;\'\'";
            dataGridViewCellStyle4.NullValue = null;
            this.debitQuantityDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.debitQuantityDataGridViewTextBoxColumn.HeaderText = "Приход";
            this.debitQuantityDataGridViewTextBoxColumn.Name = "debitQuantityDataGridViewTextBoxColumn";
            this.debitQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // normQuantityDataGridViewTextBoxColumn
            // 
            this.normQuantityDataGridViewTextBoxColumn.DataPropertyName = "normQuantity";
            dataGridViewCellStyle5.Format = "#,0.##;-#,0.##;\'\'";
            dataGridViewCellStyle5.NullValue = null;
            this.normQuantityDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.normQuantityDataGridViewTextBoxColumn.HeaderText = "Расход по норме";
            this.normQuantityDataGridViewTextBoxColumn.Name = "normQuantityDataGridViewTextBoxColumn";
            this.normQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.normQuantityDataGridViewTextBoxColumn.Width = 150;
            // 
            // creditQuantityDataGridViewTextBoxColumn
            // 
            this.creditQuantityDataGridViewTextBoxColumn.DataPropertyName = "creditQuantity";
            dataGridViewCellStyle6.Format = "#,0.###;-#,0.###;\'\'";
            dataGridViewCellStyle6.NullValue = null;
            this.creditQuantityDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.creditQuantityDataGridViewTextBoxColumn.HeaderText = "Расход";
            this.creditQuantityDataGridViewTextBoxColumn.Name = "creditQuantityDataGridViewTextBoxColumn";
            this.creditQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endQuantityDataGridViewTextBoxColumn
            // 
            this.endQuantityDataGridViewTextBoxColumn.DataPropertyName = "endQuantity";
            dataGridViewCellStyle7.Format = "#,0.###;-#,0.###;\'\'";
            dataGridViewCellStyle7.NullValue = null;
            this.endQuantityDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.endQuantityDataGridViewTextBoxColumn.HeaderText = "Остаток на конец периода";
            this.endQuantityDataGridViewTextBoxColumn.Name = "endQuantityDataGridViewTextBoxColumn";
            this.endQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.endQuantityDataGridViewTextBoxColumn.Width = 150;
            // 
            // bsInventory
            // 
            this.bsInventory.DataSource = typeof(Texac.Ekon.Inventory.InventoryEntry);
            // 
            // InventoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bnInventory);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "InventoryControl";
            this.Size = new System.Drawing.Size(1275, 567);
            ((System.ComponentModel.ISupportInitialize)(this.bnInventory)).EndInit();
            this.bnInventory.ResumeLayout(false);
            this.bnInventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsInventory;
        private System.Windows.Forms.BindingNavigator bnInventory;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.ToolStripButton tsbImportFromInventory;
        private System.Windows.Forms.ToolStripButton tsbReport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox orderIdTextBox;
        private System.Windows.Forms.TextBox tbFactDateReady;
        private System.Windows.Forms.TextBox obozToTextBox;
        private System.Windows.Forms.TextBox employeeTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.TextBox remainingQtyTextBox;
        private System.Windows.Forms.TextBox completedTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn debitQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn normQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endQuantityDataGridViewTextBoxColumn;
    }
}
