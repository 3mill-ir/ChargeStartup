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
using System.Drawing.Drawing2D;


namespace Agency
{
    public partial class LoginPage : Form
    {
        HomePage homepg;
        AgencyBusiness Agency;


        public LoginPage()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text) )
            {
                Agency = new AgencyBusiness();
                

                Int64 userID;
                if (Int64.TryParse(textBox1.Text, out userID))
                {
                    if (Agency.IsValidAgency(userID, textBox2.Text))
                    {
                        this.Hide();
                        homepg = new HomePage(Agency);
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
            //                                                Color.WhiteSmoke,
            //                                                Color.SlateGray,
            //                                                90F))
            //{
            //    e.Graphics.FillRectangle(brush, this.ClientRectangle);
            //}
 
        }

        private void LoginPage_Paint(object sender, PaintEventArgs e)
        {
            //using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
            //                                                Color.Gray,
            //                                                Color.SlateGray,
            //                                                90F))
            //{
            //    e.Graphics.FillRectangle(brush, this.ClientRectangle);
            //}
        }

        
    }
}
