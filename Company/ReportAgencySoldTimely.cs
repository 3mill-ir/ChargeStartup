using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CompanyBussinesLayer;
using PersianMessageBoxComponent;
using Microsoft.Reporting.WinForms;
using System.Windows.Forms.DataVisualization.Charting;



namespace Company
{
    public partial class ReportAgencySoldTimely : Form
    {
        CompanyBusiness Company;
        public DataSet CompanyChart_DataSet;
        Int64 AgencyID;
        bool isFirstTime_Tab1;
        bool isFirstTime_Tab2;
        bool isFirstTime_Tab3;
        bool isFirstTime_Tab4;
        bool isFirstTime_Tab5;
        public ReportAgencySoldTimely(CompanyBusiness CB, Int64 AG_ID)
        {
            InitializeComponent();

            Company = CB;
            AgencyID = AG_ID;
            isFirstTime_Tab1 = true;
            isFirstTime_Tab2 = true;
            isFirstTime_Tab3 = true;
            isFirstTime_Tab4 = true;
            isFirstTime_Tab5 = true;
      
        }
       

        public void Tab1Fill()
        {

            dataGridView2.DataSource = CompanyChart_DataSet.Tables["CompanyPurchaseDaily_DT"];
            chart1.DataSource = CompanyChart_DataSet.Tables["CompanyPurchaseDaily_DT"];
            
            chart1.ChartAreas[0].AxisX.Title = "نوع شارژ";
            chart1.ChartAreas[0].AxisY.Title = "تعداد شارژ";
            if (isFirstTime_Tab1)
            {
                chart1.Series.Add("Info1");
                chart1.Series.Add("Info2");
                chart1.Series.Add("Info3");
                chart1.Series.Add("Info4");
                isFirstTime_Tab1 = false;
            }
                

            chart1.Series["Info1"].LegendText = "همراه اول";
            chart1.Series["Info1"].XValueMember = "Charge_Price_Category";
            chart1.Series["Info1"].YValueMembers = "HamrahAval";
            chart1.Series["Info1"].Color = Color.FromArgb(196, 236, 227);
            

            chart1.Series["Info2"].LegendText = "ایرانسل";
            chart1.Series["Info2"].XValueMember = "Charge_Price_Category";
            chart1.Series["Info2"].YValueMembers = "Irancel";
            chart1.Series["Info2"].Color = Color.FromArgb(255, 204, 0);

            chart1.Series["Info3"].LegendText = "تالیا";
            chart1.Series["Info3"].XValueMember = "Charge_Price_Category";
            chart1.Series["Info3"].YValueMembers = "Taliya";
            chart1.Series["Info3"].Color = Color.FromArgb(213, 24, 31);

            chart1.Series["Info4"].LegendText = "رایتل";
            chart1.Series["Info4"].XValueMember = "Charge_Price_Category";
            chart1.Series["Info4"].YValueMembers = "Rightel";
            chart1.Series["Info4"].Color = Color.FromArgb(153, 43, 107);

            chart1.Series["Info1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
             chart1.Series["Info2"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
             chart1.Series["Info3"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
             chart1.Series["Info4"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
             chart1.Series["Info1"].ToolTip = "تعداد #VALY{G} عدد شارژ";
             chart1.Series["Info2"].ToolTip = "تعداد #VALY{G} عدد شارژ";
             chart1.Series["Info3"].ToolTip = "تعداد #VALY{G} عدد شارژ";
             chart1.Series["Info4"].ToolTip = "تعداد #VALY{G} عدد شارژ";
            chart1.DataBind();
        }


        public void Tab2Fill() 
        {
            chart2.ChartAreas[0].AxisX.Title = "تاریخ";
            chart2.ChartAreas[0].AxisY.Title = "تعداد شارژ";
            chart2.DataSource = CompanyChart_DataSet;
       
            
            if (isFirstTime_Tab2) {
                chart2.Series.Add("Info1");
                chart2.Series.Add("Info2");
                chart2.Series.Add("Info3");
                chart2.Series.Add("Info4");
                isFirstTime_Tab2 = false;
            }
            

            chart2.Series["Info1"].LegendText = "1,000 تومانی";
            chart2.Series["Info1"].Color = Color.FromArgb(196, 236, 227);
            chart2.Series["Info1"].Points.DataBindXY(CompanyChart_DataSet.Tables["Hamrah_1000_DT"].DefaultView, "DateBuyed", CompanyChart_DataSet.Tables["Hamrah_1000_DT"].DefaultView, "ChargeCount");



            chart2.Series["Info2"].LegendText = "2,000 تومانی ";
            chart2.Series["Info2"].Color = Color.FromArgb(19, 236, 227);
            chart2.Series["Info2"].Points.DataBindXY(CompanyChart_DataSet.Tables["Hamrah_2000_DT"].DefaultView, "DateBuyed", CompanyChart_DataSet.Tables["Hamrah_2000_DT"].DefaultView, "ChargeCount");

            chart2.Series["Info3"].LegendText = "5,000 تومانی";
            chart2.Series["Info3"].Color = Color.FromArgb(196, 23, 227);
            chart2.Series["Info3"].Points.DataBindXY(CompanyChart_DataSet.Tables["Hamrah_5000_DT"].DefaultView, "DateBuyed", CompanyChart_DataSet.Tables["Hamrah_5000_DT"].DefaultView, "ChargeCount");



            chart2.Series["Info4"].LegendText = "10,000 تومانی ";
            chart2.Series["Info4"].Color = Color.FromArgb(196, 236, 22);
            chart2.Series["Info4"].Points.DataBindXY(CompanyChart_DataSet.Tables["Hamrah_10000_DT"].DefaultView, "DateBuyed", CompanyChart_DataSet.Tables["Hamrah_10000_DT"].DefaultView, "ChargeCount");

            chart2.Series["Info1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            chart2.Series["Info2"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            chart2.Series["Info3"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            chart2.Series["Info4"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            chart2.DataManipulator.InsertEmptyPoints(1, IntervalType.Number, "Info1, Info2,Info3,Info4");
            chart2.Series["Info1"].ToolTip = "تعداد #VALY{G} عدد شارژ";
            chart2.Series["Info2"].ToolTip = "تعداد #VALY{G} عدد شارژ";
            chart2.Series["Info3"].ToolTip = "تعداد #VALY{G} عدد شارژ";
            chart2.Series["Info4"].ToolTip = "تعداد #VALY{G} عدد شارژ";
        

            chart2.DataBind();
  
        }

        public void Tab3Fill()
        {
            chart3.ChartAreas[0].AxisX.Title = "تاریخ";
            chart3.ChartAreas[0].AxisY.Title = "تعداد شارژ";
            chart3.DataSource = CompanyChart_DataSet;
            if (isFirstTime_Tab3)
            {
                chart3.Series.Add("Info1");
                chart3.Series.Add("Info2");
                chart3.Series.Add("Info3");
                chart3.Series.Add("Info4");
                isFirstTime_Tab3 = false;
            }


            chart3.Series["Info1"].LegendText = "1,000 تومانی";
            chart3.Series["Info1"].Color = Color.FromArgb(196, 236, 227);
            chart3.Series["Info1"].Points.DataBindXY(CompanyChart_DataSet.Tables["Irancel_1000_DT"].DefaultView, "DateBuyed", CompanyChart_DataSet.Tables["Irancel_1000_DT"].DefaultView, "ChargeCount");



            chart3.Series["Info2"].LegendText = "2,000 تومانی ";
            chart3.Series["Info2"].Color = Color.FromArgb(19, 236, 227);
            chart3.Series["Info2"].Points.DataBindXY(CompanyChart_DataSet.Tables["Irancel_2000_DT"].DefaultView, "DateBuyed", CompanyChart_DataSet.Tables["Irancel_2000_DT"].DefaultView, "ChargeCount");

            chart3.Series["Info3"].LegendText = "5,000 تومانی";
            chart3.Series["Info3"].Color = Color.FromArgb(196, 23, 227);
            chart3.Series["Info3"].Points.DataBindXY(CompanyChart_DataSet.Tables["Irancel_5000_DT"].DefaultView, "DateBuyed", CompanyChart_DataSet.Tables["Irancel_5000_DT"].DefaultView, "ChargeCount");



            chart3.Series["Info4"].LegendText = "10,000 تومانی ";
            chart3.Series["Info4"].Color = Color.FromArgb(196, 236, 22);
            chart3.Series["Info4"].Points.DataBindXY(CompanyChart_DataSet.Tables["Irancel_10000_DT"].DefaultView, "DateBuyed", CompanyChart_DataSet.Tables["Irancel_10000_DT"].DefaultView, "ChargeCount");

            chart3.Series["Info1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            chart3.Series["Info2"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            chart3.Series["Info3"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            chart3.Series["Info4"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            chart3.DataManipulator.InsertEmptyPoints(1, IntervalType.Number, "Info1, Info2,Info3,Info4");
            chart3.Series["Info1"].ToolTip = "تعداد #VALY{G} عدد شارژ";
            chart3.Series["Info2"].ToolTip = "تعداد #VALY{G} عدد شارژ";
            chart3.Series["Info3"].ToolTip = "تعداد #VALY{G} عدد شارژ";
            chart3.Series["Info4"].ToolTip = "تعداد #VALY{G} عدد شارژ";
            chart3.DataBind();
        }
        public void Tab4Fill()
        {
            chart4.ChartAreas[0].AxisX.Title = "تاریخ";
            chart4.ChartAreas[0].AxisY.Title = "تعداد شارژ";
            chart4.DataSource = CompanyChart_DataSet;
            if (isFirstTime_Tab4)
            {
                chart4.Series.Add("Info1");
                chart4.Series.Add("Info2");
                chart4.Series.Add("Info3");
                chart4.Series.Add("Info4");
                isFirstTime_Tab4 = false;
            }


            chart4.Series["Info1"].LegendText = "1,000 تومانی";
            chart4.Series["Info1"].Color = Color.FromArgb(196, 236, 227);
            chart4.Series["Info1"].Points.DataBindXY(CompanyChart_DataSet.Tables["Taliya_1000_DT"].DefaultView, "DateBuyed", CompanyChart_DataSet.Tables["Taliya_1000_DT"].DefaultView, "ChargeCount");



            chart4.Series["Info2"].LegendText = "2,000 تومانی ";
            chart4.Series["Info2"].Color = Color.FromArgb(19, 236, 227);
            chart4.Series["Info2"].Points.DataBindXY(CompanyChart_DataSet.Tables["Taliya_2000_DT"].DefaultView, "DateBuyed", CompanyChart_DataSet.Tables["Taliya_2000_DT"].DefaultView, "ChargeCount");

            chart4.Series["Info3"].LegendText = "5,000 تومانی";
            chart4.Series["Info3"].Color = Color.FromArgb(196, 23, 227);
            chart4.Series["Info3"].Points.DataBindXY(CompanyChart_DataSet.Tables["Taliya_5000_DT"].DefaultView, "DateBuyed", CompanyChart_DataSet.Tables["Taliya_5000_DT"].DefaultView, "ChargeCount");



            chart4.Series["Info4"].LegendText = "10,000 تومانی ";
            chart4.Series["Info4"].Color = Color.FromArgb(196, 236, 22);
            chart4.Series["Info4"].Points.DataBindXY(CompanyChart_DataSet.Tables["Taliya_10000_DT"].DefaultView, "DateBuyed", CompanyChart_DataSet.Tables["Taliya_10000_DT"].DefaultView, "ChargeCount");

            chart4.Series["Info1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            chart4.Series["Info2"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            chart4.Series["Info3"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            chart4.Series["Info4"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            chart4.DataManipulator.InsertEmptyPoints(1, IntervalType.Number, "Info1, Info2,Info3,Info4");
            chart4.Series["Info1"].ToolTip = "تعداد #VALY{G} عدد شارژ";
            chart4.Series["Info2"].ToolTip = "تعداد #VALY{G} عدد شارژ";
            chart4.Series["Info3"].ToolTip = "تعداد #VALY{G} عدد شارژ";
            chart4.Series["Info4"].ToolTip = "تعداد #VALY{G} عدد شارژ";
            chart4.DataBind();
        }
        public void Tab5Fill()
        {
            chart5.ChartAreas[0].AxisX.Title = "تاریخ";
            chart5.ChartAreas[0].AxisY.Title = "تعداد شارژ";
            chart5.DataSource = CompanyChart_DataSet;
            if (isFirstTime_Tab5)
            {
                chart5.Series.Add("Info1");
                chart5.Series.Add("Info2");
                chart5.Series.Add("Info3");
                chart5.Series.Add("Info4");
                isFirstTime_Tab5 = false;
            }


            chart5.Series["Info1"].LegendText = "1,000 تومانی";
            chart5.Series["Info1"].Color = Color.FromArgb(196, 236, 227);
            chart5.Series["Info1"].Points.DataBindXY(CompanyChart_DataSet.Tables["Rightel_1000_DT"].DefaultView, "DateBuyed", CompanyChart_DataSet.Tables["Rightel_1000_DT"].DefaultView, "ChargeCount");



            chart5.Series["Info2"].LegendText = "2,000 تومانی ";
            chart5.Series["Info2"].Color = Color.FromArgb(19, 236, 227);
            chart5.Series["Info2"].Points.DataBindXY(CompanyChart_DataSet.Tables["Rightel_2000_DT"].DefaultView, "DateBuyed", CompanyChart_DataSet.Tables["Rightel_2000_DT"].DefaultView, "ChargeCount");

            chart5.Series["Info3"].LegendText = "5,000 تومانی";
            chart5.Series["Info3"].Color = Color.FromArgb(196, 23, 227);
            chart5.Series["Info3"].Points.DataBindXY(CompanyChart_DataSet.Tables["Rightel_5000_DT"].DefaultView, "DateBuyed", CompanyChart_DataSet.Tables["Rightel_5000_DT"].DefaultView, "ChargeCount");



            chart5.Series["Info4"].LegendText = "10,000 تومانی ";
            chart5.Series["Info4"].Color = Color.FromArgb(196, 236, 22);
            chart5.Series["Info4"].Points.DataBindXY(CompanyChart_DataSet.Tables["Rightel_10000_DT"].DefaultView, "DateBuyed", CompanyChart_DataSet.Tables["Rightel_10000_DT"].DefaultView, "ChargeCount");

            chart5.Series["Info1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            chart5.Series["Info2"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            chart5.Series["Info3"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            chart5.Series["Info4"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            chart5.DataManipulator.InsertEmptyPoints(1, IntervalType.Number, "Info1, Info2,Info3,Info4");
            chart5.Series["Info1"].ToolTip = "تعداد #VALY{G} عدد شارژ";
            chart5.Series["Info2"].ToolTip = "تعداد #VALY{G} عدد شارژ";
            chart5.Series["Info3"].ToolTip = "تعداد #VALY{G} عدد شارژ";
            chart5.Series["Info4"].ToolTip = "تعداد #VALY{G} عدد شارژ";
            chart5.DataBind();
        }
        public void Tab6Fill() {

            dataGridView1.DataSource = CompanyChart_DataSet.Tables["WholeData_DT"];


        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(faDatePicker1.SelectedDateTime.ToString());
            DateTime MinDate=new DateTime(1900,1,1);
            DateTime MaxDate=new DateTime(2100,1,1);
            DateTime Date = faDatePicker1.SelectedDateTime;

                        CompanyChart_DataSet = Company.TimeBase_AgencySoldDaily(Date,AgencyID);
                        Tab1Fill();
                        Tab2Fill();
                        Tab3Fill();
                        Tab4Fill();
                        Tab5Fill();
                        Tab6Fill();
                   
             


        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReportCompanypurchaseDaily_PrintPage RCPD_PP = new ReportCompanypurchaseDaily_PrintPage(CompanyChart_DataSet.Tables["WholeData_DT"]);
            RCPD_PP.Show();
        }



    

        //private void tabPage2_Click(object sender, EventArgs e)
        //{
        //    DateTime BeginDate = DateTime.Now; DateTime EndDate = DateTime.Now;

        //    MessageBox.Show(Company.NumberOfCompanyPurchasedCharge( BeginDate,  EndDate).Rows[0][1].ToString());

        //    //reportViewer1.LocalReport.DataSources.Clear(); //clear report
        //    //reportViewer1.LocalReport.ReportEmbeddedResource = "Company.ReportOnCompanyPurchaseDaily.rdlc";
        //    //Microsoft.Reporting.WinForms.ReportDataSource dataset = new Microsoft.Reporting.WinForms.ReportDataSource("CompanyPurchaseDailyDS", Company.NumberOfCompanyPurchasedCharge( BeginDate,  EndDate)); // set the datasource

        //    //reportViewer1.LocalReport.DataSources.Add(dataset);
        //    //reportViewer1.LocalReport.Refresh();
        //    //this.reportViewer1.RefreshReport();
        //}

     



    }
}
