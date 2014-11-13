using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Globalization;
using FarsiLibrary.Utils;
using System.ServiceModel;

namespace AgencyBusinessLayer
{
    public class AgencyBusiness : IAgencyBusiness
    {

        public Int64 AgencyID;
        public string AgencyPassword;
        private Int64 SessionToken;


     

        public bool IsValidAgency(Int64 username, string password)
        {
            AgencyID = username;
            AgencyPassword = password;
            IISChargeService.AgencyServiceClient proxy = new IISChargeService.AgencyServiceClient();
            Int64 AgencyValidation = proxy.AgencyValidator(AgencyID, AgencyPassword);

            if (proxy.State == CommunicationState.Faulted)
                proxy.Abort();
            else
                proxy.Close();
            if (AgencyValidation != 0)
            {
                SessionToken = AgencyValidation;
                return true;
            }
            return false ;
        }

        public void AgencyLogOut() {

            IISChargeService.AgencyServiceClient proxy = new IISChargeService.AgencyServiceClient();
            proxy.AgencyLogOut(AgencyID,SessionToken);
            if (proxy.State == CommunicationState.Faulted)
                proxy.Abort();
            else
                proxy.Close();
        
        }
        public bool AgencyChangePassword(string oldpassword, string newpassword)
        {

            IISChargeService.AgencyServiceClient proxy = new IISChargeService.AgencyServiceClient();
            bool AgencypasswordChange = proxy.AgencyChangePassword(AgencyID, oldpassword, newpassword);
            return AgencypasswordChange;
        }

       public string CheckAgencyCredit() {
            IISChargeService.AgencyServiceClient proxy = new IISChargeService.AgencyServiceClient();
            string creditInfo = proxy.CheckAgencyCredit(AgencyID);
            return creditInfo;
        }

        public DataSet RequestCharge(string OperatorName, string Category, int amountOfcharge,string tempOp,string tempCat)
        {
            IISChargeService.AgencyServiceClient proxy = new IISChargeService.AgencyServiceClient();
           

            IISChargeService.ChargeTable ct = new IISChargeService.ChargeTable();
            ct = proxy.RequestCharge(OperatorName, Category, amountOfcharge, AgencyID);
            DataTable dt = new DataTable();
            dt = ct.GetChargeTable;

            ChargePrintDS CPDS = new ChargePrintDS();
            foreach(DataRow dr in dt.Rows){
                CPDS.ChargePrintDT.Rows.Add(dr[0], dr[1], dr[2], tempOp, tempCat);
            }
            return CPDS;
        }

        public DataTable RequestDailyReport(DateTime FromDate, DateTime ToDate)
        {
            IISChargeService.AgencyServiceClient proxy = new IISChargeService.AgencyServiceClient();
            IISChargeService.ChargeTable ct = new IISChargeService.ChargeTable();
            ct = proxy.RequestDailyReport(AgencyID, FromDate, ToDate);
            DataTable dt = new DataTable();
            dt = ct.GetChargeTable;
            return dt;
        }

        public DataTable RequestMonthlyReport(int year)
        {
            IISChargeService.AgencyServiceClient proxy = new IISChargeService.AgencyServiceClient();
            IISChargeService.ChargeTable ct = new IISChargeService.ChargeTable();
            ct = proxy.RequestMonthlyReport(AgencyID, year);
            DataTable dt = new DataTable();
            dt = ct.GetChargeTable;
            return dt;
        }

        public DataTable NumberOfAgencySoldCharge(DateTime BeginDate, DateTime EndDate, Int64 AgencyID)
        {



            IISChargeService.AgencyServiceClient proxy = new IISChargeService.AgencyServiceClient();
            IISChargeService.ChargeTable ct = new IISChargeService.ChargeTable();
            ct = proxy.NumberOfAgencySoldCharge(BeginDate, EndDate, AgencyID);
            DataTable In_Server = new DataTable();
            In_Server = ct.GetChargeTable;

            DataTable dt = new DataTable("AgencyPurchaseDaily_DT");
            dt.Columns.Add("Charge_Price_Category", typeof(string));
            dt.Columns.Add("HamrahAval", typeof(int));
            dt.Columns.Add("Irancel", typeof(int));
            dt.Columns.Add("Taliya", typeof(int));
            dt.Columns.Add("Rightel", typeof(int));


            DataRow dr = dt.NewRow();
            dr[0] = "1,000 تومانی";
            dr[1] = int.Parse(In_Server.Rows[0][0].ToString());
            dr[2] = int.Parse(In_Server.Rows[0][4].ToString());
            dr[3] = int.Parse(In_Server.Rows[0][8].ToString());
            dr[4] = int.Parse(In_Server.Rows[0][12].ToString());
            dt.Rows.Add(dr);
            DataRow dr1 = dt.NewRow();
            dr1[0] = "2,000 تومانی";
            dr1[1] = int.Parse(In_Server.Rows[0][1].ToString());
            dr1[2] = int.Parse(In_Server.Rows[0][5].ToString());
            dr1[3] = int.Parse(In_Server.Rows[0][9].ToString());
            dr1[4] = int.Parse(In_Server.Rows[0][13].ToString());
            dt.Rows.Add(dr1);
            DataRow dr2 = dt.NewRow();
            dr2[0] = "5,000 تومانی";
            dr2[1] = int.Parse(In_Server.Rows[0][2].ToString());
            dr2[2] = int.Parse(In_Server.Rows[0][6].ToString());
            dr2[3] = int.Parse(In_Server.Rows[0][10].ToString());
            dr2[4] = int.Parse(In_Server.Rows[0][14].ToString());
            dt.Rows.Add(dr2);
            DataRow dr3 = dt.NewRow();
            dr3[0] = "10,000 تومانی";
            dr3[1] = int.Parse(In_Server.Rows[0][3].ToString());
            dr3[2] = int.Parse(In_Server.Rows[0][7].ToString());
            dr3[3] = int.Parse(In_Server.Rows[0][11].ToString());
            dr3[4] = int.Parse(In_Server.Rows[0][15].ToString());
            dt.Rows.Add(dr3);

            return dt;
        }


        public DataSet TimeBase_AgencySoldDaily(DateTime Date, Int64 AgencyID)
        {


            IISChargeService.AgencyServiceClient proxy = new IISChargeService.AgencyServiceClient();
            IISChargeService.ChargeTable ct = new IISChargeService.ChargeTable();
            ct = proxy.TimeBase_AgencySoldDaily(Date, AgencyID);
            DataTable In_Server = new DataTable();
            In_Server = ct.GetChargeTable;



            var newSort = from row in In_Server.AsEnumerable()
                          group row by new { ID = row.Field<string>("Charge_Operator"), Cat = row.Field<int>("Charge_Price_Category"), time1 = row.Field<DateTime>("DateBuyed").ToString("hh:mm:ss tt") } into grp
                          orderby grp.Key.time1
                          select new
                          {
                              Charge_Operator = grp.Key.ID,
                              Charge_Price_Category = grp.Key.Cat,
                              Charge_Date_Buyed = grp.Key.time1,
                              Sum = grp.Sum(r => r.Field<int>("ChargeCount"))
                          };

            AgencyPurchaseDailyDataSet CPDDS = new AgencyPurchaseDailyDataSet();

            //******************************
            DataTable dt = NumberOfAgencySoldCharge(Date, Date.AddDays(1), AgencyID);
            foreach (DataRow dr in dt.Rows)
            {
                CPDDS.AgencyPurchaseDaily_DT.Rows.Add(dr.ItemArray);
            }
            //***********************************

            foreach (var t in newSort)
            {
                string timeofBuy = t.Charge_Date_Buyed;
                timeofBuy = timeofBuy.Replace("AM", "صبح");
                timeofBuy = timeofBuy.Replace("PM", "عصر");
                if (t.Charge_Operator.ToString() == "HamrahAval")
                {
                    if (t.Charge_Price_Category == 1000)
                        CPDDS.Hamrah_1000_DT.Rows.Add(timeofBuy, t.Sum);
                    else if (t.Charge_Price_Category == 2000)
                        CPDDS.Hamrah_2000_DT.Rows.Add(timeofBuy, t.Sum);
                    else if (t.Charge_Price_Category == 5000)
                        CPDDS.Hamrah_5000_DT.Rows.Add(timeofBuy, t.Sum);
                    else if (t.Charge_Price_Category == 10000)
                        CPDDS.Hamrah_10000_DT.Rows.Add(timeofBuy, t.Sum);
                }
                else if (t.Charge_Operator.ToString() == "Irancel")
                {
                    if (t.Charge_Price_Category == 1000)
                        CPDDS.Irancel_1000_DT.Rows.Add(timeofBuy, t.Sum);
                    else if (t.Charge_Price_Category == 2000)
                        CPDDS.Irancel_2000_DT.Rows.Add(timeofBuy, t.Sum);
                    else if (t.Charge_Price_Category == 5000)
                        CPDDS.Irancel_5000_DT.Rows.Add(timeofBuy, t.Sum);
                    else if (t.Charge_Price_Category == 10000)
                        CPDDS.Irancel_10000_DT.Rows.Add(timeofBuy, t.Sum);
                }
                else if (t.Charge_Operator.ToString() == "Taliya")
                {
                    if (t.Charge_Price_Category == 1000)
                        CPDDS.Taliya_1000_DT.Rows.Add(timeofBuy, t.Sum);
                    else if (t.Charge_Price_Category == 2000)
                        CPDDS.Taliya_2000_DT.Rows.Add(timeofBuy, t.Sum);
                    else if (t.Charge_Price_Category == 5000)
                        CPDDS.Taliya_5000_DT.Rows.Add(timeofBuy, t.Sum);
                    else if (t.Charge_Price_Category == 10000)
                        CPDDS.Taliya_10000_DT.Rows.Add(timeofBuy, t.Sum);
                }
                else if (t.Charge_Operator.ToString() == "Rightel")
                {
                    if (t.Charge_Price_Category == 1000)
                        CPDDS.Rightel_1000_DT.Rows.Add(timeofBuy, t.Sum);
                    else if (t.Charge_Price_Category == 2000)
                        CPDDS.Rightel_2000_DT.Rows.Add(timeofBuy, t.Sum);
                    else if (t.Charge_Price_Category == 5000)
                        CPDDS.Rightel_5000_DT.Rows.Add(timeofBuy, t.Sum);
                    else if (t.Charge_Price_Category == 10000)
                        CPDDS.Rightel_10000_DT.Rows.Add(timeofBuy, t.Sum);
                }
            }





            var mynewSort = from row in In_Server.AsEnumerable()
                            group row by new { ID = row.Field<string>("Charge_Operator"), Cat = row.Field<int>("Charge_Price_Category"), time1 = row.Field<DateTime>("DateBuyed").ToString("hh:mm:ss tt"), price = row.Field<int>("PriceBuyed") } into grp
                            orderby grp.Key.time1
                            select new
                            {
                                Charge_Operator = grp.Key.ID,
                                Charge_Price_Category = grp.Key.Cat,
                                Charge_Date_Buyed = grp.Key.time1,
                                PriceBuyed = grp.Key.price,
                                SumPriceBuyed = grp.Sum(r => r.Field<int>("TotalPrice")),
                                Sum = grp.Sum(r => r.Field<int>("ChargeCount"))
                            };


            foreach (var p in mynewSort)
            {
                string timeofBuy = p.Charge_Date_Buyed;
                timeofBuy = timeofBuy.Replace("AM", "صبح");
                timeofBuy = timeofBuy.Replace("PM", "عصر");
                //******
                NumberFormatInfo nfi = new NumberFormatInfo();
                nfi.NumberDecimalDigits = 0;
                string price_cat = Decimal.Parse(p.Charge_Price_Category.ToString(), NumberStyles.AllowThousands).ToString("N", nfi);
                string price_buyed = Decimal.Parse(p.PriceBuyed.ToString(), NumberStyles.AllowThousands).ToString("N", nfi);
                string price_sum = Decimal.Parse(p.SumPriceBuyed.ToString(), NumberStyles.AllowThousands).ToString("N", nfi);
                string sum = Decimal.Parse(p.Sum.ToString(), NumberStyles.AllowThousands).ToString("N", nfi);
                //*******


                if (p.Charge_Operator.ToString() == "HamrahAval")
                {
                    if (p.Charge_Price_Category == 1000)
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "همراه اول", price_cat, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 2000)
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "همراه اول", price_cat, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 5000)
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "همراه اول", price_cat, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 10000)
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "همراه اول", price_cat, price_buyed, sum, price_sum);
                }
                else if (p.Charge_Operator.ToString() == "Irancel")
                {
                    if (p.Charge_Price_Category == 1000)
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "ایرانسل", price_cat, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 2000)
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "ایرانسل", price_cat, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 5000)
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "ایرانسل", price_cat, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 10000)
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "ایرانسل", price_cat, price_buyed, sum, price_sum);
                }
                else if (p.Charge_Operator.ToString() == "Taliya")
                {
                    if (p.Charge_Price_Category == 1000)
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "تالیا", price_cat, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 2000)
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "تالیا", price_cat, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 5000)
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "تالیا", price_cat, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 10000)
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "تالیا", price_cat, price_buyed, sum, price_sum);
                }
                else if (p.Charge_Operator.ToString() == "Rightel")
                {
                    if (p.Charge_Price_Category == 1000)
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "رایتل", price_cat, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 2000)
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "رایتل", price_cat, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 5000)
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "رایتل", price_cat, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 10000)
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "رایتل", price_cat, price_buyed, sum, price_sum);
                }
            }

            return CPDDS;
        }

        public DataSet DayBase_AgencySoldDaily(DateTime BeginDate, DateTime EndDate, Int64 AgencyID)
        {


            IISChargeService.AgencyServiceClient proxy = new IISChargeService.AgencyServiceClient();
            IISChargeService.ChargeTable ct = new IISChargeService.ChargeTable();
            ct = proxy.DayBase_AgencySoldDaily(BeginDate, EndDate, AgencyID);
            DataTable In_Server = new DataTable();
            In_Server = ct.GetChargeTable;



            var newSort = from row in In_Server.AsEnumerable()
                          group row by new { ID = row.Field<string>("Charge_Operator"), Cat = row.Field<int>("Charge_Price_Category"), time1 = row.Field<DateTime>("DateBuyed").Date } into grp
                          orderby grp.Key.time1
                          select new
                          {
                              Charge_Operator = grp.Key.ID,
                              Charge_Price_Category = grp.Key.Cat,
                              Charge_Date_Buyed = grp.Key.time1,
                              Sum = grp.Sum(r => r.Field<int>("ChargeCount"))
                          };

            AgencyPurchaseDailyDataSet CPDDS = new AgencyPurchaseDailyDataSet();

            //******************************
            DataTable dt = NumberOfAgencySoldCharge(BeginDate, EndDate, AgencyID);
            foreach (DataRow dr in dt.Rows)
            {
                CPDDS.AgencyPurchaseDaily_DT.Rows.Add(dr.ItemArray);
            }
            //***********************************

            foreach (var t in newSort)
            {
                if (t.Charge_Operator.ToString() == "HamrahAval")
                {
                    if (t.Charge_Price_Category == 1000)
                        CPDDS.Hamrah_1000_DT.Rows.Add(PersianDateConverter.ToPersianDate(t.Charge_Date_Buyed).ToString("yyyy-MM-dd"), t.Sum);
                    else if (t.Charge_Price_Category == 2000)
                        CPDDS.Hamrah_2000_DT.Rows.Add(PersianDateConverter.ToPersianDate(t.Charge_Date_Buyed).ToString("yyyy-MM-dd"), t.Sum);
                    else if (t.Charge_Price_Category == 5000)
                        CPDDS.Hamrah_5000_DT.Rows.Add(PersianDateConverter.ToPersianDate(t.Charge_Date_Buyed).ToString("yyyy-MM-dd"), t.Sum);
                    else if (t.Charge_Price_Category == 10000)
                        CPDDS.Hamrah_10000_DT.Rows.Add(PersianDateConverter.ToPersianDate(t.Charge_Date_Buyed).ToString("yyyy-MM-dd"), t.Sum);
                }
                else if (t.Charge_Operator.ToString() == "Irancel")
                {
                    if (t.Charge_Price_Category == 1000)
                        CPDDS.Irancel_1000_DT.Rows.Add(PersianDateConverter.ToPersianDate(t.Charge_Date_Buyed).ToString("yyyy-MM-dd"), t.Sum);
                    else if (t.Charge_Price_Category == 2000)
                        CPDDS.Irancel_2000_DT.Rows.Add(PersianDateConverter.ToPersianDate(t.Charge_Date_Buyed).ToString("yyyy-MM-dd"), t.Sum);
                    else if (t.Charge_Price_Category == 5000)
                        CPDDS.Irancel_5000_DT.Rows.Add(PersianDateConverter.ToPersianDate(t.Charge_Date_Buyed).ToString("yyyy-MM-dd"), t.Sum);
                    else if (t.Charge_Price_Category == 10000)
                        CPDDS.Irancel_10000_DT.Rows.Add(PersianDateConverter.ToPersianDate(t.Charge_Date_Buyed).ToString("yyyy-MM-dd"), t.Sum);
                }
                else if (t.Charge_Operator.ToString() == "Taliya")
                {
                    if (t.Charge_Price_Category == 1000)
                        CPDDS.Taliya_1000_DT.Rows.Add(PersianDateConverter.ToPersianDate(t.Charge_Date_Buyed).ToString("yyyy-MM-dd"), t.Sum);
                    else if (t.Charge_Price_Category == 2000)
                        CPDDS.Taliya_2000_DT.Rows.Add(PersianDateConverter.ToPersianDate(t.Charge_Date_Buyed).ToString("yyyy-MM-dd"), t.Sum);
                    else if (t.Charge_Price_Category == 5000)
                        CPDDS.Taliya_5000_DT.Rows.Add(PersianDateConverter.ToPersianDate(t.Charge_Date_Buyed).ToString("yyyy-MM-dd"), t.Sum);
                    else if (t.Charge_Price_Category == 10000)
                        CPDDS.Taliya_10000_DT.Rows.Add(PersianDateConverter.ToPersianDate(t.Charge_Date_Buyed).ToString("yyyy-MM-dd"), t.Sum);
                }
                else if (t.Charge_Operator.ToString() == "Rightel")
                {
                    if (t.Charge_Price_Category == 1000)
                        CPDDS.Rightel_1000_DT.Rows.Add(PersianDateConverter.ToPersianDate(t.Charge_Date_Buyed).ToString("yyyy-MM-dd"), t.Sum);
                    else if (t.Charge_Price_Category == 2000)
                        CPDDS.Rightel_2000_DT.Rows.Add(PersianDateConverter.ToPersianDate(t.Charge_Date_Buyed).ToString("yyyy-MM-dd"), t.Sum);
                    else if (t.Charge_Price_Category == 5000)
                        CPDDS.Rightel_5000_DT.Rows.Add(PersianDateConverter.ToPersianDate(t.Charge_Date_Buyed).ToString("yyyy-MM-dd"), t.Sum);
                    else if (t.Charge_Price_Category == 10000)
                        CPDDS.Rightel_10000_DT.Rows.Add(PersianDateConverter.ToPersianDate(t.Charge_Date_Buyed).ToString("yyyy-MM-dd"), t.Sum);
                }
            }





            var mynewSort = from row in In_Server.AsEnumerable()
                            group row by new { ID = row.Field<string>("Charge_Operator"), Cat = row.Field<int>("Charge_Price_Category"), time1 = row.Field<DateTime>("DateBuyed"), price = row.Field<int>("PriceBuyed") } into grp
                            orderby grp.Key.time1
                            select new
                            {
                                Charge_Operator = grp.Key.ID,
                                Charge_Price_Category = grp.Key.Cat,
                                Charge_Date_Buyed = grp.Key.time1,
                                PriceBuyed = grp.Key.price,
                                SumPriceBuyed = grp.Sum(r => r.Field<int>("TotalPrice")),
                                Sum = grp.Sum(r => r.Field<int>("ChargeCount"))
                            };


            foreach (var p in mynewSort)
            {
                //******
                NumberFormatInfo nfi = new NumberFormatInfo();
                nfi.NumberDecimalDigits = 0;
                string price_cat = Decimal.Parse(p.Charge_Price_Category.ToString(), NumberStyles.AllowThousands).ToString("N", nfi);
                string price_buyed = Decimal.Parse(p.PriceBuyed.ToString(), NumberStyles.AllowThousands).ToString("N", nfi);
                string price_sum = Decimal.Parse(p.SumPriceBuyed.ToString(), NumberStyles.AllowThousands).ToString("N", nfi);
                string sum = Decimal.Parse(p.Sum.ToString(), NumberStyles.AllowThousands).ToString("N", nfi);
                //*******


                if (p.Charge_Operator.ToString() == "HamrahAval")
                {
                    if (p.Charge_Price_Category == 1000)
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "همراه اول", price_cat,price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 2000)
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "همراه اول", price_cat, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 5000)
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "همراه اول", price_cat, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 10000)
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "همراه اول", price_cat,  price_buyed, sum, price_sum);
                }
                else if (p.Charge_Operator.ToString() == "Irancel")
                {
                    if (p.Charge_Price_Category == 1000)
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "ایرانسل", price_cat, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 2000)
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "ایرانسل", price_cat, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 5000)
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "ایرانسل", price_cat, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 10000)
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "ایرانسل", price_cat, price_buyed, sum, price_sum);
                }
                else if (p.Charge_Operator.ToString() == "Taliya")
                {
                    if (p.Charge_Price_Category == 1000)
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "تالیا", price_cat,  price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 2000)
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "تالیا", price_cat, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 5000)
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "تالیا", price_cat,price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 10000)
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "تالیا", price_cat, price_buyed, sum, price_sum);
                }
                else if (p.Charge_Operator.ToString() == "Rightel")
                {
                    if (p.Charge_Price_Category == 1000)
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "رایتل", price_cat, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 2000)
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "رایتل", price_cat,  price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 5000)
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "رایتل", price_cat,  price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 10000)
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "رایتل", price_cat, price_buyed, sum, price_sum);
                }
            }

            return CPDDS;
        }


        public DataSet MonthBase_AgencySoldDaily(DateTime BeginDate, DateTime EndDate, Int64 AgencyID)
        {



            IISChargeService.AgencyServiceClient proxy = new IISChargeService.AgencyServiceClient();
            IISChargeService.ChargeTable ct = new IISChargeService.ChargeTable();
            ct = proxy.DayBase_AgencySoldDaily(BeginDate, EndDate, AgencyID);
            DataTable In_Server = new DataTable();
            In_Server = ct.GetChargeTable;



            var newSort = from row in In_Server.AsEnumerable()
                          group row by new { ID = row.Field<string>("Charge_Operator"), Cat = row.Field<int>("Charge_Price_Category"), time1 = PersianDateConverter.ToPersianDate(row.Field<DateTime>("DateBuyed")).Month } into grp
                          orderby grp.Key.time1
                          select new
                          {
                              Charge_Operator = grp.Key.ID,
                              Charge_Price_Category = grp.Key.Cat,
                              Charge_Date_Buyed = grp.Key.time1,
                              //PersianDateConverter.ToPersianDate(grp.Key.time1).Month,
                              Sum = grp.Sum(r => r.Field<int>("ChargeCount"))
                          };

            AgencyPurchaseDailyDataSet CPDDS = new AgencyPurchaseDailyDataSet();

            //******************************
            DataTable dt = NumberOfAgencySoldCharge(BeginDate, EndDate, AgencyID);
            foreach (DataRow dr in dt.Rows)
            {
                CPDDS.AgencyPurchaseDaily_DT.Rows.Add(dr.ItemArray);
            }
            //***********************************

            foreach (var t in newSort)
            {
                string persianmonth;
                switch (t.Charge_Date_Buyed)
                {
                    case 1:
                        persianmonth = "فروردین";
                        break;
                    case 2:
                        persianmonth = "اردیبهشت";
                        break;
                    case 3:
                        persianmonth = "خرداد";
                        break;
                    case 4:
                        persianmonth = "تیر";
                        break;
                    case 5:
                        persianmonth = "مرداد";
                        break;
                    case 6:
                        persianmonth = "شهریور";
                        break;
                    case 7:
                        persianmonth = "مهر";
                        break;
                    case 8:
                        persianmonth = "آبان";
                        break;
                    case 9:
                        persianmonth = "آذر";
                        break;
                    case 10:
                        persianmonth = "دی";
                        break;
                    case 11:
                        persianmonth = "بهمن";
                        break;
                    case 12:
                        persianmonth = "اسفند";
                        break;
                    default:
                        persianmonth = "خطا";
                        break;
                }
                if (t.Charge_Operator.ToString() == "HamrahAval")
                {
                    if (t.Charge_Price_Category == 1000)
                        CPDDS.Hamrah_1000_DT.Rows.Add(persianmonth, t.Sum);
                    else if (t.Charge_Price_Category == 2000)
                        CPDDS.Hamrah_2000_DT.Rows.Add(persianmonth, t.Sum);
                    else if (t.Charge_Price_Category == 5000)
                        CPDDS.Hamrah_5000_DT.Rows.Add(persianmonth, t.Sum);
                    else if (t.Charge_Price_Category == 10000)
                        CPDDS.Hamrah_10000_DT.Rows.Add(persianmonth, t.Sum);
                }
                else if (t.Charge_Operator.ToString() == "Irancel")
                {
                    if (t.Charge_Price_Category == 1000)
                        CPDDS.Irancel_1000_DT.Rows.Add(persianmonth, t.Sum);
                    else if (t.Charge_Price_Category == 2000)
                        CPDDS.Irancel_2000_DT.Rows.Add(persianmonth, t.Sum);
                    else if (t.Charge_Price_Category == 5000)
                        CPDDS.Irancel_5000_DT.Rows.Add(persianmonth, t.Sum);
                    else if (t.Charge_Price_Category == 10000)
                        CPDDS.Irancel_10000_DT.Rows.Add(persianmonth, t.Sum);
                }
                else if (t.Charge_Operator.ToString() == "Taliya")
                {
                    if (t.Charge_Price_Category == 1000)
                        CPDDS.Taliya_1000_DT.Rows.Add(persianmonth, t.Sum);
                    else if (t.Charge_Price_Category == 2000)
                        CPDDS.Taliya_2000_DT.Rows.Add(persianmonth, t.Sum);
                    else if (t.Charge_Price_Category == 5000)
                        CPDDS.Taliya_5000_DT.Rows.Add(persianmonth, t.Sum);
                    else if (t.Charge_Price_Category == 10000)
                        CPDDS.Taliya_10000_DT.Rows.Add(persianmonth, t.Sum);
                }
                else if (t.Charge_Operator.ToString() == "Rightel")
                {
                    if (t.Charge_Price_Category == 1000)
                        CPDDS.Rightel_1000_DT.Rows.Add(persianmonth, t.Sum);
                    else if (t.Charge_Price_Category == 2000)
                        CPDDS.Rightel_2000_DT.Rows.Add(persianmonth, t.Sum);
                    else if (t.Charge_Price_Category == 5000)
                        CPDDS.Rightel_5000_DT.Rows.Add(persianmonth, t.Sum);
                    else if (t.Charge_Price_Category == 10000)
                        CPDDS.Rightel_10000_DT.Rows.Add(persianmonth, t.Sum);
                }
            }





            var mynewSort = from row in In_Server.AsEnumerable()
                            group row by new { ID = row.Field<string>("Charge_Operator"), Cat = row.Field<int>("Charge_Price_Category"), time1 = PersianDateConverter.ToPersianDate(row.Field<DateTime>("DateBuyed")).Month, price = row.Field<int>("PriceBuyed") } into grp
                            orderby grp.Key.time1
                            select new
                            {
                                Charge_Operator = grp.Key.ID,
                                Charge_Price_Category = grp.Key.Cat,
                                Charge_Date_Buyed =grp.Key.time1,
                                //PersianDateConverter.ToPersianDate(grp.Key.time1).Month,
                                PriceBuyed = grp.Key.price,
                               
                                SumPriceBuyed = grp.Sum(r => r.Field<int>("TotalPrice")),
                                Sum = grp.Sum(r => r.Field<int>("ChargeCount"))
                            };


            foreach (var p in mynewSort)
            {
                //******
                NumberFormatInfo nfi = new NumberFormatInfo();
                nfi.NumberDecimalDigits = 0;
                string price_cat = Decimal.Parse(p.Charge_Price_Category.ToString(), NumberStyles.AllowThousands).ToString("N", nfi);
                string price_buyed = Decimal.Parse(p.PriceBuyed.ToString(), NumberStyles.AllowThousands).ToString("N", nfi);
                string price_sum = Decimal.Parse(p.SumPriceBuyed.ToString(), NumberStyles.AllowThousands).ToString("N", nfi);
                string sum = Decimal.Parse(p.Sum.ToString(), NumberStyles.AllowThousands).ToString("N", nfi);
                //*******
                string persianmonth;
                switch (p.Charge_Date_Buyed)
                {
                    case 1:
                        persianmonth = "فروردین";
                        break;
                    case 2:
                        persianmonth = "اردیبهشت";
                        break;
                    case 3:
                        persianmonth = "خرداد";
                        break;
                    case 4:
                        persianmonth = "تیر";
                        break;
                    case 5:
                        persianmonth = "مرداد";
                        break;
                    case 6:
                        persianmonth = "شهریور";
                        break;
                    case 7:
                        persianmonth = "مهر";
                        break;
                    case 8:
                        persianmonth = "آبان";
                        break;
                    case 9:
                        persianmonth = "آذر";
                        break;
                    case 10:
                        persianmonth = "دی";
                        break;
                    case 11:
                        persianmonth = "بهمن";
                        break;
                    case 12:
                        persianmonth = "اسفند";
                        break;
                    default:
                        persianmonth = "خطا";
                        break;
                }

                if (p.Charge_Operator.ToString() == "HamrahAval")
                {
                    if (p.Charge_Price_Category == 1000)
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "همراه اول", price_cat,  price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 2000)
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "همراه اول", price_cat, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 5000)
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "همراه اول", price_cat,  price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 10000)
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "همراه اول", price_cat, price_buyed, sum, price_sum);
                }
                else if (p.Charge_Operator.ToString() == "Irancel")
                {
                    if (p.Charge_Price_Category == 1000)
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "ایرانسل", price_cat,  price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 2000)
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "ایرانسل", price_cat,  price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 5000)
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "ایرانسل", price_cat,  price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 10000)
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "ایرانسل", price_cat, price_buyed, sum, price_sum);
                }
                else if (p.Charge_Operator.ToString() == "Taliya")
                {
                    if (p.Charge_Price_Category == 1000)
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "تالیا", price_cat,  price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 2000)
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "تالیا", price_cat,  price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 5000)
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "تالیا", price_cat,  price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 10000)
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "تالیا", price_cat,  price_buyed, sum, price_sum);
                }
                else if (p.Charge_Operator.ToString() == "Rightel")
                {
                    if (p.Charge_Price_Category == 1000)
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "رایتل", price_cat, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 2000)
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "رایتل", price_cat,  price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 5000)
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "رایتل", price_cat,  price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 10000)
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "رایتل", price_cat, price_buyed, sum, price_sum);
                }
            }


            return CPDDS;
        }
    }
}


