using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Texac.ToolingDesign
{
    public partial class JobOrderPrintForm : Form
    {
        private List<JobOrderReportDetail> _allDetails;

        public JobOrderPrintForm()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        public List<JobOrderReportMaster> CreateTestData()
        {
            var result = new List<JobOrderReportMaster>();
            var random = new Random();

            for (int orderIndex = 1; orderIndex <= 3; orderIndex++)
            {
                var order = new JobOrderReportMaster
                {
                    OrderId = orderIndex,
                    OrderNumber = $"ORD-2026-00{orderIndex}",
                    OrderDate = DateTime.Today.AddDays(-orderIndex),
                    TotalQuantity = 0
                };

                int materialsCount = random.Next(7, 11); // 7–10 материалов
                materialsCount += 30;
                for (int i = 1; i <= materialsCount; i++)
                {
                    var qty = Math.Round(random.NextDouble() * 10 + 1, 2);

                    var material = new JobOrderReportDetail
                    {
                        OrderId = order.OrderId,
                        MaterialId = i,
                        MaterialTitle = $"Материал {i}",
                        Unit = "шт",
                        Quantity = qty,
                        Description = $"Описание материала {i} для заказа {order.OrderNumber}"
                    };

                    order.Materials.Add(material);
                    order.TotalQuantity += (int)qty;
                }

                result.Add(order);
            }

            return result;
        }

        private void JobOrderPrintForm_Load(object sender, EventArgs e)
        {
            var masters = CreateTestData();
            _allDetails = masters.SelectMany(x => x.Materials).ToList();
            
            reportViewer1.LocalReport.DataSources.Clear();

            reportViewer1.LocalReport.DataSources.Add(
                new ReportDataSource("MasterDataSet", masters));

            reportViewer1.LocalReport.SubreportProcessing += LocalReport_SubreportProcessing;
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);

            reportViewer1.RefreshReport();

        }

        private void LocalReport_SubreportProcessing(object sender, SubreportProcessingEventArgs e)
        {
            int orderId = Convert.ToInt32(e.Parameters["OrderId"].Values[0]);

            var detailsForOrder = _allDetails
                .Where(d => d.OrderId == orderId)
                .ToList();

            e.DataSources.Add(
                new ReportDataSource("DetailDataSet", detailsForOrder));
        }
    }
}
