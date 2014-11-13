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

namespace Agency
{
    public partial class ConfirmPage : Form
    {
        AgencyBusiness Agency;
        string OperatorName;
        string Category;
        string temp_op;
        string temp_cat;

        public ConfirmPage(string Op, string Cat, AgencyBusiness AG)
        {
            InitializeComponent();
            Agency = AG;
            OperatorName = Op;
            Category = Cat;
          

            switch (Op)
            {
                case "H":
                    temp_op = "همراه اول";
                    this.BackColor = Color.FromArgb(196, 236, 227);
                    pictureBox1.Image = Properties.Resources.Hamraheaval_logo;
                    break;
                case "I":
                    temp_op = "ایرانسل";
                    this.BackColor = Color.FromArgb(255, 204, 0);
                    pictureBox1.Image = Properties.Resources.Irancell_logo;
                    break;
                case "T":
                    temp_op = "تالیا";
                    this.BackColor = Color.FromArgb(213, 24, 31);
                    pictureBox1.Image = Properties.Resources.Taliya_logo;
                    break;
                case "R":
                    temp_op = "رایتل";
                    this.BackColor = Color.FromArgb(153, 43, 107);
                    pictureBox1.Image = Properties.Resources.Rightel_logo;
                    break;
            }
            switch (Cat)
            {
                case "1":
                    temp_cat = "1,000 تومانی";
                    break;
                case "2":
                    temp_cat = "2,000 تومانی";
                    break;
                case "5":
                    temp_cat = "5,000 تومانی";
                    break;
                case "10":
                    temp_cat = "10,000 تومانی";
                    break;
            }
            comboBox1.SelectedIndex = 0;
            string temp = "";
            temp = "   مایل به خرید و چاپ                         شارژ ";
            temp = temp + temp_cat;
            temp = temp + " از ";
            temp = temp + temp_op;
            temp = temp + " هستید؟";
            richTextBox1.Text = temp;
            richTextBox1.Select(richTextBox1.Text.IndexOf(temp_cat), temp_cat.Length);
            richTextBox1.SelectionColor = Color.Red;

            richTextBox1.Select(richTextBox1.Text.IndexOf(temp_op), temp_op.Length); ;

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ChargeAmount;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    ChargeAmount = 1;
                    break;
                case 1:
                    ChargeAmount = 2;
                    break;
                case 2:
                    ChargeAmount = 3;
                    break;
                case 3:
                    ChargeAmount = 4;
                    break;
                case 4:
                    ChargeAmount = 5;
                    break;
                default:
                    ChargeAmount = 1;
                    break;
            }

            DataSet tempDS = Agency.RequestCharge(OperatorName, Category, ChargeAmount, temp_op, temp_cat);

            ChargePrint RP = new ChargePrint(tempDS);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
