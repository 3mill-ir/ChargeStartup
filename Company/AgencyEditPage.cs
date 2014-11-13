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
    public partial class AgencyEditPage : Form
    {
        CompanyBusiness Company;
        DataTable dt;
        bool ValidEmail;

        public AgencyEditPage(CompanyBusiness CB, Int64 username)
        {
            InitializeComponent();
            Company = CB;
            dt = new DataTable();
            dt = Company.GetAgencyInformation(username);
            FormFill();

        }

        public void FormFill()
        {
            textBox1.Text = dt.Rows[0]["AG_FirstName"].ToString();
            textBox2.Text = dt.Rows[0]["AG_Lastname"].ToString();
            textBox3.Text = dt.Rows[0]["AG_fatherName"].ToString();
            textBox4.Text = dt.Rows[0]["AG_CertificateCode"].ToString();
            textBox5.Text = dt.Rows[0]["AG_CertificatePlace"].ToString();
            textBox6.Text = dt.Rows[0]["AG_Email"].ToString();
            textBox7.Text = dt.Rows[0]["AG_HomePostalCode"].ToString();
            textBox8.Text = dt.Rows[0]["AG_StoreName"].ToString();
            textBox9.Text = dt.Rows[0]["AG_CreditBalance"].ToString();
            textBox10.Text = dt.Rows[0]["AG_StoreTellNumber"].ToString();
            textBox11.Text = dt.Rows[0]["AG_HomeAddress"].ToString();
            textBox12.Text = dt.Rows[0]["AG_StoreAddress"].ToString();

            maskedTextBox1.Text = dt.Rows[0]["AG_BirthDate"].ToString();
            maskedTextBox2.Text = dt.Rows[0]["AG_ID"].ToString();
            maskedTextBox3.Text = dt.Rows[0]["AG_MobileNumber"].ToString();

            comboBox1.SelectedIndex = comboBox1.FindStringExact(dt.Rows[0]["AG_Gender"].ToString());
            comboBox3.SelectedIndex = comboBox3.FindStringExact(dt.Rows[0]["AG_StoreType"].ToString());


            if (dt.Rows[0]["AG_Statues"].ToString() == "True")
            {
                comboBox2.SelectedIndex = comboBox2.FindStringExact("فعال");

            }
            else
            {
                comboBox2.SelectedIndex = comboBox2.FindStringExact("غیر فعال");

            }


            PersianCalendar PC = new PersianCalendar();

            DateTime signupDate = new DateTime();
            signupDate = DateTime.Parse(dt.Rows[0]["AG_SignupDate"].ToString());
            string signupdate_str = String.Format("{0}/{1}/{2}    {3}", PC.GetYear(signupDate), PC.GetMonth(signupDate), PC.GetDayOfMonth(signupDate), signupDate.ToShortTimeString());
            signupdate_str=signupdate_str.Replace("AM", "صبح");
            signupdate_str=signupdate_str.Replace("PM", "عصر");
            label37.Text = signupdate_str;

          
            DateTime lasteditedDate = new DateTime();
            lasteditedDate = DateTime.Parse(dt.Rows[0]["AG_LastEditedDate"].ToString());
            string lastediteddate_str = String.Format("{0}/{1}/{2}    {3}", PC.GetYear(lasteditedDate), PC.GetMonth(lasteditedDate), PC.GetDayOfMonth(lasteditedDate), lasteditedDate.ToShortTimeString());
            lastediteddate_str=lastediteddate_str.Replace("AM", "صبح");
            lastediteddate_str=lastediteddate_str.Replace("PM", "عصر");
            label39.Text = lastediteddate_str;

            label40.Text = dt.Rows[0]["AG_LastEditedBy"].ToString();

            if (!Company.User_isOperator)
            {
                textBox13.Text = dt.Rows[0]["AG_Password"].ToString();
            }
            else {
                textBox13.Text = "قابل مشاهده برای مدیر";
                textBox13.Enabled = false;
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
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
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
            if (string.IsNullOrWhiteSpace(textBox8.Text))
            {
                textBox8.BackColor = Color.Red;
                result = false;
            }
            else
            {
                textBox8.BackColor = Color.White;

            }
            //*************************************************



            //**********************************************
            if (string.IsNullOrWhiteSpace(textBox9.Text))
            {
                textBox9.BackColor = Color.Red;
                result = false;
            }
            else
            {
                textBox9.BackColor = Color.White;

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
            if (string.IsNullOrWhiteSpace(textBox12.Text))
            {
                textBox12.BackColor = Color.Red;
                result = false;
            }
            else
            {
                textBox12.BackColor = Color.White;

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
                string tempPass;
                if (Company.User_isOperator)
                {
                    tempPass = dt.Rows[0]["AG_Password"].ToString();
                }
                else { 
                    tempPass=textBox13.Text;
                }
                

                string username_str = maskedTextBox2.Text.Replace("-", string.Empty);
                Int64 username_int = Int64.Parse(username_str);

                string creditbalance_str = textBox9.Text.Replace(",", string.Empty);
                int creditbalance_int = int.Parse(creditbalance_str);

                bool statues;
                if (comboBox2.SelectedItem.ToString() == "فعال")
                {
                    statues = true;
                }
                else {
                    statues = false;
                }
                DateTime signupdate = DateTime.Parse(dt.Rows[0]["AG_SignupDate"].ToString());

                if (Company.EditAgencyInformation(username_int, tempPass, textBox1.Text, textBox2.Text, textBox3.Text, comboBox1.SelectedItem.ToString(), maskedTextBox1.Text, textBox4.Text, textBox5.Text, maskedTextBox3.Text, textBox6.Text, textBox7.Text, textBox11.Text, textBox8.Text, creditbalance_int, textBox10.Text, comboBox3.SelectedItem.ToString(), textBox12.Text, signupdate, DateTime.Now, Company.UserID,statues))
                {
                    PersianMessageBox pmb = new PersianMessageBox();
                    pmb.show("عملیات ویرایش اطلاعات واحد با موفقیت انجام شد.", "موفقیت", PersianMessageBox.Information, 1, "OK");
                }
                else
                {
                    PersianMessageBox pmb = new PersianMessageBox();
                    pmb.show("مشکل در ویرایش اطلاعات.", "خطا", PersianMessageBox.Error, 1, "OK");
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
