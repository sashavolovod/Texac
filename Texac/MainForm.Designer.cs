namespace Texac
{
    partial class MainForm
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
            this.ssStatusStrip = new System.Windows.Forms.StatusStrip();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.miFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.miOperation = new System.Windows.Forms.ToolStripMenuItem();
            this.заказыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miDictionary = new System.Windows.Forms.ToolStripMenuItem();
            this.miEployees = new System.Windows.Forms.ToolStripMenuItem();
            this.единицыИзмеренияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miDocs = new System.Windows.Forms.ToolStripMenuItem();
            this.miTrebovaniya = new System.Windows.Forms.ToolStripMenuItem();
            this.miIssuedMaterials = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miMaterialreport = new System.Windows.Forms.ToolStripMenuItem();
            this.miReadyWork = new System.Windows.Forms.ToolStripMenuItem();
            this.miHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.miTtn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssStatusStrip
            // 
            this.ssStatusStrip.Location = new System.Drawing.Point(0, 481);
            this.ssStatusStrip.Name = "ssStatusStrip";
            this.ssStatusStrip.Size = new System.Drawing.Size(800, 22);
            this.ssStatusStrip.TabIndex = 0;
            this.ssStatusStrip.Text = "statusStrip1";
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFile,
            this.miOperation,
            this.miDictionary,
            this.miDocs,
            this.отчетыToolStripMenuItem,
            this.miHelp});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(800, 24);
            this.mnuMain.TabIndex = 1;
            this.mnuMain.Text = "menuStrip1";
            // 
            // miFile
            // 
            this.miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.miExit});
            this.miFile.Name = "miFile";
            this.miFile.Size = new System.Drawing.Size(48, 20);
            this.miFile.Text = "Файл";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(105, 6);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(108, 22);
            this.miExit.Text = "Выход";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // miOperation
            // 
            this.miOperation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заказыToolStripMenuItem});
            this.miOperation.Name = "miOperation";
            this.miOperation.Size = new System.Drawing.Size(75, 20);
            this.miOperation.Text = "Операции";
            // 
            // заказыToolStripMenuItem
            // 
            this.заказыToolStripMenuItem.Name = "заказыToolStripMenuItem";
            this.заказыToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.заказыToolStripMenuItem.Text = "Заказы";
            // 
            // miDictionary
            // 
            this.miDictionary.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miEployees,
            this.единицыИзмеренияToolStripMenuItem});
            this.miDictionary.Name = "miDictionary";
            this.miDictionary.Size = new System.Drawing.Size(94, 20);
            this.miDictionary.Text = "Справочники";
            // 
            // miEployees
            // 
            this.miEployees.Name = "miEployees";
            this.miEployees.Size = new System.Drawing.Size(186, 22);
            this.miEployees.Text = "Работники цеха";
            this.miEployees.Click += new System.EventHandler(this.miEployees_Click);
            // 
            // единицыИзмеренияToolStripMenuItem
            // 
            this.единицыИзмеренияToolStripMenuItem.Name = "единицыИзмеренияToolStripMenuItem";
            this.единицыИзмеренияToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.единицыИзмеренияToolStripMenuItem.Text = "Единицы измерения";
            // 
            // miDocs
            // 
            this.miDocs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miTrebovaniya,
            this.miIssuedMaterials,
            this.miTtn});
            this.miDocs.Name = "miDocs";
            this.miDocs.Size = new System.Drawing.Size(82, 20);
            this.miDocs.Text = "Документы";
            // 
            // miTrebovaniya
            // 
            this.miTrebovaniya.Name = "miTrebovaniya";
            this.miTrebovaniya.Size = new System.Drawing.Size(210, 22);
            this.miTrebovaniya.Text = "Требования";
            this.miTrebovaniya.Click += new System.EventHandler(this.miTrebovaniya_Click);
            // 
            // miIssuedMaterials
            // 
            this.miIssuedMaterials.Name = "miIssuedMaterials";
            this.miIssuedMaterials.Size = new System.Drawing.Size(210, 22);
            this.miIssuedMaterials.Text = "Полученные материалы";
            this.miIssuedMaterials.Click += new System.EventHandler(this.miIssuedMaterials_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miMaterialreport,
            this.miReadyWork});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // miMaterialreport
            // 
            this.miMaterialreport.Name = "miMaterialreport";
            this.miMaterialreport.Size = new System.Drawing.Size(224, 22);
            this.miMaterialreport.Text = "Расход материалов";
            this.miMaterialreport.Click += new System.EventHandler(this.miMaterialreport_Click);
            // 
            // miReadyWork
            // 
            this.miReadyWork.Name = "miReadyWork";
            this.miReadyWork.Size = new System.Drawing.Size(224, 22);
            this.miReadyWork.Text = "По выполненным работам";
            this.miReadyWork.Click += new System.EventHandler(this.miReadyWork_Click);
            // 
            // miHelp
            // 
            this.miHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAbout});
            this.miHelp.Name = "miHelp";
            this.miHelp.Size = new System.Drawing.Size(68, 20);
            this.miHelp.Text = "Помощь";
            // 
            // miAbout
            // 
            this.miAbout.Name = "miAbout";
            this.miAbout.Size = new System.Drawing.Size(149, 22);
            this.miAbout.Text = "О программе";
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 457);
            this.tabControl1.TabIndex = 2;
            // 
            // miTtn
            // 
            this.miTtn.Name = "miTtn";
            this.miTtn.Size = new System.Drawing.Size(210, 22);
            this.miTtn.Text = "ТТН";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ssStatusStrip);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Name = "MainForm";
            this.Text = "Техас";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            ((System.Configuration.IPersistComponentSettings)(this)).LoadComponentSettings();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ssStatusStrip;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem miFile;
        private System.Windows.Forms.ToolStripMenuItem miOperation;
        private System.Windows.Forms.ToolStripMenuItem заказыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miDictionary;
        private System.Windows.Forms.ToolStripMenuItem miEployees;
        private System.Windows.Forms.ToolStripMenuItem единицыИзмеренияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miHelp;
        private System.Windows.Forms.ToolStripMenuItem miAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.ToolStripMenuItem miDocs;
        private System.Windows.Forms.ToolStripMenuItem miTrebovaniya;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miMaterialreport;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ToolStripMenuItem miIssuedMaterials;
        private System.Windows.Forms.ToolStripMenuItem miReadyWork;
        private System.Windows.Forms.ToolStripMenuItem miTtn;
    }
}

