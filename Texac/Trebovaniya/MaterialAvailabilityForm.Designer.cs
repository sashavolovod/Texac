namespace Texac.Trebovaniya
{
    partial class MaterialAvailabilityForm
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
            this.lvMaterials = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lvMaterials
            // 
            this.lvMaterials.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvMaterials.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvMaterials.Location = new System.Drawing.Point(1, 1);
            this.lvMaterials.Name = "lvMaterials";
            this.lvMaterials.Size = new System.Drawing.Size(930, 477);
            this.lvMaterials.TabIndex = 0;
            this.lvMaterials.UseCompatibleStateImageBehavior = false;
            this.lvMaterials.View = System.Windows.Forms.View.Details;
            // 
            // MaterialAvailabilityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 503);
            this.Controls.Add(this.lvMaterials);
            this.Name = "MaterialAvailabilityForm";
            this.Text = "Контроль наличия материалов на складах";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvMaterials;
    }
}