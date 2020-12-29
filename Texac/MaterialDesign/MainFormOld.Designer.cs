namespace Texac.MaterialDesign
{
    partial class MainFormOld
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
            this.panTitleBar = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panTitleBar
            // 
            this.panTitleBar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panTitleBar.Name = "panTitleBar";
            this.panTitleBar.Size = new System.Drawing.Size(885, 60);
            this.panTitleBar.TabIndex = 0;
            this.panTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panTitleBar_MouseDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 514);
            this.ControlBox = false;
            this.Controls.Add(this.panTitleBar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panTitleBar;
    }
}