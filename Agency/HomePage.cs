using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgencyBusinessLayer;
using System.Drawing.Drawing2D;
using PersianMessageBoxComponent;
using System.Globalization;

namespace Agency
{
    public partial class HomePage : Form
    {
        AgencyBusiness Agency;
        ConfirmPage CP;
        ReportPage RP;
        int AG_Credit;
        int AG_Credit_Balance;
        public HomePage(AgencyBusiness AG)
        {
            InitializeComponent();
            Agency = AG;

            FormFill();
            
        }
        private void FormFill(){
            string CreditInfo = Agency.CheckAgencyCredit();
            string[] info = CreditInfo.Split(',');
            AG_Credit_Balance = int.Parse(info[0]);
            AG_Credit = int.Parse(info[1]);


            label1.Text = "مشترک گرامی اعتبار شما جهت خرید شارژ در این دوره " + FormatInteger(info[0]) + " تومان است.";
            label2.Text = "مشترک گرامی اعتبار باقیمانده شما در این دوره " + FormatInteger(info[1]) + " تومان است.";
            if (AG_Credit > 0)
                label2.BackColor = Color.Red;
            else {
                label2.BackColor = Color.LightGreen;
            }
        }
        private string FormatInteger(string  info) {
            string result = info;
            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalDigits = 0;
            result = Decimal.Parse(info, NumberStyles.AllowThousands).ToString("N", nfi);
            return result;
        }
        private void RequestCharge(string operatorname,string category){
            if (AG_Credit > 0)
            {
                CP = new ConfirmPage(operatorname, category, Agency);
                CP.ShowDialog();
                FormFill();
            }
            else {
                PersianMessageBox pmb = new PersianMessageBox();
                pmb.show("مشترک گرامی اعتبار شما جهت خرید شارژ کافی نمی باشد. لطفاً اعتبار خود را تمدید نمایید.", "هشدار", PersianMessageBox.Warning, 1, "OK");
            
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RequestCharge("H", "1");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RequestCharge("H", "2");
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RequestCharge("H", "5");
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RequestCharge("H", "10");
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RequestCharge("I", "1");
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RequestCharge("I", "2");
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RequestCharge("I", "5");
        
        }

        private void button8_Click(object sender, EventArgs e)
        {
            RequestCharge("I", "10");
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            RequestCharge("T", "1");
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
            RequestCharge("T", "2");
           
        }

        private void button11_Click(object sender, EventArgs e)
        {
            RequestCharge("T", "5");
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            RequestCharge("T", "10");
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            RequestCharge("R", "1");
          
        }

        private void button14_Click(object sender, EventArgs e)
        {
            RequestCharge("R", "2");
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            RequestCharge("R", "5");
           
        }

        private void button16_Click(object sender, EventArgs e)
        {
            RequestCharge("R", "10");
           
        }

       

        private void HomePage_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                              Color.WhiteSmoke,
                                                              Color.SlateGray,
                                                              90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            AgencyChangePassword ACP = new AgencyChangePassword(Agency);
            ACP.ShowDialog();
        }

        private void HomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Agency.AgencyLogOut();
            Application.Exit();
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.Image = Properties.Resources.calendar_dailyclick;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Image = Properties.Resources.calendar_dailynorm;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ReportAgencySoldTimely RAST = new ReportAgencySoldTimely(Agency);
            RAST.Show();
        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            pictureBox7.Image = Properties.Resources.calendar_monthlyclick;
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.Image = Properties.Resources.calendar_monthlynorm;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            ReportAgencySoldDaily RASD = new ReportAgencySoldDaily(Agency);
            RASD.Show();
        }

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            pictureBox8.Image = Properties.Resources.calendar_yearlyclick;
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.Image = Properties.Resources.calendar_yearlynorm;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            ReportAgencySoldMonthly RASM = new ReportAgencySoldMonthly(Agency);
            RASM.Show();
        }

       

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            panel1.BackColor = Color.SlateGray;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(196, 236, 227);
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(196, 236, 227);
            panel1.BackColor = Color.SlateGray;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(196, 236, 227);
            panel1.BackColor = Color.SlateGray;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Transparent;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(196, 236, 227);
            panel1.BackColor = Color.SlateGray;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.Transparent;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(196, 236, 227);
            panel1.BackColor = Color.SlateGray;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.Transparent;
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            panel2.BackColor = Color.SlateGray;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(255, 204, 0);
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.Lock_Green;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.Lock_Red;
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackColor = Color.FromArgb(255, 204, 0);
            panel2.BackColor = Color.SlateGray;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.Transparent;
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button6.BackColor = Color.FromArgb(255, 204, 0);
            panel2.BackColor = Color.SlateGray;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackColor = Color.Transparent;
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            button7.BackColor = Color.FromArgb(255, 204, 0);
            panel2.BackColor = Color.SlateGray;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.BackColor = Color.Transparent;
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            button8.BackColor = Color.FromArgb(255, 204, 0);
            panel2.BackColor = Color.SlateGray;
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.BackColor = Color.Transparent;
        }

        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            panel3.BackColor = Color.SlateGray;
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            panel3.BackColor = Color.FromArgb(213, 24, 31);
        }

        private void button9_MouseEnter(object sender, EventArgs e)
        {
            button9.BackColor = Color.FromArgb(213, 24, 31);
            panel3.BackColor = Color.SlateGray;
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            button9.BackColor = Color.Transparent;
        }

        private void button10_MouseEnter(object sender, EventArgs e)
        {
            button10.BackColor = Color.FromArgb(213, 24, 31);
            panel3.BackColor = Color.SlateGray;
        }

        private void button10_MouseLeave(object sender, EventArgs e)
        {
            button10.BackColor = Color.Transparent;
        }

        private void button11_MouseEnter(object sender, EventArgs e)
        {
            button11.BackColor = Color.FromArgb(213, 24, 31);
            panel3.BackColor = Color.SlateGray;
        }

        private void button11_MouseLeave(object sender, EventArgs e)
        {
            button11.BackColor = Color.Transparent;
        }

        private void button12_MouseEnter(object sender, EventArgs e)
        {
            button12.BackColor = Color.FromArgb(213, 24, 31);
            panel3.BackColor = Color.SlateGray;
        }

        private void button12_MouseLeave(object sender, EventArgs e)
        {
            button12.BackColor = Color.Transparent;
        }

        private void panel4_MouseEnter(object sender, EventArgs e)
        {
            panel4.BackColor = Color.SlateGray;
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = Color.FromArgb(153, 43, 107);
        }

        private void button13_MouseEnter(object sender, EventArgs e)
        {
            button13.BackColor = Color.FromArgb(153, 43, 107);
            panel4.BackColor = Color.SlateGray;
        }

        private void button13_MouseLeave(object sender, EventArgs e)
        {
            button13.BackColor = Color.Transparent;
        }

        private void button14_MouseEnter(object sender, EventArgs e)
        {
            button14.BackColor = Color.FromArgb(153, 43, 107);
            panel4.BackColor = Color.SlateGray;
        }

        private void button14_MouseLeave(object sender, EventArgs e)
        {
            button14.BackColor = Color.Transparent;
        }

        private void button15_MouseEnter(object sender, EventArgs e)
        {
            button15.BackColor = Color.FromArgb(153, 43, 107);
            panel4.BackColor = Color.SlateGray;
        }

        private void button15_MouseLeave(object sender, EventArgs e)
        {
            button15.BackColor = Color.Transparent;
        }

        private void button16_MouseEnter(object sender, EventArgs e)
        {
            button16.BackColor = Color.FromArgb(153, 43, 107);
            panel4.BackColor = Color.SlateGray;
        }

        private void button16_MouseLeave(object sender, EventArgs e)
        {
            button16.BackColor = Color.Transparent;
        }

    }
}
