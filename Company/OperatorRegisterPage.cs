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
using System.Globalization;
using PersianMessageBoxComponent;
using System.Text.RegularExpressions;

namespace Company
{
    public partial class OperatorRegisterPage : Form
    {
        CompanyBusiness Company;
        bool ValidEmail;
        public OperatorRegisterPage(CompanyBusiness CB)
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            
            Company = CB;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(textBox6.Text) && !IsValidEmail(textBox6.Text))
            {
                textBox6.BackColor = Color.Red;
                PersianMessageBox pmb = new PersianMessageBox();
                pmb.show("ایمیل وارد شده معتبر نمی باشد.", "خطا", PersianMessageBox.Error, 1, "OK");
                return;

            }
            else if (!string.IsNullOrWhiteSpace(textBox6.Text) && IsValidEmail(textBox6.Text))
            {
                textBox6.BackColor = Color.White;
            }
            else if (string.IsNullOrWhiteSpace(textBox6.Text))
            {
                textBox6.BackColor = Color.White;
            }


            if (isAllFieldCompleted() && isValidBirthdate())
            {
                string tempPass = Company.GetUniqueKey(10);

                string username_str = maskedTextBox2.Text.Replace("-", string.Empty);
                Int64 username_int = Int64.Parse(username_str);

               ;


               if (Company.AddNewOperator(username_int, tempPass, textBox1.Text, textBox2.Text, textBox3.Text, comboBox1.SelectedItem.ToString(), maskedTextBox1.Text, textBox4.Text, textBox5.Text, maskedTextBox3.Text, textBox6.Text, textBox7.Text, textBox11.Text, DateTime.Now, DateTime.Now, Company.UserID, true))
               {
                   PersianMessageBox pmb = new PersianMessageBox();
                   pmb.show("عملیات ثبت نام اپراتور جدید با موفقیت انجام شد.", "موفقیت", PersianMessageBox.Information, 1, "OK");
               }
               else
               {
                   PersianMessageBox pmb = new PersianMessageBox();
                   pmb.show("مشکل در ثبت نام اپراتور جدید.", "خطا", PersianMessageBox.Error, 1, "OK");
               }

            }

        }







        public void ChangeLanguageTo_persian(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo language = new System.Globalization.CultureInfo("fa-ir");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(language);
        }
        public void ChangelanguageTo_English(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo language = new System.Globalization.CultureInfo("en-us");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(language);

        }



        private bool isAllFieldCompleted()
        {
            bool result = true;

            //**********************************************
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.BackColor = Color.Red;
                result = false;
            }
            else
            {
                textBox1.BackColor = Color.White;
               
            }
            //*************************************************

            //**********************************************
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.BackColor = Color.Red;
                result = false;
            }
            else
            {
                textBox2.BackColor = Color.White;
                
            }
            //*************************************************


            //**********************************************
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                textBox3.BackColor = Color.Red;
                result = false;
            }
            else
            {
                textBox3.BackColor = Color.White;
               
            }
            //*************************************************

            //**********************************************
            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                textBox4.BackColor = Color.Red;
                result = false;
            }
            else
            {
                textBox4.BackColor = Color.White;
                
            }
            //*************************************************


            //**********************************************
            if (string.IsNullOrWhiteSpace(textBox5.Text))
            {
                textBox5.BackColor = Color.Red;
                result = false;
            }
            else
            {
                textBox5.BackColor = Color.White;
                
            }
            //*************************************************








            //**********************************************
            if (string.IsNullOrWhiteSpace(textBox11.Text))
            {
                textBox11.BackColor = Color.Red;
                result = false;
            }
            else
            {
                textBox11.BackColor = Color.White;
               
            }
            //*************************************************




            //**********************************************
            if (!maskedTextBox1.MaskCompleted)
            {
                maskedTextBox1.BackColor = Color.Red;
                result = false;
            }
            else
            {
                maskedTextBox1.BackColor = Color.White;
              
            }
            //*************************************************

            //**********************************************
            if (!maskedTextBox2.MaskCompleted)
            {
                maskedTextBox2.BackColor = Color.Red;
                result = false;
            }
            else
            {
                maskedTextBox2.BackColor = Color.White;
                
            }
            //*************************************************

            //**********************************************
            if (!maskedTextBox3.MaskCompleted)
            {
                maskedTextBox3.BackColor = Color.Red;
                result = false;
            }
            else
            {
                maskedTextBox3.BackColor = Color.White;
               
            }
            //*************************************************


            if (!result)
            {
                PersianMessageBox pmb = new PersianMessageBox();
                pmb.show("لطفاً تمامی فیلدهایی که با ستاره مشخص شده اند را پر کنید.", "هشدار", PersianMessageBox.Warning, 1, "OK");

            }

            return result;

        }

        private bool isValidBirthdate()
        {

            string[] words = maskedTextBox1.Text.Split('/');
            PersianCalendar PC = new PersianCalendar();
            bool isleapyear = false;
            if (PC.IsLeapYear(int.Parse(words[2])))
            {
                isleapyear = true;
               
            }
            else
            {
                isleapyear = false;
            }

            if ((int.Parse(words[2]) > 0 && int.Parse(words[1]) > 0 && int.Parse(words[0]) > 0) && ((int.Parse(words[1]) >= 7 && int.Parse(words[1]) <= 11 && int.Parse(words[0]) <= 30) || (int.Parse(words[1]) <= 6 && int.Parse(words[1]) >= 0 && int.Parse(words[0]) <= 31) || (isleapyear == true && int.Parse(words[1]) == 12 && int.Parse(words[0]) <= 30) || (isleapyear == false && int.Parse(words[1]) == 12 && int.Parse(words[0]) <= 29)))
            {

                return true;
            }
            else
            {
                PersianMessageBox pmb = new PersianMessageBox();
                pmb.show("تاریخ تولد اشتباه است.", "خطا", PersianMessageBox.Error, 1, "OK");
                return false;
            }
        }



        public bool IsValidEmail(string email)
        {
            ValidEmail = false;
            if (String.IsNullOrEmpty(email))
                return false;


            try
            {
                email = Regex.Replace(email, @"(@)(.+)$", this.DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }

            if (ValidEmail)
                return false;


            try
            {
                return Regex.IsMatch(email,
                      @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                      @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                      RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
        private string DomainMapper(Match match)
        {

            IdnMapping idn = new IdnMapping();

            string domainName = match.Groups[2].Value;
            try
            {
                domainName = idn.GetAscii(domainName);
            }
            catch (ArgumentException)
            {
                ValidEmail = true;
            }
            return match.Groups[1].Value + domainName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
