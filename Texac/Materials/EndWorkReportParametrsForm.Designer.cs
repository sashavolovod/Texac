namespace Texac.Materials
{
    partial class frmEndWorkReportParametrs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEndWorkReportParametrs));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbOrder23 = new System.Windows.Forms.RadioButton();
            this.rbOrder208 = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.chbDescription = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbOrder23);
            this.groupBox1.Controls.Add(this.rbOrder208);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 75);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип отчета";
            // 
            // rbOrder23
            // 
            this.rbOrder23.AutoSize = true;
            this.rbOrder23.Location = new System.Drawing.Point(9, 44);
            this.rbOrder23.Name = "rbOrder23";
            this.rbOrder23.Size = new System.Drawing.Size(106, 17);
            this.rbOrder23.TabIndex = 1;
            this.rbOrder23.Text = "Заказы 23 (233)";
            this.rbOrder23.UseVisualStyleBackColor = true;
            // 
            // rbOrder208
            // 
            this.rbOrder208.AutoSize = true;
            this.rbOrder208.Checked = true;
            this.rbOrder208.Location = new System.Drawing.Point(9, 21);
            this.rbOrder208.Name = "rbOrder208";
            this.rbOrder208.Size = new System.Drawing.Size(85, 17);
            this.rbOrder208.TabIndex = 0;
            this.rbOrder208.TabStop = true;
            this.rbOrder208.Text = "Заказы 208";
            this.rbOrder208.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::Texac.Properties.Resources.Close;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(139, 137);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Отмена    ";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnView
            // 
            this.btnView.Image = ((System.Drawing.Image)(resources.GetObject("btnView.Image")));
            this.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnView.Location = new System.Drawing.Point(20, 137);
            this.btnView.Name = "btnView";
            this.btnView.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnView.Size = new System.Drawing.Size(94, 29);
            this.btnView.TabIndex = 6;
            this.btnView.Text = "Просмотр ";
            this.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // chbDescription
            // 
            this.chbDescription.AutoSize = true;
            this.chbDescription.Location = new System.Drawing.Point(20, 100);
            this.chbDescription.Name = "chbDescription";
            this.chbDescription.Size = new System.Drawing.Size(205, 17);
            this.chbDescription.TabIndex = 5;
            this.chbDescription.Text = "Показывать остаток в примечании";
            this.chbDescription.UseVisualStyleBackColor = true;
            // 
            // frmEndWorkReportParametrs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(254, 183);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.chbDescription);
            this.Name = "frmEndWorkReportParametrs";
            this.Text = "Параметры отчета";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbOrder23;
        private System.Windows.Forms.RadioButton rbOrder208;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.CheckBox chbDescription;
    }
}