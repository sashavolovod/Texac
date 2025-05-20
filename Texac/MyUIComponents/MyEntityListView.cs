using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Texac.MyUIComponents
{
    [ToolboxBitmap(typeof(DataGridView))]
    public class MyEntityListView : DataGridView
    {
        [Category("Custom")]
        [Browsable(true)]
        [Description("фигня какая-то")]
        //[Editor(typeof(System.Windows.Forms.Design.WindowsFormsComponentEditor), typeof(System.Drawing.Design.UITypeEditor))]
        public string ImageFile
        { get; set; }

        public MyEntityListView()
        {
            AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.SystemColors.ButtonFace;
            RowTemplate.Height = 28;
            SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ReadOnly = true;
            AllowUserToAddRows = false;
            AllowUserToDeleteRows = false;
        }

        protected override void Dispose(bool disposing)
        {
            MessageBox.Show("Dispose");
            base.Dispose(disposing);
        }

        

    }
}
