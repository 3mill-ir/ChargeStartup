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
    public partial class ChargeAmountOnFrontStore : Form
    {
        CompanyBusiness Company;
        string OperatorName;
        string Operatorname_Persian;
        public ChargeAmountOnFrontStore(CompanyBusiness CB, string opname)
        {
            InitializeComponent();
            Company = CB;
            OperatorName = opname;
            FormFill_initial();
            FormFill();
        }

        public void FormFill_initial()
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

        public void FormFill()
        {
            Company.RetriveNumberOfChargeIn_Store();
            Company.RetriveNumberOfChargeIn_FrontStore();
            if (OperatorName == "HamrahAval")
            {
                int total_1000 = Company.Hamrah_1000_Store + Company.Hamrah_1000_FrontStore;
                int total_2000 = Company.Hamrah_2000_Store + Company.Hamrah_2000_FrontStore;
                int total_5000 = Company.Hamrah_5000_Store + Company.Hamrah_5000_FrontStore;
                int total_10000 = Company.Hamrah_10000_Store + Company.Hamrah_10000_FrontStore;

                trackBar1.Maximum = (Company.Hamrah_1000_FrontStore_Capacity < total_1000) ? Company.Hamrah_1000_FrontStore_Capacity : total_1000;
                trackBar2.Maximum = (Company.Hamrah_2000_FrontStore_Capacity < total_2000) ? Company.Hamrah_2000_FrontStore_Capacity : total_2000;
                trackBar3.Maximum = (Company.Hamrah_5000_FrontStore_Capacity < total_5000) ? Company.Hamrah_5000_FrontStore_Capacity : total_5000;
                trackBar4.Maximum = (Company.Hamrah_10000_FrontStore_Capacity < total_10000) ? Company.Hamrah_10000_FrontStore_Capacity : total_10000;

                label13.Text = Company.Hamrah_1000_FrontStore.ToString();
                label14.Text = Company.Hamrah_2000_FrontStore.ToString();
                label15.Text = Company.Hamrah_5000_FrontStore.ToString();
                label16.Text = Company.Hamrah_10000_FrontStore.ToString();

                trackBar1.Value = Company.Hamrah_1000_FrontStore;
                trackBar2.Value = Company.Hamrah_2000_FrontStore;
                trackBar3.Value = Company.Hamrah_5000_FrontStore;
                trackBar4.Value = Company.Hamrah_10000_FrontStore;



                label7.Text = Company.Hamrah_1000_Store.ToString();
                label8.Text = Company.Hamrah_2000_Store.ToString();
                label9.Text = Company.Hamrah_5000_Store.ToString();
                label10.Text = Company.Hamrah_10000_Store.ToString();



            }
            else if (OperatorName == "Irancel")
            {
                int total_1000 = Company.Irancel_1000_Store + Company.Irancel_1000_FrontStore;
                int total_2000 = Company.Irancel_2000_Store + Company.Irancel_2000_FrontStore;
                int total_5000 = Company.Irancel_5000_Store + Company.Irancel_5000_FrontStore;
                int total_10000 = Company.Irancel_10000_Store + Company.Irancel_10000_FrontStore;

                trackBar1.Maximum = (Company.Irancel_1000_FrontStore_Capacity < total_1000) ? Company.Irancel_1000_FrontStore_Capacity : total_1000;
                trackBar2.Maximum = (Company.Irancel_2000_FrontStore_Capacity < total_2000) ? Company.Irancel_2000_FrontStore_Capacity : total_2000;
                trackBar3.Maximum = (Company.Irancel_5000_FrontStore_Capacity < total_5000) ? Company.Irancel_5000_FrontStore_Capacity : total_5000;
                trackBar4.Maximum = (Company.Irancel_10000_FrontStore_Capacity < total_10000) ? Company.Irancel_10000_FrontStore_Capacity : total_10000;


                label13.Text = Company.Irancel_1000_FrontStore.ToString();
                label14.Text = Company.Irancel_2000_FrontStore.ToString();
                label15.Text = Company.Irancel_5000_FrontStore.ToString();
                label16.Text = Company.Irancel_10000_FrontStore.ToString();

                trackBar1.Value = Company.Irancel_1000_FrontStore;
                trackBar2.Value = Company.Irancel_2000_FrontStore;
                trackBar3.Value = Company.Irancel_5000_FrontStore;
                trackBar4.Value = Company.Irancel_10000_FrontStore;



                label7.Text = Company.Irancel_1000_Store.ToString();
                label8.Text = Company.Irancel_2000_Store.ToString();
                label9.Text = Company.Irancel_5000_Store.ToString();
                label10.Text = Company.Irancel_10000_Store.ToString();



            }
            else if (OperatorName == "Taliya")
            {

                int total_1000 = Company.Taliya_1000_Store + Company.Taliya_1000_FrontStore;
                int total_2000 = Company.Taliya_2000_Store + Company.Taliya_2000_FrontStore;
                int total_5000 = Company.Taliya_5000_Store + Company.Taliya_5000_FrontStore;
                int total_10000 = Company.Taliya_10000_Store + Company.Taliya_10000_FrontStore;

                trackBar1.Maximum = (Company.Taliya_1000_FrontStore_Capacity < total_1000) ? Company.Taliya_1000_FrontStore_Capacity : total_1000;
                trackBar2.Maximum = (Company.Taliya_2000_FrontStore_Capacity < total_2000) ? Company.Taliya_2000_FrontStore_Capacity : total_2000;
                trackBar3.Maximum = (Company.Taliya_5000_FrontStore_Capacity < total_5000) ? Company.Taliya_5000_FrontStore_Capacity : total_5000;
                trackBar4.Maximum = (Company.Taliya_10000_FrontStore_Capacity < total_10000) ? Company.Taliya_10000_FrontStore_Capacity : total_10000;


                label13.Text = Company.Taliya_1000_FrontStore.ToString();
                label14.Text = Company.Taliya_2000_FrontStore.ToString();
                label15.Text = Company.Taliya_5000_FrontStore.ToString();
                label16.Text = Company.Taliya_10000_FrontStore.ToString();

                trackBar1.Value = Company.Taliya_1000_FrontStore;
                trackBar2.Value = Company.Taliya_2000_FrontStore;
                trackBar3.Value = Company.Taliya_5000_FrontStore;
                trackBar4.Value = Company.Taliya_10000_FrontStore;



                label7.Text = Company.Taliya_1000_Store.ToString();
                label8.Text = Company.Taliya_2000_Store.ToString();
                label9.Text = Company.Taliya_5000_Store.ToString();
                label10.Text = Company.Taliya_10000_Store.ToString();


            }
            else if (OperatorName == "Rightel")
            {


                int total_1000 = Company.Rightel_1000_Store + Company.Rightel_1000_FrontStore;
                int total_2000 = Company.Rightel_2000_Store + Company.Rightel_2000_FrontStore;
                int total_5000 = Company.Rightel_5000_Store + Company.Rightel_5000_FrontStore;
                int total_10000 = Company.Rightel_10000_Store + Company.Rightel_10000_FrontStore;

                trackBar1.Maximum = (Company.Rightel_1000_FrontStore_Capacity < total_1000) ? Company.Rightel_1000_FrontStore_Capacity : total_1000;
                trackBar2.Maximum = (Company.Rightel_2000_FrontStore_Capacity < total_2000) ? Company.Rightel_2000_FrontStore_Capacity : total_2000;
                trackBar3.Maximum = (Company.Rightel_5000_FrontStore_Capacity < total_5000) ? Company.Rightel_5000_FrontStore_Capacity : total_5000;
                trackBar4.Maximum = (Company.Rightel_10000_FrontStore_Capacity < total_10000) ? Company.Rightel_10000_FrontStore_Capacity : total_10000;


                label13.Text = Company.Rightel_1000_FrontStore.ToString();
                label14.Text = Company.Rightel_2000_FrontStore.ToString();
                label15.Text = Company.Rightel_5000_FrontStore.ToString();
                label16.Text = Company.Rightel_10000_FrontStore.ToString();

                trackBar1.Value = Company.Rightel_1000_FrontStore;
                trackBar2.Value = Company.Rightel_2000_FrontStore;
                trackBar3.Value = Company.Rightel_5000_FrontStore;
                trackBar4.Value = Company.Rightel_10000_FrontStore;




                label7.Text = Company.Rightel_1000_Store.ToString();
                label8.Text = Company.Rightel_2000_Store.ToString();
                label9.Text = Company.Rightel_5000_Store.ToString();
                label10.Text = Company.Rightel_10000_Store.ToString();


            }
            ChartDispaly_1000();
            ChartDispaly_2000();
            ChartDispaly_5000();
            ChartDispaly_10000();
            label20.Text = "0";
            label21.Text = "0";
            label22.Text = "0";
            label23.Text = "0";

        }
        private void ChartDispaly_1000()
        {
            if (OperatorName == "HamrahAval")
            {

                if (Company.Hamrah_1000_FrontStore_Capacity != 0)
                {
                    int ratio_1000 = (int.Parse(label13.Text) * 360) / Company.Hamrah_1000_FrontStore_Capacity;
                    chart5.Enabled = true;
                    chart5.Series[0].Points[0].YValues[0] = 360 - ratio_1000;
                    chart5.Series[0].Points[1].YValues[0] = ratio_1000;
                }
                else
                {
                    chart5.Enabled = false;
                    chart5.Series[0].Points[0].YValues[0] = 0;
                    chart5.Series[0].Points[1].YValues[0] = 0;
                }
            }
            else if (OperatorName == "Irancel")
            {
                if (Company.Irancel_1000_FrontStore_Capacity != 0)
                {
                    int ratio_1000 = (int.Parse(label13.Text) * 360) / Company.Irancel_1000_FrontStore_Capacity;
                    chart5.Enabled = true;
                    chart5.Series[0].Points[0].YValues[0] = 360 - ratio_1000;
                    chart5.Series[0].Points[1].YValues[0] = ratio_1000;
                }
                else
                {
                    chart5.Enabled = false;
                    chart5.Series[0].Points[0].YValues[0] = 0;
                    chart5.Series[0].Points[1].YValues[0] = 0;
                }

            }
            else if (OperatorName == "Taliya")
            {
                if (Company.Taliya_1000_FrontStore_Capacity != 0)
                {
                    int ratio_1000 = (int.Parse(label13.Text) * 360) / Company.Taliya_1000_FrontStore_Capacity;
                    chart5.Enabled = true;
                    chart5.Series[0].Points[0].YValues[0] = 360 - ratio_1000;
                    chart5.Series[0].Points[1].YValues[0] = ratio_1000;
                }
                else
                {
                    chart5.Enabled = false;
                    chart5.Series[0].Points[0].YValues[0] = 0;
                    chart5.Series[0].Points[1].YValues[0] = 0;
                }

            }
            else if (OperatorName == "Rightel")
            {
                if (Company.Rightel_1000_FrontStore_Capacity != 0)
                {
                    int ratio_1000 = (int.Parse(label13.Text) * 360) / Company.Rightel_1000_FrontStore_Capacity;
                    chart5.Enabled = true;
                    chart5.Series[0].Points[0].YValues[0] = 360 - ratio_1000;
                    chart5.Series[0].Points[1].YValues[0] =  ratio_1000;
                }
                else
                {
                    chart5.Enabled = false;
                    chart5.Series[0].Points[0].YValues[0] = 0;
                    chart5.Series[0].Points[1].YValues[0] = 0;
                }
            }
        }



        private void ChartDispaly_2000() {
            if (OperatorName == "HamrahAval")
            {
 
                if (Company.Hamrah_2000_FrontStore_Capacity != 0)
                {
                    int ratio_2000 = (int.Parse(label14.Text) * 360) / Company.Hamrah_2000_FrontStore_Capacity;
                    chart6.Enabled = true;
                    chart6.Series[0].Points[0].YValues[0] = 360 - ratio_2000;
                    chart6.Series[0].Points[1].YValues[0] =  ratio_2000;
                }
                else
                {
                    chart6.Enabled = false;
                    chart6.Series[0].Points[0].YValues[0] = 0;
                    chart6.Series[0].Points[1].YValues[0] = 0;
                }

            }
            else if (OperatorName == "Irancel")
            {
             
                if (Company.Irancel_2000_FrontStore_Capacity != 0)
                {
                    int ratio_2000 = (int.Parse(label14.Text) * 360) / Company.Irancel_2000_FrontStore_Capacity;
                    chart6.Enabled = true;
                    chart6.Series[0].Points[0].YValues[0] = 360 - ratio_2000;
                    chart6.Series[0].Points[1].YValues[0] =  ratio_2000;
                }
                else
                {
                    chart6.Enabled = false;
                    chart6.Series[0].Points[0].YValues[0] = 0;
                    chart6.Series[0].Points[1].YValues[0] = 0;
                }
                
            }
            else if (OperatorName == "Taliya")
            {
               
                if (Company.Taliya_2000_FrontStore_Capacity != 0)
                {
                    int ratio_2000 = (int.Parse(label14.Text) * 360) / Company.Taliya_2000_FrontStore_Capacity;
                    chart6.Enabled = true;
                    chart6.Series[0].Points[0].YValues[0] = 360 - ratio_2000;
                    chart6.Series[0].Points[1].YValues[0] =  ratio_2000;
                }
                else
                {
                    chart6.Enabled = false;
                    chart6.Series[0].Points[0].YValues[0] = 0;
                    chart6.Series[0].Points[1].YValues[0] = 0;
                }
               
            }
            else if (OperatorName == "Rightel")
            {
              
                if (Company.Rightel_2000_FrontStore_Capacity != 0)
                {
                    int ratio_2000 = (int.Parse(label14.Text) * 360) / Company.Rightel_2000_FrontStore_Capacity;
                    chart6.Enabled = true;
                    chart6.Series[0].Points[0].YValues[0] = 360 - ratio_2000;
                    chart6.Series[0].Points[1].YValues[0] =  ratio_2000;
                }
                else
                {
                    chart6.Enabled = false;
                    chart6.Series[0].Points[0].YValues[0] = 0;
                    chart6.Series[0].Points[1].YValues[0] = 0;
                }
               
            }
        }



        private void ChartDispaly_5000() {
            if (OperatorName == "HamrahAval")
            {

               
                if (Company.Hamrah_5000_FrontStore_Capacity != 0)
                {
                    int ratio_5000 = (int.Parse(label15.Text) * 360) / Company.Hamrah_5000_FrontStore_Capacity;
                    chart7.Enabled = true;
                    chart7.Series[0].Points[0].YValues[0] = 360 - ratio_5000;
                    chart7.Series[0].Points[1].YValues[0] = ratio_5000;
                }
                else
                {
                    chart7.Enabled = false;
                    chart7.Series[0].Points[0].YValues[0] = 0;
                    chart7.Series[0].Points[1].YValues[0] = 0;
                }
                

            }
            else if (OperatorName == "Irancel")
            {
               
                if (Company.Irancel_5000_FrontStore_Capacity != 0)
                {
                    int ratio_5000 = (int.Parse(label15.Text) * 360) / Company.Irancel_5000_FrontStore_Capacity;
                    chart7.Enabled = true;
                    chart7.Series[0].Points[0].YValues[0] = 360 - ratio_5000;
                    chart7.Series[0].Points[1].YValues[0] =  ratio_5000;
                }
                else
                {
                    chart7.Enabled = false;
                    chart7.Series[0].Points[0].YValues[0] = 0;
                    chart7.Series[0].Points[1].YValues[0] = 0;
                }
              
            }
            else if (OperatorName == "Taliya")
            {
               
                if (Company.Taliya_5000_FrontStore_Capacity != 0)
                {
                    int ratio_5000 = (int.Parse(label15.Text) * 360) / Company.Taliya_5000_FrontStore_Capacity;
                    chart7.Enabled = true;
                    chart7.Series[0].Points[0].YValues[0] = 360 - ratio_5000;
                    chart7.Series[0].Points[1].YValues[0] =  ratio_5000;
                }
                else
                {
                    chart7.Enabled = false;
                    chart7.Series[0].Points[0].YValues[0] = 0;
                    chart7.Series[0].Points[1].YValues[0] = 0;
                }
                
            }
            else if (OperatorName == "Rightel")
            {
               
                if (Company.Rightel_5000_FrontStore_Capacity != 0)
                {
                    int ratio_5000 = (int.Parse(label15.Text) * 360) / Company.Rightel_5000_FrontStore_Capacity;
                    chart7.Enabled = true;
                    chart7.Series[0].Points[0].YValues[0] = 360 - ratio_5000;
                    chart7.Series[0].Points[1].YValues[0] =  ratio_5000;
                }
                else
                {
                    chart7.Enabled = false;
                    chart7.Series[0].Points[0].YValues[0] = 0;
                    chart7.Series[0].Points[1].YValues[0] = 0;
                }
                
            }
        }



        private void ChartDispaly_10000() {
            if (OperatorName == "HamrahAval")
            {

                if (Company.Hamrah_10000_FrontStore_Capacity != 0)
                {
                    int ratio_10000 = (int.Parse(label16.Text) * 360) / Company.Hamrah_10000_FrontStore_Capacity;
                    chart8.Enabled = true;
                    chart8.Series[0].Points[0].YValues[0] = 360 - ratio_10000;
                    chart8.Series[0].Points[1].YValues[0] = ratio_10000;
                }
                else
                {
                    chart8.Enabled = false;
                    chart8.Series[0].Points[0].YValues[0] = 0;
                    chart8.Series[0].Points[1].YValues[0] = 0;
                }


            }
            else if (OperatorName == "Irancel")
            {
               
                if (Company.Irancel_10000_FrontStore_Capacity != 0)
                {
                    int ratio_10000 = (int.Parse(label16.Text) * 360) / Company.Irancel_10000_FrontStore_Capacity;
                    chart8.Enabled = true;
                    chart8.Series[0].Points[0].YValues[0] = 360 - ratio_10000;
                    chart8.Series[0].Points[1].YValues[0] = ratio_10000;
                }
                else
                {
                    chart8.Enabled = false;
                    chart8.Series[0].Points[0].YValues[0] = 0;
                    chart8.Series[0].Points[1].YValues[0] = 0;
                }
            }
            else if (OperatorName == "Taliya")
            {
                
                if (Company.Taliya_10000_FrontStore_Capacity != 0)
                {
                    int ratio_10000 = (int.Parse(label16.Text) * 360) / Company.Taliya_10000_FrontStore_Capacity;
                    chart8.Enabled = true;
                    chart8.Series[0].Points[0].YValues[0] = 360 - ratio_10000;
                    chart8.Series[0].Points[1].YValues[0] =  ratio_10000;
                }
                else
                {
                    chart8.Enabled = false;
                    chart8.Series[0].Points[0].YValues[0] = 0;
                    chart8.Series[0].Points[1].YValues[0] = 0;
                }
            }
            else if (OperatorName == "Rightel")
            {
                
                if (Company.Rightel_10000_FrontStore_Capacity != 0)
                {
                    int ratio_10000 = (int.Parse(label16.Text) * 360) / Company.Rightel_10000_FrontStore_Capacity;
                    chart8.Enabled = true;
                    chart8.Series[0].Points[0].YValues[0] = 360 - ratio_10000;
                    chart8.Series[0].Points[1].YValues[0] =  ratio_10000;
                }
                else
                {
                    chart8.Enabled = false;
                    chart8.Series[0].Points[0].YValues[0] = 0;
                    chart8.Series[0].Points[1].YValues[0] = 0;
                }
            }
        }
       

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
          

            if (OperatorName == "HamrahAval")
            {
                label13.Text = trackBar1.Value.ToString();
                label20.Text = (trackBar1.Value - Company.Hamrah_1000_FrontStore).ToString();

                label7.Text = (Company.Hamrah_1000_FrontStore - trackBar1.Value + Company.Hamrah_1000_Store).ToString();

                
            
                if (trackBar1.Value != Company.Hamrah_1000_FrontStore)
                {
                    label13.BackColor = Color.LightGray;
                    button2.Enabled = true;
                }
                else
                {

                    label13.BackColor = Color.Transparent;
                    button2.Enabled = CheckStatues();
                }
            }
            else if (OperatorName == "Irancel")
            {
                label13.Text = trackBar1.Value.ToString();
                label20.Text = (trackBar1.Value - Company.Irancel_1000_FrontStore).ToString();

                label7.Text = (Company.Irancel_1000_FrontStore - trackBar1.Value + Company.Irancel_1000_Store).ToString();



                if (trackBar1.Value != Company.Irancel_1000_FrontStore)
                {
                    label13.BackColor = Color.LightGray;
                    button2.Enabled = true;
                }
                else
                {

                    label13.BackColor = Color.Transparent;
                    button2.Enabled = CheckStatues();
                }
            }
            else if (OperatorName == "Taliya")
            {
                label13.Text = trackBar1.Value.ToString();
                label20.Text = (trackBar1.Value - Company.Taliya_1000_FrontStore).ToString();
                label7.Text = (Company.Taliya_1000_FrontStore - trackBar1.Value + Company.Taliya_1000_Store).ToString();
                if (trackBar1.Value != Company.Taliya_1000_FrontStore)
                {
                    label13.BackColor = Color.LightGray;
                    button2.Enabled = true;
                }
                else
                {

                    label13.BackColor = Color.Transparent;
                    button2.Enabled = CheckStatues();
                }
            }
            else if (OperatorName == "Rightel")
            {
                label13.Text = trackBar1.Value.ToString();
                label20.Text = (trackBar1.Value - Company.Rightel_1000_FrontStore).ToString();
                label7.Text = (Company.Rightel_1000_FrontStore - trackBar1.Value + Company.Rightel_1000_Store).ToString();
                if (trackBar1.Value != Company.Rightel_1000_FrontStore)
                {
                    label13.BackColor = Color.LightGray;
                    button2.Enabled = true;
                }
                else
                {

                    label13.BackColor = Color.Transparent;
                    button2.Enabled = CheckStatues();
                }
            }
            ChartDispaly_1000();

        }



        private void trackBar2_Scroll(object sender, EventArgs e)
        {
           
       
    
            if (OperatorName == "HamrahAval")
            {
                label14.Text = trackBar2.Value.ToString();
                label21.Text = (trackBar2.Value - Company.Hamrah_2000_FrontStore).ToString();
                label8.Text = (Company.Hamrah_2000_FrontStore - trackBar2.Value + Company.Hamrah_2000_Store).ToString();
                if (trackBar2.Value != Company.Hamrah_2000_FrontStore)
                {
                    label14.BackColor = Color.LightGray;
                    button2.Enabled = true;
                }
                else
                {

                    label14.BackColor = Color.Transparent;
                    button2.Enabled = CheckStatues();
                }
            }
            else if (OperatorName == "Irancel")
            {
                label14.Text = trackBar2.Value.ToString();
                label21.Text = (trackBar2.Value - Company.Irancel_2000_FrontStore).ToString();
                label8.Text = (Company.Irancel_2000_FrontStore - trackBar2.Value + Company.Irancel_2000_Store).ToString();
                if (trackBar2.Value != Company.Irancel_2000_FrontStore)
                {
                    label14.BackColor = Color.LightGray;
                    button2.Enabled = true;
                }
                else
                {

                    label14.BackColor = Color.Transparent;
                    button2.Enabled = CheckStatues();
                }
            }
            else if (OperatorName == "Taliya")
            {
                label14.Text = trackBar2.Value.ToString();
                label21.Text = (trackBar2.Value - Company.Taliya_2000_FrontStore).ToString();
                label8.Text = (Company.Taliya_2000_FrontStore - trackBar2.Value + Company.Taliya_2000_Store).ToString();
                if (trackBar2.Value != Company.Taliya_2000_FrontStore)
                {
                    label14.BackColor = Color.LightGray;
                    button2.Enabled = true;
                }
                else
                {

                    label14.BackColor = Color.Transparent;
                    button2.Enabled = CheckStatues();
                }
            }
            else if (OperatorName == "Rightel")
            {
                label14.Text = trackBar2.Value.ToString();
                label21.Text = (trackBar2.Value - Company.Rightel_2000_FrontStore).ToString();
                label8.Text = (Company.Rightel_2000_FrontStore - trackBar2.Value + Company.Rightel_2000_Store).ToString();
                if (trackBar2.Value != Company.Rightel_2000_FrontStore)
                {
                    label14.BackColor = Color.LightGray;
                    button2.Enabled = true;
                }
                else
                {

                    label14.BackColor = Color.Transparent;
                    button2.Enabled = CheckStatues();
                }
            }
            ChartDispaly_2000();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
         
          
         
            if (OperatorName == "HamrahAval")
            {
                label15.Text = trackBar3.Value.ToString();
                label22.Text = (trackBar3.Value - Company.Hamrah_5000_FrontStore).ToString();
                label9.Text = (Company.Hamrah_5000_FrontStore - trackBar3.Value + Company.Hamrah_5000_Store).ToString();
                if (trackBar3.Value != Company.Hamrah_5000_FrontStore)
                {
                    label15.BackColor = Color.LightGray;
                    button2.Enabled = true;
                }
                else
                {

                    label15.BackColor = Color.Transparent;
                    button2.Enabled = CheckStatues();
                }
            }
            else if (OperatorName == "Irancel")
            {
                label15.Text = trackBar3.Value.ToString();
                label22.Text = (trackBar3.Value - Company.Irancel_5000_FrontStore).ToString();
                label9.Text = (Company.Irancel_5000_FrontStore - trackBar3.Value + Company.Irancel_5000_Store).ToString();
                if (trackBar3.Value != Company.Irancel_5000_FrontStore)
                {
                    label15.BackColor = Color.LightGray;
                    button2.Enabled = true;
                }
                else
                {

                    label15.BackColor = Color.Transparent;
                    button2.Enabled = CheckStatues();
                }
            }
            else if (OperatorName == "Taliya")
            {
                label15.Text = trackBar3.Value.ToString();
                label22.Text = (trackBar3.Value - Company.Taliya_5000_FrontStore).ToString();
                label9.Text = (Company.Taliya_5000_FrontStore - trackBar3.Value + Company.Taliya_5000_Store).ToString();
                if (trackBar3.Value != Company.Taliya_5000_FrontStore)
                {
                    label15.BackColor = Color.LightGray;
                    button2.Enabled = true;
                }
                else
                {

                    label15.BackColor = Color.Transparent;
                    button2.Enabled = CheckStatues();
                }
            }
            else if (OperatorName == "Rightel")
            {
                label15.Text = trackBar3.Value.ToString();
                label22.Text = (trackBar3.Value - Company.Rightel_5000_FrontStore).ToString();
                label9.Text = (Company.Rightel_5000_FrontStore - trackBar3.Value + Company.Rightel_5000_Store).ToString();
                if (trackBar3.Value != Company.Rightel_5000_FrontStore)
                {
                    label15.BackColor = Color.LightGray;
                    button2.Enabled = true;
                }
                else
                {

                    label15.BackColor = Color.Transparent;
                    button2.Enabled = CheckStatues();
                }
            }
            ChartDispaly_5000();
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
   
            
            if (OperatorName == "HamrahAval")
            {
                label16.Text = trackBar4.Value.ToString();
                label23.Text = (trackBar4.Value - Company.Hamrah_10000_FrontStore).ToString();
                label10.Text = (Company.Hamrah_10000_FrontStore - trackBar4.Value + Company.Hamrah_10000_FrontStore).ToString();
                if (trackBar4.Value != Company.Hamrah_10000_FrontStore)
                {
                    label16.BackColor = Color.LightGray;
                    button2.Enabled = true;
                }
                else
                {

                    label16.BackColor = Color.Transparent;
                    button2.Enabled = CheckStatues();
                }
            }
            else if (OperatorName == "Irancel")
            {
                label16.Text = trackBar4.Value.ToString();
                label23.Text = (trackBar4.Value - Company.Irancel_10000_FrontStore).ToString();
                label10.Text = (Company.Irancel_10000_FrontStore - trackBar4.Value + Company.Irancel_10000_FrontStore).ToString();
                if (trackBar4.Value != Company.Irancel_10000_FrontStore)
                {
                    label16.BackColor = Color.LightGray;
                    button2.Enabled = true;
                }
                else
                {

                    label16.BackColor = Color.Transparent;
                    button2.Enabled = CheckStatues();
                }
            }
            else if (OperatorName == "Taliya")
            {
                label16.Text = trackBar4.Value.ToString();
                label23.Text = (trackBar4.Value - Company.Taliya_10000_FrontStore).ToString();
                label10.Text = (Company.Taliya_10000_FrontStore - trackBar4.Value + Company.Taliya_10000_FrontStore).ToString();
                if (trackBar4.Value != Company.Taliya_10000_FrontStore)
                {
                    label16.BackColor = Color.LightGray;
                    button2.Enabled = true;
                }
                else
                {

                    label16.BackColor = Color.Transparent;
                    button2.Enabled = CheckStatues();
                }
            }
            else if (OperatorName == "Rightel")
            {
                label16.Text = trackBar4.Value.ToString();
                label23.Text = (trackBar4.Value - Company.Rightel_10000_FrontStore).ToString();
                label10.Text = (Company.Rightel_10000_FrontStore - trackBar4.Value + Company.Rightel_10000_FrontStore).ToString();
                if (trackBar4.Value != Company.Rightel_10000_FrontStore)
                {
                    label16.BackColor = Color.LightGray;
                    button2.Enabled = true;
                }
                else
                {

                    label16.BackColor = Color.Transparent;
                    button2.Enabled = CheckStatues();
                }
            }
            ChartDispaly_10000();
        }


        private bool CheckStatues()
        {


            bool result = false;


            if (OperatorName == "HamrahAval")
            {
                if (trackBar1.Value != Company.Hamrah_1000_FrontStore)
                    result = true;
                else if (trackBar2.Value != Company.Hamrah_2000_FrontStore)
                    result = true;
                else if (trackBar3.Value != Company.Hamrah_5000_FrontStore)
                    result = true;
                else if (trackBar4.Value != Company.Hamrah_10000_FrontStore)
                    result = true;
            }
            else if (OperatorName == "Irancel")
            {
                if (trackBar1.Value != Company.Irancel_1000_FrontStore)
                    result = true;
                else if (trackBar2.Value != Company.Irancel_2000_FrontStore)
                    result = true;
                else if (trackBar3.Value != Company.Irancel_5000_FrontStore)
                    result = true;
                else if (trackBar4.Value != Company.Irancel_10000_FrontStore)
                    result = true;
            }
            else if (OperatorName == "Taliya")
            {
                if (trackBar1.Value != Company.Taliya_1000_FrontStore)
                    result = true;
                else if (trackBar2.Value != Company.Taliya_2000_FrontStore)
                    result = true;
                else if (trackBar3.Value != Company.Taliya_5000_FrontStore)
                    result = true;
                else if (trackBar4.Value != Company.Taliya_10000_FrontStore)
                    result = true;
            }
            else if (OperatorName == "Rightel")
            {
                if (trackBar1.Value != Company.Rightel_1000_FrontStore)
                    result = true;
                else if (trackBar2.Value != Company.Rightel_2000_FrontStore)
                    result = true;
                else if (trackBar3.Value != Company.Rightel_5000_FrontStore)
                    result = true;
                else if (trackBar4.Value != Company.Rightel_10000_FrontStore)
                    result = true;
            }

            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckStatues())
            {
                PersianMessageBox pmb = new PersianMessageBox();
                if (pmb.show("آیا مایل به اعمال تغییرات هستید؟ /n در صورت تایید شما قادر به بازگشت به حال اولیه نخواهید بود.", "تایید", PersianMessageBox.Question, 2, "YES/NO"))
                {

                    ChargeTransfer();
                    FormFill();
                    button2.Enabled = false;

                }
            }
        }




        private void ChargeTransfer()
        {


            if (int.Parse(label20.Text) > 0)
                Company.TransferChargeFrom_Store_To_FrontStore(Math.Abs(int.Parse(label20.Text)), OperatorName, 1000);
            else if (int.Parse(label20.Text) < 0)
                Company.TransferChargeFrom_FrontStore_To_Store(Math.Abs(int.Parse(label20.Text)), OperatorName, 1000);

            if (int.Parse(label21.Text) > 0)
                Company.TransferChargeFrom_Store_To_FrontStore(Math.Abs(int.Parse(label21.Text)), OperatorName, 2000);
            else if (int.Parse(label21.Text) < 0)
                Company.TransferChargeFrom_FrontStore_To_Store(Math.Abs(int.Parse(label21.Text)), OperatorName, 2000);

            if (int.Parse(label22.Text) > 0)
                Company.TransferChargeFrom_Store_To_FrontStore(Math.Abs(int.Parse(label22.Text)), OperatorName, 5000);
            else if (int.Parse(label22.Text) < 0)
                Company.TransferChargeFrom_FrontStore_To_Store(Math.Abs(int.Parse(label22.Text)), OperatorName, 5000);


            if (int.Parse(label23.Text) > 0)
                Company.TransferChargeFrom_Store_To_FrontStore(Math.Abs(int.Parse(label23.Text)), OperatorName, 10000);
            else if (int.Parse(label23.Text) < 0)
                Company.TransferChargeFrom_FrontStore_To_Store(Math.Abs(int.Parse(label23.Text)), OperatorName, 10000);



        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersianMessageBox pmb = new PersianMessageBox();
            if (pmb.show("آیا میخواهید تمامی تغییرات را به حالت اولیه بازگردانید؟", "اطمینان", PersianMessageBox.Question, 2, "YES/NO"))
            {
                FormFill();
                button2.Enabled = false;
                label13.BackColor = Color.Transparent;
                label14.BackColor = Color.Transparent;
                label15.BackColor = Color.Transparent;
                label16.BackColor = Color.Transparent;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (CheckStatues())
            {
                PersianMessageBox pmb = new PersianMessageBox();
                if (pmb.show("تغییرات شما ذخیره نشده است ایا مایل به ذخیره تغییرات هستید؟", "اطمینان", PersianMessageBox.Question, 2, "YES/NO"))
                {
                    ChargeTransfer();
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
    }
}
