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
    public partial class OperatorShowPage : Form
    {
        CompanyBusiness Company;
        DataTable dt;
        bool ValidEmail;
        bool InfoChanged;
        Int64 SA_ID;

        public OperatorShowPage(CompanyBusiness CB, Int64 username)
        {
            InitializeComponent();
            Company = CB;
          
            SA_ID = username;
            dt = new DataTable();
            dt = Company.GetOperatorInformation(SA_ID);
            FormFill();
            InfoChanged = false;
        }

        public void FormFill()
        {
            textBox1.Text = dt.Rows[0]["SA_FirstName"].ToString();
            textBox2.Text = dt.Rows[0]["SA_Lastname"].ToString();
            textBox3.Text = dt.Rows[0]["SA_fatherName"].ToString();
            textBox4.Text = dt.Rows[0]["SA_CertificateCode"].ToString();
            textBox5.Text = dt.Rows[0]["SA_CertificatePlace"].ToString();
            textBox6.Text = dt.Rows[0]["SA_Email"].ToString();
            textBox7.Text = dt.Rows[0]["SA_HomePostalCode"].ToString();
            textBox11.Text = dt.Rows[0]["SA_HomeAddress"].ToString();

            maskedTextBox1.Text = dt.Rows[0]["SA_BirthDate"].ToString();
            maskedTextBox2.Text = dt.Rows[0]["SA_ID"].ToString();
            maskedTextBox3.Text = dt.Rows[0]["SA_MobileNumber"].ToString();

            comboBox1.SelectedIndex = comboBox1.FindStringExact(dt.Rows[0]["SA_Gender"].ToString());
            


            if (dt.Rows[0]["SA_Statues"].ToString() == "True")
            {
                comboBox2.SelectedIndex = comboBox2.FindStringExact("فعال");

            }
            else
            {
                comboBox2.SelectedIndex = comboBox2.FindStringExact("غیر فعال");

            }


            PersianCalendar PC = new PersianCalendar();

            DateTime signupDate = new DateTime();
            signupDate = DateTime.Parse(dt.Rows[0]["SA_SignupDate"].ToString());
            string signupdate_str = String.Format("{0}/{1}/{2}    {3}", PC.GetYear(signupDate), PC.GetMonth(signupDate), PC.GetDayOfMonth(signupDate), signupDate.ToShortTimeString());
            signupdate_str = signupdate_str.Replace("AM", "صبح");
            signupdate_str = signupdate_str.Replace("PM", "عصر");
            label37.Text = signupdate_str;


            DateTime lasteditedDate = new DateTime();
            lasteditedDate = DateTime.Parse(dt.Rows[0]["SA_LastEditedDate"].ToString());
            string lastediteddate_str = String.Format("{0}/{1}/{2}    {3}", PC.GetYear(lasteditedDate), PC.GetMonth(lasteditedDate), PC.GetDayOfMonth(lasteditedDate), lasteditedDate.ToShortTimeString());
            lastediteddate_str = lastediteddate_str.Replace("AM", "صبح");
            lastediteddate_str = lastediteddate_str.Replace("PM", "عصر");
            label39.Text = lastediteddate_str;

            label40.Text = dt.Rows[0]["SA_LastEditedBy"].ToString();

            if (!Company.User_isOperator)
            {
                textBox13.Text = dt.Rows[0]["SA_Password"].ToString();
            }
            else
            {
                textBox13.Text = "قابل مشاهده برای مدیر";
                textBox13.Enabled = false;
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
            if (!InfoChanged)
            {
                panel1.Enabled = false;
                panel2.Enabled = false;
                panel3.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = true;
                InfoChanged = false;
                return;

            }
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
                    tempPass = dt.Rows[0]["SA_Password"].ToString();
                }
                else
                {
                    tempPass = textBox13.Text;
                }


                string username_str = maskedTextBox2.Text.Replace("-", string.Empty);
                Int64 username_int = Int64.Parse(username_str);

               

                bool statues;
                if (comboBox2.SelectedItem.ToString() == "فعال")
                {
                    statues = true;
                }
                else
                {
                    statues = false;
                }

                DateTime signupdate = DateTime.Parse(dt.Rows[0]["SA_SignupDate"].ToString());

                if (Company.EditOperatorInformation(username_int, tempPass, textBox1.Text, textBox2.Text, textBox3.Text, comboBox1.SelectedItem.ToString(), maskedTextBox1.Text, textBox4.Text, textBox5.Text, maskedTextBox3.Text, textBox6.Text, textBox7.Text, textBox11.Text, signupdate, DateTime.Now, Company.UserID, statues))
                {
                    PersianMessageBox pmb = new PersianMessageBox();
                    pmb.show("عملیات ویرایش اطلاعات اپراتور با موفقیت انجام شد.", "موفقیت", PersianMessageBox.Information, 1, "OK");
                }
                else
                {
                    PersianMessageBox pmb = new PersianMessageBox();
                    pmb.show("مشکل در ویرایش اطلاعات.", "خطا", PersianMessageBox.Error, 1, "OK");
                }


                panel1.Enabled = false;
                panel2.Enabled = false;
                panel3.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = true;
                InfoChanged = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (InfoChanged)
            {
                PersianMessageBox pmb = new PersianMessageBox();
                if (pmb.show("آیا مایل به لغو عملیات ویرایش اطلاعات هستید؟", "بستن پنجره", PersianMessageBox.Question, 2, "YES/NO"))
                {
                    panel1.Enabled = false;
                    panel2.Enabled = false;
                    panel3.Enabled = false;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = true;

                    dt = new DataTable();
                    dt = Company.GetOperatorInformation(SA_ID);
                    FormFill();
                    InfoChanged = false;

                }
                else
                {

                    return;
                }
            }
            else
            {
                panel1.Enabled = false;
                panel2.Enabled = false;
                panel3.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = true;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            panel2.Enabled = true;
            panel3.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = false;
            InfoChanged = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (InfoChanged)
            {
                PersianMessageBox pmb = new PersianMessageBox();
                if (pmb.show("آیا مایل به بستن پنجره و لغو عملیات ویرایش اطلاعات هستید؟", "بستن پنجره", PersianMessageBox.Question, 2, "YES/NO"))
                {
                    Close();
                }
                else
                {
                    FormFill();
                    return;
                }
            }
            Close();
        }

        public void Text_Changed(object sender, EventArgs e)
        {

            InfoChanged = true;

        }
    }
}
