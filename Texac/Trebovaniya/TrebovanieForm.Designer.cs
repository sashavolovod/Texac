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
            System.Windows.Forms.Label docNumberLabel;
            System.Windows.Forms.Label docDateLabel;
            System.Windows.Forms.Label scladLabel;
            System.Windows.Forms.Label nЦехаLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.docNumberTextBox = new System.Windows.Forms.TextBox();
            this.bsTrebovanie = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new Texac.dataDataSet();
            this.docDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.scladTextBox = new System.Windows.Forms.TextBox();
            this.bsTrebovanieDetails = new System.Windows.Forms.BindingSource(this.components);
            this.dgvTrebovanieDetails = new System.Windows.Forms.DataGridView();
            this.colTrebovanieDetailId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrebovanielId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMatCartId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaterialCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKol1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKol2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.taTrebovanie = new Texac.dataDataSetTableAdapters.TrebovanieTableAdapter();
            this.tableAdapterManager = new Texac.dataDataSetTableAdapters.TableAdapterManager();
            this.taTrebovanieDetails = new Texac.dataDataSetTableAdapters.TrebovanieDetailsTableAdapter();
            this.taDepartmentsView = new Texac.dataDataSetTableAdapters.DepartmentsViewTableAdapter();
            docNumberLabel = new System.Windows.Forms.Label();
            docDateLabel = new System.Windows.Forms.Label();
            scladLabel = new System.Windows.Forms.Label();
            nЦехаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsTrebovanie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTrebovanieDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrebovanieDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // docNumberLabel
            // 
            docNumberLabel.AutoSize = true;
            docNumberLabel.Location = new System.Drawing.Point(12, 23);
            docNumberLabel.Name = "docNumberLabel";
            docNumberLabel.Size = new System.Drawing.Size(21, 13);
            docNumberLabel.TabIndex = 6;
            docNumberLabel.Text = "№:";
            // 
            // docDateLabel
            // 
            docDateLabel.AutoSize = true;
            docDateLabel.Location = new System.Drawing.Point(93, 23);
            docDateLabel.Name = "docDateLabel";
            docDateLabel.Size = new System.Drawing.Size(21, 13);
            docDateLabel.TabIndex = 7;
            docDateLabel.Text = "от:";
            // 
            // scladLabel
            // 
            scladLabel.AutoSize = true;
            scladLabel.Location = new System.Drawing.Point(293, 23);
            scladLabel.Name = "scladLabel";
            scladLabel.Size = new System.Drawing.Size(83, 13);
            scladLabel.TabIndex = 8;
            scladLabel.Text = "Номер склада:";
            // 
            // nЦехаLabel
            // 
            nЦехаLabel.AutoSize = true;
            nЦехаLabel.Location = new System.Drawing.Point(470, 23);
            nЦехаLabel.Name = "nЦехаLabel";
            nЦехаLabel.Size = new System.Drawing.Size(58, 13);
            nЦехаLabel.TabIndex = 9;
            nЦехаLabel.Text = "Заказчик:";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(784, 391);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 31);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(675, 391);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 31);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrint.Location = new System.Drawing.Point(12, 391);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(90, 31);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "Печать";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // docNumberTextBox
            // 
            this.docNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTrebovanie, "DocNumber", true));
            this.docNumberTextBox.Location = new System.Drawing.Point(39, 20);
            this.docNumberTextBox.Name = "docNumberTextBox";
            this.docNumberTextBox.Size = new System.Drawing.Size(48, 20);
            this.docNumberTextBox.TabIndex = 7;
            // 
            // bsTrebovanie
            // 
            this.bsTrebovanie.DataMember = "Trebovanie";
            this.bsTrebovanie.DataSource = this.ds;
            // 
            // ds
            // 
            this.ds.DataSetName = "dataDataSet";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // docDateDateTimePicker
            // 
            this.docDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsTrebovanie, "DocDate", true));
            this.docDateDateTimePicker.Location = new System.Drawing.Point(120, 20);
            this.docDateDateTimePicker.Name = "docDateDateTimePicker";
            this.docDateDateTimePicker.Size = new System.Drawing.Size(141, 20);
            this.docDateDateTimePicker.TabIndex = 8;
            // 
            // scladTextBox
            // 
            this.scladTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTrebovanie, "Sclad", true));
            this.scladTextBox.Location = new System.Drawing.Point(382, 20);
            this.scladTextBox.Name = "scladTextBox";
            this.scladTextBox.Size = new System.Drawing.Size(59, 20);
            this.scladTextBox.TabIndex = 9;
            // 
            // bsTrebovanieDetails
            // 
            this.bsTrebovanieDetails.DataMember = "tblTrebovanietblTrebovanieDetails";
            this.bsTrebovanieDetails.DataSource = this.bsTrebovanie;
            // 
            // dgvTrebovanieDetails
            // 
            this.dgvTrebovanieDetails.AllowUserToAddRows = false;
            this.dgvTrebovanieDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTrebovanieDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTrebovanieDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.colTrebovanieDetailId,
            this.colTrebovanielId,
            this.colMatCartId,
            this.colMaterialCode,
            this.colMaterial,
            this.colEd,
            this.colKol1,
            this.colKol2});
            this.dgvTrebovanieDetails.DataSource = this.bsTrebovanieDetails;
            this.dgvTrebovanieDetails.Location = new System.Drawing.Point(12, 58);
            this.dgvTrebovanieDetails.Name = "dgvTrebovanieDetails";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTrebovanieDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTrebovanieDetails.Size = new System.Drawing.Size(868, 313);
            this.dgvTrebovanieDetails.TabIndex = 11;
            // 
            // colTrebovanieDetailId
            // 
            this.colTrebovanieDetailId.DataPropertyName = "tblTrebovanieDetailId";
            this.colTrebovanieDetailId.HeaderText = "tblTrebovanieDetailId";
            this.colTrebovanieDetailId.Name = "colTrebovanieDetailId";
            this.colTrebovanieDetailId.Visible = false;
            this.colTrebovanieDetailId.Width = 60;
            // 
            // colTrebovanielId
            // 
            this.colTrebovanielId.DataPropertyName = "tblTrebovanielId";
            this.colTrebovanielId.HeaderText = "tblTrebovanielId";
            this.colTrebovanielId.Name = "colTrebovanielId";
            this.colTrebovanielId.Visible = false;
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
            // cbCustomer
            // 
            this.cbCustomer.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsTrebovanie, "NЦеха", true));
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(534, 20);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(266, 21);
            this.cbCustomer.TabIndex = 12;
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
            this.tableAdapterManager.UpdateOrder = Texac.dataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            // TrebovanieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 438);
            this.Controls.Add(this.cbCustomer);
            this.Controls.Add(this.dgvTrebovanieDetails);
            this.Controls.Add(nЦехаLabel);
            this.Controls.Add(scladLabel);
            this.Controls.Add(this.scladTextBox);
            this.Controls.Add(docDateLabel);
            this.Controls.Add(this.docDateDateTimePicker);
            this.Controls.Add(docNumberLabel);
            this.Controls.Add(this.docNumberTextBox);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "TrebovanieForm";
            this.Text = "Требование - ";
            this.Load += new System.EventHandler(this.TrebovanieForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsTrebovanie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTrebovanieDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrebovanieDetails)).EndInit();
            ((System.Configuration.IPersistComponentSettings)(this)).LoadComponentSettings();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.BindingSource bsTrebovanie;
        private dataDataSetTableAdapters.TrebovanieTableAdapter taTrebovanie;
        private dataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private dataDataSet ds;
        private System.Windows.Forms.TextBox docNumberTextBox;
        private System.Windows.Forms.DateTimePicker docDateDateTimePicker;
        private System.Windows.Forms.TextBox scladTextBox;
        private System.Windows.Forms.BindingSource bsTrebovanieDetails;
        private dataDataSetTableAdapters.TrebovanieDetailsTableAdapter taTrebovanieDetails;
        private System.Windows.Forms.DataGridView dgvTrebovanieDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKol2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKol1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaterialCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMatCartId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrebovanielId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrebovanieDetailId;
        private System.Windows.Forms.ComboBox cbCustomer;
        private dataDataSetTableAdapters.DepartmentsViewTableAdapter taDepartmentsView;
    }
}