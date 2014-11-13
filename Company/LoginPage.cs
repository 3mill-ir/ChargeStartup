using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CompanyBussinesLayer;
using PersianMessageBoxComponent;


namespace Company
{
    public partial class LoginPage : Form
    {
        HomePage homepg;
        CompanyBusiness Company;


        public LoginPage()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text) )
            {
                Company = new CompanyBusiness();
  
                bool isOperator = false;

                if (comboBox1.SelectedItem.ToString() == "اپراتور")
                    isOperator = true;
                else
                    isOperator = false;

                Int64 userID;
                if (Int64.TryParse(textBox1.Text, out userID))
                {
                    if (Company.IsValidUser(userID, textBox2.Text, isOperator))
                    {
                        this.Hide();
                        homepg = new HomePage(Company);
                        homepg.Show();
                    }
                    else
                    {
                        PersianMessageBox pmb = new PersianMessageBox();
                        pmb.show("نام کاربری یا کلمه عبور اشتباه است.", "خطا", PersianMessageBox.Error, 1, "OK");
                    }
                }
                else {
                    PersianMessageBox pmb = new PersianMessageBox();
                    pmb.show("نام کاربری یا کلمه عبور اشتباه است.", "خطا", PersianMessageBox.Error, 1, "OK");
                }
            }
            else
            {
                PersianMessageBox pmb = new PersianMessageBox();
                pmb.show("لطفاً تمامی فیلدهای خالی را پر کنید.", "هشدار", PersianMessageBox.Warning, 1, "OK");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
