namespace Texac.Orders
{
    partial class OrderControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label orderFullNumberLabel;
            System.Windows.Forms.Label orderIdLabel;
            System.Windows.Forms.Label lbIncludeInReport;
            System.Windows.Forms.Label reportDateLabel;
            System.Windows.Forms.Label orderNumberLabel;
            System.Windows.Forms.Label orderDateLabel;
            System.Windows.Forms.Label obozToLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderControl));
            this.tbOrderId = new System.Windows.Forms.TextBox();
            this.bsOrder = new System.Windows.Forms.BindingSource(this.components);
            this.orderBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbOrderFullNumber = new System.Windows.Forms.TextBox();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bnOrder = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.cbIncludeInReport = new System.Windows.Forms.CheckBox();
            this.dtReportDate = new DateTimePickerEx();
            this.tbOrderNumber = new System.Windows.Forms.TextBox();
            this.orderDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tbObozTo = new System.Windows.Forms.TextBox();
            orderFullNumberLabel = new System.Windows.Forms.Label();
            orderIdLabel = new System.Windows.Forms.Label();
            lbIncludeInReport = new System.Windows.Forms.Label();
            reportDateLabel = new System.Windows.Forms.Label();
            orderNumberLabel = new System.Windows.Forms.Label();
            orderDateLabel = new System.Windows.Forms.Label();
            obozToLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnOrder)).BeginInit();
            this.bnOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderFullNumberLabel
            // 
            orderFullNumberLabel.AutoSize = true;
            orderFullNumberLabel.Location = new System.Drawing.Point(140, 51);
            orderFullNumberLabel.Name = "orderFullNumberLabel";
            orderFullNumberLabel.Size = new System.Drawing.Size(58, 13);
            orderFullNumberLabel.TabIndex = 10;
            orderFullNumberLabel.Text = "№ Заказа";
            // 
            // orderIdLabel
            // 
            orderIdLabel.AutoSize = true;
            orderIdLabel.Location = new System.Drawing.Point(12, 51);
            orderIdLabel.Name = "orderIdLabel";
            orderIdLabel.Size = new System.Drawing.Size(42, 13);
            orderIdLabel.TabIndex = 8;
            orderIdLabel.Text = "№ п.п.:";
            // 
            // lbIncludeInReport
            // 
            lbIncludeInReport.AutoSize = true;
            lbIncludeInReport.Location = new System.Drawing.Point(331, 51);
            lbIncludeInReport.Name = "lbIncludeInReport";
            lbIncludeInReport.Size = new System.Drawing.Size(39, 13);
            lbIncludeInReport.TabIndex = 11;
            lbIncludeInReport.Text = "Отчет:";
            // 
            // reportDateLabel
            // 
            reportDateLabel.AutoSize = true;
            reportDateLabel.Location = new System.Drawing.Point(404, 51);
            reportDateLabel.Name = "reportDateLabel";
            reportDateLabel.Size = new System.Drawing.Size(72, 13);
            reportDateLabel.TabIndex = 12;
            reportDateLabel.Text = "Дата отчета:";
            reportDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // orderNumberLabel
            // 
            orderNumberLabel.AutoSize = true;
            orderNumberLabel.Location = new System.Drawing.Point(18, 93);
            orderNumberLabel.Name = "orderNumberLabel";
            orderNumberLabel.Size = new System.Drawing.Size(69, 13);
            orderNumberLabel.TabIndex = 13;
            orderNumberLabel.Text = "№ зак. зав.:";
            // 
            // orderDateLabel
            // 
            orderDateLabel.AutoSize = true;
            orderDateLabel.Location = new System.Drawing.Point(107, 93);
            orderDateLabel.Name = "orderDateLabel";
            orderDateLabel.Size = new System.Drawing.Size(75, 13);
            orderDateLabel.TabIndex = 14;
            orderDateLabel.Text = "Дата заказа:";
            // 
            // obozToLabel
            // 
            obozToLabel.AutoSize = true;
            obozToLabel.Location = new System.Drawing.Point(204, 93);
            obozToLabel.Name = "obozToLabel";
            obozToLabel.Size = new System.Drawing.Size(95, 13);
            obozToLabel.TabIndex = 15;
            obozToLabel.Text = "Обозначение ТО:";
            // 
            // tbOrderId
            // 
            this.tbOrderId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOrder, "orderId", true));
            this.tbOrderId.Location = new System.Drawing.Point(60, 48);
            this.tbOrderId.Name = "tbOrderId";
            this.tbOrderId.Size = new System.Drawing.Size(62, 20);
            this.tbOrderId.TabIndex = 9;
            // 
            // bsOrder
            // 
            this.bsOrder.DataSource = typeof(Texac.Domain.Order);
            // 
            // orderBindingNavigatorSaveItem
            // 
            this.orderBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.orderBindingNavigatorSaveItem.Enabled = false;
            this.orderBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("orderBindingNavigatorSaveItem.Image")));
            this.orderBindingNavigatorSaveItem.Name = "orderBindingNavigatorSaveItem";
            this.orderBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.orderBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tbOrderFullNumber
            // 
            this.tbOrderFullNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOrder, "orderFullNumber", true));
            this.tbOrderFullNumber.Location = new System.Drawing.Point(204, 48);
            this.tbOrderFullNumber.Name = "tbOrderFullNumber";
            this.tbOrderFullNumber.Size = new System.Drawing.Size(98, 20);
            this.tbOrderFullNumber.TabIndex = 11;
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bnOrder
            // 
            this.bnOrder.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bnOrder.BindingSource = this.bsOrder;
            this.bnOrder.CountItem = this.bindingNavigatorCountItem;
            this.bnOrder.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bnOrder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.orderBindingNavigatorSaveItem});
            this.bnOrder.Location = new System.Drawing.Point(0, 0);
            this.bnOrder.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnOrder.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnOrder.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnOrder.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnOrder.Name = "bnOrder";
            this.bnOrder.PositionItem = this.bindingNavigatorPositionItem;
            this.bnOrder.Size = new System.Drawing.Size(975, 25);
            this.bnOrder.TabIndex = 7;
            this.bnOrder.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 529);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(975, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // cbIncludeInReport
            // 
            this.cbIncludeInReport.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bsOrder, "includeInReport", true));
            this.cbIncludeInReport.Location = new System.Drawing.Point(376, 46);
            this.cbIncludeInReport.Name = "cbIncludeInReport";
            this.cbIncludeInReport.Size = new System.Drawing.Size(22, 22);
            this.cbIncludeInReport.TabIndex = 12;
            this.cbIncludeInReport.UseVisualStyleBackColor = true;
            // 
            // dtReportDate
            // 
            this.dtReportDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsOrder, "reportDate", true));
            this.dtReportDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtReportDate.Location = new System.Drawing.Point(479, 48);
            this.dtReportDate.Name = "dtReportDate";
            this.dtReportDate.Size = new System.Drawing.Size(100, 20);
            this.dtReportDate.TabIndex = 13;
            this.dtReportDate.Value = new System.DateTime(2020, 8, 14, 11, 54, 42, 988);
            // 
            // tbOrderNumber
            // 
            this.tbOrderNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOrder, "orderNumber", true));
            this.tbOrderNumber.Location = new System.Drawing.Point(15, 109);
            this.tbOrderNumber.Name = "tbOrderNumber";
            this.tbOrderNumber.Size = new System.Drawing.Size(72, 20);
            this.tbOrderNumber.TabIndex = 14;
            // 
            // orderDateDateTimePicker
            // 
            this.orderDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsOrder, "orderDate", true));
            this.orderDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.orderDateDateTimePicker.Location = new System.Drawing.Point(93, 109);
            this.orderDateDateTimePicker.Name = "orderDateDateTimePicker";
            this.orderDateDateTimePicker.Size = new System.Drawing.Size(105, 20);
            this.orderDateDateTimePicker.TabIndex = 15;
            // 
            // tbObozTo
            // 
            this.tbObozTo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOrder, "obozTo", true));
            this.tbObozTo.Location = new System.Drawing.Point(204, 109);
            this.tbObozTo.Name = "tbObozTo";
            this.tbObozTo.Size = new System.Drawing.Size(173, 20);
            this.tbObozTo.TabIndex = 16;
            // 
            // OrderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(obozToLabel);
            this.Controls.Add(this.tbObozTo);
            this.Controls.Add(orderDateLabel);
            this.Controls.Add(this.orderDateDateTimePicker);
            this.Controls.Add(orderNumberLabel);
            this.Controls.Add(this.tbOrderNumber);
            this.Controls.Add(reportDateLabel);
            this.Controls.Add(this.dtReportDate);
            this.Controls.Add(lbIncludeInReport);
            this.Controls.Add(this.cbIncludeInReport);
            this.Controls.Add(orderFullNumberLabel);
            this.Controls.Add(orderIdLabel);
            this.Controls.Add(this.tbOrderId);
            this.Controls.Add(this.tbOrderFullNumber);
            this.Controls.Add(this.bnOrder);
            this.Controls.Add(this.statusStrip1);
            this.Name = "OrderControl";
            this.Size = new System.Drawing.Size(975, 551);
            ((System.ComponentModel.ISupportInitialize)(this.bsOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnOrder)).EndInit();
            this.bnOrder.ResumeLayout(false);
            this.bnOrder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsOrder;
        private System.Windows.Forms.TextBox tbOrderId;
        private System.Windows.Forms.ToolStripButton orderBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox tbOrderFullNumber;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.BindingNavigator bnOrder;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.CheckBox cbIncludeInReport;
        private DateTimePickerEx dtReportDate;
        private System.Windows.Forms.TextBox tbOrderNumber;
        private System.Windows.Forms.DateTimePicker orderDateDateTimePicker;
        private System.Windows.Forms.TextBox tbObozTo;
    }
}
