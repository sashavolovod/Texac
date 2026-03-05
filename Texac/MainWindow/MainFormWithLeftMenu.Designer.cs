namespace Texac.MainWindow
{
    partial class MainFormWithLeftMenu
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.flpNav = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlMenuToggle = new System.Windows.Forms.Panel();
            this.btnToggleMenu = new System.Windows.Forms.Button();
            this.pnlSearchWrap = new System.Windows.Forms.Panel();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.txtMenuSearch = new System.Windows.Forms.TextBox();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlMenuToggle.SuspendLayout();
            this.pnlSearchWrap.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 530);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1278, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitMain.Location = new System.Drawing.Point(20, 0);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.pnlLeft);
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.mainTabControl);
            this.splitMain.Size = new System.Drawing.Size(1258, 530);
            this.splitMain.SplitterDistance = 240;
            this.splitMain.SplitterWidth = 6;
            this.splitMain.TabIndex = 6;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.flpNav);
            this.pnlLeft.Controls.Add(this.pnlSearchWrap);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(240, 530);
            this.pnlLeft.TabIndex = 5;
            // 
            // flpNav
            // 
            this.flpNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpNav.Location = new System.Drawing.Point(0, 40);
            this.flpNav.Name = "flpNav";
            this.flpNav.Size = new System.Drawing.Size(240, 490);
            this.flpNav.TabIndex = 2;
            // 
            // pnlMenuToggle
            // 
            this.pnlMenuToggle.Controls.Add(this.btnToggleMenu);
            this.pnlMenuToggle.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuToggle.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuToggle.Name = "pnlMenuToggle";
            this.pnlMenuToggle.Size = new System.Drawing.Size(20, 530);
            this.pnlMenuToggle.TabIndex = 7;
            // 
            // btnToggleMenu
            // 
            this.btnToggleMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnToggleMenu.FlatAppearance.BorderSize = 0;
            this.btnToggleMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnToggleMenu.Location = new System.Drawing.Point(0, 0);
            this.btnToggleMenu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.btnToggleMenu.Name = "btnToggleMenu";
            this.btnToggleMenu.Size = new System.Drawing.Size(20, 530);
            this.btnToggleMenu.TabIndex = 6;
            this.btnToggleMenu.TabStop = false;
            this.btnToggleMenu.Text = "<";
            this.btnToggleMenu.UseVisualStyleBackColor = true;
            // 
            // pnlSearchWrap
            // 
            this.pnlSearchWrap.BackColor = System.Drawing.SystemColors.Control;
            this.pnlSearchWrap.Controls.Add(this.pnlSearch);
            this.pnlSearchWrap.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearchWrap.Location = new System.Drawing.Point(0, 0);
            this.pnlSearchWrap.Name = "pnlSearchWrap";
            this.pnlSearchWrap.Padding = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.pnlSearchWrap.Size = new System.Drawing.Size(240, 40);
            this.pnlSearchWrap.TabIndex = 3;
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.White;
            this.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearch.Controls.Add(this.txtMenuSearch);
            this.pnlSearch.Controls.Add(this.picSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 4);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Padding = new System.Windows.Forms.Padding(4);
            this.pnlSearch.Size = new System.Drawing.Size(236, 32);
            this.pnlSearch.TabIndex = 1;
            // 
            // txtMenuSearch
            // 
            this.txtMenuSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMenuSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMenuSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMenuSearch.Location = new System.Drawing.Point(28, 4);
            this.txtMenuSearch.Name = "txtMenuSearch";
            this.txtMenuSearch.Size = new System.Drawing.Size(202, 20);
            this.txtMenuSearch.TabIndex = 7;
            // 
            // picSearch
            // 
            this.picSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.picSearch.Location = new System.Drawing.Point(4, 4);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(24, 22);
            this.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picSearch.TabIndex = 6;
            this.picSearch.TabStop = false;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1012, 530);
            this.mainTabControl.TabIndex = 0;
            // 
            // MainFormWithLeftMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 552);
            this.Controls.Add(this.splitMain);
            this.Controls.Add(this.pnlMenuToggle);
            this.Controls.Add(this.statusStrip1);
            this.Name = "MainFormWithLeftMenu";
            this.Text = "Техас";
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlMenuToggle.ResumeLayout(false);
            this.pnlSearchWrap.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.FlowLayoutPanel flpNav;
        private System.Windows.Forms.Panel pnlMenuToggle;
        private System.Windows.Forms.Button btnToggleMenu;
        private System.Windows.Forms.Panel pnlSearchWrap;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.TextBox txtMenuSearch;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.TabControl mainTabControl;
    }
}