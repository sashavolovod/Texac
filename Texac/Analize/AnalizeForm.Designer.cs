namespace Texac.Analize
{
    partial class AnalizeForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnFindOrderNumbers = new System.Windows.Forms.Button();
            this.tbNaimTO = new System.Windows.Forms.TextBox();
            this.tbOrderNumbers = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.equpmentByTOEntityDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsEqupmentByTO = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equpmentByTOEntityDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEqupmentByTO)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCalc);
            this.panel1.Controls.Add(this.btnFindOrderNumbers);
            this.panel1.Controls.Add(this.tbNaimTO);
            this.panel1.Controls.Add(this.tbOrderNumbers);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 183);
            this.panel1.TabIndex = 0;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(20, 127);
            this.btnCalc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(158, 38);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "Рассчитать";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnFindOrderNumbers
            // 
            this.btnFindOrderNumbers.Location = new System.Drawing.Point(616, 17);
            this.btnFindOrderNumbers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFindOrderNumbers.Name = "btnFindOrderNumbers";
            this.btnFindOrderNumbers.Size = new System.Drawing.Size(227, 38);
            this.btnFindOrderNumbers.TabIndex = 2;
            this.btnFindOrderNumbers.Text = "Найти номера заказов";
            this.btnFindOrderNumbers.UseVisualStyleBackColor = true;
            this.btnFindOrderNumbers.Click += new System.EventHandler(this.btnFindOrderNumbers_Click);
            // 
            // tbNaimTO
            // 
            this.tbNaimTO.Location = new System.Drawing.Point(164, 23);
            this.tbNaimTO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNaimTO.Name = "tbNaimTO";
            this.tbNaimTO.Size = new System.Drawing.Size(423, 27);
            this.tbNaimTO.TabIndex = 1;
            this.tbNaimTO.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNaimTO_KeyDown);
            // 
            // tbOrderNumbers
            // 
            this.tbOrderNumbers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOrderNumbers.Location = new System.Drawing.Point(164, 80);
            this.tbOrderNumbers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbOrderNumbers.Name = "tbOrderNumbers";
            this.tbOrderNumbers.Size = new System.Drawing.Size(679, 27);
            this.tbOrderNumbers.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Номера заказов:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование ТО:";
            // 
            // equpmentByTOEntityDataGridView
            // 
            this.equpmentByTOEntityDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.equpmentByTOEntityDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.equpmentByTOEntityDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.equpmentByTOEntityDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.equpmentByTOEntityDataGridView.DataSource = this.bsEqupmentByTO;
            this.equpmentByTOEntityDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equpmentByTOEntityDataGridView.Location = new System.Drawing.Point(0, 183);
            this.equpmentByTOEntityDataGridView.Name = "equpmentByTOEntityDataGridView";
            this.equpmentByTOEntityDataGridView.Size = new System.Drawing.Size(856, 330);
            this.equpmentByTOEntityDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Operation";
            this.dataGridViewTextBoxColumn1.HeaderText = "Операция";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 130;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "hours";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn2.HeaderText = "Затрачено часов";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 180;
            // 
            // bsEqupmentByTO
            // 
            this.bsEqupmentByTO.DataSource = typeof(Texac.Analize.EqupmentByTOEntity);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 513);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(856, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // AnalizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 535);
            this.Controls.Add(this.equpmentByTOEntityDataGridView);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(872, 573);
            this.Name = "AnalizeForm";
            this.Text = "Расчет загрузки оборудования";
            this.Load += new System.EventHandler(this.AnalizeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equpmentByTOEntityDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEqupmentByTO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnFindOrderNumbers;
        private System.Windows.Forms.TextBox tbNaimTO;
        private System.Windows.Forms.TextBox tbOrderNumbers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bsEqupmentByTO;
        private System.Windows.Forms.DataGridView equpmentByTOEntityDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}