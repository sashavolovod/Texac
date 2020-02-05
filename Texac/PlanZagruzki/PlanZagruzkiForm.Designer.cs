namespace Texac.PlanZagruzki
{
    partial class PlanZagruzkiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlanZagruzkiForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnBuild = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbNotReady = new System.Windows.Forms.CheckBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvPlanZagruzki = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lvGrafik = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbSelectCount = new System.Windows.Forms.Label();
            this.btnUncheck = new System.Windows.Forms.Button();
            this.oborudovanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zagruzkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planZagruzkiEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanZagruzki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planZagruzkiEntityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lvGrafik);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 560);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbSelectCount);
            this.panel4.Controls.Add(this.btnBuild);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 479);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(345, 81);
            this.panel4.TabIndex = 2;
            // 
            // btnBuild
            // 
            this.btnBuild.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBuild.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBuild.Image = ((System.Drawing.Image)(resources.GetObject("btnBuild.Image")));
            this.btnBuild.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuild.Location = new System.Drawing.Point(105, 37);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBuild.Size = new System.Drawing.Size(137, 33);
            this.btnBuild.TabIndex = 0;
            this.btnBuild.Text = "Построить";
            this.btnBuild.UseVisualStyleBackColor = true;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnUncheck);
            this.panel3.Controls.Add(this.cbNotReady);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(345, 43);
            this.panel3.TabIndex = 1;
            // 
            // cbNotReady
            // 
            this.cbNotReady.AutoSize = true;
            this.cbNotReady.Checked = true;
            this.cbNotReady.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbNotReady.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbNotReady.Location = new System.Drawing.Point(12, 12);
            this.cbNotReady.Name = "cbNotReady";
            this.cbNotReady.Size = new System.Drawing.Size(194, 20);
            this.cbNotReady.TabIndex = 0;
            this.cbNotReady.Text = "Невыполненные графики";
            this.cbNotReady.UseVisualStyleBackColor = true;
            this.cbNotReady.CheckedChanged += new System.EventHandler(this.cbNotReady_CheckedChanged);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(345, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 560);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvPlanZagruzki);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(348, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(608, 560);
            this.panel2.TabIndex = 2;
            // 
            // dgvPlanZagruzki
            // 
            this.dgvPlanZagruzki.AllowUserToAddRows = false;
            this.dgvPlanZagruzki.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvPlanZagruzki.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPlanZagruzki.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlanZagruzki.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPlanZagruzki.ColumnHeadersHeight = 30;
            this.dgvPlanZagruzki.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oborudovanieDataGridViewTextBoxColumn,
            this.zagruzkaDataGridViewTextBoxColumn});
            this.dgvPlanZagruzki.DataSource = this.planZagruzkiEntityBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPlanZagruzki.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPlanZagruzki.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPlanZagruzki.Location = new System.Drawing.Point(0, 0);
            this.dgvPlanZagruzki.Name = "dgvPlanZagruzki";
            this.dgvPlanZagruzki.Size = new System.Drawing.Size(608, 560);
            this.dgvPlanZagruzki.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 560);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(956, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lvGrafik
            // 
            this.lvGrafik.CheckBoxes = true;
            this.lvGrafik.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvGrafik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvGrafik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvGrafik.FullRowSelect = true;
            this.lvGrafik.GridLines = true;
            this.lvGrafik.Location = new System.Drawing.Point(0, 43);
            this.lvGrafik.MultiSelect = false;
            this.lvGrafik.Name = "lvGrafik";
            this.lvGrafik.Size = new System.Drawing.Size(345, 436);
            this.lvGrafik.TabIndex = 3;
            this.lvGrafik.UseCompatibleStateImageBehavior = false;
            this.lvGrafik.View = System.Windows.Forms.View.Details;
            this.lvGrafik.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvGrafik_ItemChecked);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "№";
            this.columnHeader1.Width = 55;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "График";
            this.columnHeader2.Width = 122;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Дата";
            this.columnHeader3.Width = 76;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Срок";
            this.columnHeader4.Width = 91;
            // 
            // lbSelectCount
            // 
            this.lbSelectCount.AutoSize = true;
            this.lbSelectCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSelectCount.ForeColor = System.Drawing.Color.Navy;
            this.lbSelectCount.Location = new System.Drawing.Point(12, 13);
            this.lbSelectCount.Name = "lbSelectCount";
            this.lbSelectCount.Size = new System.Drawing.Size(95, 15);
            this.lbSelectCount.TabIndex = 1;
            this.lbSelectCount.Text = "Выбрано 0 из 0";
            // 
            // btnUncheck
            // 
            this.btnUncheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUncheck.Enabled = false;
            this.btnUncheck.Image = ((System.Drawing.Image)(resources.GetObject("btnUncheck.Image")));
            this.btnUncheck.Location = new System.Drawing.Point(300, 6);
            this.btnUncheck.Name = "btnUncheck";
            this.btnUncheck.Size = new System.Drawing.Size(39, 34);
            this.btnUncheck.TabIndex = 1;
            this.btnUncheck.UseVisualStyleBackColor = true;
            this.btnUncheck.Click += new System.EventHandler(this.btnUncheck_Click);
            // 
            // oborudovanieDataGridViewTextBoxColumn
            // 
            this.oborudovanieDataGridViewTextBoxColumn.DataPropertyName = "oborudovanie";
            this.oborudovanieDataGridViewTextBoxColumn.Frozen = true;
            this.oborudovanieDataGridViewTextBoxColumn.HeaderText = "Оборудование";
            this.oborudovanieDataGridViewTextBoxColumn.Name = "oborudovanieDataGridViewTextBoxColumn";
            this.oborudovanieDataGridViewTextBoxColumn.Width = 200;
            // 
            // zagruzkaDataGridViewTextBoxColumn
            // 
            this.zagruzkaDataGridViewTextBoxColumn.DataPropertyName = "zagruzka";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.zagruzkaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.zagruzkaDataGridViewTextBoxColumn.HeaderText = "Время";
            this.zagruzkaDataGridViewTextBoxColumn.Name = "zagruzkaDataGridViewTextBoxColumn";
            // 
            // planZagruzkiEntityBindingSource
            // 
            this.planZagruzkiEntityBindingSource.DataSource = typeof(Texac.PlanZagruzki.PlanZagruzkiEntity);
            // 
            // PlanZagruzkiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 582);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlanZagruzkiForm";
            this.Text = "План загрузки оборудования";
            this.Load += new System.EventHandler(this.PlanZagruzkiForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanZagruzki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planZagruzkiEntityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox cbNotReady;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvPlanZagruzki;
        private System.Windows.Forms.BindingSource planZagruzkiEntityBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn oborudovanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zagruzkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ListView lvGrafik;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label lbSelectCount;
        private System.Windows.Forms.Button btnUncheck;
    }
}