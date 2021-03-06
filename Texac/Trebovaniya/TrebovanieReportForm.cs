﻿using Microsoft.Reporting.WinForms;
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

            dataDataSet.TrebovanieRow row = (dataDataSet.TrebovanieRow)ds.Trebovanie.Rows[0];
            
            ReportParameter[] parameters = new ReportParameter[9];
            parameters[0] = new ReportParameter("parDocNumber", row.DocNumber.ToString());
            parameters[1] = new ReportParameter("parDocDate", row.DocDate.ToShortDateString());
            parameters[2] = new ReportParameter("parSclad", row.Sclad.ToString());

            if (zatreboval == "")
                zatreboval = "Нач. бюро Остапук В.П.";
            if (poluchil == "")
                poluchil = "мастер Бацук А.Г.";

            parameters[3] = new ReportParameter("parPerson1", poluchil);
            parameters[4] = new ReportParameter("parPerson2", zatreboval);
            parameters[5] = new ReportParameter("parPerson3", poluchil);

            parameters[6] = new ReportParameter("parId", row.TrebovanieId.ToString());

            if(row.IsOrderIdNull())
                parameters[7] = new ReportParameter("parOrderId", "");
            else
                parameters[7] = new ReportParameter("parOrderId", row.OrderId.ToString());

            if (row.IsOrderNumberNull())
            {
                if (row.IsNЦехаNull() == false)
                {
                    if (row.NЦеха == 70)
                        parameters[8] = new ReportParameter("parOrderNumber", "23/1");
                    else
                        parameters[8] = new ReportParameter("parOrderNumber", "25");
                } else
                    parameters[8] = new ReportParameter("parOrderNumber", "");
            }
            else
                parameters[8] = new ReportParameter("parOrderNumber", row.OrderNumber);

            this.reportViewer1.LocalReport.SetParameters(parameters);

            taTrebovanieDetails.FillByIdWithGroup(ds.TrebovanieDetails, trebovanieId);

            int c = ds.TrebovanieDetails.Rows.Count;
            
            while (c < 8)
            {
                //dataDataSet.TrebovanieDetailsRow r = (dataDataSet.TrebovanieDetailsRow)ds.TrebovanieDetails.NewRow();
                ds.TrebovanieDetails.AddTrebovanieDetailsRow((dataDataSet.TrebovanieDetailsRow)ds.TrebovanieDetails.NewRow());
                c++;
            }

            reportViewer1.RefreshReport();
        }
    }
}
