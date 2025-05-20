using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Threading;
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
            try
            {
                // проверка обновления программы
               // if (Environment.MachineName.Equals("WIN7X64") == false)
               //     getUpdate();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Application.Run(new MaterialDesign.MainForm());

            //Application.Run(new TempForm());

           


            //Application.Run(new Temp.ListForm());


           //********* Application.Run(new MigratorForm());


            //Application.Run(new RashodParametersForm());
            //Application.Run(new TrebovanieForm(1));

            //Application.Run(new AddTrebovaniyaForm());

            //openOrderForm();

            //Application.Run(new Analize.AnalizeForm());
        }

        static void openOrderForm()
        {
            RestClient.RestClient db = new RestClient.RestClient();
            Order order = db.getEntyty<Order>(88500);
            Application.Run(new OrderForm(order));
        }
        public static void Cmd(string line)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = $"/c {line} ",
                WindowStyle = ProcessWindowStyle.Hidden,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false
            });
        }

        static async void getUpdate()
        {
            String updateServerUrl = "http://172.16.2.114:8888";
            var currentVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString(2);
            var executableFileNamePath = Assembly.GetEntryAssembly().Location;
            var executableFileName = Path.GetFileName(executableFileNamePath);

            Directory.SetCurrentDirectory(AppContext.BaseDirectory);
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var response = await client.GetAsync($"{updateServerUrl}/texac/version.txt");
                    var readVersion = await response.Content.ReadAsStringAsync();
                    readVersion = readVersion.TrimEnd(Environment.NewLine.ToCharArray());
                    if (Convert.ToDouble(currentVersion, CultureInfo.InvariantCulture) < Convert.ToDouble(readVersion, CultureInfo.InvariantCulture))
                    {
                        using (var stream = await client.GetStreamAsync($"{updateServerUrl}/texac/{executableFileName}"))
                        using (var file = new FileStream("new.exe", FileMode.Create))
                            await stream.CopyToAsync(file);
                        string cmd = $"taskkill /f /im \"{executableFileName}\" && timeout /t 2 && del \"{executableFileNamePath}\" && move /y new.exe \"{executableFileName}\" && \"{executableFileNamePath}\" ";
                        Cmd(cmd);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("getUpdate(): " +ex.Message);
                    return;
                }
            }
        }
    }
}
