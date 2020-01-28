namespace Texac.Trebovaniya
{
    partial class TrebovanieList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrebovanieList));
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
            this.dataDataSet = new Texac.dataDataSet();
            this.taTrebovania = new Texac.dataDataSetTableAdapters.TrebovaniaViewTableAdapter();
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
            this.tsbAddEmpty = new System.Windows.Forms.ToolStripButton();
            this.tableAdapterManager = new Texac.dataDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrebovania)).BeginInit();
            this.cmsTrebovaniaDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsTrebovania)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnTrebovania)).BeginInit();
            this.bnTrebovania.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTrebovania
            // 
            this.dgvTrebovania.AllowUserToAddRows = false;
            this.dgvTrebovania.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTrebovania.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTrebovania.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTrebovania.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            this.dgvTrebovania.Location = new System.Drawing.Point(0, 25);
            this.dgvTrebovania.Name = "dgvTrebovania";
            this.dgvTrebovania.ReadOnly = true;
            this.dgvTrebovania.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTrebovania.Size = new System.Drawing.Size(897, 456);
            this.dgvTrebovania.TabIndex = 7;
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
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.docDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
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
            this.miOpenTrebovanie.Click += new System.EventHandler(this.miOpenTrebovanie_Click);
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
            // dataDataSet
            // 
            this.dataDataSet.DataSetName = "dataDataSet";
            this.dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taTrebovania
            // 
            this.taTrebovania.ClearBeforeFill = true;
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
            this.btnAdd,
            this.tsbAddEmpty});
            this.bnTrebovania.Location = new System.Drawing.Point(0, 0);
            this.bnTrebovania.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bnTrebovania.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bnTrebovania.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bnTrebovania.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bnTrebovania.Name = "bnTrebovania";
            this.bnTrebovania.PositionItem = this.bindingNavigatorPositionItem1;
            this.bnTrebovania.Size = new System.Drawing.Size(897, 25);
            this.bnTrebovania.TabIndex = 6;
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
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(178, 22);
            this.btnAdd.Text = "Сформировать требования";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tsbAddEmpty
            // 
            this.tsbAddEmpty.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddEmpty.Image")));
            this.tsbAddEmpty.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddEmpty.Name = "tsbAddEmpty";
            this.tsbAddEmpty.Size = new System.Drawing.Size(186, 22);
            this.tsbAddEmpty.Text = "Добавить пустое требование";
            this.tsbAddEmpty.Click += new System.EventHandler(this.tsbAddEmpty_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.MaterialReportDetailsTableAdapter = null;
            this.tableAdapterManager.TrebovanieDetailsTableAdapter = null;
            this.tableAdapterManager.TrebovanieTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Texac.dataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ВидыПрофессиийTableAdapter = null;
            this.tableAdapterManager.РаботникиЦехаTableAdapter = null;
            // 
            // TrebovanieList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvTrebovania);
            this.Controls.Add(this.bnTrebovania);
            this.Name = "TrebovanieList";
            this.Size = new System.Drawing.Size(897, 481);
            this.Load += new System.EventHandler(this.TrebovanieList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrebovania)).EndInit();
            this.cmsTrebovaniaDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsTrebovania)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnTrebovania)).EndInit();
            this.bnTrebovania.ResumeLayout(false);
            this.bnTrebovania.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn trebovanieIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scladDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zakazchikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip cmsTrebovaniaDgv;
        private System.Windows.Forms.ToolStripMenuItem miOpenTrebovanie;
        private System.Windows.Forms.ToolStripMenuItem добавитьТребованияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьПустоеТребованиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actDelTrebovanie;
        private System.Windows.Forms.BindingSource bsTrebovania;
        private dataDataSet dataDataSet;
        private dataDataSetTableAdapters.TrebovaniaViewTableAdapter taTrebovania;
        private dataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.BindingNavigator bnTrebovania;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderNumber;
        private System.Windows.Forms.DataGridView dgvTrebovania;
        private System.Windows.Forms.ToolStripButton tsbAddEmpty;
    }
}
