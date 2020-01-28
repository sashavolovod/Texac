namespace Texac.Trebovaniya
{
    partial class OrderNumberForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderNumberForm));
            this.tbOrderNumber = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCnacel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbOrderNumber
            // 
            this.tbOrderNumber.Location = new System.Drawing.Point(12, 34);
            this.tbOrderNumber.Name = "tbOrderNumber";
            this.tbOrderNumber.Size = new System.Drawing.Size(261, 20);
            this.tbOrderNumber.TabIndex = 0;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(51, 95);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 1;
            this.btnApply.Text = "Принять";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCnacel
            // 
            this.btnCnacel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCnacel.Location = new System.Drawing.Point(154, 95);
            this.btnCnacel.Name = "btnCnacel";
            this.btnCnacel.Size = new System.Drawing.Size(75, 23);
            this.btnCnacel.TabIndex = 1;
            this.btnCnacel.Text = "Отмена";
            this.btnCnacel.UseVisualStyleBackColor = true;
            // 
            // OrderNumberForm
            // 
            this.AcceptButton = this.btnApply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 142);
            this.Controls.Add(this.btnCnacel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.tbOrderNumber);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderNumberForm";
            this.Text = "Номер заказа";
            this.Load += new System.EventHandler(this.OrderNumberForm_Load);
            ((System.Configuration.IPersistComponentSettings)(this)).LoadComponentSettings();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbOrderNumber;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCnacel;
    }
}