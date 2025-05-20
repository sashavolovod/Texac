using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace Texac
{
    public partial class TrebovanieReportForm : MyForm
    {
        Int32 trebovanieId;
        string zatreboval;
        string poluchil;
        public TrebovanieReportForm(Int32 trebovanieId, string zatreboval, string poluchil)
        {
            this.trebovanieId = trebovanieId;
            this.zatreboval = zatreboval;
            this.poluchil = poluchil;
            InitializeComponent();
        }

        private void TrebovanieReportForm_Load(object sender, EventArgs e)
        {
            taTrebovanie.FillById(ds.Trebovanie, trebovanieId);
            taTrebovanieDetails.FillById(ds.TrebovanieDetails, trebovanieId);

            dataDataSet1.TrebovanieRow row = (dataDataSet1.TrebovanieRow)ds.Trebovanie.Rows[0];
            
            ReportParameter[] parameters = new ReportParameter[13];
            parameters[0] = new ReportParameter("parDocNumber", row.DocNumber.ToString());
            parameters[1] = new ReportParameter("parDocDate", row.DocDate.ToShortDateString());
            parameters[2] = new ReportParameter("parSclad", row.Sclad.ToString());

            if(row.IsRecipientNull())
                parameters[3] = new ReportParameter("parRecipient", "");
            else
                parameters[3] = new ReportParameter("parRecipient", row.Recipient);

            if(row.IsCustomerNull())
                parameters[4] = new ReportParameter("parCustomer", "");
            else
                parameters[4] = new ReportParameter("parCustomer", row.Customer);

            parameters[5] = new ReportParameter("parId", row.TrebovanieId.ToString());

            if(row.IsOrderIdNull())
                parameters[6] = new ReportParameter("parOrderId", "");
            else
                parameters[6] = new ReportParameter("parOrderId", row.OrderId.ToString());

            if(row.IsCostCodeNull())
                parameters[7] = new ReportParameter("parCostCode", "");
            else
                parameters[7] = new ReportParameter("parCostCode", row.CostCode);

            if (row.IsOsnovanieNull())
                parameters[8] = new ReportParameter("parOsnovanie", "");
            else
            {
                if(row.IsDescriptionNull())
                    parameters[8] = new ReportParameter("parOsnovanie", row.Osnovanie);
                else
                    parameters[8] = new ReportParameter("parOsnovanie", row.Osnovanie + ", " + row.Description);
            }

            if (row.IsRecipientPostNull())
                parameters[9] = new ReportParameter("parRecipientPost", "");
            else
                parameters[9] = new ReportParameter("parRecipientPost", row.RecipientPost);

            if (row.IsCustomerPostNull())
                parameters[10] = new ReportParameter("parCustomerPost", "");
            else
                parameters[10] = new ReportParameter("parCustomerPost", row.CustomerPost);

            if (row.IsWorkshopCodeNull())
                parameters[11] = new ReportParameter("parWorkshopCode", "");
            else
                parameters[11] = new ReportParameter("parWorkshopCode", row.WorkshopCode);

            if (row.IsDescriptionNull())
                parameters[12] = new ReportParameter("parDescription", "");
            else
                parameters[12] = new ReportParameter("parDescription", row.Description);

            reportViewer1.LocalReport.SetParameters(parameters);
            taTrebovanieDetails.FillByIdWithGroup(ds.TrebovanieDetails, trebovanieId);
            /*
            int c = ds.TrebovanieDetails.Rows.Count;
            while (c < 8)
            {
                ds.TrebovanieDetails.AddTrebovanieDetailsRow((dataDataSet1.TrebovanieDetailsRow)ds.TrebovanieDetails.NewRow());
                c++;
            }
            */
            reportViewer1.RefreshReport();
        }
    }
}
