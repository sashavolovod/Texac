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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ssStatusStrip = new System.Windows.Forms.StatusStrip();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.miFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.miOperation = new System.Windows.Forms.ToolStripMenuItem();
            this.заказыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miAddPlanOrders = new System.Windows.Forms.ToolStripMenuItem();
            this.miLocksmithOperation = new System.Windows.Forms.ToolStripMenuItem();
            this.miDictionary = new System.Windows.Forms.ToolStripMenuItem();
            this.miEployees = new System.Windows.Forms.ToolStripMenuItem();
            this.единицыИзмеренияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miDocs = new System.Windows.Forms.ToolStripMenuItem();
            this.miTrebovaniya = new System.Windows.Forms.ToolStripMenuItem();
            this.miIssuedMaterials = new System.Windows.Forms.ToolStripMenuItem();
            this.miTtn = new System.Windows.Forms.ToolStripMenuItem();
            this.miDopZN = new System.Windows.Forms.ToolStripMenuItem();
            this.miDeliveryNote = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miMaterialreport = new System.Windows.Forms.ToolStripMenuItem();
            this.miReadyWork = new System.Windows.Forms.ToolStripMenuItem();
            this.miMatZN = new System.Windows.Forms.ToolStripMenuItem();
            this.miPlanZagruzki = new System.Windows.Forms.ToolStripMenuItem();
            this.miOsnastka = new System.Windows.Forms.ToolStripMenuItem();
            this.miEqupmentByTO = new System.Windows.Forms.ToolStripMenuItem();
            this.miPsnHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.miHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.miAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.miDeploy = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssStatusStrip
            // 
            this.ssStatusStrip.Location = new System.Drawing.Point(0, 506);
            this.ssStatusStrip.Name = "ssStatusStrip";
            this.ssStatusStrip.Size = new System.Drawing.Size(876, 22);
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
            this.miHelp,
            this.miAdmin});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(876, 24);
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
            this.заказыToolStripMenuItem,
            this.miAddPlanOrders,
            this.miLocksmithOperation});
            this.miOperation.Name = "miOperation";
            this.miOperation.Size = new System.Drawing.Size(75, 20);
            this.miOperation.Text = "Операции";
            // 
            // заказыToolStripMenuItem
            // 
            this.заказыToolStripMenuItem.Name = "заказыToolStripMenuItem";
            this.заказыToolStripMenuItem.Size = new System.Drawing.Size(353, 22);
            this.заказыToolStripMenuItem.Text = "Заказы";
            // 
            // miAddPlanOrders
            // 
            this.miAddPlanOrders.Name = "miAddPlanOrders";
            this.miAddPlanOrders.Size = new System.Drawing.Size(353, 22);
            this.miAddPlanOrders.Text = "Добавление годовых заявок";
            this.miAddPlanOrders.Click += new System.EventHandler(this.miAddPlanOrders_Click);
            // 
            // miLocksmithOperation
            // 
            this.miLocksmithOperation.Name = "miLocksmithOperation";
            this.miLocksmithOperation.Size = new System.Drawing.Size(353, 22);
            this.miLocksmithOperation.Text = "Распределение слесарных работ по типу оснастки";
            this.miLocksmithOperation.Click += new System.EventHandler(this.miLocksmithOperation_Click);
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
            this.miTtn,
            this.miDopZN,
            this.miDeliveryNote});
            this.miDocs.Name = "miDocs";
            this.miDocs.Size = new System.Drawing.Size(82, 20);
            this.miDocs.Text = "Документы";
            // 
            // miTrebovaniya
            // 
            this.miTrebovaniya.Image = ((System.Drawing.Image)(resources.GetObject("miTrebovaniya.Image")));
            this.miTrebovaniya.Name = "miTrebovaniya";
            this.miTrebovaniya.Size = new System.Drawing.Size(228, 22);
            this.miTrebovaniya.Text = "Требования";
            this.miTrebovaniya.Click += new System.EventHandler(this.miTrebovaniya_Click);
            // 
            // miIssuedMaterials
            // 
            this.miIssuedMaterials.Name = "miIssuedMaterials";
            this.miIssuedMaterials.Size = new System.Drawing.Size(228, 22);
            this.miIssuedMaterials.Text = "Полученные материалы";
            this.miIssuedMaterials.Click += new System.EventHandler(this.miIssuedMaterials_Click);
            // 
            // miTtn
            // 
            this.miTtn.Name = "miTtn";
            this.miTtn.Size = new System.Drawing.Size(228, 22);
            this.miTtn.Text = "ТТН";
            this.miTtn.Click += new System.EventHandler(this.miTtn_Click);
            // 
            // miDopZN
            // 
            this.miDopZN.Image = ((System.Drawing.Image)(resources.GetObject("miDopZN.Image")));
            this.miDopZN.Name = "miDopZN";
            this.miDopZN.Size = new System.Drawing.Size(228, 22);
            this.miDopZN.Text = "Дополнение к заказ-наряду";
            this.miDopZN.Click += new System.EventHandler(this.miDopZN_Click);
            // 
            // miDeliveryNote
            // 
            this.miDeliveryNote.Name = "miDeliveryNote";
            this.miDeliveryNote.Size = new System.Drawing.Size(228, 22);
            this.miDeliveryNote.Text = "Накладная (сдача оснастки)";
            this.miDeliveryNote.Click += new System.EventHandler(this.miDeliveryNote_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miMaterialreport,
            this.miReadyWork,
            this.miMatZN,
            this.miPlanZagruzki,
            this.miOsnastka,
            this.miEqupmentByTO,
            this.miPsnHistory});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // miMaterialreport
            // 
            this.miMaterialreport.Name = "miMaterialreport";
            this.miMaterialreport.Size = new System.Drawing.Size(371, 22);
            this.miMaterialreport.Text = "Расход материалов";
            this.miMaterialreport.Click += new System.EventHandler(this.miMaterialreport_Click);
            // 
            // miReadyWork
            // 
            this.miReadyWork.Name = "miReadyWork";
            this.miReadyWork.Size = new System.Drawing.Size(371, 22);
            this.miReadyWork.Text = "По выполненным работам";
            this.miReadyWork.Click += new System.EventHandler(this.miReadyWork_Click);
            // 
            // miMatZN
            // 
            this.miMatZN.Name = "miMatZN";
            this.miMatZN.Size = new System.Drawing.Size(371, 22);
            this.miMatZN.Text = "Материалы по заказ-нарядам";
            this.miMatZN.Click += new System.EventHandler(this.miMatZN_Click);
            // 
            // miPlanZagruzki
            // 
            this.miPlanZagruzki.Name = "miPlanZagruzki";
            this.miPlanZagruzki.Size = new System.Drawing.Size(371, 22);
            this.miPlanZagruzki.Text = "План загрузки оборудования";
            this.miPlanZagruzki.Click += new System.EventHandler(this.miPlanZagruzki_Click);
            // 
            // miOsnastka
            // 
            this.miOsnastka.Name = "miOsnastka";
            this.miOsnastka.Size = new System.Drawing.Size(371, 22);
            this.miOsnastka.Text = "О выполнении плана сдачи оснастки и инструментов";
            this.miOsnastka.Click += new System.EventHandler(this.miOsnastka_Click);
            // 
            // miEqupmentByTO
            // 
            this.miEqupmentByTO.Name = "miEqupmentByTO";
            this.miEqupmentByTO.Size = new System.Drawing.Size(371, 22);
            this.miEqupmentByTO.Text = "Расчет загрузки оборудования по ТО";
            this.miEqupmentByTO.Click += new System.EventHandler(this.miEqupmentByTO_Click);
            // 
            // miPsnHistory
            // 
            this.miPsnHistory.Image = global::Texac.Properties.Resources.Joker_Design_Android_Document_48;
            this.miPsnHistory.Name = "miPsnHistory";
            this.miPsnHistory.Size = new System.Drawing.Size(371, 22);
            this.miPsnHistory.Text = "Выписанные накладные";
            this.miPsnHistory.Click += new System.EventHandler(this.miPsnHistory_Click);
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
            this.miAbout.Click += new System.EventHandler(this.miAbout_Click);
            // 
            // miAdmin
            // 
            this.miAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miDeploy});
            this.miAdmin.Name = "miAdmin";
            this.miAdmin.Size = new System.Drawing.Size(134, 20);
            this.miAdmin.Text = "Администрирование";
            // 
            // miDeploy
            // 
            this.miDeploy.Name = "miDeploy";
            this.miDeploy.Size = new System.Drawing.Size(237, 22);
            this.miDeploy.Text = "Опубликовать новую версию";
            this.miDeploy.Click += new System.EventHandler(this.miDeploy_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(876, 482);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.MouseLeave += new System.EventHandler(this.tabControl1_MouseLeave);
            this.tabControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseMove);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 528);
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
        private System.Windows.Forms.ToolStripMenuItem miDopZN;
        private System.Windows.Forms.ToolStripMenuItem miMatZN;
        private System.Windows.Forms.ToolStripMenuItem miPlanZagruzki;
        private System.Windows.Forms.ToolStripMenuItem miOsnastka;
        private System.Windows.Forms.ToolStripMenuItem miEqupmentByTO;
        private System.Windows.Forms.ToolStripMenuItem miAddPlanOrders;
        private System.Windows.Forms.ToolStripMenuItem miAdmin;
        private System.Windows.Forms.ToolStripMenuItem miDeploy;
        private System.Windows.Forms.ToolStripMenuItem miDeliveryNote;
        private System.Windows.Forms.ToolStripMenuItem miLocksmithOperation;
        private System.Windows.Forms.ToolStripMenuItem miPsnHistory;
    }
}

