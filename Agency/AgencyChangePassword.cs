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
using PersianMessageBoxComponent;


namespace Agency
{
    public partial class AgencyChangePassword : Form
    {
       
        AgencyBusiness Agency;


        public AgencyChangePassword(AgencyBusiness AG)
        {
            InitializeComponent();
            Agency = AG;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox3.Text))
            {
                if (Agency.AgencyPassword == textBox1.Text)
                {
                    if (textBox2.Text == textBox3.Text)
                    {
                        if (Agency.AgencyChangePassword(textBox2.Text, textBox3.Text))
                        {
                            PersianMessageBox pmb = new PersianMessageBox();
                            pmb.show("کلمه عبور با موفقیت تغییر کرد.", "موفقیت", PersianMessageBox.Information, 1, "OK");
                        }
                        else
                        {
                            PersianMessageBox pmb = new PersianMessageBox();
                            pmb.show("مشکلی در تغییر کلمه عبور پیش آمده است جهت اطلاعات بیشتر با پشتیبانی تماس بگیرید.", "خطا", PersianMessageBox.Information, 1, "OK");
                        }
                    }
                    else
                    {
                        PersianMessageBox pmb = new PersianMessageBox();
                        pmb.show("کلمه عبور جدید با یکدیگر همخوانی ندارند.", "هشدار", PersianMessageBox.Warning, 1, "OK");
                    }
                }
                else
                {
                    PersianMessageBox pmb = new PersianMessageBox();
                    pmb.show("کلمه عبور قبلی اشتباه است.", "هشدار", PersianMessageBox.Warning, 1, "OK");
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox2.Text))
            {
                if (textBox2.Text != textBox3.Text)
                    textBox3.BackColor = Color.Red;
                else
                    textBox3.BackColor = Color.White;
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox3.Text))
            {
                if (textBox2.Text != textBox3.Text)
                    textBox3.BackColor = Color.Red;
                else
                    textBox3.BackColor = Color.White;
            }
        }
    }
}
