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

namespace Company
{
    public partial class HomePage : Form
    {
        CompanyBusiness Company;
        public HomePage(CompanyBusiness CB)
        {
            InitializeComponent();
            Company = CB;
           Company.RetriveChargeSetting();
           Company.RetriveNumberOfChargeIn_FrontStore();
        }

        private void ثبتواحدجدیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgencyRegisterPage ARP = new AgencyRegisterPage(Company);
            ARP.Show();
        }

       

        private void لیستواحدهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgencySelectPage ASP = new AgencySelectPage(Company);
            ASP.Show();
        }

        private void جدیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OperatorRegisterPage ORP = new OperatorRegisterPage(Company);
            ORP.Show();
        }

        private void نمایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OperatorSelectPage OSP = new OperatorSelectPage(Company);
            OSP.Show();
        }

        private void همراهاولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportChargePage ICP = new ImportChargePage(Company, "HamrahAval");
            ICP.Show();
        }

        private void ایرانسلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportChargePage ICP = new ImportChargePage(Company, "Irancel");
            ICP.Show();
        }

        private void تالیاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportChargePage ICP = new ImportChargePage(Company, "Taliya");
            ICP.Show();
        }

        private void رایتلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportChargePage ICP = new ImportChargePage(Company, "Rightel");
            ICP.Show();
        }

     

        private void ظرفیتسرورToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChargeCapacityOnServer CCOS = new ChargeCapacityOnServer(Company);
            CCOS.Show();
        }


        private void ظرفیتانبارToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChargeCapacityOnFrontStore CCOFS = new ChargeCapacityOnFrontStore(Company);
            CCOFS.Show();
        }

        private void قیمتفروششارژToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChargePricePage CPP = new ChargePricePage(Company);
            CPP.Show();
        }

        private void HomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Company.SaveChargeSetting();
        }

        private void همراهاولToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChargeAmountOnFrontStore CAOFS = new ChargeAmountOnFrontStore(Company, "HamrahAval");
            CAOFS.Show();
        }

        private void ایرانسلToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChargeAmountOnFrontStore CAOFS = new ChargeAmountOnFrontStore(Company, "Irancel");
            CAOFS.Show();
        }

        private void تالیاToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChargeAmountOnFrontStore CAOFS = new ChargeAmountOnFrontStore(Company, "Taliya");
            CAOFS.Show();
        }

        private void رایتلToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChargeAmountOnFrontStore CAOFS = new ChargeAmountOnFrontStore(Company, "Rightel");
            CAOFS.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChargeAmountOnServer CAOS = new ChargeAmountOnServer(Company, "HamrahAval");
            CAOS.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChargeAmountOnServer CAOS = new ChargeAmountOnServer(Company, "Irancel");
            CAOS.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChargeAmountOnServer CAOS = new ChargeAmountOnServer(Company, "Taliya");
            CAOS.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChargeAmountOnServer CAOS = new ChargeAmountOnServer(Company, "Rightel");
            CAOS.Show();
        }

       

        private void ماهانهToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReportCompanyPurchaseMonthly RCPM = new ReportCompanyPurchaseMonthly(Company);
            RCPM.Show();
        }

        private void روزانهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportCompanySoldDaily RCSD = new ReportCompanySoldDaily(Company);
            RCSD.Show();
        }

        private void ماهانهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportCompanySoldMonthly RCSM = new ReportCompanySoldMonthly(Company);
            RCSM.Show();
        }

        private void روزانهToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ReportAgencySelectDaily RASD = new ReportAgencySelectDaily(Company);
            RASD.Show();
        }

        private void ماهانهToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ReportAgencySelectMonthly RASM = new ReportAgencySelectMonthly(Company);
            RASM.Show();
        }

        private void یکروزهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportCompanyPurchaseTimely RCPT = new ReportCompanyPurchaseTimely(Company);
            RCPT.Show();
        }

        private void چندروزهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportCompanyPurchaseDaily RCPD = new ReportCompanyPurchaseDaily(Company);
            RCPD.Show();
        }

        private void یکروزهToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReportCompanySoldTimely RCST = new ReportCompanySoldTimely(Company);
            RCST.Show();
        }

        private void چندروزهToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReportCompanySoldDaily RCSD = new ReportCompanySoldDaily(Company);
            RCSD.Show();
        }

        private void یکروزهToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ReportAgencySelectTimely RAST = new ReportAgencySelectTimely(Company);
            RAST.Show();
        }

        private void چندروزهToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ReportAgencySelectDaily RASD = new ReportAgencySelectDaily(Company);
            RASD.Show();
        }
    }
}
