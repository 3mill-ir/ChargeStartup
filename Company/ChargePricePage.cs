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
using System.Globalization;

namespace Company
{

    public partial class ChargePricePage : Form
    {
        CompanyBusiness Company;

        public ChargePricePage(CompanyBusiness CB)
        {
            InitializeComponent();
            Company = CB;

            FormFil();
        }

        public void FormFil()
        {
            Company.RetriveChargeSetting();
            textBox1.Text = Company.Hamrah_1000_Price.ToString();
            textBox2.Text = Company.Hamrah_2000_Price.ToString();
            textBox3.Text = Company.Hamrah_5000_Price.ToString();
            textBox4.Text = Company.Hamrah_10000_Price.ToString();

            textBox5.Text = Company.Irancel_1000_Price.ToString();
            textBox6.Text = Company.Irancel_2000_Price.ToString();
            textBox7.Text = Company.Irancel_5000_Price.ToString();
            textBox8.Text = Company.Irancel_10000_Price.ToString();


            textBox9.Text = Company.Taliya_1000_Price.ToString();
            textBox10.Text = Company.Taliya_2000_Price.ToString();
            textBox11.Text = Company.Taliya_5000_Price.ToString();
            textBox12.Text = Company.Taliya_10000_Price.ToString();


            textBox13.Text = Company.Rightel_1000_Price.ToString();
            textBox14.Text = Company.Rightel_2000_Price.ToString();
            textBox15.Text = Company.Rightel_5000_Price.ToString();
            textBox16.Text = Company.Rightel_10000_Price.ToString();

            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckStatues())
            {
                if (checkiFCanAccept())
                {
                    PersianMessageBox pmb = new PersianMessageBox();
                    if (pmb.show("آیا میخواهید تمامی تغییرات را ذخیره نمایید؟", "اطمینان", PersianMessageBox.Question, 2, "YES/NO"))
                    {

                        CompleteChargePriceSetting();
                        FormFil();
                        button2.Enabled = false;
                    }
                }
                else
                {
                    PersianMessageBox pmb = new PersianMessageBox();
                    pmb.show("لطفاً قیمت فروش تمامی شارژها را وارد نمایید", "هشدار", PersianMessageBox.Warning, 1, "OK");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersianMessageBox pmb = new PersianMessageBox();
            if (pmb.show("آیا میخواهید تمامی تغییرات را به حالت اولیه بازگردانید؟", "اطمینان", PersianMessageBox.Question, 2, "YES/NO"))
            {
                FormFil();
                button2.Enabled = false;
                textBox1.BackColor = Color.White;
                textBox2.BackColor = Color.White;
                textBox3.BackColor = Color.White;
                textBox4.BackColor = Color.White;

                textBox5.BackColor = Color.White;
                textBox6.BackColor = Color.White;
                textBox7.BackColor = Color.White;
                textBox8.BackColor = Color.White;

                textBox9.BackColor = Color.White;
                textBox10.BackColor = Color.White;
                textBox11.BackColor = Color.White;
                textBox12.BackColor = Color.White;

                textBox13.BackColor = Color.White;
                textBox14.BackColor = Color.White;
                textBox15.BackColor = Color.White;
                textBox16.BackColor = Color.White;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (CheckStatues())
            {
                PersianMessageBox pmb = new PersianMessageBox();
                if (pmb.show("تغییرات شما ذخیره نشده است ایا مایل به ذخیره تغییرات هستید؟", "اطمینان", PersianMessageBox.Question, 2, "YES/NO"))
                {
                    if (checkiFCanAccept())
                    {
                        CompleteChargePriceSetting();
                        Close();
                    }
                    else {
                        PersianMessageBox pmbnew = new PersianMessageBox();
                        pmbnew.show("لطفاً قیمت فروش تمامی شارژها را وارد نمایید", "هشدار", PersianMessageBox.Warning, 1, "OK");
                    }
                }
                else
                {
                    Close();
                }

            }
            else
            {
                Close();
            }
        }

        private void CompleteChargePriceSetting()
        {
            Company.Hamrah_1000_Price = int.Parse(textBox1.Text.Replace(",", string.Empty));
            Company.Hamrah_2000_Price = int.Parse(textBox2.Text.Replace(",", string.Empty));
            Company.Hamrah_5000_Price = int.Parse(textBox3.Text.Replace(",", string.Empty));
            Company.Hamrah_10000_Price = int.Parse(textBox4.Text.Replace(",", string.Empty));


            Company.Irancel_1000_Price = int.Parse(textBox5.Text.Replace(",", string.Empty));
            Company.Irancel_2000_Price = int.Parse(textBox6.Text.Replace(",", string.Empty));
            Company.Irancel_5000_Price = int.Parse(textBox7.Text.Replace(",", string.Empty));
            Company.Irancel_10000_Price = int.Parse(textBox8.Text.Replace(",", string.Empty));


            Company.Taliya_1000_Price = int.Parse(textBox9.Text.Replace(",", string.Empty));
            Company.Taliya_2000_Price = int.Parse(textBox10.Text.Replace(",", string.Empty));
            Company.Taliya_5000_Price = int.Parse(textBox11.Text.Replace(",", string.Empty));
            Company.Taliya_10000_Price = int.Parse(textBox12.Text.Replace(",", string.Empty));


            Company.Rightel_1000_Price = int.Parse(textBox13.Text.Replace(",", string.Empty));
            Company.Rightel_2000_Price = int.Parse(textBox14.Text.Replace(",", string.Empty));
            Company.Rightel_5000_Price = int.Parse(textBox15.Text.Replace(",", string.Empty));
            Company.Rightel_10000_Price = int.Parse(textBox16.Text.Replace(",", string.Empty));

            Company.SaveChargeSetting();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                NumberFormatInfo nfi = new NumberFormatInfo();
                nfi.NumberDecimalDigits = 0;
                textBox1.Text = Decimal.Parse(textBox1.Text, NumberStyles.AllowThousands).ToString("N", nfi);
                textBox1.Select(textBox1.Text.Length, 0);

                if (textBox1.Text.Replace(",", string.Empty) != Company.Hamrah_1000_Price.ToString())
                {
                    textBox1.BackColor = Color.LightGray;
                    button2.Enabled = true;
                }
                else
                {
                    textBox1.BackColor = Color.White;
                    button2.Enabled = CheckStatues();
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox2.Text))
            {
                NumberFormatInfo nfi = new NumberFormatInfo();
                nfi.NumberDecimalDigits = 0;
                textBox2.Text = Decimal.Parse(textBox2.Text, NumberStyles.AllowThousands).ToString("N", nfi);
                textBox2.Select(textBox2.Text.Length, 0);

                if (textBox2.Text.Replace(",", string.Empty) != Company.Hamrah_2000_Price.ToString())
                {
                    textBox2.BackColor = Color.LightGray;
                    button2.Enabled = true;
                }
                else
                {
                    textBox2.BackColor = Color.White;
                    button2.Enabled = CheckStatues();
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox3.Text))
            {
                NumberFormatInfo nfi = new NumberFormatInfo();
                nfi.NumberDecimalDigits = 0;
                textBox3.Text = Decimal.Parse(textBox3.Text, NumberStyles.AllowThousands).ToString("N", nfi);
                textBox3.Select(textBox3.Text.Length, 0);
                if (textBox3.Text.Replace(",", string.Empty) != Company.Hamrah_5000_Price.ToString())
                {
                    textBox3.BackColor = Color.LightGray;
                    button2.Enabled = true;
                }
                else
                {
                    textBox3.BackColor = Color.White;
                    button2.Enabled = CheckStatues();
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox4.Text))
            {
                NumberFormatInfo nfi = new NumberFormatInfo();
                nfi.NumberDecimalDigits = 0;
                textBox4.Text = Decimal.Parse(textBox4.Text, NumberStyles.AllowThousands).ToString("N", nfi);
                textBox4.Select(textBox4.Text.Length, 0);
                if (textBox4.Text.Replace(",", string.Empty) != Company.Hamrah_10000_Price.ToString())
                {
                    textBox4.BackColor = Color.LightGray;
                    button2.Enabled = true;

                }
                else
                {
                    textBox4.BackColor = Color.White;
                    button2.Enabled = CheckStatues();
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox5.Text))
            {
                NumberFormatInfo nfi = new NumberFormatInfo();
                nfi.NumberDecimalDigits = 0;
                textBox5.Text = Decimal.Parse(textBox5.Text, NumberStyles.AllowThousands).ToString("N", nfi);
                textBox5.Select(textBox5.Text.Length, 0);
                if (textBox5.Text.Replace(",", string.Empty) != Company.Irancel_1000_Price.ToString())
                {
                    textBox5.BackColor = Color.LightGray;
                    button2.Enabled = true;
                }
                else
                {
                    textBox5.BackColor = Color.White;
                    button2.Enabled = CheckStatues();
                }
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox6.Text))
            {
                NumberFormatInfo nfi = new NumberFormatInfo();
                nfi.NumberDecimalDigits = 0;
                textBox6.Text = Decimal.Parse(textBox6.Text, NumberStyles.AllowThousands).ToString("N", nfi);
                textBox6.Select(textBox6.Text.Length, 0);
                if (textBox6.Text.Replace(",", string.Empty) != Company.Irancel_2000_Price.ToString())
                {
                    textBox6.BackColor = Color.LightGray;
                    button2.Enabled = true;
                }
                else
                {
                    textBox6.BackColor = Color.White;
                    button2.Enabled = CheckStatues();
                }
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox7.Text))
            {
                NumberFormatInfo nfi = new NumberFormatInfo();
                nfi.NumberDecimalDigits = 0;
                textBox7.Text = Decimal.Parse(textBox7.Text, NumberStyles.AllowThousands).ToString("N", nfi);
                textBox7.Select(textBox7.Text.Length, 0);
                if (textBox7.Text.Replace(",", string.Empty) != Company.Irancel_5000_Price.ToString())
                {
                    textBox7.BackColor = Color.LightGray;
                    button2.Enabled = true;
                }
                else
                {
                    textBox7.BackColor = Color.White;
                    button2.Enabled = CheckStatues();
                }
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox8.Text))
            {
                NumberFormatInfo nfi = new NumberFormatInfo();
                nfi.NumberDecimalDigits = 0;
                textBox8.Text = Decimal.Parse(textBox8.Text, NumberStyles.AllowThousands).ToString("N", nfi);
                textBox8.Select(textBox8.Text.Length, 0);
                if (textBox8.Text.Replace(",", string.Empty) != Company.Irancel_10000_Price.ToString())
                {
                    textBox8.BackColor = Color.LightGray;
                    button2.Enabled = true;
                }
                else
                {
                    textBox8.BackColor = Color.White;
                    button2.Enabled = CheckStatues();
                }
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox9.Text))
            {
                NumberFormatInfo nfi = new NumberFormatInfo();
                nfi.NumberDecimalDigits = 0;
                textBox9.Text = Decimal.Parse(textBox9.Text, NumberStyles.AllowThousands).ToString("N", nfi);
                textBox9.Select(textBox9.Text.Length, 0);
                if (textBox9.Text.Replace(",", string.Empty) != Company.Taliya_1000_Price.ToString())
                {
                    textBox9.BackColor = Color.LightGray;
                    button2.Enabled = true;
                }
                else
                {
                    textBox9.BackColor = Color.White;
                    button2.Enabled = CheckStatues();
                }
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox10.Text))
            {
                NumberFormatInfo nfi = new NumberFormatInfo();
                nfi.NumberDecimalDigits = 0;
                textBox10.Text = Decimal.Parse(textBox10.Text, NumberStyles.AllowThousands).ToString("N", nfi);
                textBox10.Select(textBox10.Text.Length, 0);
                if (textBox10.Text.Replace(",", string.Empty) != Company.Taliya_2000_Price.ToString())
                {
                    textBox10.BackColor = Color.LightGray;
                    button2.Enabled = true;
                }
                else
                {
                    textBox10.BackColor = Color.White;
                    button2.Enabled = CheckStatues();
                }
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox11.Text))
            {
                NumberFormatInfo nfi = new NumberFormatInfo();
                nfi.NumberDecimalDigits = 0;
                textBox11.Text = Decimal.Parse(textBox11.Text, NumberStyles.AllowThousands).ToString("N", nfi);
                textBox11.Select(textBox11.Text.Length, 0);
                if (textBox11.Text != Company.Taliya_5000_Price.ToString())
                {
                    textBox11.BackColor = Color.LightGray;
                    button2.Enabled = true;
                }
                else
                {
                    textBox11.BackColor = Color.White;
                    button2.Enabled = CheckStatues();
                }
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox12.Text))
            {
                NumberFormatInfo nfi = new NumberFormatInfo();
                nfi.NumberDecimalDigits = 0;
                textBox12.Text = Decimal.Parse(textBox12.Text, NumberStyles.AllowThousands).ToString("N", nfi);
                textBox12.Select(textBox12.Text.Length, 0);
                if (textBox12.Text.Replace(",", string.Empty) != Company.Taliya_10000_Price.ToString())
                {
                    textBox12.BackColor = Color.LightGray;
                    button2.Enabled = true;
                }
                else
                {
                    textBox12.BackColor = Color.White;
                    button2.Enabled = CheckStatues();
                }
            }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox13.Text))
            {
                NumberFormatInfo nfi = new NumberFormatInfo();
                nfi.NumberDecimalDigits = 0;
                textBox13.Text = Decimal.Parse(textBox13.Text, NumberStyles.AllowThousands).ToString("N", nfi);
                textBox13.Select(textBox13.Text.Length, 0);
                if (textBox13.Text.Replace(",", string.Empty) != Company.Rightel_1000_Price.ToString())
                {
                    textBox13.BackColor = Color.LightGray;
                    button2.Enabled = true;
                }
                else
                {
                    textBox13.BackColor = Color.White;
                    button2.Enabled = CheckStatues();
                }
            }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox14.Text))
            {
                NumberFormatInfo nfi = new NumberFormatInfo();
                nfi.NumberDecimalDigits = 0;
                textBox14.Text = Decimal.Parse(textBox14.Text, NumberStyles.AllowThousands).ToString("N", nfi);
                textBox14.Select(textBox14.Text.Length, 0);
                if (textBox14.Text.Replace(",", string.Empty) != Company.Rightel_2000_Price.ToString())
                {
                    textBox14.BackColor = Color.LightGray;
                    button2.Enabled = true;
                }
                else
                {
                    textBox14.BackColor = Color.White;
                    button2.Enabled = CheckStatues();
                }
            }
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox15.Text))
            {
                NumberFormatInfo nfi = new NumberFormatInfo();
                nfi.NumberDecimalDigits = 0;
                textBox15.Text = Decimal.Parse(textBox15.Text, NumberStyles.AllowThousands).ToString("N", nfi);
                textBox15.Select(textBox15.Text.Length, 0);
                if (textBox15.Text.Replace(",", string.Empty) != Company.Rightel_5000_Price.ToString())
                {
                    textBox15.BackColor = Color.LightGray;
                    button2.Enabled = true;
                }
                else
                {
                    textBox15.BackColor = Color.White;
                    button2.Enabled = CheckStatues();
                }
            }
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox16.Text))
            {
                NumberFormatInfo nfi = new NumberFormatInfo();
                nfi.NumberDecimalDigits = 0;
                textBox16.Text = Decimal.Parse(textBox16.Text, NumberStyles.AllowThousands).ToString("N", nfi);
                textBox16.Select(textBox16.Text.Length, 0);
                if (textBox16.Text.Replace(",", string.Empty) != Company.Rightel_10000_Price.ToString())
                {
                    textBox16.BackColor = Color.LightGray;
                    button2.Enabled = true;
                }
                else
                {
                    textBox16.BackColor = Color.White;
                    button2.Enabled = CheckStatues();
                }
            }
        }



        private void textBoxes_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private bool CheckStatues()
        {
            bool result = false;

            if (textBox1.Text.Replace(",", string.Empty) != Company.Hamrah_1000_Price.ToString())
                result = true;
            else if (textBox2.Text.Replace(",", string.Empty) != Company.Hamrah_2000_Price.ToString())
                result = true;
            else if (textBox3.Text.Replace(",", string.Empty) != Company.Hamrah_5000_Price.ToString())
                result = true;
            else if (textBox4.Text.Replace(",", string.Empty) != Company.Hamrah_10000_Price.ToString())
                result = true;
            else if (textBox5.Text.Replace(",", string.Empty) != Company.Irancel_1000_Price.ToString())
                result = true;
            else if (textBox6.Text.Replace(",", string.Empty) != Company.Irancel_2000_Price.ToString())
                result = true;
            else if (textBox7.Text.Replace(",", string.Empty) != Company.Irancel_5000_Price.ToString())
                result = true;
            else if (textBox8.Text.Replace(",", string.Empty) != Company.Irancel_10000_Price.ToString())
                result = true;
            else if (textBox9.Text.Replace(",", string.Empty) != Company.Taliya_1000_Price.ToString())
                result = true;
            else if (textBox10.Text.Replace(",", string.Empty) != Company.Taliya_2000_Price.ToString())
                result = true;
            else if (textBox11.Text.Replace(",", string.Empty) != Company.Taliya_5000_Price.ToString())
                result = true;
            else if (textBox12.Text.Replace(",", string.Empty) != Company.Taliya_10000_Price.ToString())
                result = true;
            else if (textBox13.Text.Replace(",", string.Empty) != Company.Rightel_1000_Price.ToString())
                result = true;
            else if (textBox14.Text.Replace(",", string.Empty) != Company.Rightel_2000_Price.ToString())
                result = true;
            else if (textBox15.Text.Replace(",", string.Empty) != Company.Rightel_5000_Price.ToString())
                result = true;
            else if (textBox16.Text.Replace(",", string.Empty) != Company.Rightel_10000_Price.ToString())
                result = true;



            return result;
        }

        private void ChargePricePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Company.SaveChargeSetting();
        }


        private bool checkiFCanAccept()
        {

            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox3.Text) && !string.IsNullOrWhiteSpace(textBox4.Text) && !string.IsNullOrWhiteSpace(textBox5.Text) && !string.IsNullOrWhiteSpace(textBox6.Text) && !string.IsNullOrWhiteSpace(textBox7.Text) && !string.IsNullOrWhiteSpace(textBox8.Text) && !string.IsNullOrWhiteSpace(textBox9.Text) && !string.IsNullOrWhiteSpace(textBox10.Text) && !string.IsNullOrWhiteSpace(textBox11.Text) && !string.IsNullOrWhiteSpace(textBox12.Text) && !string.IsNullOrWhiteSpace(textBox13.Text) && !string.IsNullOrWhiteSpace(textBox14.Text) && !string.IsNullOrWhiteSpace(textBox15.Text) && !string.IsNullOrWhiteSpace(textBox16.Text))
            {
                return true;
            }
            else
                return false;

        }
    }
}
