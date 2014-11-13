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

namespace Company
{
    public partial class ChargeCapacityOnFrontStore : Form
    {
        CompanyBusiness Company;


        public ChargeCapacityOnFrontStore(CompanyBusiness CB)
        {
            InitializeComponent();
            Company = CB;
            DoubleBuffered = true;
            FormFill();
        }

        public void FormFill()
        {
            Company.RetriveChargeSetting();
            Company.RetriveNumberOfChargeIn_FrontStore();


            trackBar1.Minimum = Company.Hamrah_1000_FrontStore;
            trackBar2.Minimum = Company.Hamrah_2000_FrontStore;
            trackBar3.Minimum = Company.Hamrah_5000_FrontStore;
            trackBar4.Minimum = Company.Hamrah_10000_FrontStore;

            trackBar5.Minimum = Company.Irancel_1000_FrontStore;
            trackBar6.Minimum = Company.Irancel_2000_FrontStore;
            trackBar7.Minimum = Company.Irancel_5000_FrontStore;
            trackBar8.Minimum = Company.Irancel_10000_FrontStore;

            trackBar9.Minimum = Company.Taliya_1000_FrontStore;
            trackBar10.Minimum = Company.Taliya_2000_FrontStore;
            trackBar11.Minimum = Company.Taliya_5000_FrontStore;
            trackBar12.Minimum = Company.Taliya_10000_FrontStore;

            trackBar13.Minimum = Company.Rightel_1000_FrontStore;
            trackBar14.Minimum = Company.Rightel_2000_FrontStore;
            trackBar15.Minimum = Company.Rightel_5000_FrontStore;
            trackBar16.Minimum = Company.Rightel_10000_FrontStore;
        


            label7.Text = Company.Hamrah_1000_FrontStore_Capacity.ToString();
            label9.Text = Company.Hamrah_2000_FrontStore_Capacity.ToString();
            label11.Text = Company.Hamrah_5000_FrontStore_Capacity.ToString();
            label14.Text = Company.Hamrah_10000_FrontStore_Capacity.ToString();

            label18.Text = Company.Irancel_1000_FrontStore_Capacity.ToString();
            label21.Text = Company.Irancel_2000_FrontStore_Capacity.ToString();
            label23.Text = Company.Irancel_5000_FrontStore_Capacity.ToString();
            label25.Text = Company.Irancel_10000_FrontStore_Capacity.ToString();

            label27.Text = Company.Taliya_1000_FrontStore_Capacity.ToString();
            label29.Text = Company.Taliya_2000_FrontStore_Capacity.ToString();
            label31.Text = Company.Taliya_5000_FrontStore_Capacity.ToString();
            label33.Text = Company.Taliya_10000_FrontStore_Capacity.ToString();

            label39.Text = Company.Rightel_1000_FrontStore_Capacity.ToString();
            label41.Text = Company.Rightel_2000_FrontStore_Capacity.ToString();
            label43.Text = Company.Rightel_5000_FrontStore_Capacity.ToString();
            label45.Text = Company.Rightel_10000_FrontStore_Capacity.ToString();

            trackBar1.Value = Company.Hamrah_1000_FrontStore_Capacity;
            trackBar2.Value = Company.Hamrah_2000_FrontStore_Capacity;
            trackBar3.Value = Company.Hamrah_5000_FrontStore_Capacity;
            trackBar4.Value = Company.Hamrah_10000_FrontStore_Capacity;

            trackBar5.Value = Company.Irancel_1000_FrontStore_Capacity;
            trackBar6.Value = Company.Irancel_2000_FrontStore_Capacity;
            trackBar7.Value = Company.Irancel_5000_FrontStore_Capacity;
            trackBar8.Value = Company.Irancel_10000_FrontStore_Capacity;

            trackBar9.Value = Company.Taliya_1000_FrontStore_Capacity;
            trackBar10.Value = Company.Taliya_2000_FrontStore_Capacity;
            trackBar11.Value = Company.Taliya_5000_FrontStore_Capacity;
            trackBar12.Value = Company.Taliya_10000_FrontStore_Capacity;

            trackBar13.Value = Company.Rightel_1000_FrontStore_Capacity;
            trackBar14.Value = Company.Rightel_2000_FrontStore_Capacity;
            trackBar15.Value = Company.Rightel_5000_FrontStore_Capacity;
            trackBar16.Value = Company.Rightel_10000_FrontStore_Capacity;

            label6.Text = "0";
            label8.Text = "0";
            label10.Text = "0";
            label13.Text = "0";

            label17.Text = "0";
            label20.Text = "0";
            label22.Text = "0";
            label24.Text = "0";

            label26.Text = "0";
            label28.Text = "0";
            label30.Text = "0";
            label32.Text = "0";

            label38.Text = "0";
            label40.Text = "0";
            label42.Text = "0";
            label44.Text = "0";


        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label7.Text = trackBar1.Value.ToString();
            label6.Text = (trackBar1.Value - Company.Hamrah_1000_FrontStore_Capacity).ToString();
            if (trackBar1.Value != Company.Hamrah_1000_FrontStore_Capacity)
            {
                label6.BackColor = Color.LightGray;
                button3.Enabled = true;
            }
            else
            {

                label6.BackColor = Color.Transparent;
                button3.Enabled = CheckStatues();
            }
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label9.Text = trackBar2.Value.ToString();
            label8.Text = (trackBar2.Value - Company.Hamrah_2000_FrontStore_Capacity).ToString();
            if (trackBar2.Value != Company.Hamrah_2000_FrontStore_Capacity)
            {
                label8.BackColor = Color.LightGray;
                button3.Enabled = true;
            }
            else
            {
                label8.BackColor = Color.Transparent;
                button3.Enabled = CheckStatues();
            }
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            label11.Text = trackBar3.Value.ToString();
            label10.Text = (trackBar3.Value - Company.Hamrah_5000_FrontStore_Capacity).ToString();
            if (trackBar3.Value != Company.Hamrah_5000_FrontStore_Capacity)
            {
                label10.BackColor = Color.LightGray;
                button3.Enabled = true;
            }
            else
            {
                label10.BackColor = Color.Transparent;
                button3.Enabled = CheckStatues();
            }
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            label14.Text = trackBar4.Value.ToString();
            label13.Text = (trackBar4.Value - Company.Hamrah_10000_FrontStore_Capacity).ToString();
            if (trackBar4.Value != Company.Hamrah_10000_FrontStore_Capacity)
            {
                label13.BackColor = Color.LightGray;
                button3.Enabled = true;
            }
            else
            {
                label13.BackColor = Color.Transparent;
                button3.Enabled = CheckStatues();
            }
        }

        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            label18.Text = trackBar5.Value.ToString();
            label17.Text = (trackBar5.Value - Company.Irancel_1000_FrontStore_Capacity).ToString();
            if (trackBar5.Value != Company.Irancel_1000_FrontStore_Capacity)
            {
                label17.BackColor = Color.LightGray;
                button3.Enabled = true;
            }
            else
            {
                label17.BackColor = Color.Transparent;
                button3.Enabled = CheckStatues();
            }
        }

        private void trackBar6_Scroll(object sender, EventArgs e)
        {
            label21.Text = trackBar6.Value.ToString();
            label20.Text = (trackBar6.Value - Company.Irancel_2000_FrontStore_Capacity).ToString();
            if (trackBar6.Value != Company.Irancel_2000_FrontStore_Capacity)
            {
                label20.BackColor = Color.LightGray;
                button3.Enabled = true;
            }
            else
            {
                label20.BackColor = Color.Transparent;
                button3.Enabled = CheckStatues();
            }
        }

        private void trackBar7_Scroll(object sender, EventArgs e)
        {
            label23.Text = trackBar7.Value.ToString();
            label22.Text = (trackBar7.Value - Company.Irancel_5000_FrontStore_Capacity).ToString();
            if (trackBar7.Value != Company.Irancel_5000_FrontStore_Capacity)
            {
                label22.BackColor = Color.LightGray;
                button3.Enabled = true;
            }
            else
            {
                label22.BackColor = Color.Transparent;
                button3.Enabled = CheckStatues();
            }
        }

        private void trackBar8_Scroll(object sender, EventArgs e)
        {
            label25.Text = trackBar8.Value.ToString();
            label24.Text = (trackBar8.Value - Company.Irancel_10000_FrontStore_Capacity).ToString();
            if (trackBar8.Value != Company.Irancel_10000_FrontStore_Capacity)
            {
                label24.BackColor = Color.LightGray;
                button3.Enabled = true;
            }
            else
            {
                label24.BackColor = Color.Transparent;
                button3.Enabled = CheckStatues();
            }
        }

        private void trackBar9_Scroll(object sender, EventArgs e)
        {
            label27.Text = trackBar9.Value.ToString();
            label26.Text = (trackBar9.Value - Company.Taliya_1000_FrontStore_Capacity).ToString();
            if (trackBar9.Value != Company.Taliya_1000_FrontStore_Capacity)
            {
                label26.BackColor = Color.LightGray;
                button3.Enabled = true;
            }
            else
            {
                label26.BackColor = Color.Transparent;
                button3.Enabled = CheckStatues();
            }
        }

        private void trackBar10_Scroll(object sender, EventArgs e)
        {
            label29.Text = trackBar10.Value.ToString();
            label28.Text = (trackBar10.Value - Company.Taliya_2000_FrontStore_Capacity).ToString();
            if (trackBar10.Value != Company.Taliya_2000_FrontStore_Capacity)
            {
                label28.BackColor = Color.LightGray;
                button3.Enabled = true;
            }
            else
            {
                label28.BackColor = Color.Transparent;
                button3.Enabled = CheckStatues();
            }
        }

        private void trackBar11_Scroll(object sender, EventArgs e)
        {
            label31.Text = trackBar11.Value.ToString();
            label30.Text = (trackBar11.Value - Company.Taliya_5000_FrontStore_Capacity).ToString();
            if (trackBar11.Value != Company.Taliya_5000_FrontStore_Capacity)
            {
                label30.BackColor = Color.LightGray;
                button3.Enabled = true;
            }
            else
            {
                label30.BackColor = Color.Transparent;
                button3.Enabled = CheckStatues();
            }
        }

        private void trackBar12_Scroll(object sender, EventArgs e)
        {
            label33.Text = trackBar12.Value.ToString();
            label32.Text = (trackBar12.Value - Company.Taliya_10000_FrontStore_Capacity).ToString();
            if (trackBar12.Value != Company.Taliya_10000_FrontStore_Capacity)
            {
                label32.BackColor = Color.LightGray;
                button3.Enabled = true;
            }
            else
            {
                label32.BackColor = Color.Transparent;
                button3.Enabled = CheckStatues();
            }
        }

        private void trackBar13_Scroll(object sender, EventArgs e)
        {
            label39.Text = trackBar13.Value.ToString();
            label38.Text = (trackBar13.Value - Company.Rightel_1000_FrontStore_Capacity).ToString();
            if (trackBar13.Value != Company.Rightel_1000_FrontStore_Capacity)
            {
                label38.BackColor = Color.LightGray;
                button3.Enabled = true;
            }
            else
            {
                label38.BackColor = Color.Transparent;
                button3.Enabled = CheckStatues();
            }
        }

        private void trackBar14_Scroll(object sender, EventArgs e)
        {
            label41.Text = trackBar14.Value.ToString();
            label40.Text = (trackBar14.Value - Company.Rightel_2000_FrontStore_Capacity).ToString();
            if (trackBar14.Value != Company.Rightel_2000_FrontStore_Capacity)
            {
                label40.BackColor = Color.LightGray;
                button3.Enabled = true;
            }
            else
            {
                label40.BackColor = Color.Transparent;
                button3.Enabled = CheckStatues();
            }
        }

        private void trackBar15_Scroll(object sender, EventArgs e)
        {
            label43.Text = trackBar15.Value.ToString();
            label42.Text = (trackBar15.Value - Company.Rightel_5000_FrontStore_Capacity).ToString();
            if (trackBar15.Value != Company.Rightel_5000_FrontStore_Capacity)
            {
                label42.BackColor = Color.LightGray;
                button3.Enabled = true;
            }
            else
            {
                label42.BackColor = Color.Transparent;
                button3.Enabled = CheckStatues();
            }
        }

        private void trackBar16_Scroll(object sender, EventArgs e)
        {
            label45.Text = trackBar16.Value.ToString();
            label44.Text = (trackBar16.Value - Company.Rightel_10000_FrontStore_Capacity).ToString();

            if (trackBar16.Value != Company.Rightel_10000_FrontStore_Capacity)
            {
                label44.BackColor = Color.LightGray;
                button3.Enabled = true;
            }
            else
            {
                label44.BackColor = Color.Transparent;
                button3.Enabled = CheckStatues();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckStatues())
            {
                PersianMessageBox pmb = new PersianMessageBox();
                if (pmb.show("آیا مایل به اعمال تغییرات هستید؟ /n در صورت تایید شما قادر به بازگشت به حال اولیه نخواهید بود.", "تایید", PersianMessageBox.Question, 2, "YES/NO"))
                {

                    CompleteChargeCapacitySetting();
                    FormFill();
                    button3.Enabled = false;

                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CheckStatues())
            {
                PersianMessageBox pmb = new PersianMessageBox();
                if (pmb.show("تغییرات شما ذخیره نشده است ایا مایل به ذخیره تغییرات هستید؟", "اطمینان", PersianMessageBox.Question, 2, "YES/NO"))
                {
                    CompleteChargeCapacitySetting();
                    Close();
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

        private void button3_Click(object sender, EventArgs e)
        {
            PersianMessageBox pmb = new PersianMessageBox();
            if (pmb.show("آیا میخواهید تمامی تغییرات را به حالت اولیه بازگردانید؟", "اطمینان", PersianMessageBox.Question, 2, "YES/NO"))
            {
                FormFill();
                button3.Enabled = false;
                label6.BackColor = Color.Transparent;
                label8.BackColor = Color.Transparent;
                label10.BackColor = Color.Transparent;
                label13.BackColor = Color.Transparent;
                label17.BackColor = Color.Transparent;
                label20.BackColor = Color.Transparent;
                label22.BackColor = Color.Transparent;
                label24.BackColor = Color.Transparent;
                label26.BackColor = Color.Transparent;
                label28.BackColor = Color.Transparent;
                label30.BackColor = Color.Transparent;
                label32.BackColor = Color.Transparent;
                label38.BackColor = Color.Transparent;
                label40.BackColor = Color.Transparent;
                label42.BackColor = Color.Transparent;
                label44.BackColor = Color.Transparent;
            }
        }

        public void CompleteChargeCapacitySetting()
        {
            Company.Hamrah_1000_FrontStore_Capacity = trackBar1.Value;
            Company.Hamrah_2000_FrontStore_Capacity = trackBar2.Value;
            Company.Hamrah_5000_FrontStore_Capacity = trackBar3.Value;
            Company.Hamrah_10000_FrontStore_Capacity = trackBar4.Value;

            Company.Irancel_1000_FrontStore_Capacity = trackBar5.Value;
            Company.Irancel_2000_FrontStore_Capacity = trackBar6.Value;
            Company.Irancel_5000_FrontStore_Capacity = trackBar7.Value;
            Company.Irancel_10000_FrontStore_Capacity = trackBar8.Value;

            Company.Taliya_1000_FrontStore_Capacity = trackBar9.Value;
            Company.Taliya_2000_FrontStore_Capacity = trackBar10.Value;
            Company.Taliya_5000_FrontStore_Capacity = trackBar11.Value;
            Company.Taliya_10000_FrontStore_Capacity = trackBar12.Value;

            Company.Rightel_1000_FrontStore_Capacity = trackBar13.Value;
            Company.Rightel_2000_FrontStore_Capacity = trackBar14.Value;
            Company.Rightel_5000_FrontStore_Capacity = trackBar15.Value;
            Company.Rightel_10000_FrontStore_Capacity = trackBar16.Value;


            Company.RetriveNumberOfChargeIn_FrontStore();

            //TransferCharge_IfNeeded(Company.Hamrah_1000_FrontStore_Capacity, Company.Hamrah_1000_FrontStore, "HamrahAval", 1000);
            //TransferCharge_IfNeeded(Company.Hamrah_2000_FrontStore_Capacity, Company.Hamrah_2000_FrontStore, "HamrahAval", 2000);
            //TransferCharge_IfNeeded(Company.Hamrah_5000_FrontStore_Capacity, Company.Hamrah_5000_FrontStore, "HamrahAval", 5000);
            //TransferCharge_IfNeeded(Company.Hamrah_10000_FrontStore_Capacity, Company.Hamrah_10000_FrontStore, "HamrahAval", 10000);

            //TransferCharge_IfNeeded(Company.Irancel_1000_FrontStore_Capacity, Company.Irancel_1000_FrontStore, "Irancel", 1000);
            //TransferCharge_IfNeeded(Company.Irancel_2000_FrontStore_Capacity, Company.Irancel_2000_FrontStore, "Irancel", 2000);
            //TransferCharge_IfNeeded(Company.Irancel_5000_FrontStore_Capacity, Company.Irancel_5000_FrontStore, "Irancel", 5000);
            //TransferCharge_IfNeeded(Company.Irancel_10000_FrontStore_Capacity, Company.Irancel_10000_FrontStore, "Irancel", 10000);


            //TransferCharge_IfNeeded(Company.Taliya_1000_FrontStore_Capacity, Company.Taliya_1000_FrontStore, "Taliya", 1000);
            //TransferCharge_IfNeeded(Company.Taliya_2000_FrontStore_Capacity, Company.Taliya_2000_FrontStore, "Taliya", 2000);
            //TransferCharge_IfNeeded(Company.Taliya_5000_FrontStore_Capacity, Company.Taliya_5000_FrontStore, "Taliya", 5000);
            //TransferCharge_IfNeeded(Company.Taliya_10000_FrontStore_Capacity, Company.Taliya_10000_FrontStore, "Taliya", 10000);



            //TransferCharge_IfNeeded(Company.Rightel_1000_FrontStore_Capacity, Company.Rightel_1000_FrontStore, "Rightel", 1000);
            //TransferCharge_IfNeeded(Company.Rightel_2000_FrontStore_Capacity, Company.Rightel_2000_FrontStore, "Rightel", 2000);
            //TransferCharge_IfNeeded(Company.Rightel_5000_FrontStore_Capacity, Company.Rightel_5000_FrontStore, "Rightel", 5000);
            //TransferCharge_IfNeeded(Company.Rightel_10000_FrontStore_Capacity, Company.Rightel_10000_FrontStore, "Rightel", 10000);


            Company.SaveChargeSetting();
        }



        //public void TransferCharge_IfNeeded(int newcapacity, int stock, string operatorname, int pricecategory)
        //{

        //    int transferCharge_count = newcapacity - stock;
        //    if (transferCharge_count < 0)
        //    {
        //        Company.TransferChargeFrom_FrontStore_To_Store(Math.Abs(transferCharge_count), operatorname, pricecategory);
        //    }


        //}



        private bool CheckStatues()
        {
            bool result = false;

            if (trackBar1.Value != Company.Hamrah_1000_FrontStore_Capacity)
                result = true;
            else if (trackBar2.Value != Company.Hamrah_2000_FrontStore_Capacity)
                result = true;
            else if (trackBar3.Value != Company.Hamrah_5000_FrontStore_Capacity)
                result = true;
            else if (trackBar4.Value != Company.Hamrah_10000_FrontStore_Capacity)
                result = true;
            else if (trackBar5.Value != Company.Irancel_1000_FrontStore_Capacity)
                result = true;
            else if (trackBar6.Value != Company.Irancel_2000_FrontStore_Capacity)
                result = true;
            else if (trackBar7.Value != Company.Irancel_5000_FrontStore_Capacity)
                result = true;
            else if (trackBar8.Value != Company.Irancel_10000_FrontStore_Capacity)
                result = true;
            else if (trackBar9.Value != Company.Taliya_1000_FrontStore_Capacity)
                result = true;
            else if (trackBar10.Value != Company.Taliya_2000_FrontStore_Capacity)
                result = true;
            else if (trackBar11.Value != Company.Taliya_5000_FrontStore_Capacity)
                result = true;
            else if (trackBar12.Value != Company.Taliya_10000_FrontStore_Capacity)
                result = true;
            else if (trackBar13.Value != Company.Rightel_1000_FrontStore_Capacity)
                result = true;
            else if (trackBar14.Value != Company.Rightel_2000_FrontStore_Capacity)
                result = true;
            else if (trackBar15.Value != Company.Rightel_5000_FrontStore_Capacity)
                result = true;
            else if (trackBar16.Value != Company.Rightel_10000_FrontStore_Capacity)
                result = true;



            return result;
        }







    }
}
