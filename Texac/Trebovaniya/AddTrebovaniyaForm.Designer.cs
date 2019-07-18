namespace Texac.Trebovaniya
{
    partial class AddTrebovaniyaForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvTrebovaniya = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMatCartId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ASUPCODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsTrebovaniyaView = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new Texac.dataDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.dtpTrebovanieDate = new System.Windows.Forms.DateTimePicker();
            this.tbTrebovanieNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOrderGroup = new System.Windows.Forms.Button();
            this.btnOneOrder = new System.Windows.Forms.Button();
            this.taTrebovaniyaView = new Texac.dataDataSetTableAdapters.AddTrebovaniyaViewTableAdapter();
            this.tam = new Texac.dataDataSetTableAdapters.TableAdapterManager();
            this.taTrebovanieDetails = new Texac.dataDataSetTableAdapters.TrebovanieDetailsTableAdapter();
            this.taTrebovanie = new Texac.dataDataSetTableAdapters.TrebovanieTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrebovaniya)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTrebovaniyaView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTrebovaniya
            // 
            this.dgvTrebovaniya.AllowUserToAddRows = false;
            this.dgvTrebovaniya.AllowUserToDeleteRows = false;
            this.dgvTrebovaniya.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTrebovaniya.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTrebovaniya.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTrebovaniya.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTrebovaniya.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrebovaniya.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.colMatCartId,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.colMaterial,
            this.ASUPCODE,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dgvTrebovaniya.DataSource = this.bsTrebovaniyaView;
            this.dgvTrebovaniya.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTrebovaniya.Location = new System.Drawing.Point(0, 62);
            this.dgvTrebovaniya.Name = "dgvTrebovaniya";
            this.dgvTrebovaniya.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTrebovaniya.Size = new System.Drawing.Size(818, 496);
            this.dgvTrebovaniya.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Sclad";
            this.dataGridViewTextBoxColumn7.HeaderText = "Склад";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn7.Width = 50;
            // 
            // colMatCartId
            // 
            this.colMatCartId.DataPropertyName = "MatCartId";
            this.colMatCartId.HeaderText = "MatCartId";
            this.colMatCartId.Name = "colMatCartId";
            this.colMatCartId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colMatCartId.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "OrderId";
            this.dataGridViewTextBoxColumn2.HeaderText = "OrderId";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MaterialCode";
            this.dataGridViewTextBoxColumn3.HeaderText = "MaterialCode";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // colMaterial
            // 
            this.colMaterial.DataPropertyName = "MaterialName";
            this.colMaterial.HeaderText = "Наименование материала";
            this.colMaterial.Name = "colMaterial";
            this.colMaterial.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colMaterial.Width = 250;
            // 
            // ASUPCODE
            // 
            this.ASUPCODE.DataPropertyName = "ASUPCODE";
            this.ASUPCODE.HeaderText = "Номер карточки";
            this.ASUPCODE.Name = "ASUPCODE";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Qty";
            this.dataGridViewTextBoxColumn5.HeaderText = "Кол-во";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Ed";
            this.dataGridViewTextBoxColumn6.HeaderText = "Ед. изм.";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "DateTP";
            this.dataGridViewTextBoxColumn8.HeaderText = "Дата ТП";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "OrderType";
            this.dataGridViewTextBoxColumn9.HeaderText = "Номер заказа";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // bsTrebovaniyaView
            // 
            this.bsTrebovaniyaView.DataMember = "AddTrebovaniyaView";
            this.bsTrebovaniyaView.DataSource = this.ds;
            // 
            // ds
            // 
            this.ds.DataSetName = "dataDataSet";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Controls.Add(this.dtpTrebovanieDate);
            this.panel1.Controls.Add(this.tbTrebovanieNumber);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnOrderGroup);
            this.panel1.Controls.Add(this.btnOneOrder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 62);
            this.panel1.TabIndex = 11;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(683, 19);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(123, 27);
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "Сформировать";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // dtpTrebovanieDate
            // 
            this.dtpTrebovanieDate.Location = new System.Drawing.Point(499, 24);
            this.dtpTrebovanieDate.Name = "dtpTrebovanieDate";
            this.dtpTrebovanieDate.Size = new System.Drawing.Size(151, 20);
            this.dtpTrebovanieDate.TabIndex = 10;
            // 
            // tbTrebovanieNumber
            // 
            this.tbTrebovanieNumber.Location = new System.Drawing.Point(381, 24);
            this.tbTrebovanieNumber.Name = "tbTrebovanieNumber";
            this.tbTrebovanieNumber.Size = new System.Drawing.Size(45, 20);
            this.tbTrebovanieNumber.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(457, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Дата:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Номер требования с ";
            // 
            // btnOrderGroup
            // 
            this.btnOrderGroup.Location = new System.Drawing.Point(123, 19);
            this.btnOrderGroup.Name = "btnOrderGroup";
            this.btnOrderGroup.Size = new System.Drawing.Size(115, 28);
            this.btnOrderGroup.TabIndex = 6;
            this.btnOrderGroup.Text = "Группа заказов";
            this.btnOrderGroup.UseVisualStyleBackColor = true;
            this.btnOrderGroup.Click += new System.EventHandler(this.btnOrderGroup_Click);
            // 
            // btnOneOrder
            // 
            this.btnOneOrder.Location = new System.Drawing.Point(15, 19);
            this.btnOneOrder.Name = "btnOneOrder";
            this.btnOneOrder.Size = new System.Drawing.Size(92, 28);
            this.btnOneOrder.TabIndex = 5;
            this.btnOneOrder.Text = "Один заказ";
            this.btnOneOrder.UseVisualStyleBackColor = true;
            this.btnOneOrder.Click += new System.EventHandler(this.btnOneOrder_Click);
            // 
            // taTrebovaniyaView
            // 
            this.taTrebovaniyaView.ClearBeforeFill = true;
            // 
            // tam
            // 
            this.tam.BackupDataSetBeforeUpdate = false;
            this.tam.MaterialReportDetailsTableAdapter = null;
            this.tam.TrebovanieDetailsTableAdapter = this.taTrebovanieDetails;
            this.tam.TrebovanieTableAdapter = this.taTrebovanie;
            this.tam.UpdateOrder = Texac.dataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tam.ВидыПрофессиийTableAdapter = null;
            this.tam.РаботникиЦехаTableAdapter = null;
            // 
            // taTrebovanieDetails
            // 
            this.taTrebovanieDetails.ClearBeforeFill = true;
            // 
            // taTrebovanie
            // 
            this.taTrebovanie.ClearBeforeFill = true;
            // 
            // AddTrebovaniyaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 558);
            this.Controls.Add(this.dgvTrebovaniya);
            this.Controls.Add(this.panel1);
            this.Name = "AddTrebovaniyaForm";
            this.Text = "Требование";
            this.Load += new System.EventHandler(this.AddTrebovaniyaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrebovaniya)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTrebovaniyaView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.Configuration.IPersistComponentSettings)(this)).LoadComponentSettings();
            this.ResumeLayout(false);

        }

        #endregion
        private dataDataSet ds;
        private System.Windows.Forms.BindingSource bsTrebovaniyaView;
        private dataDataSetTableAdapters.AddTrebovaniyaViewTableAdapter taTrebovaniyaView;
        private System.Windows.Forms.DataGridView dgvTrebovaniya;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOneOrder;
        private System.Windows.Forms.Button btnOrderGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTrebovanieNumber;
        private System.Windows.Forms.DateTimePicker dtpTrebovanieDate;
        private System.Windows.Forms.Button btnCreate;
        private dataDataSetTableAdapters.TableAdapterManager tam;
        private dataDataSetTableAdapters.TrebovanieDetailsTableAdapter taTrebovanieDetails;
        private dataDataSetTableAdapters.TrebovanieTableAdapter taTrebovanie;
        private System.Windows.Forms.DataGridViewTextBoxColumn ASUPCODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMatCartId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}