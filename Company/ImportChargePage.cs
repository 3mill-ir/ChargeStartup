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
    public partial class ImportChargePage : Form
    {
        CompanyBusiness Company;
        String OperatorName;
        String Operatorname_Persian;
        public ImportChargePage(CompanyBusiness CB, string ON)
        {
            InitializeComponent();
            Company = CB;
            OperatorName = ON;
            comboBox1.SelectedIndex = 0;
            FormFill();
        }

        public void FormFill()
        {


            if (OperatorName == "HamrahAval")
            {
                pictureBox1.Image = Properties.Resources.Hamraheaval_logo;
                this.BackColor = Color.FromArgb(196, 236, 227);
                this.Text = "بسته شارژ همرا اول";
                Operatorname_Persian = "همراه اول";
            }
            else if (OperatorName == "Irancel")
            {
                pictureBox1.Image = Properties.Resources.Irancell_logo;
                this.BackColor = Color.FromArgb(255, 204, 0);
                this.Text = "بسته شارژ ایرانسل";
                Operatorname_Persian = "ایرانسل";
            }
            else if (OperatorName == "Taliya")
            {
                pictureBox1.Image = Properties.Resources.Taliya_logo;
                this.BackColor = Color.FromArgb(213, 24, 31);
                this.Text = "بسته شارژ تالیا";
                Operatorname_Persian = "تالیا";
            }
            else if (OperatorName == "Rightel")
            {
                pictureBox1.Image = Properties.Resources.Rightel_logo;
                this.BackColor = Color.FromArgb(153, 43, 107);
                this.Text = "بسته شارژ رایتل";
                Operatorname_Persian = "رایتل";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool result = false;
            string cate_str = comboBox1.SelectedItem.ToString().Replace(" تومانی", string.Empty);

            int cate_int = int.Parse(cate_str.Replace(",", string.Empty));

            string buyed_str = textBox2.Text.Replace(",", string.Empty);
            int buyed_int=int.Parse(buyed_str);

            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text))
            {

                openFileDialog1.Title = "انتخاب بسته شارژ " + Operatorname_Persian;
                openFileDialog1.Filter = "Excel files|*.xlsx";
                openFileDialog1.InitialDirectory = @"C:\";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    result=Company.ImportChargeFromExcelToStore(openFileDialog1.FileName.ToString(),
OperatorName,cate_int,textBox1.Text,buyed_int,DateTime.Now);
                    PersianMessageBox pmb = new PersianMessageBox();
                    pmb.show("عملیات انتقال شارژ به سرور با موفقیت انجام شد", "اطلاع", PersianMessageBox.Information, 1, "OK");
                }

            }
            else
            {

                PersianMessageBox pmb = new PersianMessageBox();
                pmb.show("لطفاً نام شرکت تهیکننده بسته شارژی و قیمت خرید را وارد نمایید.", "هشدار", PersianMessageBox.Warning, 1, "OK");

            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo language = new System.Globalization.CultureInfo("fa-ir");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(language);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox2.Text))
            {
                NumberFormatInfo nfi = new NumberFormatInfo();
                nfi.NumberDecimalDigits = 0;
                textBox2.Text = Decimal.Parse(textBox2.Text,NumberStyles.AllowThousands).ToString("N", nfi);
                textBox2.Select(textBox2.Text.Length, 0);
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
