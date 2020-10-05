using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Texac.Domain;
using Texac.Orders;
using Texac.Trebovaniya;

namespace Texac
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new MaterialDesign.MainForm());

            Application.Run(new MainForm());

            //Application.Run(new MigratorForm());


            //Application.Run(new RashodParametersForm());
            //Application.Run(new TrebovanieForm(1));

            //Application.Run(new AddTrebovaniyaForm());

            //openOrderForm();
        }

        static void openOrderForm()
        {
            RestClient.RestClient db = new RestClient.RestClient();
            Order order = db.getEntyty<Order>(88500);
            Application.Run(new OrderForm(order));
        }
    }
}
