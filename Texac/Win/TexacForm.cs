using System.Windows.Forms;

namespace Texac.Win
{
    public class TexacForm : Form
    {
        protected override void OnLoad(System.EventArgs e)
        {
            base.OnLoad(e);
            UiStateManager.Restore(this);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            UiStateManager.Save(this);
            base.OnFormClosing(e);
        }
    }
}