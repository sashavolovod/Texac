namespace Texac.Request
{
    partial class RequestForm
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
            this.tbOrderId = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbMaster = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbQty = new System.Windows.Forms.TextBox();
            this.dtpRequestDate = new System.Windows.Forms.DateTimePicker();
            this.lbRequestDate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbScopeOfWork = new System.Windows.Forms.TextBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.tbCustomer = new System.Windows.Forms.TextBox();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            this.SuspendLayout();
            // 
            // tbOrderId
            // 
            this.tbOrderId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOrderId.Location = new System.Drawing.Point(170, 26);
            this.tbOrderId.Margin = new System.Windows.Forms.Padding(5);
            this.tbOrderId.Name = "tbOrderId";
            this.tbOrderId.Size = new System.Drawing.Size(274, 27);
            this.tbOrderId.TabIndex = 0;
            this.tbOrderId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbOrderId_KeyDown);
            // 
            // tbDescription
            // 
            this.tbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDescription.Location = new System.Drawing.Point(170, 63);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(5);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(274, 27);
            this.tbDescription.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Номер заказа:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Заявка на:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Заказчик:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Технолог:";
            // 
            // cbEmployee
            // 
            this.cbEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEmployee.FormattingEnabled = true;
            this.cbEmployee.Location = new System.Drawing.Point(170, 138);
            this.cbEmployee.Margin = new System.Windows.Forms.Padding(5);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(274, 28);
            this.cbEmployee.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Мастер/слесарь:";
            // 
            // cbMaster
            // 
            this.cbMaster.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMaster.FormattingEnabled = true;
            this.cbMaster.Location = new System.Drawing.Point(170, 176);
            this.cbMaster.Margin = new System.Windows.Forms.Padding(5);
            this.cbMaster.Name = "cbMaster";
            this.cbMaster.Size = new System.Drawing.Size(274, 28);
            this.cbMaster.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Количество:";
            // 
            // tbQty
            // 
            this.tbQty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbQty.Location = new System.Drawing.Point(170, 214);
            this.tbQty.Margin = new System.Windows.Forms.Padding(5);
            this.tbQty.Name = "tbQty";
            this.tbQty.Size = new System.Drawing.Size(274, 27);
            this.tbQty.TabIndex = 10;
            // 
            // dtpRequestDate
            // 
            this.dtpRequestDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpRequestDate.Location = new System.Drawing.Point(170, 251);
            this.dtpRequestDate.Margin = new System.Windows.Forms.Padding(5);
            this.dtpRequestDate.Name = "dtpRequestDate";
            this.dtpRequestDate.Size = new System.Drawing.Size(274, 27);
            this.dtpRequestDate.TabIndex = 12;
            // 
            // lbRequestDate
            // 
            this.lbRequestDate.AutoSize = true;
            this.lbRequestDate.Location = new System.Drawing.Point(12, 256);
            this.lbRequestDate.Name = "lbRequestDate";
            this.lbRequestDate.Size = new System.Drawing.Size(150, 20);
            this.lbRequestDate.TabIndex = 13;
            this.lbRequestDate.Text = "Дата подачи заявки:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Объем работ:";
            // 
            // tbScopeOfWork
            // 
            this.tbScopeOfWork.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbScopeOfWork.Location = new System.Drawing.Point(16, 311);
            this.tbScopeOfWork.Margin = new System.Windows.Forms.Padding(5);
            this.tbScopeOfWork.Multiline = true;
            this.tbScopeOfWork.Name = "tbScopeOfWork";
            this.tbScopeOfWork.Size = new System.Drawing.Size(428, 166);
            this.tbScopeOfWork.TabIndex = 15;
            // 
            // btnPreview
            // 
            this.btnPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreview.Image = global::Texac.Properties.Resources._1383136876_agt_print;
            this.btnPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPreview.Location = new System.Drawing.Point(300, 485);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPreview.Size = new System.Drawing.Size(144, 41);
            this.btnPreview.TabIndex = 17;
            this.btnPreview.Text = "Просмотр";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // tbCustomer
            // 
            this.tbCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCustomer.Location = new System.Drawing.Point(170, 100);
            this.tbCustomer.Margin = new System.Windows.Forms.Padding(5);
            this.tbCustomer.Name = "tbCustomer";
            this.tbCustomer.Size = new System.Drawing.Size(274, 27);
            this.tbCustomer.TabIndex = 4;
            // 
            // bs
            // 
            this.bs.DataSource = typeof(Texac.Request.RequestEntity);
            // 
            // RequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 538);
            this.Controls.Add(this.tbCustomer);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.tbScopeOfWork);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbRequestDate);
            this.Controls.Add(this.dtpRequestDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbQty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbMaster);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbEmployee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbOrderId);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RequestForm";
            this.Text = "Создание заявки";
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbOrderId;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbMaster;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbQty;
        private System.Windows.Forms.DateTimePicker dtpRequestDate;
        private System.Windows.Forms.Label lbRequestDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbScopeOfWork;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.BindingSource bs;
        private System.Windows.Forms.TextBox tbCustomer;
    }
}