using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Texac
{
    public partial class TempForm : Form
    {
        public TempForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Object o = listView1.SelectedItems[0].Index;
            MessageBox.Show(o.ToString());
        }
    }
}
