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
using AgencyBusinessLayer;


namespace Agency
{
    public partial class ReportPage : Form
    {
        AgencyBusiness Agency;
        public ReportPage(AgencyBusiness AG)
        {
            InitializeComponent();
            PersianCalendar PC = new PersianCalendar();
            comboBox1.SelectedItem = PC.GetDayOfMonth(DateTime.Now).ToString();
            comboBox2.SelectedIndex = PC.GetMonth(DateTime.Now) - 1;
            comboBox3.SelectedItem = PC.GetYear(DateTime.Now).ToString();
            comboBox4.SelectedItem = comboBox3.SelectedItem;
            comboBox5.SelectedIndex = comboBox2.SelectedIndex;
            comboBox6.SelectedItem = comboBox1.SelectedItem;
            comboBox7.SelectedItem = comboBox3.SelectedItem;
            Agency = AG;
            label9.Visible = false;
            label10.Visible = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime FromDate = new DateTime(Convert.ToInt32(comboBox3.SelectedItem), Convert.ToInt32(comboBox2.SelectedIndex) + 1, Convert.ToInt32(comboBox1.SelectedItem));
            DateTime ToDate = new DateTime(Convert.ToInt32(comboBox4.SelectedItem), Convert.ToInt32(comboBox5.SelectedIndex) + 1, Convert.ToInt32(comboBox6.SelectedItem));
            DataTable dt = new DataTable();
            dt = Agency.RequestDailyReport(FromDate, ToDate);

            dt.Columns[0].ColumnName = "اپراتور";
            dt.Columns[1].ColumnName = "مبلغ شارژ";
            dt.Columns[2].ColumnName = "سریال شارژ";
            dt.Columns[3].ColumnName = "شماره پیگیری تراکنش";
            dt.Columns[4].ColumnName = "تاریخ درخواست شارژ";

            int[,] temp = new int[4, 4];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][0].ToString() == "HamrahAval")
                {
                    dt.Rows[i][0] = "همراه اول";
                    if (dt.Rows[i][1].ToString() == "1000")
                        temp[0, 0]++;
                    else if (dt.Rows[i][1].ToString() == "2000")
                        temp[0, 1]++;
                    else if (dt.Rows[i][1].ToString() == "5000")
                        temp[0, 2]++;
                    else if (dt.Rows[i][1].ToString() == "10000")
                        temp[0, 3]++;
                }
                else if (dt.Rows[i][0].ToString() == "Irancel")
                {
                    dt.Rows[i][0] = "ایرانسل";
                    if (dt.Rows[i][1].ToString() == "1000")
                        temp[1, 0]++;
                    else if (dt.Rows[i][1].ToString() == "2000")
                        temp[1, 1]++;
                    else if (dt.Rows[i][1].ToString() == "5000")
                        temp[1, 2]++;
                    else if (dt.Rows[i][1].ToString() == "10000")
                        temp[1, 3]++;
                }
                else if (dt.Rows[i][0].ToString() == "Taliya")
                {
                    dt.Rows[i][0] = "تالیا";
                    if (dt.Rows[i][1].ToString() == "1000")
                        temp[2, 0]++;
                    else if (dt.Rows[i][1].ToString() == "2000")
                        temp[2, 1]++;
                    else if (dt.Rows[i][1].ToString() == "5000")
                        temp[2, 2]++;
                    else if (dt.Rows[i][1].ToString() == "10000")
                        temp[2, 3]++;
                }
                else if (dt.Rows[i][0].ToString() == "Rightel")
                {
                    dt.Rows[i][0] = "رایتل";
                    if (dt.Rows[i][1].ToString() == "1000")
                        temp[3, 0]++;
                    else if (dt.Rows[i][1].ToString() == "2000")
                        temp[3, 1]++;
                    else if (dt.Rows[i][1].ToString() == "5000")
                        temp[3, 2]++;
                    else if (dt.Rows[i][1].ToString() == "10000")
                        temp[3, 3]++;
                }
            }


            dataGridView1.DataSource = dt;
            dataGridView1.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;

            Format_DataGridView1_OperatorName();
            Format_DataGridView1_Color();


            int hamrah_all = (temp[0, 0] * 1000) + (temp[0, 1] * 2000) + (temp[0, 2] * 5000) + (temp[0, 3] * 10000);
            int irancel_all = (temp[1, 0] * 1000) + (temp[1, 1] * 2000) + (temp[1, 2] * 5000) + (temp[1, 3] * 10000);
            int taliya_all = (temp[2, 0] * 1000) + (temp[2, 1] * 2000) + (temp[2, 2] * 5000) + (temp[2, 3] * 10000);
            int rightel_all = (temp[3, 0] * 1000) + (temp[3, 1] * 2000) + (temp[3, 2] * 5000) + (temp[3, 3] * 10000);
            int all = hamrah_all + irancel_all + taliya_all + rightel_all;
            DataTable ReportDT = new DataTable();
            ReportDT.Columns.Add("اپراتور", typeof(string));
            ReportDT.Columns.Add("1,000 تومانی", typeof(string));
            ReportDT.Columns.Add("2,000 تومانی", typeof(string));
            ReportDT.Columns.Add("5,000 تومانی", typeof(string));
            ReportDT.Columns.Add("10,000 تومانی", typeof(string));
            ReportDT.Columns.Add("مجموع دریافت", typeof(string));

            ReportDT.Rows.Add("همراه اول", (temp[0, 0] * 1000).ToString(), (temp[0, 1] * 2000).ToString(), (temp[0, 2] * 5000).ToString(), (temp[0, 3] * 10000).ToString(), hamrah_all.ToString());
            ReportDT.Rows.Add("ایرانسل", (temp[1, 0] * 1000).ToString(), (temp[1, 1] * 2000).ToString(), (temp[1, 2] * 5000).ToString(), (temp[1, 3] * 10000).ToString(), irancel_all.ToString());
            ReportDT.Rows.Add("تالیا", (temp[2, 0] * 1000).ToString(), (temp[2, 1] * 2000).ToString(), (temp[2, 2] * 5000).ToString(), (temp[2, 3] * 10000).ToString(), taliya_all.ToString());
            ReportDT.Rows.Add("رایتل", (temp[3, 0] * 1000).ToString(), (temp[3, 1] * 2000).ToString(), (temp[3, 2] * 5000).ToString(), (temp[3, 3] * 10000).ToString(), rightel_all.ToString());
            ReportDT.Rows.Add("", "", "", "", "",  all.ToString());
            dataGridView2.DataSource = ReportDT;

            dataGridView2.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView2.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView2.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView2.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView2.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView2.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    if (row.Cells[0].Value.ToString() == "همراه اول")
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(196, 236, 227);
                    }
                    else if (row.Cells[0].Value.ToString() == "ایرانسل")
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(255, 204, 0);
                    }
                    else if (row.Cells[0].Value.ToString() == "تالیا")
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(213, 24, 31);
                    }
                    else if (row.Cells[0].Value.ToString() == "رایتل")
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(153, 43, 107);
                    }
                }
            }
           
            dataGridView2.Rows[dataGridView2.Rows.Count - 1].DefaultCellStyle.BackColor = Color.SeaGreen;
            dataGridView2.Columns["مجموع دریافت"].DefaultCellStyle.BackColor = Color.SeaGreen;
            for (int i = 0; i < dataGridView2.Rows.Count; i++) {
                dataGridView2.Rows[i].Cells[dataGridView2.Columns["مجموع دریافت"].Index].Style.ApplyStyle(this.dataGridView2.Columns["مجموع دریافت"].DefaultCellStyle);
            }
           
            int height1 = dataGridView1.ColumnHeadersHeight;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                height1 += row.Height;
            }
            if (panel1.Height < 606)
                panel1.Height = height1 + 5;

            dataGridView1.Columns[0].Width = 70;
            dataGridView1.Columns[1].Width = 90;
            dataGridView1.Columns[2].Width = 120;
            dataGridView1.Columns[3].Width = 140;
            dataGridView1.Columns[4].Width = 140;

            dataGridView2.Columns[5].Width = 120;

            int height2 = dataGridView2.ColumnHeadersHeight;
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                height2 += row.Height;
            }
            panel2.Height = height2 + 5;


            label10.Text = all.ToString() + " تومان";
            label9.Visible = true;
            label10.Visible = true;
         
        }



        public void Format_DataGridView1_OperatorName()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    if (row.Cells[0].Value.ToString() == "HamrahAval")
                    {
                        row.Cells[0].Value = "همراه اول";
                    }
                    else if (row.Cells[0].Value.ToString() == "Irancel")
                    {
                        row.Cells[0].Value = "ایرانسل";
                    }
                    else if (row.Cells[0].Value.ToString() == "Taliya")
                    {
                        row.Cells[0].Value = "تالیا";
                    }
                    else if (row.Cells[0].Value.ToString() == "Rightel")
                    {
                        row.Cells[0].Value = "رایتل";
                    }
                }
            }
        }
        public void Format_DataGridView1_Color()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    if (row.Cells[0].Value.ToString() == "همراه اول")
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(196, 236, 227);
                    }
                    else if (row.Cells[0].Value.ToString() == "ایرانسل")
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(255, 204, 0);
                    }
                    else if (row.Cells[0].Value.ToString() == "تالیا")
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(213, 24, 31);
                    }
                    else if (row.Cells[0].Value.ToString() == "رایتل")
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(153, 43, 107);
                    }
                }
            }

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            else
            {
                Format_DataGridView1_Color();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable MonthReportTable = new DataTable();
            MonthReportTable.Columns.Add("ماه", typeof(string));
            MonthReportTable.Rows.Add("فروردین");
            MonthReportTable.Rows.Add("اردیبهشت");
            MonthReportTable.Rows.Add("خرداد");
            MonthReportTable.Rows.Add("تیر");
            MonthReportTable.Rows.Add("مرداد");
            MonthReportTable.Rows.Add("شهریور");
            MonthReportTable.Rows.Add("مهر");
            MonthReportTable.Rows.Add("آبان");
            MonthReportTable.Rows.Add("آذر");
            MonthReportTable.Rows.Add("دی");
            MonthReportTable.Rows.Add("بهمن");
            MonthReportTable.Rows.Add("اسفند");

            DataTable dt = new DataTable();
            dt = Agency.RequestMonthlyReport(Convert.ToInt32(comboBox7.SelectedItem));
            dt.Columns[0].ColumnName = "همراه اول";
            dt.Columns[1].ColumnName = "ایرانسل";
            dt.Columns[2].ColumnName = "تالیا";
            dt.Columns[3].ColumnName = "رایتل";


            foreach (DataColumn dc in dt.Columns)
            {
                MonthReportTable.Columns.Add(dc.ColumnName, typeof(string));
            }
            MonthReportTable.Columns.Add("مجموع قیمت", typeof(string));
            int all_year = 0;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int all_month = 0;
                foreach (DataColumn dc in dt.Columns)
                {
                    MonthReportTable.Rows[i][dc.ColumnName] = dt.Rows[i][dc.ColumnName];
                    all_month = all_month + Convert.ToInt32(MonthReportTable.Rows[i][dc.ColumnName]);
                }
                MonthReportTable.Rows[i]["مجموع قیمت"] = all_month.ToString();
                all_year = all_year + all_month;
            }
            MonthReportTable.Rows.Add("", "", "", "", "", all_year.ToString());
            dataGridView3.DataSource = MonthReportTable;
            dataGridView3.Columns["همراه اول"].DefaultCellStyle.BackColor = Color.FromArgb(196, 236, 227);
            dataGridView3.Columns["ایرانسل"].DefaultCellStyle.BackColor = Color.FromArgb(255, 204, 0);
            dataGridView3.Columns["تالیا"].DefaultCellStyle.BackColor = Color.FromArgb(213, 24, 31);
            dataGridView3.Columns["رایتل"].DefaultCellStyle.BackColor = Color.FromArgb(153, 43, 107);
            dataGridView3.Columns["مجموع قیمت"].DefaultCellStyle.BackColor = Color.SeaGreen;
            dataGridView3.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView3.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView3.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView3.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView3.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView3.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView3.Rows[dataGridView3.Rows.Count - 1].DefaultCellStyle.BackColor = Color.SeaGreen;


            int height3 = dataGridView3.ColumnHeadersHeight;
            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                height3 += row.Height;
            }
            panel3.Height = height3 + 5;
        }

    }
}
