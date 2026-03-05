using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Texac.Net
{
    public static class UiApi
    {
        public static async Task<T> SafeCall<T>(Func<Task<T>> action, string title = "Ошибка")
        {
            try
            {
                return await action();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(T);
            }
        }

        public static async Task SafeCall(Func<Task> action, string title = "Ошибка")
        {
            try
            {
                await action();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}