namespace Texac
{
    partial class MigratorForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbLog = new System.Windows.Forms.RichTextBox();
            this.btnCopyData = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnCopyData);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 365);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 68);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(79, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 33);
            this.button2.TabIndex = 0;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(219, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "testREST";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tbLog
            // 
            this.tbLog.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLog.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbLog.Location = new System.Drawing.Point(0, 0);
            this.tbLog.Name = "tbLog";
            this.tbLog.Size = new System.Drawing.Size(739, 365);
            this.tbLog.TabIndex = 1;
            this.tbLog.Text = "";
            // 
            // btnCopyData
            // 
            this.btnCopyData.Location = new System.Drawing.Point(350, 23);
            this.btnCopyData.Name = "btnCopyData";
            this.btnCopyData.Size = new System.Drawing.Size(114, 33);
            this.btnCopyData.TabIndex = 0;
            this.btnCopyData.Text = "CopyData";
            this.btnCopyData.UseVisualStyleBackColor = true;
            this.btnCopyData.Click += new System.EventHandler(this.btnCopyData_Click);
            // 
            // MigratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 433);
            this.Controls.Add(this.tbLog);
            this.Controls.Add(this.panel1);
            this.Name = "MigratorForm";
            this.Text = "MigratorForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox tbLog;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCopyData;
    }
}