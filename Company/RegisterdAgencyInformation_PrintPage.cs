﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Company
{
    public partial class RegisterdAgencyInformation_PrintPage : Form
    {
        DataTable Printint_DT;
        public RegisterdAgencyInformation_PrintPage(DataTable dt)
        {
            InitializeComponent();
            Printint_DT = dt;
        }

        private void RegisterdAgencyInformation_PrintPage_Load(object sender, EventArgs e)
        {

            reportViewer1.LocalReport.DataSources.Clear(); //clear report
            reportViewer1.LocalReport.ReportEmbeddedResource = "Company.RegisterdAgencyInformation_PrintTemplate.rdlc";
            Microsoft.Reporting.WinForms.ReportDataSource dataset = new Microsoft.Reporting.WinForms.ReportDataSource("RegisterdInformationDS", Printint_DT); // set the datasource

            reportViewer1.LocalReport.DataSources.Add(dataset);
            reportViewer1.LocalReport.Refresh();
            //System.Drawing.Printing.PageSettings pg = new System.Drawing.Printing.PageSettings();
            //pg.Margins.Top = 0;
            //pg.Margins.Bottom = 0;
            //pg.Margins.Left = 0;
            //pg.Margins.Right = 0;
            //System.Drawing.Printing.PaperSize size = new PaperSize();
            //size.RawKind = (int)PaperKind.A5;
            //pg.PaperSize = size;
            //reportViewer1.SetPageSettings(pg);
            reportViewer1.RefreshReport();
        }
    }
}
