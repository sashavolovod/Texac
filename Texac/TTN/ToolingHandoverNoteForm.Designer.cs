namespace Texac.TTN
{
    partial class ToolingHandoverNoteForm
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
            this.tbCustomer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbOrderNumber = new System.Windows.Forms.TextBox();
            this.tbOrderId = new System.Windows.Forms.TextBox();
            this.tbPartName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPartNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbToolingCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbToolingName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbToolLife = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPreview = new System.Windows.Forms.Button();
            this.tbIssued = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbReceivedPost = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbReceived = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbCustomer
            // 
            this.tbCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCustomer.Location = new System.Drawing.Point(190, 88);
            this.tbCustomer.Margin = new System.Windows.Forms.Padding(5);
            this.tbCustomer.Name = "tbCustomer";
            this.tbCustomer.Size = new System.Drawing.Size(304, 27);
            this.tbCustomer.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Заказчик:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Номер заказа завода:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Номер заказа:";
            // 
            // tbOrderNumber
            // 
            this.tbOrderNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOrderNumber.Location = new System.Drawing.Point(190, 51);
            this.tbOrderNumber.Margin = new System.Windows.Forms.Padding(5);
            this.tbOrderNumber.Name = "tbOrderNumber";
            this.tbOrderNumber.Size = new System.Drawing.Size(304, 27);
            this.tbOrderNumber.TabIndex = 7;
            // 
            // tbOrderId
            // 
            this.tbOrderId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOrderId.Location = new System.Drawing.Point(190, 14);
            this.tbOrderId.Margin = new System.Windows.Forms.Padding(5);
            this.tbOrderId.Name = "tbOrderId";
            this.tbOrderId.Size = new System.Drawing.Size(304, 27);
            this.tbOrderId.TabIndex = 6;
            this.tbOrderId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbOrderId_KeyDown);
            // 
            // tbPartName
            // 
            this.tbPartName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPartName.Location = new System.Drawing.Point(190, 125);
            this.tbPartName.Margin = new System.Windows.Forms.Padding(5);
            this.tbPartName.Name = "tbPartName";
            this.tbPartName.Size = new System.Drawing.Size(304, 27);
            this.tbPartName.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Наименование детали:";
            // 
            // tbPartNumber
            // 
            this.tbPartNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPartNumber.Location = new System.Drawing.Point(190, 162);
            this.tbPartNumber.Margin = new System.Windows.Forms.Padding(5);
            this.tbPartNumber.Name = "tbPartNumber";
            this.tbPartNumber.Size = new System.Drawing.Size(304, 27);
            this.tbPartNumber.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Номер детали:";
            // 
            // tbToolingCode
            // 
            this.tbToolingCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbToolingCode.Location = new System.Drawing.Point(190, 199);
            this.tbToolingCode.Margin = new System.Windows.Forms.Padding(5);
            this.tbToolingCode.Name = "tbToolingCode";
            this.tbToolingCode.Size = new System.Drawing.Size(304, 27);
            this.tbToolingCode.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Обозначение ТО:";
            // 
            // tbToolingName
            // 
            this.tbToolingName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbToolingName.Location = new System.Drawing.Point(190, 236);
            this.tbToolingName.Margin = new System.Windows.Forms.Padding(5);
            this.tbToolingName.Name = "tbToolingName";
            this.tbToolingName.Size = new System.Drawing.Size(304, 27);
            this.tbToolingName.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Наименование ТО:";
            // 
            // tbToolLife
            // 
            this.tbToolLife.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbToolLife.Location = new System.Drawing.Point(190, 273);
            this.tbToolLife.Margin = new System.Windows.Forms.Padding(5);
            this.tbToolLife.Name = "tbToolLife";
            this.tbToolLife.Size = new System.Drawing.Size(304, 27);
            this.tbToolLife.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Стойкость:";
            // 
            // btnPreview
            // 
            this.btnPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreview.Image = global::Texac.Properties.Resources._1383136876_agt_print;
            this.btnPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPreview.Location = new System.Drawing.Point(350, 435);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPreview.Size = new System.Drawing.Size(144, 41);
            this.btnPreview.TabIndex = 22;
            this.btnPreview.Text = "Просмотр";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // tbIssued
            // 
            this.tbIssued.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIssued.Location = new System.Drawing.Point(190, 310);
            this.tbIssued.Margin = new System.Windows.Forms.Padding(5);
            this.tbIssued.Name = "tbIssued";
            this.tbIssued.Size = new System.Drawing.Size(304, 27);
            this.tbIssued.TabIndex = 23;
            this.tbIssued.Text = "Гринчик А.С.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 313);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Отпустил:";
            // 
            // tbReceivedPost
            // 
            this.tbReceivedPost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbReceivedPost.Location = new System.Drawing.Point(190, 347);
            this.tbReceivedPost.Margin = new System.Windows.Forms.Padding(5);
            this.tbReceivedPost.Name = "tbReceivedPost";
            this.tbReceivedPost.Size = new System.Drawing.Size(304, 27);
            this.tbReceivedPost.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 350);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "Получил (должность):";
            // 
            // tbReceived
            // 
            this.tbReceived.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbReceived.Location = new System.Drawing.Point(190, 384);
            this.tbReceived.Margin = new System.Windows.Forms.Padding(5);
            this.tbReceived.Name = "tbReceived";
            this.tbReceived.Size = new System.Drawing.Size(304, 27);
            this.tbReceived.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 387);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "Получил (ФИО):";
            // 
            // ToolingHandoverNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 488);
            this.Controls.Add(this.tbReceived);
            this.Controls.Add(this.tbReceivedPost);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbIssued);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.tbToolLife);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbToolingName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbToolingCode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPartNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPartName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbCustomer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbOrderNumber);
            this.Controls.Add(this.tbOrderId);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ToolingHandoverNoteForm";
            this.Text = "Накладная на сдачу оснастки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbOrderNumber;
        private System.Windows.Forms.TextBox tbOrderId;
        private System.Windows.Forms.TextBox tbPartName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPartNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbToolingCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbToolingName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbToolLife;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.TextBox tbIssued;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbReceivedPost;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbReceived;
        private System.Windows.Forms.Label label11;
    }
}