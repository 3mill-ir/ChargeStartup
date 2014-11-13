using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Security.Cryptography;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Globalization;
using FarsiLibrary.Utils;

namespace CompanyBussinesLayer
{
    public class CompanyBusiness : ICompanyBusiness
    {
        public Int64 UserID;
        public string UserPassword;
        public bool User_isOperator;
        //**********************************************************
        public int Hamrah_1000_Store;
        public int Hamrah_2000_Store;
        public int Hamrah_5000_Store;
        public int Hamrah_10000_Store;

        public int Irancel_1000_Store;
        public int Irancel_2000_Store;
        public int Irancel_5000_Store;
        public int Irancel_10000_Store;

        public int Taliya_1000_Store;
        public int Taliya_2000_Store;
        public int Taliya_5000_Store;
        public int Taliya_10000_Store;

        public int Rightel_1000_Store;
        public int Rightel_2000_Store;
        public int Rightel_5000_Store;
        public int Rightel_10000_Store;



        public int Hamrah_1000_FrontStore;
        public int Hamrah_2000_FrontStore;
        public int Hamrah_5000_FrontStore;
        public int Hamrah_10000_FrontStore;

        public int Irancel_1000_FrontStore;
        public int Irancel_2000_FrontStore;
        public int Irancel_5000_FrontStore;
        public int Irancel_10000_FrontStore;

        public int Taliya_1000_FrontStore;
        public int Taliya_2000_FrontStore;
        public int Taliya_5000_FrontStore;
        public int Taliya_10000_FrontStore;

        public int Rightel_1000_FrontStore;
        public int Rightel_2000_FrontStore;
        public int Rightel_5000_FrontStore;
        public int Rightel_10000_FrontStore;


        public int Hamrah_1000_Server;
        public int Hamrah_2000_Server;
        public int Hamrah_5000_Server;
        public int Hamrah_10000_Server;

        public int Irancel_1000_Server;
        public int Irancel_2000_Server;
        public int Irancel_5000_Server;
        public int Irancel_10000_Server;

        public int Taliya_1000_Server;
        public int Taliya_2000_Server;
        public int Taliya_5000_Server;
        public int Taliya_10000_Server;

        public int Rightel_1000_Server;
        public int Rightel_2000_Server;
        public int Rightel_5000_Server;
        public int Rightel_10000_Server;


        //*************************************************************
        public int Hamrah_1000_Price;
        public int Hamrah_2000_Price;
        public int Hamrah_5000_Price;
        public int Hamrah_10000_Price;

        public int Irancel_1000_Price;
        public int Irancel_2000_Price;
        public int Irancel_5000_Price;
        public int Irancel_10000_Price;

        public int Taliya_1000_Price;
        public int Taliya_2000_Price;
        public int Taliya_5000_Price;
        public int Taliya_10000_Price;

        public int Rightel_1000_Price;
        public int Rightel_2000_Price;
        public int Rightel_5000_Price;
        public int Rightel_10000_Price;



        //**********************************************************
        public int Hamrah_1000_FrontStore_Capacity;
        public int Hamrah_2000_FrontStore_Capacity;
        public int Hamrah_5000_FrontStore_Capacity;
        public int Hamrah_10000_FrontStore_Capacity;

        public int Irancel_1000_FrontStore_Capacity;
        public int Irancel_2000_FrontStore_Capacity;
        public int Irancel_5000_FrontStore_Capacity;
        public int Irancel_10000_FrontStore_Capacity;

        public int Taliya_1000_FrontStore_Capacity;
        public int Taliya_2000_FrontStore_Capacity;
        public int Taliya_5000_FrontStore_Capacity;
        public int Taliya_10000_FrontStore_Capacity;

        public int Rightel_1000_FrontStore_Capacity;
        public int Rightel_2000_FrontStore_Capacity;
        public int Rightel_5000_FrontStore_Capacity;
        public int Rightel_10000_FrontStore_Capacity;


        public int Hamrah_1000_Server_Capacity;
        public int Hamrah_2000_Server_Capacity;
        public int Hamrah_5000_Server_Capacity;
        public int Hamrah_10000_Server_Capacity;

        public int Irancel_1000_Server_Capacity;
        public int Irancel_2000_Server_Capacity;
        public int Irancel_5000_Server_Capacity;
        public int Irancel_10000_Server_Capacity;

        public int Taliya_1000_Server_Capacity;
        public int Taliya_2000_Server_Capacity;
        public int Taliya_5000_Server_Capacity;
        public int Taliya_10000_Server_Capacity;

        public int Rightel_1000_Server_Capacity;
        public int Rightel_2000_Server_Capacity;
        public int Rightel_5000_Server_Capacity;
        public int Rightel_10000_Server_Capacity;





        public bool SaveChargeSetting()
        {
            ChargeSetting CCS = new ChargeSetting();

            CCS.Hamrah_1000_Price = Hamrah_1000_Price;
            CCS.Hamrah_2000_Price = Hamrah_2000_Price;
            CCS.Hamrah_5000_Price = Hamrah_5000_Price;
            CCS.Hamrah_10000_Price = Hamrah_10000_Price;

            CCS.Irancel_1000_Price = Irancel_1000_Price;
            CCS.Irancel_2000_Price = Irancel_2000_Price;
            CCS.Irancel_5000_Price = Irancel_5000_Price;
            CCS.Irancel_10000_Price = Irancel_10000_Price;

            CCS.Taliya_1000_Price = Taliya_1000_Price;
            CCS.Taliya_2000_Price = Taliya_2000_Price;
            CCS.Taliya_5000_Price = Taliya_5000_Price;
            CCS.Taliya_10000_Price = Taliya_10000_Price;

            CCS.Rightel_1000_Price = Rightel_1000_Price;
            CCS.Rightel_2000_Price = Rightel_2000_Price;
            CCS.Rightel_5000_Price = Rightel_5000_Price;
            CCS.Rightel_10000_Price = Rightel_10000_Price;






            CCS.Hamrah_1000_FrontStore_Capacity = Hamrah_1000_FrontStore_Capacity;
            CCS.Hamrah_2000_FrontStore_Capacity = Hamrah_2000_FrontStore_Capacity;
            CCS.Hamrah_5000_FrontStore_Capacity = Hamrah_5000_FrontStore_Capacity;
            CCS.Hamrah_10000_FrontStore_Capacity = Hamrah_10000_FrontStore_Capacity;

            CCS.Irancel_1000_FrontStore_Capacity = Irancel_1000_FrontStore_Capacity;
            CCS.Irancel_2000_FrontStore_Capacity = Irancel_2000_FrontStore_Capacity;
            CCS.Irancel_5000_FrontStore_Capacity = Irancel_5000_FrontStore_Capacity;
            CCS.Irancel_10000_FrontStore_Capacity = Irancel_10000_FrontStore_Capacity;

            CCS.Taliya_1000_FrontStore_Capacity = Taliya_1000_FrontStore_Capacity;
            CCS.Taliya_2000_FrontStore_Capacity = Taliya_2000_FrontStore_Capacity;
            CCS.Taliya_5000_FrontStore_Capacity = Taliya_5000_FrontStore_Capacity;
            CCS.Taliya_10000_FrontStore_Capacity = Taliya_10000_FrontStore_Capacity;

            CCS.Rightel_1000_FrontStore_Capacity = Rightel_1000_FrontStore_Capacity;
            CCS.Rightel_2000_FrontStore_Capacity = Rightel_2000_FrontStore_Capacity;
            CCS.Rightel_5000_FrontStore_Capacity = Rightel_5000_FrontStore_Capacity;
            CCS.Rightel_10000_FrontStore_Capacity = Rightel_10000_FrontStore_Capacity;




            CCS.Hamrah_1000_Server_Capacity = Hamrah_1000_Server_Capacity;
            CCS.Hamrah_2000_Server_Capacity = Hamrah_2000_Server_Capacity;
            CCS.Hamrah_5000_Server_Capacity = Hamrah_5000_Server_Capacity;
            CCS.Hamrah_10000_Server_Capacity = Hamrah_10000_Server_Capacity;

            CCS.Irancel_1000_Server_Capacity = Irancel_1000_Server_Capacity;
            CCS.Irancel_2000_Server_Capacity = Irancel_2000_Server_Capacity;
            CCS.Irancel_5000_Server_Capacity = Irancel_5000_Server_Capacity;
            CCS.Irancel_10000_Server_Capacity = Irancel_10000_Server_Capacity;

            CCS.Taliya_1000_Server_Capacity = Taliya_1000_Server_Capacity;
            CCS.Taliya_2000_Server_Capacity = Taliya_2000_Server_Capacity;
            CCS.Taliya_5000_Server_Capacity = Taliya_5000_Server_Capacity;
            CCS.Taliya_10000_Server_Capacity = Taliya_10000_Server_Capacity;

            CCS.Rightel_1000_Server_Capacity = Rightel_1000_Server_Capacity;
            CCS.Rightel_2000_Server_Capacity = Rightel_2000_Server_Capacity;
            CCS.Rightel_5000_Server_Capacity = Rightel_5000_Server_Capacity;
            CCS.Rightel_10000_Server_Capacity = Rightel_10000_Server_Capacity;


            Stream stream = File.Open("ChargeCapacity.osl", FileMode.Create);
            BinaryFormatter bformatter = new BinaryFormatter();


            bformatter.Serialize(stream, CCS);
            stream.Close();

            return true;
        }



        public bool RetriveChargeSetting()
        {
            if (File.Exists("ChargeCapacity.osl"))
            {
                ChargeSetting CCS = new ChargeSetting();
                Stream stream = File.Open("ChargeCapacity.osl", FileMode.Open);
                BinaryFormatter bformatter = new BinaryFormatter();


                CCS = (ChargeSetting)bformatter.Deserialize(stream);

                Hamrah_1000_Price = CCS.Hamrah_1000_Price;
                Hamrah_2000_Price = CCS.Hamrah_2000_Price;
                Hamrah_5000_Price = CCS.Hamrah_5000_Price;
                Hamrah_10000_Price = CCS.Hamrah_10000_Price;

                Irancel_1000_Price = CCS.Irancel_1000_Price;
                Irancel_2000_Price = CCS.Irancel_2000_Price;
                Irancel_5000_Price = CCS.Irancel_5000_Price;
                Irancel_10000_Price = CCS.Irancel_10000_Price;

                Taliya_1000_Price = CCS.Taliya_1000_Price;
                Taliya_2000_Price = CCS.Taliya_2000_Price;
                Taliya_5000_Price = CCS.Taliya_5000_Price;
                Taliya_10000_Price = CCS.Taliya_10000_Price;

                Rightel_1000_Price = CCS.Rightel_1000_Price;
                Rightel_2000_Price = CCS.Rightel_2000_Price;
                Rightel_5000_Price = CCS.Rightel_5000_Price;
                Rightel_10000_Price = CCS.Rightel_10000_Price;


                Hamrah_1000_FrontStore_Capacity = CCS.Hamrah_1000_FrontStore_Capacity;
                Hamrah_2000_FrontStore_Capacity = CCS.Hamrah_2000_FrontStore_Capacity;
                Hamrah_5000_FrontStore_Capacity = CCS.Hamrah_5000_FrontStore_Capacity;
                Hamrah_10000_FrontStore_Capacity = CCS.Hamrah_10000_FrontStore_Capacity;

                Irancel_1000_FrontStore_Capacity = CCS.Irancel_1000_FrontStore_Capacity;
                Irancel_2000_FrontStore_Capacity = CCS.Irancel_2000_FrontStore_Capacity;
                Irancel_5000_FrontStore_Capacity = CCS.Irancel_5000_FrontStore_Capacity;
                Irancel_10000_FrontStore_Capacity = CCS.Irancel_10000_FrontStore_Capacity;

                Taliya_1000_FrontStore_Capacity = CCS.Taliya_1000_FrontStore_Capacity;
                Taliya_2000_FrontStore_Capacity = CCS.Taliya_2000_FrontStore_Capacity;
                Taliya_5000_FrontStore_Capacity = CCS.Taliya_5000_FrontStore_Capacity;
                Taliya_10000_FrontStore_Capacity = CCS.Taliya_10000_FrontStore_Capacity;

                Rightel_1000_FrontStore_Capacity = CCS.Rightel_1000_FrontStore_Capacity;
                Rightel_2000_FrontStore_Capacity = CCS.Rightel_2000_FrontStore_Capacity;
                Rightel_5000_FrontStore_Capacity = CCS.Rightel_5000_FrontStore_Capacity;
                Rightel_10000_FrontStore_Capacity = CCS.Rightel_10000_FrontStore_Capacity;




                Hamrah_1000_Server_Capacity = CCS.Hamrah_1000_Server_Capacity;
                Hamrah_2000_Server_Capacity = CCS.Hamrah_2000_Server_Capacity;
                Hamrah_5000_Server_Capacity = CCS.Hamrah_5000_Server_Capacity;
                Hamrah_10000_Server_Capacity = CCS.Hamrah_10000_Server_Capacity;

                Irancel_1000_Server_Capacity = CCS.Irancel_1000_Server_Capacity;
                Irancel_2000_Server_Capacity = CCS.Irancel_2000_Server_Capacity;
                Irancel_5000_Server_Capacity = CCS.Irancel_5000_Server_Capacity;
                Irancel_10000_Server_Capacity = CCS.Irancel_10000_Server_Capacity;

                Taliya_1000_Server_Capacity = CCS.Taliya_1000_Server_Capacity;
                Taliya_2000_Server_Capacity = CCS.Taliya_2000_Server_Capacity;
                Taliya_5000_Server_Capacity = CCS.Taliya_5000_Server_Capacity;
                Taliya_10000_Server_Capacity = CCS.Taliya_10000_Server_Capacity;

                Rightel_1000_Server_Capacity = CCS.Rightel_1000_Server_Capacity;
                Rightel_2000_Server_Capacity = CCS.Rightel_2000_Server_Capacity;
                Rightel_5000_Server_Capacity = CCS.Rightel_5000_Server_Capacity;
                Rightel_10000_Server_Capacity = CCS.Rightel_10000_Server_Capacity;


                stream.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RetriveNumberOfChargeIn_FrontStore()
        {

            string S = "Data Source=.;Initial Catalog=Local_Charge_db;Integrated Security=True";
            SqlConnection SQLcon = new SqlConnection(S);
            SqlCommand SQLcom = new SqlCommand("NumberOfAllChargesIn_FrontStore");
            SQLcom.Connection = SQLcon;
            SQLcom.CommandType = CommandType.StoredProcedure;
            SQLcon.Open();
            DataTable dt = new DataTable("NumberOfAllChargesIn_FrontStore");
            SqlDataAdapter SQLda = new SqlDataAdapter(SQLcom);
            SQLda.Fill(dt);
            SQLcon.Close();



            Hamrah_1000_FrontStore = int.Parse(dt.Rows[0][0].ToString());
            Hamrah_2000_FrontStore = int.Parse(dt.Rows[0][1].ToString());
            Hamrah_5000_FrontStore = int.Parse(dt.Rows[0][2].ToString());
            Hamrah_10000_FrontStore = int.Parse(dt.Rows[0][3].ToString());

            Irancel_1000_FrontStore = int.Parse(dt.Rows[0][4].ToString());
            Irancel_2000_FrontStore = int.Parse(dt.Rows[0][5].ToString());
            Irancel_5000_FrontStore = int.Parse(dt.Rows[0][6].ToString());
            Irancel_10000_FrontStore = int.Parse(dt.Rows[0][7].ToString());

            Taliya_1000_FrontStore = int.Parse(dt.Rows[0][8].ToString());
            Taliya_2000_FrontStore = int.Parse(dt.Rows[0][9].ToString());
            Taliya_5000_FrontStore = int.Parse(dt.Rows[0][10].ToString());
            Taliya_10000_FrontStore = int.Parse(dt.Rows[0][11].ToString());

            Rightel_1000_FrontStore = int.Parse(dt.Rows[0][12].ToString());
            Rightel_2000_FrontStore = int.Parse(dt.Rows[0][13].ToString());
            Rightel_5000_FrontStore = int.Parse(dt.Rows[0][14].ToString());
            Rightel_10000_FrontStore = int.Parse(dt.Rows[0][15].ToString());

            return true;
        }


        public bool RetriveNumberOfChargeIn_Store()
        {

            string S = "Data Source=.;Initial Catalog=Local_Charge_db;Integrated Security=True";
            SqlConnection SQLcon = new SqlConnection(S);
            SqlCommand SQLcom = new SqlCommand("NumberOfAllChargesIn_Store");
            SQLcom.Connection = SQLcon;
            SQLcom.CommandType = CommandType.StoredProcedure;
            SQLcon.Open();
            DataTable dt = new DataTable("NumberOfAllChargesIn_Store");
            SqlDataAdapter SQLda = new SqlDataAdapter(SQLcom);
            SQLda.Fill(dt);
            SQLcon.Close();



            Hamrah_1000_Store = int.Parse(dt.Rows[0][0].ToString());
            Hamrah_2000_Store = int.Parse(dt.Rows[0][1].ToString());
            Hamrah_5000_Store = int.Parse(dt.Rows[0][2].ToString());
            Hamrah_10000_Store = int.Parse(dt.Rows[0][3].ToString());

            Irancel_1000_Store = int.Parse(dt.Rows[0][4].ToString());
            Irancel_2000_Store = int.Parse(dt.Rows[0][5].ToString());
            Irancel_5000_Store = int.Parse(dt.Rows[0][6].ToString());
            Irancel_10000_Store = int.Parse(dt.Rows[0][7].ToString());

            Taliya_1000_Store = int.Parse(dt.Rows[0][8].ToString());
            Taliya_2000_Store = int.Parse(dt.Rows[0][9].ToString());
            Taliya_5000_Store = int.Parse(dt.Rows[0][10].ToString());
            Taliya_10000_Store = int.Parse(dt.Rows[0][11].ToString());

            Rightel_1000_Store = int.Parse(dt.Rows[0][12].ToString());
            Rightel_2000_Store = int.Parse(dt.Rows[0][13].ToString());
            Rightel_5000_Store = int.Parse(dt.Rows[0][14].ToString());
            Rightel_10000_Store = int.Parse(dt.Rows[0][15].ToString());

            return true;
        }


        public bool RetriveNumberOfChargeIn_Server()
        {

            IISChargeService.AdminServiceClient proxy = new IISChargeService.AdminServiceClient();
            IISChargeService.ChargeTable ct = new IISChargeService.ChargeTable();
            ct = proxy.RetriveNumberOfChargeIn_Server();
            DataTable dt = new DataTable();
            dt = ct.GetChargeTable;

            Hamrah_1000_Server = int.Parse(dt.Rows[0][0].ToString());
            Hamrah_2000_Server = int.Parse(dt.Rows[0][1].ToString());
            Hamrah_5000_Server = int.Parse(dt.Rows[0][2].ToString());
            Hamrah_10000_Server = int.Parse(dt.Rows[0][3].ToString());

            Irancel_1000_Server = int.Parse(dt.Rows[0][4].ToString());
            Irancel_2000_Server = int.Parse(dt.Rows[0][5].ToString());
            Irancel_5000_Server = int.Parse(dt.Rows[0][6].ToString());
            Irancel_10000_Server = int.Parse(dt.Rows[0][7].ToString());

            Taliya_1000_Server = int.Parse(dt.Rows[0][8].ToString());
            Taliya_2000_Server = int.Parse(dt.Rows[0][9].ToString());
            Taliya_5000_Server = int.Parse(dt.Rows[0][10].ToString());
            Taliya_10000_Server = int.Parse(dt.Rows[0][11].ToString());

            Rightel_1000_Server = int.Parse(dt.Rows[0][12].ToString());
            Rightel_2000_Server = int.Parse(dt.Rows[0][13].ToString());
            Rightel_5000_Server = int.Parse(dt.Rows[0][14].ToString());
            Rightel_10000_Server = int.Parse(dt.Rows[0][15].ToString());


            return true;

        }

        public DataTable NumberOfCompanyPurchasedCharge(DateTime BeginDate, DateTime EndDate)
        {

            string S = "Data Source=.;Initial Catalog=Local_Charge_db;Integrated Security=True";
            SqlConnection SQLcon = new SqlConnection(S);
            SqlCommand SQLcom = new SqlCommand("NumberOfAllChargesInWhole_Store");
            SQLcom.Connection = SQLcon;
            SQLcom.CommandType = CommandType.StoredProcedure;
            SQLcom.Parameters.AddWithValue("@BeginDate", BeginDate);
            SQLcom.Parameters.AddWithValue("@EndDate", EndDate);
            SQLcon.Open();
            DataTable In_WholeStore = new DataTable("NumberOfAllChargesInWhole_Store");
            SqlDataAdapter SQLda = new SqlDataAdapter(SQLcom);
            SQLda.Fill(In_WholeStore);
            SQLcon.Close();


            IISChargeService.AdminServiceClient proxy = new IISChargeService.AdminServiceClient();
            IISChargeService.ChargeTable ct = new IISChargeService.ChargeTable();
            ct = proxy.NumberOfCompanyPurchasedCharge(BeginDate, EndDate);
            DataTable In_Server = new DataTable();
            In_Server = ct.GetChargeTable;

            DataTable dt = new DataTable("CompanyPurchaseDaily_DT");
            dt.Columns.Add("Charge_Price_Category", typeof(string));
            dt.Columns.Add("HamrahAval", typeof(int));
            dt.Columns.Add("Irancel", typeof(int));
            dt.Columns.Add("Taliya", typeof(int));
            dt.Columns.Add("Rightel", typeof(int));


            DataRow dr = dt.NewRow();
            dr[0] = "1,000 تومانی";
            dr[1] = int.Parse(In_WholeStore.Rows[0][0].ToString()) + int.Parse(In_Server.Rows[0][0].ToString());
            dr[2] = int.Parse(In_WholeStore.Rows[0][4].ToString()) + int.Parse(In_Server.Rows[0][4].ToString());
            dr[3] = int.Parse(In_WholeStore.Rows[0][8].ToString()) + int.Parse(In_Server.Rows[0][8].ToString());
            dr[4] = int.Parse(In_WholeStore.Rows[0][12].ToString()) + int.Parse(In_Server.Rows[0][12].ToString());
            dt.Rows.Add(dr);
            DataRow dr1 = dt.NewRow();
            dr1[0] = "2,000 تومانی";
            dr1[1] = int.Parse(In_WholeStore.Rows[0][1].ToString()) + int.Parse(In_Server.Rows[0][1].ToString());
            dr1[2] = int.Parse(In_WholeStore.Rows[0][5].ToString()) + int.Parse(In_Server.Rows[0][5].ToString());
            dr1[3] = int.Parse(In_WholeStore.Rows[0][9].ToString()) + int.Parse(In_Server.Rows[0][9].ToString());
            dr1[4] = int.Parse(In_WholeStore.Rows[0][13].ToString()) + int.Parse(In_Server.Rows[0][13].ToString());
            dt.Rows.Add(dr1);
            DataRow dr2 = dt.NewRow();
            dr2[0] = "5,000 تومانی";
            dr2[1] = int.Parse(In_WholeStore.Rows[0][2].ToString()) + int.Parse(In_Server.Rows[0][2].ToString());
            dr2[2] = int.Parse(In_WholeStore.Rows[0][6].ToString()) + int.Parse(In_Server.Rows[0][6].ToString());
            dr2[3] = int.Parse(In_WholeStore.Rows[0][10].ToString()) + int.Parse(In_Server.Rows[0][10].ToString());
            dr2[4] = int.Parse(In_WholeStore.Rows[0][14].ToString()) + int.Parse(In_Server.Rows[0][14].ToString());
            dt.Rows.Add(dr2);
            DataRow dr3 = dt.NewRow();
            dr3[0] = "10,000 تومانی";
            dr3[1] = int.Parse(In_WholeStore.Rows[0][3].ToString()) + int.Parse(In_Server.Rows[0][3].ToString());
            dr3[2] = int.Parse(In_WholeStore.Rows[0][7].ToString()) + int.Parse(In_Server.Rows[0][7].ToString());
            dr3[3] = int.Parse(In_WholeStore.Rows[0][11].ToString()) + int.Parse(In_Server.Rows[0][11].ToString());
            dr3[4] = int.Parse(In_WholeStore.Rows[0][15].ToString()) + int.Parse(In_Server.Rows[0][15].ToString());
            dt.Rows.Add(dr3);

            return dt;
        }


        public DataSet TimeBase_AllChargesInWhole(DateTime Date)
        {

            string S = "Data Source=.;Initial Catalog=Local_Charge_db;Integrated Security=True";
            SqlConnection SQLcon = new SqlConnection(S);
            SqlCommand SQLcom = new SqlCommand("TimeBase_AllChargesInWhole_Store");
            SQLcom.Connection = SQLcon;
            SQLcom.CommandType = CommandType.StoredProcedure;
            SQLcom.Parameters.AddWithValue("@BeginDate", Date);
          
            SQLcon.Open();
            DataTable In_WholeStore = new DataTable("TimeBase_AllChargesInWhole_Store");
            SqlDataAdapter SQLda = new SqlDataAdapter(SQLcom);
            SQLda.Fill(In_WholeStore);
            SQLcon.Close();

            IISChargeService.AdminServiceClient proxy = new IISChargeService.AdminServiceClient();
            IISChargeService.ChargeTable ct = new IISChargeService.ChargeTable();
            ct = proxy.TimeBase_AllChargesInWhole_Server(Date);
            DataTable In_Server = new DataTable();
            In_Server = ct.GetChargeTable;

            foreach (DataRow dr in In_Server.Rows)
            {
                In_WholeStore.Rows.Add(dr.ItemArray);
            }

            var newSort = from row in In_WholeStore.AsEnumerable()
                          group row by new { ID = row.Field<string>("Charge_Operator"), Cat = row.Field<int>("Charge_Price_Category"), time1 = row.Field<DateTime>("DateBuyed").ToString("hh:mm:ss tt") } into grp
                          orderby grp.Key.time1
                          select new
                          {
                              Charge_Operator = grp.Key.ID,
                              Charge_Price_Category = grp.Key.Cat,
                              Charge_Date_Buyed = grp.Key.time1,
                              Sum = grp.Sum(r => r.Field<int>("ChargeCount"))
                          };

            CompanyPurchaseDailyDataSet CPDDS = new CompanyPurchaseDailyDataSet();

            //******************************
            DataTable dt = NumberOfCompanyPurchasedCharge(Date, Date.AddDays(1));
            foreach (DataRow dr in dt.Rows)
            {
                CPDDS.CompanyPurchaseDaily_DT.Rows.Add(dr.ItemArray);
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





            var mynewSort = from row in In_WholeStore.AsEnumerable()
                            group row by new { ID = row.Field<string>("Charge_Operator"), Cat = row.Field<int>("Charge_Price_Category"), time1 = row.Field<DateTime>("DateBuyed").ToString("hh:mm:ss tt"), price = row.Field<int>("PriceBuyed"), provider = row.Field<string>("CompanyProvided") } into grp
                            orderby grp.Key.time1
                            select new
                            {
                                Charge_Operator = grp.Key.ID,
                                Charge_Price_Category = grp.Key.Cat,
                                Charge_Date_Buyed = grp.Key.time1,
                                PriceBuyed = grp.Key.price,
                                CompanyProvided = grp.Key.provider,
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
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "همراه اول", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 2000)
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "همراه اول", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 5000)
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "همراه اول", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 10000)
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "همراه اول", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                }
                else if (p.Charge_Operator.ToString() == "Irancel")
                {
                    if (p.Charge_Price_Category == 1000)
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "ایرانسل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 2000)
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "ایرانسل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 5000)
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "ایرانسل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 10000)
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "ایرانسل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                }
                else if (p.Charge_Operator.ToString() == "Taliya")
                {
                    if (p.Charge_Price_Category == 1000)
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "تالیا", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 2000)
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "تالیا", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 5000)
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "تالیا", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 10000)
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "تالیا", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                }
                else if (p.Charge_Operator.ToString() == "Rightel")
                {
                    if (p.Charge_Price_Category == 1000)
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "رایتل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 2000)
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "رایتل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 5000)
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "رایتل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 10000)
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "رایتل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                }
            }


            return CPDDS;
        }

        public DataSet DayBase_AllChargesInWhole(DateTime BeginDate, DateTime EndDate)
        {

            string S = "Data Source=.;Initial Catalog=Local_Charge_db;Integrated Security=True";
            SqlConnection SQLcon = new SqlConnection(S);
            SqlCommand SQLcom = new SqlCommand("DayBase_AllChargesInWhole_Store");
            SQLcom.Connection = SQLcon;
            SQLcom.CommandType = CommandType.StoredProcedure;
            SQLcom.Parameters.AddWithValue("@BeginDate", BeginDate);
            SQLcom.Parameters.AddWithValue("@EndDate", EndDate);
            SQLcon.Open();
            DataTable In_WholeStore = new DataTable("DayBase_AllChargesInWhole_Store");
            SqlDataAdapter SQLda = new SqlDataAdapter(SQLcom);
            SQLda.Fill(In_WholeStore);
            SQLcon.Close();

            IISChargeService.AdminServiceClient proxy = new IISChargeService.AdminServiceClient();
            IISChargeService.ChargeTable ct = new IISChargeService.ChargeTable();
            ct = proxy.DayBase_AllChargesInWhole_Server(BeginDate, EndDate);
            DataTable In_Server = new DataTable();
            In_Server = ct.GetChargeTable;

            foreach (DataRow dr in In_Server.Rows)
            {
                In_WholeStore.Rows.Add(dr.ItemArray);
            }

            var newSort = from row in In_WholeStore.AsEnumerable()
                          group row by new { ID = row.Field<string>("Charge_Operator"), Cat = row.Field<int>("Charge_Price_Category"), time1 = row.Field<DateTime>("DateBuyed").Date } into grp
                          orderby grp.Key.time1
                          select new
                          {
                              Charge_Operator = grp.Key.ID,
                              Charge_Price_Category = grp.Key.Cat,
                              Charge_Date_Buyed = grp.Key.time1,
                              Sum = grp.Sum(r => r.Field<int>("ChargeCount"))
                          };

            CompanyPurchaseDailyDataSet CPDDS = new CompanyPurchaseDailyDataSet();

            //******************************
            DataTable dt = NumberOfCompanyPurchasedCharge(BeginDate, EndDate);
            foreach (DataRow dr in dt.Rows)
            {
                CPDDS.CompanyPurchaseDaily_DT.Rows.Add(dr.ItemArray);
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





            var mynewSort = from row in In_WholeStore.AsEnumerable()
                            group row by new { ID = row.Field<string>("Charge_Operator"), Cat = row.Field<int>("Charge_Price_Category"), time1 = row.Field<DateTime>("DateBuyed").Date, price = row.Field<int>("PriceBuyed"), provider = row.Field<string>("CompanyProvided") } into grp
                            orderby grp.Key.time1
                            select new
                            {
                                Charge_Operator = grp.Key.ID,
                                Charge_Price_Category = grp.Key.Cat,
                                Charge_Date_Buyed = grp.Key.time1,
                                PriceBuyed = grp.Key.price,
                                CompanyProvided = grp.Key.provider,
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
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "همراه اول", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 2000)
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "همراه اول", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 5000)
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "همراه اول", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 10000)
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "همراه اول", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                }
                else if (p.Charge_Operator.ToString() == "Irancel")
                {
                    if (p.Charge_Price_Category == 1000)
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "ایرانسل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 2000)
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "ایرانسل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 5000)
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "ایرانسل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 10000)
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "ایرانسل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                }
                else if (p.Charge_Operator.ToString() == "Taliya")
                {
                    if (p.Charge_Price_Category == 1000)
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "تالیا", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 2000)
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "تالیا", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 5000)
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "تالیا", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 10000)
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "تالیا", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                }
                else if (p.Charge_Operator.ToString() == "Rightel")
                {
                    if (p.Charge_Price_Category == 1000)
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "رایتل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 2000)
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "رایتل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 5000)
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "رایتل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 10000)
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "رایتل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                }
            }


            return CPDDS;
        }

        public DataSet MonthBase_AllChargesInWhole(DateTime BeginDate, DateTime EndDate)
        {

            string S = "Data Source=.;Initial Catalog=Local_Charge_db;Integrated Security=True";
            SqlConnection SQLcon = new SqlConnection(S);
            SqlCommand SQLcom = new SqlCommand("DayBase_AllChargesInWhole_Store");
            SQLcom.Connection = SQLcon;
            SQLcom.CommandType = CommandType.StoredProcedure;
            SQLcom.Parameters.AddWithValue("@BeginDate", BeginDate);
            SQLcom.Parameters.AddWithValue("@EndDate", EndDate);
            SQLcon.Open();
            DataTable In_WholeStore = new DataTable("DayBase_AllChargesInWhole_Store");
            SqlDataAdapter SQLda = new SqlDataAdapter(SQLcom);
            SQLda.Fill(In_WholeStore);
            SQLcon.Close();

            IISChargeService.AdminServiceClient proxy = new IISChargeService.AdminServiceClient();
            IISChargeService.ChargeTable ct = new IISChargeService.ChargeTable();
            ct = proxy.DayBase_AllChargesInWhole_Server(BeginDate, EndDate);
            DataTable In_Server = new DataTable();
            In_Server = ct.GetChargeTable;

            foreach (DataRow dr in In_Server.Rows)
            {
                In_WholeStore.Rows.Add(dr.ItemArray);
            }

            var newSort = from row in In_WholeStore.AsEnumerable()
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

            CompanyPurchaseDailyDataSet CPDDS = new CompanyPurchaseDailyDataSet();

            //******************************
            DataTable dt = NumberOfCompanyPurchasedCharge(BeginDate, EndDate);
            foreach (DataRow dr in dt.Rows)
            {
                CPDDS.CompanyPurchaseDaily_DT.Rows.Add(dr.ItemArray);
            }
            //***********************************

            foreach (var t in newSort)
            {
                string persianmonth;
                switch (t.Charge_Date_Buyed){
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





            var mynewSort = from row in In_WholeStore.AsEnumerable()
                            group row by new { ID = row.Field<string>("Charge_Operator"), Cat = row.Field<int>("Charge_Price_Category"), time1 = PersianDateConverter.ToPersianDate(row.Field<DateTime>("DateBuyed")).Month, price = row.Field<int>("PriceBuyed"), provider = row.Field<string>("CompanyProvided") } into grp
                            orderby grp.Key.time1
                            select new
                            {
                                Charge_Operator = grp.Key.ID,
                                Charge_Price_Category = grp.Key.Cat,
                                Charge_Date_Buyed =grp.Key.time1,
                               // PersianDateConverter.ToPersianDate(grp.Key.time1).Month,
                                PriceBuyed = grp.Key.price,
                                CompanyProvided = grp.Key.provider,
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
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "همراه اول", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 2000)
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "همراه اول", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 5000)
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "همراه اول", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 10000)
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "همراه اول", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                }
                else if (p.Charge_Operator.ToString() == "Irancel")
                {
                    if (p.Charge_Price_Category == 1000)
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "ایرانسل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 2000)
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "ایرانسل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 5000)
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "ایرانسل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 10000)
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "ایرانسل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                }
                else if (p.Charge_Operator.ToString() == "Taliya")
                {
                    if (p.Charge_Price_Category == 1000)
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "تالیا", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 2000)
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "تالیا", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 5000)
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "تالیا", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 10000)
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "تالیا", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                }
                else if (p.Charge_Operator.ToString() == "Rightel")
                {
                    if (p.Charge_Price_Category == 1000)
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "رایتل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 2000)
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "رایتل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 5000)
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "رایتل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 10000)
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "رایتل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                }
            }


            return CPDDS;
        }

        public DataTable NumberOfCompanySoldCharge(DateTime BeginDate, DateTime EndDate)
        {



            IISChargeService.AdminServiceClient proxy = new IISChargeService.AdminServiceClient();
            IISChargeService.ChargeTable ct = new IISChargeService.ChargeTable();
            ct = proxy.NumberOfCompanySoldCharge(BeginDate, EndDate);
            DataTable In_Server = new DataTable();
            In_Server = ct.GetChargeTable;

            DataTable dt = new DataTable("CompanyPurchaseDaily_DT");
            dt.Columns.Add("Charge_Price_Category", typeof(string));
            dt.Columns.Add("HamrahAval", typeof(int));
            dt.Columns.Add("Irancel", typeof(int));
            dt.Columns.Add("Taliya", typeof(int));
            dt.Columns.Add("Rightel", typeof(int));


            DataRow dr = dt.NewRow();
            dr[0] = "1,000 تومانی";
            dr[1] = int.Parse(In_Server.Rows[0][0].ToString());
            dr[2] = int.Parse(In_Server.Rows[0][4].ToString());
            dr[3] =  int.Parse(In_Server.Rows[0][8].ToString());
            dr[4] =  int.Parse(In_Server.Rows[0][12].ToString());
            dt.Rows.Add(dr);
            DataRow dr1 = dt.NewRow();
            dr1[0] = "2,000 تومانی";
            dr1[1] = int.Parse(In_Server.Rows[0][1].ToString());
            dr1[2] =  int.Parse(In_Server.Rows[0][5].ToString());
            dr1[3] =  int.Parse(In_Server.Rows[0][9].ToString());
            dr1[4] =  int.Parse(In_Server.Rows[0][13].ToString());
            dt.Rows.Add(dr1);
            DataRow dr2 = dt.NewRow();
            dr2[0] = "5,000 تومانی";
            dr2[1] =  int.Parse(In_Server.Rows[0][2].ToString());
            dr2[2] = int.Parse(In_Server.Rows[0][6].ToString());
            dr2[3] =  int.Parse(In_Server.Rows[0][10].ToString());
            dr2[4] =  int.Parse(In_Server.Rows[0][14].ToString());
            dt.Rows.Add(dr2);
            DataRow dr3 = dt.NewRow();
            dr3[0] = "10,000 تومانی";
            dr3[1] =  int.Parse(In_Server.Rows[0][3].ToString());
            dr3[2] =int.Parse(In_Server.Rows[0][7].ToString());
            dr3[3] =  int.Parse(In_Server.Rows[0][11].ToString());
            dr3[4] =  int.Parse(In_Server.Rows[0][15].ToString());
            dt.Rows.Add(dr3);

            return dt;
        }
        public DataSet TimeBase_CompanySoldDaily(DateTime Date)
        {


            IISChargeService.AdminServiceClient proxy = new IISChargeService.AdminServiceClient();
            IISChargeService.ChargeTable ct = new IISChargeService.ChargeTable();
            ct = proxy.TimeBase_CompanySoldDaily(Date);
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

            CompanyPurchaseDailyDataSet CPDDS = new CompanyPurchaseDailyDataSet();

            //******************************
            DataTable dt = NumberOfCompanySoldCharge(Date, Date.AddDays(1));
            foreach (DataRow dr in dt.Rows)
            {
                CPDDS.CompanyPurchaseDaily_DT.Rows.Add(dr.ItemArray);
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
                            group row by new { ID = row.Field<string>("Charge_Operator"), Cat = row.Field<int>("Charge_Price_Category"), time1 = row.Field<DateTime>("DateBuyed").ToString("hh:mm:ss tt"), price = row.Field<int>("PriceBuyed"), provider = row.Field<string>("CompanyProvided") } into grp
                            orderby grp.Key.time1
                            select new
                            {
                                Charge_Operator = grp.Key.ID,
                                Charge_Price_Category = grp.Key.Cat,
                                Charge_Date_Buyed = grp.Key.time1,
                                PriceBuyed = grp.Key.price,
                                CompanyProvided = grp.Key.provider,
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
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "همراه اول", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 2000)
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "همراه اول", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 5000)
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "همراه اول", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 10000)
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "همراه اول", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                }
                else if (p.Charge_Operator.ToString() == "Irancel")
                {
                    if (p.Charge_Price_Category == 1000)
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "ایرانسل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 2000)
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "ایرانسل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 5000)
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "ایرانسل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 10000)
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "ایرانسل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                }
                else if (p.Charge_Operator.ToString() == "Taliya")
                {
                    if (p.Charge_Price_Category == 1000)
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "تالیا", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 2000)
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "تالیا", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 5000)
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "تالیا", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 10000)
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "تالیا", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                }
                else if (p.Charge_Operator.ToString() == "Rightel")
                {
                    if (p.Charge_Price_Category == 1000)
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "رایتل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 2000)
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "رایتل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 5000)
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "رایتل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 10000)
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "رایتل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                }
            }

            return CPDDS;
        }


        public DataSet DayBase_CompanySoldDaily(DateTime BeginDate, DateTime EndDate)
        {


            IISChargeService.AdminServiceClient proxy = new IISChargeService.AdminServiceClient();
            IISChargeService.ChargeTable ct = new IISChargeService.ChargeTable();
            ct = proxy.DayBase_CompanySoldDaily(BeginDate, EndDate);
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

            CompanyPurchaseDailyDataSet CPDDS = new CompanyPurchaseDailyDataSet();

            //******************************
            DataTable dt = NumberOfCompanySoldCharge(BeginDate, EndDate);
            foreach (DataRow dr in dt.Rows)
            {
                CPDDS.CompanyPurchaseDaily_DT.Rows.Add(dr.ItemArray);
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
                            group row by new { ID = row.Field<string>("Charge_Operator"), Cat = row.Field<int>("Charge_Price_Category"), time1 = row.Field<DateTime>("DateBuyed").Date, price = row.Field<int>("PriceBuyed"), provider = row.Field<string>("CompanyProvided") } into grp
                            orderby grp.Key.time1
                            select new
                            {
                                Charge_Operator = grp.Key.ID,
                                Charge_Price_Category = grp.Key.Cat,
                                Charge_Date_Buyed = grp.Key.time1,
                                PriceBuyed = grp.Key.price,
                                CompanyProvided = grp.Key.provider,
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
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "همراه اول", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 2000)
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "همراه اول", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 5000)
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "همراه اول", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 10000)
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "همراه اول", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                }
                else if (p.Charge_Operator.ToString() == "Irancel")
                {
                    if (p.Charge_Price_Category == 1000)
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "ایرانسل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 2000)
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "ایرانسل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 5000)
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "ایرانسل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 10000)
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "ایرانسل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                }
                else if (p.Charge_Operator.ToString() == "Taliya")
                {
                    if (p.Charge_Price_Category == 1000)
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "تالیا", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 2000)
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "تالیا", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 5000)
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "تالیا", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 10000)
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "تالیا", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                }
                else if (p.Charge_Operator.ToString() == "Rightel")
                {
                    if (p.Charge_Price_Category == 1000)
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "رایتل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 2000)
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "رایتل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 5000)
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "رایتل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 10000)
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "رایتل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                }
            }

            return CPDDS;
        }



        public DataSet MonthBase_CompanySoldDaily(DateTime BeginDate, DateTime EndDate)
        {

         

            IISChargeService.AdminServiceClient proxy = new IISChargeService.AdminServiceClient();
            IISChargeService.ChargeTable ct = new IISChargeService.ChargeTable();
            ct = proxy.DayBase_CompanySoldDaily(BeginDate, EndDate);
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

            CompanyPurchaseDailyDataSet CPDDS = new CompanyPurchaseDailyDataSet();

            //******************************
            DataTable dt = NumberOfCompanySoldCharge(BeginDate, EndDate);
            foreach (DataRow dr in dt.Rows)
            {
                CPDDS.CompanyPurchaseDaily_DT.Rows.Add(dr.ItemArray);
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
                            group row by new { ID = row.Field<string>("Charge_Operator"), Cat = row.Field<int>("Charge_Price_Category"), time1 = PersianDateConverter.ToPersianDate(row.Field<DateTime>("DateBuyed")).Month, price = row.Field<int>("PriceBuyed"), provider = row.Field<string>("CompanyProvided") } into grp
                            orderby grp.Key.time1
                            select new
                            {
                                Charge_Operator = grp.Key.ID,
                                Charge_Price_Category = grp.Key.Cat,
                                Charge_Date_Buyed = grp.Key.time1,
                                //PersianDateConverter.ToPersianDate(grp.Key.time1).Month,
                                PriceBuyed = grp.Key.price,
                                CompanyProvided = grp.Key.provider,
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
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "همراه اول", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 2000)
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "همراه اول", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 5000)
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "همراه اول", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 10000)
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "همراه اول", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                }
                else if (p.Charge_Operator.ToString() == "Irancel")
                {
                    if (p.Charge_Price_Category == 1000)
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "ایرانسل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 2000)
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "ایرانسل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 5000)
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "ایرانسل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 10000)
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "ایرانسل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                }
                else if (p.Charge_Operator.ToString() == "Taliya")
                {
                    if (p.Charge_Price_Category == 1000)
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "تالیا", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 2000)
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "تالیا", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 5000)
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "تالیا", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 10000)
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "تالیا", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                }
                else if (p.Charge_Operator.ToString() == "Rightel")
                {
                    if (p.Charge_Price_Category == 1000)
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "رایتل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 2000)
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "رایتل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 5000)
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "رایتل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 10000)
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "رایتل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                }
            }


            return CPDDS;
        }


        public DataTable NumberOfAgencySoldCharge(DateTime BeginDate, DateTime EndDate,Int64 AgencyID)
        {



            IISChargeService.AdminServiceClient proxy = new IISChargeService.AdminServiceClient();
            IISChargeService.ChargeTable ct = new IISChargeService.ChargeTable();
            ct = proxy.NumberOfAgencySoldCharge(BeginDate, EndDate,AgencyID);
            DataTable In_Server = new DataTable();
            In_Server = ct.GetChargeTable;

            DataTable dt = new DataTable("CompanyPurchaseDaily_DT");
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


            IISChargeService.AdminServiceClient proxy = new IISChargeService.AdminServiceClient();
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

            CompanyPurchaseDailyDataSet CPDDS = new CompanyPurchaseDailyDataSet();

            //******************************
            DataTable dt = NumberOfAgencySoldCharge(Date, Date.AddDays(1), AgencyID);
            foreach (DataRow dr in dt.Rows)
            {
                CPDDS.CompanyPurchaseDaily_DT.Rows.Add(dr.ItemArray);
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
                            group row by new { ID = row.Field<string>("Charge_Operator"), Cat = row.Field<int>("Charge_Price_Category"), time1 = row.Field<DateTime>("DateBuyed").ToString("hh:mm:ss tt"), price = row.Field<int>("PriceBuyed"), provider = row.Field<string>("CompanyProvided") } into grp
                            orderby grp.Key.time1
                            select new
                            {
                                Charge_Operator = grp.Key.ID,
                                Charge_Price_Category = grp.Key.Cat,
                                Charge_Date_Buyed = grp.Key.time1,
                                PriceBuyed = grp.Key.price,
                                CompanyProvided = grp.Key.provider,
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
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "همراه اول", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 2000)
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "همراه اول", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 5000)
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "همراه اول", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 10000)
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "همراه اول", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                }
                else if (p.Charge_Operator.ToString() == "Irancel")
                {
                    if (p.Charge_Price_Category == 1000)
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "ایرانسل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 2000)
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "ایرانسل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 5000)
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "ایرانسل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 10000)
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "ایرانسل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                }
                else if (p.Charge_Operator.ToString() == "Taliya")
                {
                    if (p.Charge_Price_Category == 1000)
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "تالیا", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 2000)
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "تالیا", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 5000)
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "تالیا", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 10000)
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "تالیا", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                }
                else if (p.Charge_Operator.ToString() == "Rightel")
                {
                    if (p.Charge_Price_Category == 1000)
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "رایتل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 2000)
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "رایتل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 5000)
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "رایتل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 10000)
                        CPDDS.WholeData_DT.Rows.Add(timeofBuy, "رایتل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                }
            }

            return CPDDS;
        }


        public DataSet DayBase_AgencySoldDaily(DateTime BeginDate, DateTime EndDate, Int64 AgencyID)
        {


            IISChargeService.AdminServiceClient proxy = new IISChargeService.AdminServiceClient();
            IISChargeService.ChargeTable ct = new IISChargeService.ChargeTable();
            ct = proxy.DayBase_AgencySoldDaily(BeginDate, EndDate,AgencyID);
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

            CompanyPurchaseDailyDataSet CPDDS = new CompanyPurchaseDailyDataSet();

            //******************************
            DataTable dt = NumberOfAgencySoldCharge(BeginDate, EndDate,AgencyID);
            foreach (DataRow dr in dt.Rows)
            {
                CPDDS.CompanyPurchaseDaily_DT.Rows.Add(dr.ItemArray);
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
                            group row by new { ID = row.Field<string>("Charge_Operator"), Cat = row.Field<int>("Charge_Price_Category"), time1 = row.Field<DateTime>("DateBuyed").Date, price = row.Field<int>("PriceBuyed"), provider = row.Field<string>("CompanyProvided") } into grp
                            orderby grp.Key.time1
                            select new
                            {
                                Charge_Operator = grp.Key.ID,
                                Charge_Price_Category = grp.Key.Cat,
                                Charge_Date_Buyed = grp.Key.time1,
                                PriceBuyed = grp.Key.price,
                                CompanyProvided = grp.Key.provider,
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
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "همراه اول", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 2000)
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "همراه اول", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 5000)
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "همراه اول", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 10000)
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "همراه اول", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                }
                else if (p.Charge_Operator.ToString() == "Irancel")
                {
                    if (p.Charge_Price_Category == 1000)
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "ایرانسل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 2000)
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "ایرانسل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 5000)
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "ایرانسل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 10000)
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "ایرانسل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                }
                else if (p.Charge_Operator.ToString() == "Taliya")
                {
                    if (p.Charge_Price_Category == 1000)
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "تالیا", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 2000)
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "تالیا", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 5000)
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "تالیا", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 10000)
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "تالیا", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                }
                else if (p.Charge_Operator.ToString() == "Rightel")
                {
                    if (p.Charge_Price_Category == 1000)
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "رایتل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 2000)
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "رایتل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 5000)
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "رایتل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 10000)
                        CPDDS.WholeData_DT.Rows.Add(PersianDateConverter.ToPersianDate(p.Charge_Date_Buyed).ToString("yyyy-MM-dd"), "رایتل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                }
            }

            return CPDDS;
        }
        public DataSet MonthBase_AgencySoldDaily(DateTime BeginDate, DateTime EndDate, Int64 AgencyID)
        {



            IISChargeService.AdminServiceClient proxy = new IISChargeService.AdminServiceClient();
            IISChargeService.ChargeTable ct = new IISChargeService.ChargeTable();
            ct = proxy.DayBase_AgencySoldDaily(BeginDate, EndDate,AgencyID);
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

            CompanyPurchaseDailyDataSet CPDDS = new CompanyPurchaseDailyDataSet();

            //******************************
            DataTable dt = NumberOfAgencySoldCharge(BeginDate, EndDate,AgencyID);
            foreach (DataRow dr in dt.Rows)
            {
                CPDDS.CompanyPurchaseDaily_DT.Rows.Add(dr.ItemArray);
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
                            group row by new { ID = row.Field<string>("Charge_Operator"), Cat = row.Field<int>("Charge_Price_Category"), time1 = PersianDateConverter.ToPersianDate(row.Field<DateTime>("DateBuyed")).Month, price = row.Field<int>("PriceBuyed"), provider = row.Field<string>("CompanyProvided") } into grp
                            orderby grp.Key.time1
                            select new
                            {
                                Charge_Operator = grp.Key.ID,
                                Charge_Price_Category = grp.Key.Cat,
                                Charge_Date_Buyed = grp.Key.time1,
                                //PersianDateConverter.ToPersianDate(grp.Key.time1).Month,
                                PriceBuyed = grp.Key.price,
                                CompanyProvided = grp.Key.provider,
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
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "همراه اول", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 2000)
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "همراه اول", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 5000)
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "همراه اول", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 10000)
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "همراه اول", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                }
                else if (p.Charge_Operator.ToString() == "Irancel")
                {
                    if (p.Charge_Price_Category == 1000)
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "ایرانسل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 2000)
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "ایرانسل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 5000)
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "ایرانسل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 10000)
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "ایرانسل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                }
                else if (p.Charge_Operator.ToString() == "Taliya")
                {
                    if (p.Charge_Price_Category == 1000)
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "تالیا", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 2000)
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "تالیا", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 5000)
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "تالیا", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 10000)
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "تالیا", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                }
                else if (p.Charge_Operator.ToString() == "Rightel")
                {
                    if (p.Charge_Price_Category == 1000)
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "رایتل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 2000)
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "رایتل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 5000)
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "رایتل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                    else if (p.Charge_Price_Category == 10000)
                        CPDDS.WholeData_DT.Rows.Add(persianmonth, "رایتل", price_cat, p.CompanyProvided, price_buyed, sum, price_sum);
                }
            }


            return CPDDS;
        }

        public DataSet AgencyInformationPrint(Int64 username, string password, string firstname, string lastname, string fathername, string gender, string birthdate, string certificatecode, string certificateplace, string mobilenum, string email, string homepostalcode, string homeaddress, string storename,string creditbalance, string storetell, string storetype, string storeaddress, string signupdate, DateTime lasteditdate, Int64 lasteditedby, bool statues)
        {
            RegisterdInformationDataSet RIDS = new RegisterdInformationDataSet();
            RIDS.AgencyInformationDT.Rows.Add(username.ToString(), password, firstname, lastname, fathername,gender, birthdate, certificatecode, certificateplace, mobilenum, email, homepostalcode, homeaddress, storename, creditbalance, storetell, storetype, storeaddress, signupdate,UserID);
            
           
            return RIDS; 
        }

        public bool IsValidUser(Int64 username, string password, bool isOperator)
        {
            UserID = username;
            UserPassword = password;
            User_isOperator = isOperator;
            IISChargeService.AdminServiceClient proxy = new IISChargeService.AdminServiceClient();
            bool AgencyValidation = proxy.IsValidUser(UserID, UserPassword, User_isOperator);
            return AgencyValidation;

        }


        public bool AddNewAgency(Int64 username, string password, string firstname, string lastname, string fathername, string gender, string birthdate, string certificatecode, string certificateplace, string mobilenum, string email, string homepostalcode, string homeaddress, string storename, int creditbalance, string storetell, string storetype, string storeaddress, DateTime signupdate, DateTime lasteditdate, Int64 lasteditedby, bool statues)
        {

            IISChargeService.AdminServiceClient proxy = new IISChargeService.AdminServiceClient();

            bool ResultStatues = proxy.AddNewAgency(username, password, firstname, lastname, fathername, gender, birthdate, certificatecode, certificateplace, mobilenum, email, homepostalcode, homeaddress, storename, creditbalance, storetell, storetype, storeaddress, signupdate, lasteditdate, lasteditedby, statues);

            return ResultStatues;
        }



        public DataSet OperatorInformationPrint(Int64 username, string password, string firstname, string lastname, string fathername, string gender, string birthdate, string certificatecode, string certificateplace, string mobilenum, string email, string homepostalcode, string homeaddress, string signupdate, DateTime lasteditdate, Int64 lasteditedby, bool statues) {
         
            
            RegisterdInformationDataSet RIDS = new RegisterdInformationDataSet();

            RIDS.OperatorInformationDT.Rows.Add( username.ToString(),  password,  firstname,  lastname,  fathername,  gender,  birthdate,  certificatecode,  certificateplace,  mobilenum,  email,  homepostalcode,  homeaddress,  signupdate);

            return RIDS;
        
        }

        public bool AddNewOperator(Int64 username, string password, string firstname, string lastname, string fathername, string gender, string birthdate, string certificatecode, string certificateplace, string mobilenum, string email, string homepostalcode, string homeaddress, DateTime signupdate, DateTime lasteditdate, Int64 lasteditedby, bool statues)
        {
            IISChargeService.AdminServiceClient proxy = new IISChargeService.AdminServiceClient();

            bool ResultStatues = proxy.AddNewOperator(username, password, firstname, lastname, fathername, gender, birthdate, certificatecode, certificateplace, mobilenum, email, homepostalcode, homeaddress, signupdate, lasteditdate, lasteditedby, statues);

            return ResultStatues;
        }


        public DataTable AgenciesList()
        {

            IISChargeService.AdminServiceClient proxy = new IISChargeService.AdminServiceClient();
            IISChargeService.ChargeTable ct = new IISChargeService.ChargeTable();
            ct = proxy.AgenciesList();
            DataTable dt = new DataTable();
            dt = ct.GetChargeTable;
            return dt;
        }

        public DataTable GetAgencyInformation(Int64 username)
        {
            IISChargeService.AdminServiceClient proxy = new IISChargeService.AdminServiceClient();
            IISChargeService.ChargeTable ct = new IISChargeService.ChargeTable();
            ct = proxy.GetAgencyInformation(username);
            DataTable dt = new DataTable();
            dt = ct.GetChargeTable;
            return dt;
        }


        public bool EditAgencyInformation(Int64 username, string password, string firstname, string lastname, string fathername, string gender, string birthdate, string certificatecode, string certificateplace, string mobilenum, string email, string homepostalcode, string homeaddress, string storename, int creditbalance, string storetell, string storetype, string storeaddress, DateTime signupdate, DateTime lasteditdate, Int64 lasteditedby, bool statues)
        {
            IISChargeService.AdminServiceClient proxy = new IISChargeService.AdminServiceClient();

            bool ResultStatues = proxy.EditAgencyInformation(username, password, firstname, lastname, fathername, gender, birthdate, certificatecode, certificateplace, mobilenum, email, homepostalcode, homeaddress, storename, creditbalance, storetell, storetype, storeaddress, signupdate, lasteditdate, lasteditedby, statues);

            return ResultStatues;
        }





        public DataTable OperatorsList()
        {

            IISChargeService.AdminServiceClient proxy = new IISChargeService.AdminServiceClient();
            IISChargeService.ChargeTable ct = new IISChargeService.ChargeTable();
            ct = proxy.OperatorsList();
            DataTable dt = new DataTable();
            dt = ct.GetChargeTable;
            return dt;
        }

        public DataTable GetOperatorInformation(Int64 username)
        {
            IISChargeService.AdminServiceClient proxy = new IISChargeService.AdminServiceClient();
            IISChargeService.ChargeTable ct = new IISChargeService.ChargeTable();
            ct = proxy.GetOperatorInformation(username);
            DataTable dt = new DataTable();
            dt = ct.GetChargeTable;
            return dt;
        }


        public bool EditOperatorInformation(Int64 username, string password, string firstname, string lastname, string fathername, string gender, string birthdate, string certificatecode, string certificateplace, string mobilenum, string email, string homepostalcode, string homeaddress, DateTime signupdate, DateTime lasteditdate, Int64 lasteditedby, bool statues)
        {
            IISChargeService.AdminServiceClient proxy = new IISChargeService.AdminServiceClient();

            bool ResultStatues = proxy.EditOperatorInformation(username, password, firstname, lastname, fathername, gender, birthdate, certificatecode, certificateplace, mobilenum, email, homepostalcode, homeaddress, signupdate, lasteditdate, lasteditedby, statues);

            return ResultStatues;
        }

        public bool AddCharge(DataTable dt)
        {

            IISChargeService.AdminServiceClient proxy = new IISChargeService.AdminServiceClient();

            bool ResultStatues = false;// = proxy.AddCharge();
            return ResultStatues;
        }

        private bool ClearTable_Temp_Charge()
        {
            string ssqltable = "temp_Charge";
            string ssqlconnectionstring = "Data Source=.;Initial Catalog=Local_Charge_db;Integrated Security=True";
            //execute a query to erase any previous data from our destination table
            string sclearsql = "delete from " + ssqltable;
            SqlConnection sqlconn = new SqlConnection(ssqlconnectionstring);
            SqlCommand sqlcmd = new SqlCommand(sclearsql, sqlconn);
            sqlconn.Open();
            sqlcmd.ExecuteNonQuery();
            sqlconn.Close();
            return true;
        }


        public bool ImportChargeFromExcelToStore(string excelfilepath, string operatoname, int category, string providedcompany, int pricebuyed, DateTime datebuyed)
        {

            //declare variables - edit these based on your particular situation
            string ssqltable = "temp_Charge";
            // make sure your sheet name is correct, here sheet name is sheet1, so you can change your sheet name if have different
            string myexceldataquery = "select Charge_Password,Charge_Serial from [sheet1$]";
            //try
            //{
            //create our connection strings
            string sexcelconnectionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + excelfilepath + ";Extended Properties=Excel 12.0;";
            string ssqlconnectionstring = "Data Source=.;Initial Catalog=Local_Charge_db;Integrated Security=True";
            //execute a query to erase any previous data from our destination table
            ClearTable_Temp_Charge();
            //series of commands to bulk copy data from the excel file into our sql table
            OleDbConnection oledbconn = new OleDbConnection(sexcelconnectionstring);
            OleDbCommand oledbcmd = new OleDbCommand(myexceldataquery, oledbconn);
            oledbconn.Open();
            OleDbDataReader dr = oledbcmd.ExecuteReader();
            SqlBulkCopy bulkcopy = new SqlBulkCopy(ssqlconnectionstring);
            bulkcopy.DestinationTableName = ssqltable;
            while (dr.Read())
            {
                bulkcopy.WriteToServer(dr);
            }

            oledbconn.Close();
            PrepareChargeOnStore(operatoname, category, providedcompany, pricebuyed, datebuyed);
            return true;
        }
        //catch (Exception ex)
        //{
        //    //handle exception
        //    return false;
        //}

        // }
        private bool PrepareChargeOnStore(string operatoname, int category, string providedcompany, int pricebuyed, DateTime datebuyed)
        {

            string Query = "Select Charge_Password ,Charge_Serial  from temp_Charge";
            string S = "Data Source=.;Initial Catalog=Local_Charge_db;Integrated Security=True";
            SqlConnection SQLcon = new SqlConnection(S);
            SqlCommand SQLcom = new SqlCommand(Query);
            SQLcom.Connection = SQLcon;
            SQLcon.Open();
            SqlDataAdapter SQLda = new SqlDataAdapter(SQLcom);
            DataTable PassSerial_Datatable = new DataTable("Paging");
            SQLda.Fill(PassSerial_Datatable);
            SQLcon.Close();

            DataTable transfer_DataTable = new DataTable("Charge_Store");
            transfer_DataTable.Columns.Add("Charge_Transation_Number", typeof(Int64));
            transfer_DataTable.Columns.Add("Charge_Operator", typeof(string));
            transfer_DataTable.Columns.Add("Charge_Price_Category", typeof(int));
            transfer_DataTable.Columns.Add("Charge_Password", typeof(Int64));
            transfer_DataTable.Columns.Add("Charge_Serial", typeof(Int64));
            transfer_DataTable.Columns.Add("Charge_Company_provided", typeof(string));
            transfer_DataTable.Columns.Add("Charge_Price_Buyed", typeof(int));
            transfer_DataTable.Columns.Add("Charge_Date_Buyed", typeof(DateTime));



            for (int index = 0; index < PassSerial_Datatable.Rows.Count; index++)
            {
                DataRow dr = transfer_DataTable.NewRow();
                dr["Charge_Transation_Number"] = GenerateTransactionNumber();
                dr["Charge_Operator"] = operatoname;
                dr["Charge_Price_Category"] = category;
                dr["Charge_Password"] = PassSerial_Datatable.Rows[index]["Charge_Password"];
                dr["Charge_Serial"] = PassSerial_Datatable.Rows[index]["Charge_Serial"];
                dr["Charge_Company_provided"] = providedcompany;
                dr["Charge_Price_Buyed"] = pricebuyed;
                dr["Charge_Date_Buyed"] = datebuyed;
                transfer_DataTable.Rows.Add(dr);

            }

            bool isSuccuss;
            //try
            //{
            SQLcon.Open();
            SqlBulkCopy bulkCopy = new SqlBulkCopy(SQLcon, SqlBulkCopyOptions.TableLock | SqlBulkCopyOptions.FireTriggers | SqlBulkCopyOptions.UseInternalTransaction, null);
            bulkCopy.DestinationTableName = transfer_DataTable.TableName;
            bulkCopy.WriteToServer(transfer_DataTable);
            isSuccuss = true;
            //}
            ////catch (Exception ex)
            ////{
            ////    isSuccuss = false;
            //}
            //execute a query to erase any previous data from our destination table
            ClearTable_Temp_Charge();
            return isSuccuss;
            //string Insert_Query = string.Format("Insert into Charge_Store values (N'{0}','{1}','{2}','{3}',N'{4}','{5}','{6}')", operatoname, category, chargepass, chargeserial, providedcompany, pricebuyed, datebuyed);

            //string S = "Data Source=.;Initial Catalog=my_CHARGE_db;Integrated Security=True";

            //SqlConnection SQLcon = new SqlConnection(S);
            //SqlCommand SQLcom = new SqlCommand(Insert_Query, SQLcon);

            //SQLcon.Open();
            //SQLcom.ExecuteNonQuery();
            //SQLcon.Close();



        }


        private Int64 GenerateTransactionNumber()
        {
            byte[] buffer = Guid.NewGuid().ToByteArray();
            return BitConverter.ToInt64(buffer, 0);
        }


        public bool TransferChargeFrom_Store_To_FrontStore(int ChargeCount, string operatorname, int pricecategory)
        {

            string Query = string.Format("delete Top({0}) from Charge_Store  output deleted.Charge_Transation_Number, deleted.Charge_Operator,deleted.Charge_Price_Category, deleted.Charge_Password,deleted.Charge_Serial, deleted.Charge_Company_provided,deleted.Charge_Price_Buyed, deleted.Charge_Date_Buyed into Front_Charge_Store where Charge_Operator='{1}' and Charge_Price_Category='{2}'", ChargeCount, operatorname, pricecategory);
            string S = "Data Source=.;Initial Catalog=Local_Charge_db;Integrated Security=True";
            SqlConnection SQLcon = new SqlConnection(S);
            SqlCommand SQLcom = new SqlCommand(Query);
            SQLcom.Connection = SQLcon;
            SQLcon.Open();
            SQLcom.ExecuteNonQuery();
            SQLcon.Close();

            return true;

        }

        public bool TransferChargeFrom_FrontStore_To_Store(int ChargeCount, string operatorname, int pricecategory)
        {

            string Query = string.Format("delete Top({0}) from Front_Charge_Store   output deleted.Charge_Transation_Number, deleted.Charge_Operator,deleted.Charge_Price_Category, deleted.Charge_Password,deleted.Charge_Serial, deleted.Charge_Company_provided,deleted.Charge_Price_Buyed, deleted.Charge_Date_Buyed into Charge_Store where Charge_Operator='{1}' and Charge_Price_Category='{2}'", ChargeCount, operatorname, pricecategory);
            string S = "Data Source=.;Initial Catalog=Local_Charge_db;Integrated Security=True";
            SqlConnection SQLcon = new SqlConnection(S);
            SqlCommand SQLcom = new SqlCommand(Query);
            SQLcom.Connection = SQLcon;
            SQLcon.Open();
            //SqlDataAdapter SQLda = new SqlDataAdapter(SQLcom);
            //DataTable dt_temp = new DataTable("Charge_Store");
            //SQLda.Fill(dt_temp);
            SQLcom.ExecuteNonQuery();
            SQLcon.Close();

            //SQLcon.Open();
            //SqlBulkCopy bulkCopy = new SqlBulkCopy(SQLcon, SqlBulkCopyOptions.TableLock | SqlBulkCopyOptions.FireTriggers | SqlBulkCopyOptions.UseInternalTransaction, null);
            //bulkCopy.DestinationTableName = dt_temp.TableName;
            //bulkCopy.WriteToServer(dt_temp);

            return true;
        }



        public void PrepareFor_TransferChargeFrom_FrontStore_To_Server(int ChargeCount, string operatorname, int pricecategory)
        {
            string Query = string.Format("delete Top({0}) from Front_Charge_Store  output deleted.Charge_Transation_Number, deleted.Charge_Operator,deleted.Charge_Price_Category, deleted.Charge_Password,deleted.Charge_Serial, deleted.Charge_Company_provided,deleted.Charge_Price_Buyed, deleted.Charge_Date_Buyed into Temp_Deleted_Charge where Charge_Operator='{1}' and Charge_Price_Category='{2}'", ChargeCount, operatorname, pricecategory);
            string S = "Data Source=.;Initial Catalog=Local_Charge_db;Integrated Security=True";
            SqlConnection SQLcon = new SqlConnection(S);
            SqlCommand SQLcom = new SqlCommand(Query);
            SQLcom.Connection = SQLcon;
            SQLcon.Open();
            SQLcom.ExecuteNonQuery();
            SQLcon.Close();

        }


        public void PrepareFor_TransferChargeFrom_Server_To_FrontStore(int ChargeCount, string operatorname, int pricecategory)
        {

            IISChargeService.AdminServiceClient proxy = new IISChargeService.AdminServiceClient();

            proxy.PrepareFor_TransferChargeFrom_Server_To_FrontStore(ChargeCount, operatorname, pricecategory);

        }

        public void TransferChargeFrom_FrontStore_To_Server()
        {

            string Query = "Select *  from Temp_Deleted_Charge";
            string S = "Data Source=.;Initial Catalog=Local_Charge_db;Integrated Security=True";
            SqlConnection SQLcon = new SqlConnection(S);
            SqlCommand SQLcom = new SqlCommand(Query);
            SQLcom.Connection = SQLcon;
            SQLcon.Open();
            SqlDataAdapter SQLda = new SqlDataAdapter(SQLcom);
            DataTable Temp_Datatable = new DataTable("Temp_Deleted_Charge");
            SQLda.Fill(Temp_Datatable);
            SQLcon.Close();

            DataTable transfer_DataTable = new DataTable("Service_Charge");
            transfer_DataTable.Columns.Add("Charge_Transation_Number", typeof(Int64));
            transfer_DataTable.Columns.Add("Charge_Operator", typeof(string));
            transfer_DataTable.Columns.Add("Charge_Price_Category", typeof(int));
            transfer_DataTable.Columns.Add("Charge_Password", typeof(Int64));
            transfer_DataTable.Columns.Add("Charge_Serial", typeof(Int64));
            transfer_DataTable.Columns.Add("Charge_Company_provided", typeof(string));
            transfer_DataTable.Columns.Add("Charge_Price_Buyed", typeof(int));
            transfer_DataTable.Columns.Add("Charge_Date_Buyed", typeof(DateTime));
            transfer_DataTable.Columns.Add("Charge_Price_willSell", typeof(int));
            transfer_DataTable.Columns.Add("System_Admin_ID", typeof(Int64));




            for (int index = 0; index < Temp_Datatable.Rows.Count; index++)
            {
                DataRow dr = transfer_DataTable.NewRow();
                string temp_op_name = Temp_Datatable.Rows[index][1].ToString();
                int temp_category = int.Parse(Temp_Datatable.Rows[index][2].ToString());
                dr["Charge_Transation_Number"] = Temp_Datatable.Rows[index][0];
                dr["Charge_Operator"] = Temp_Datatable.Rows[index][1];
                dr["Charge_Price_Category"] = Temp_Datatable.Rows[index][2];
                dr["Charge_Password"] = Temp_Datatable.Rows[index][3];
                dr["Charge_Serial"] = Temp_Datatable.Rows[index][4];
                dr["Charge_Company_provided"] = Temp_Datatable.Rows[index][5];
                dr["Charge_Price_Buyed"] = Temp_Datatable.Rows[index][6];
                dr["Charge_Date_Buyed"] = Temp_Datatable.Rows[index][7];
                dr["Charge_Price_willSell"] = priceWillSell(temp_op_name, temp_category);
                dr["System_Admin_ID"] = UserID;
                transfer_DataTable.Rows.Add(dr);

            }

            IISChargeService.AdminServiceClient proxy = new IISChargeService.AdminServiceClient();

            proxy.TransferChargeFrom_FrontStore_To_Server(transfer_DataTable);

            ClearTable_Temp_Deleted_Charge();

        }

        private int priceWillSell(string op_name, int cat)
        {
            int price = 0;
            switch (op_name)
            {
                case "hamrahAval":
                    switch (cat)
                    {
                        case 1000:
                            price = Hamrah_1000_Price;
                            break;
                        case 2000:
                            price = Hamrah_2000_Price;
                            break;
                        case 5000:
                            price = Hamrah_5000_Price;
                            break;
                        case 10000:
                            price = Hamrah_10000_Price;
                            break;
                        default:
                            price = 0;
                            break;
                    }
                    break;
                case "Irancel":
                    switch (cat)
                    {
                        case 1000:
                            price = Irancel_1000_Price;
                            break;
                        case 2000:
                            price = Irancel_2000_Price;
                            break;
                        case 5000:
                            price = Irancel_5000_Price;
                            break;
                        case 10000:
                            price = Irancel_10000_Price;
                            break;
                        default:
                            price = 0;
                            break;
                    }
                    break;
                case "Taliya":
                    switch (cat)
                    {
                        case 1000:
                            price = Taliya_1000_Price;
                            break;
                        case 2000:
                            price = Taliya_2000_Price;
                            break;
                        case 5000:
                            price = Taliya_5000_Price;
                            break;
                        case 10000:
                            price = Taliya_10000_Price;
                            break;
                        default:
                            price = 0;
                            break;
                    }
                    break;
                case "Rightel":
                    switch (cat)
                    {
                        case 1000:
                            price = Rightel_1000_Price;
                            break;
                        case 2000:
                            price = Rightel_2000_Price;
                            break;
                        case 5000:
                            price = Rightel_5000_Price;
                            break;
                        case 10000:
                            price = Rightel_10000_Price;
                            break;
                        default:
                            price = 0;
                            break;
                    }
                    break;
                default:
                    {
                        price = 0;
                        break;
                    }

            }
            return price;

        }

        private bool ClearTable_Temp_Deleted_Charge()
        {
            string ssqltable = "Temp_Deleted_Charge";
            string ssqlconnectionstring = "Data Source=.;Initial Catalog=Local_Charge_db;Integrated Security=True";
            //execute a query to erase any previous data from our destination table
            string sclearsql = "delete from " + ssqltable;
            SqlConnection sqlconn = new SqlConnection(ssqlconnectionstring);
            SqlCommand sqlcmd = new SqlCommand(sclearsql, sqlconn);
            sqlconn.Open();
            sqlcmd.ExecuteNonQuery();
            sqlconn.Close();
            return true;
        }

        public bool TransferChargeFrom_Server_To_FrontStore()
        {
            IISChargeService.AdminServiceClient proxy = new IISChargeService.AdminServiceClient();
            IISChargeService.ChargeTable ct = new IISChargeService.ChargeTable();
            ct = proxy.TransferChargeFrom_Server_To_FrontStore();
            DataTable dt = new DataTable();
            dt = ct.GetChargeTable;

            //DataTable transfer_DataTable = new DataTable("Front_Charge_Store");
            //transfer_DataTable.Columns.Add("Charge_Transation_Number", typeof(Int64));
            //transfer_DataTable.Columns.Add("Charge_Operator", typeof(string));
            //transfer_DataTable.Columns.Add("Charge_Price_Category", typeof(int));
            //transfer_DataTable.Columns.Add("Charge_Password", typeof(Int64));
            //transfer_DataTable.Columns.Add("Charge_Serial", typeof(Int64));
            //transfer_DataTable.Columns.Add("Charge_Company_provided", typeof(string));
            //transfer_DataTable.Columns.Add("Charge_Price_Buyed", typeof(int));
            //transfer_DataTable.Columns.Add("Charge_Date_Buyed", typeof(DateTime));



            //for (int index = 0; index < dt.Rows.Count; index++)
            //{
            //    DataRow dr = transfer_DataTable.NewRow();
            //    dr["Charge_Transation_Number"] = dt.Rows[index][0];
            //    dr["Charge_Operator"] = dt.Rows[index][1];
            //    dr["Charge_Price_Category"] = dt.Rows[index][2];
            //    dr["Charge_Password"] = dt.Rows[index][3];
            //    dr["Charge_Serial"] = dt.Rows[index][4];
            //    dr["Charge_Company_provided"] = dt.Rows[index][5];
            //    dr["Charge_Price_Buyed"] = dt.Rows[index][6];
            //    dr["Charge_Date_Buyed"] = dt.Rows[index][7];
            //    transfer_DataTable.Rows.Add(dr);
            //}

            string S = "Data Source=.;Initial Catalog=Local_Charge_db;Integrated Security=True";
            SqlConnection SQLcon = new SqlConnection(S);
            SqlCommand SQLcom = new SqlCommand();
            SQLcom.Connection = SQLcon;
            bool isSuccuss = true;
            //try
            //{
            SQLcon.Open();
            SqlBulkCopy bulkCopy = new SqlBulkCopy(SQLcon, SqlBulkCopyOptions.TableLock | SqlBulkCopyOptions.FireTriggers | SqlBulkCopyOptions.UseInternalTransaction, null);
            bulkCopy.DestinationTableName = dt.TableName;
            bulkCopy.WriteToServer(dt);
            return isSuccuss;
        }




        public int ChargeOnStore(string operatorname, int pricecategory)
        {
            int count = 0;
            string Query = string.Format("Select count(*) from Charge_Store where Charge_Operator='{0}' and Charge_Price_Category='{1}'", operatorname, pricecategory);
            string S = "Data Source=.;Initial Catalog=Local_Charge_db;Integrated Security=True";
            SqlConnection SQLcon = new SqlConnection(S);
            SqlCommand SQLcom = new SqlCommand(Query);
            SQLcom.Connection = SQLcon;
            SQLcon.Open();
            SqlDataReader reader = SQLcom.ExecuteReader();
            if (reader.HasRows)
            {
                if (!reader.IsDBNull(0))
                {
                    count = reader.GetInt32(0);
                }
            }
            return count;

        }

        public int ChargeOnFrontStore(string operatorname, int pricecategory)
        {

            int count = 0;
            string Query = string.Format("Select count(*) from Front_Charge_Store where Charge_Operator='{0}' and Charge_Price_Category='{1}'", operatorname, pricecategory);

            string S = "Data Source=.;Initial Catalog=Local_Charge_db;Integrated Security=True";
            SqlConnection SQLcon = new SqlConnection(S);
            SqlCommand SQLcom = new SqlCommand(Query);
            SQLcom.Connection = SQLcon;
            SQLcon.Open();
            SqlDataReader reader = SQLcom.ExecuteReader();
            if (reader.HasRows)
            {
                if (!reader.IsDBNull(0))
                {
                    count = reader.GetInt32(0);
                }
            }
            return count;

        }

        public string GetUniqueKey(int maxSize)
        {
            char[] chars = new char[62];
            chars =
            "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
            byte[] data = new byte[1];
            RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
            crypto.GetNonZeroBytes(data);
            data = new byte[maxSize];
            crypto.GetNonZeroBytes(data);
            StringBuilder result = new StringBuilder(maxSize);
            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }
            return result.ToString();
        }





    }


    [Serializable()]
    public class ChargeSetting : ISerializable
    {
        public int Hamrah_1000_Price;
        public int Hamrah_2000_Price;
        public int Hamrah_5000_Price;
        public int Hamrah_10000_Price;

        public int Irancel_1000_Price;
        public int Irancel_2000_Price;
        public int Irancel_5000_Price;
        public int Irancel_10000_Price;

        public int Taliya_1000_Price;
        public int Taliya_2000_Price;
        public int Taliya_5000_Price;
        public int Taliya_10000_Price;

        public int Rightel_1000_Price;
        public int Rightel_2000_Price;
        public int Rightel_5000_Price;
        public int Rightel_10000_Price;


        public int Hamrah_1000_FrontStore_Capacity;
        public int Hamrah_2000_FrontStore_Capacity;
        public int Hamrah_5000_FrontStore_Capacity;
        public int Hamrah_10000_FrontStore_Capacity;

        public int Irancel_1000_FrontStore_Capacity;
        public int Irancel_2000_FrontStore_Capacity;
        public int Irancel_5000_FrontStore_Capacity;
        public int Irancel_10000_FrontStore_Capacity;

        public int Taliya_1000_FrontStore_Capacity;
        public int Taliya_2000_FrontStore_Capacity;
        public int Taliya_5000_FrontStore_Capacity;
        public int Taliya_10000_FrontStore_Capacity;

        public int Rightel_1000_FrontStore_Capacity;
        public int Rightel_2000_FrontStore_Capacity;
        public int Rightel_5000_FrontStore_Capacity;
        public int Rightel_10000_FrontStore_Capacity;


        public int Hamrah_1000_Server_Capacity;
        public int Hamrah_2000_Server_Capacity;
        public int Hamrah_5000_Server_Capacity;
        public int Hamrah_10000_Server_Capacity;

        public int Irancel_1000_Server_Capacity;
        public int Irancel_2000_Server_Capacity;
        public int Irancel_5000_Server_Capacity;
        public int Irancel_10000_Server_Capacity;

        public int Taliya_1000_Server_Capacity;
        public int Taliya_2000_Server_Capacity;
        public int Taliya_5000_Server_Capacity;
        public int Taliya_10000_Server_Capacity;

        public int Rightel_1000_Server_Capacity;
        public int Rightel_2000_Server_Capacity;
        public int Rightel_5000_Server_Capacity;
        public int Rightel_10000_Server_Capacity;

        public ChargeSetting(SerializationInfo info, StreamingContext ctxt)
        {
            //Get the values from info and assign them to the appropriate properties
            Hamrah_1000_Price = (int)info.GetValue("Hamrah_1000_Price", typeof(int));
            Hamrah_2000_Price = (int)info.GetValue("Hamrah_2000_Price", typeof(int));
            Hamrah_5000_Price = (int)info.GetValue("Hamrah_5000_Price", typeof(int));
            Hamrah_10000_Price = (int)info.GetValue("Hamrah_10000_Price", typeof(int));

            Irancel_1000_Price = (int)info.GetValue("Irancel_1000_Price", typeof(int));
            Irancel_2000_Price = (int)info.GetValue("Irancel_2000_Price", typeof(int));
            Irancel_5000_Price = (int)info.GetValue("Irancel_5000_Price", typeof(int));
            Irancel_10000_Price = (int)info.GetValue("Irancel_10000_Price", typeof(int));

            Taliya_1000_Price = (int)info.GetValue("Taliya_1000_Price", typeof(int));
            Taliya_2000_Price = (int)info.GetValue("Taliya_2000_Price", typeof(int));
            Taliya_5000_Price = (int)info.GetValue("Taliya_5000_Price", typeof(int));
            Taliya_10000_Price = (int)info.GetValue("Taliya_10000_Price", typeof(int));

            Rightel_1000_Price = (int)info.GetValue("Rightel_1000_Price", typeof(int));
            Rightel_2000_Price = (int)info.GetValue("Rightel_2000_Price", typeof(int));
            Rightel_5000_Price = (int)info.GetValue("Rightel_5000_Price", typeof(int));
            Rightel_10000_Price = (int)info.GetValue("Rightel_10000_Price", typeof(int));




            Hamrah_1000_FrontStore_Capacity = (int)info.GetValue("Hamrah_1000_FrontStore_Capacity", typeof(int));
            Hamrah_2000_FrontStore_Capacity = (int)info.GetValue("Hamrah_2000_FrontStore_Capacity", typeof(int));
            Hamrah_5000_FrontStore_Capacity = (int)info.GetValue("Hamrah_5000_FrontStore_Capacity", typeof(int));
            Hamrah_10000_FrontStore_Capacity = (int)info.GetValue("Hamrah_10000_FrontStore_Capacity", typeof(int));

            Irancel_1000_FrontStore_Capacity = (int)info.GetValue("Irancel_1000_FrontStore_Capacity", typeof(int));
            Irancel_2000_FrontStore_Capacity = (int)info.GetValue("Irancel_2000_FrontStore_Capacity", typeof(int));
            Irancel_5000_FrontStore_Capacity = (int)info.GetValue("Irancel_5000_FrontStore_Capacity", typeof(int));
            Irancel_10000_FrontStore_Capacity = (int)info.GetValue("Irancel_10000_FrontStore_Capacity", typeof(int));

            Taliya_1000_FrontStore_Capacity = (int)info.GetValue("Taliya_1000_FrontStore_Capacity", typeof(int));
            Taliya_2000_FrontStore_Capacity = (int)info.GetValue("Taliya_2000_FrontStore_Capacity", typeof(int));
            Taliya_5000_FrontStore_Capacity = (int)info.GetValue("Taliya_5000_FrontStore_Capacity", typeof(int));
            Taliya_10000_FrontStore_Capacity = (int)info.GetValue("Taliya_10000_FrontStore_Capacity", typeof(int));

            Rightel_1000_FrontStore_Capacity = (int)info.GetValue("Rightel_1000_FrontStore_Capacity", typeof(int));
            Rightel_1000_FrontStore_Capacity = (int)info.GetValue("Rightel_2000_FrontStore_Capacity", typeof(int));
            Rightel_1000_FrontStore_Capacity = (int)info.GetValue("Rightel_5000_FrontStore_Capacity", typeof(int));
            Rightel_1000_FrontStore_Capacity = (int)info.GetValue("Rightel_10000_FrontStore_Capacity", typeof(int));


            Hamrah_1000_Server_Capacity = (int)info.GetValue("Hamrah_1000_Server_Capacity", typeof(int));
            Hamrah_2000_Server_Capacity = (int)info.GetValue("Hamrah_2000_Server_Capacity", typeof(int));
            Hamrah_5000_Server_Capacity = (int)info.GetValue("Hamrah_5000_Server_Capacity", typeof(int));
            Hamrah_10000_Server_Capacity = (int)info.GetValue("Hamrah_10000_Server_Capacity", typeof(int));

            Irancel_1000_Server_Capacity = (int)info.GetValue("Irancel_1000_Server_Capacity", typeof(int));
            Irancel_2000_Server_Capacity = (int)info.GetValue("Irancel_2000_Server_Capacity", typeof(int));
            Irancel_5000_Server_Capacity = (int)info.GetValue("Irancel_5000_Server_Capacity", typeof(int));
            Irancel_10000_Server_Capacity = (int)info.GetValue("Irancel_10000_Server_Capacity", typeof(int));

            Taliya_1000_Server_Capacity = (int)info.GetValue("Taliya_1000_Server_Capacity", typeof(int));
            Taliya_2000_Server_Capacity = (int)info.GetValue("Taliya_2000_Server_Capacity", typeof(int));
            Taliya_5000_Server_Capacity = (int)info.GetValue("Taliya_5000_Server_Capacity", typeof(int));
            Taliya_10000_Server_Capacity = (int)info.GetValue("Taliya_10000_Server_Capacity", typeof(int));

            Rightel_1000_Server_Capacity = (int)info.GetValue("Rightel_1000_Server_Capacity", typeof(int));
            Rightel_1000_Server_Capacity = (int)info.GetValue("Rightel_2000_Server_Capacity", typeof(int));
            Rightel_1000_Server_Capacity = (int)info.GetValue("Rightel_5000_Server_Capacity", typeof(int));
            Rightel_1000_Server_Capacity = (int)info.GetValue("Rightel_10000_Server_Capacity", typeof(int));

        }

        public ChargeSetting()
        {
            // TODO: Complete member initialization
        }

        //Serialization function.
        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            //You can use any custom name for your name-value pair. But make sure you
            // read the values with the same name. For ex:- If you write EmpId as "EmployeeId"
            // then you should read the same with "EmployeeId"
            info.AddValue("Hamrah_1000_Price", Hamrah_1000_Price);
            info.AddValue("Hamrah_2000_Price", Hamrah_2000_Price);
            info.AddValue("Hamrah_5000_Price", Hamrah_5000_Price);
            info.AddValue("Hamrah_10000_Price", Hamrah_10000_Price);

            info.AddValue("Irancel_1000_Price", Irancel_1000_Price);
            info.AddValue("Irancel_2000_Price", Irancel_2000_Price);
            info.AddValue("Irancel_5000_Price", Irancel_5000_Price);
            info.AddValue("Irancel_10000_Price", Irancel_10000_Price);

            info.AddValue("Taliya_1000_Price", Taliya_1000_Price);
            info.AddValue("Taliya_2000_Price", Taliya_2000_Price);
            info.AddValue("Taliya_5000_Price", Taliya_5000_Price);
            info.AddValue("Taliya_10000_Price", Taliya_10000_Price);

            info.AddValue("Rightel_1000_Price", Rightel_1000_Price);
            info.AddValue("Rightel_2000_Price", Rightel_2000_Price);
            info.AddValue("Rightel_5000_Price", Rightel_5000_Price);
            info.AddValue("Rightel_10000_Price", Rightel_10000_Price);




            info.AddValue("Hamrah_1000_FrontStore_Capacity", Hamrah_1000_FrontStore_Capacity);
            info.AddValue("Hamrah_2000_FrontStore_Capacity", Hamrah_2000_FrontStore_Capacity);
            info.AddValue("Hamrah_5000_FrontStore_Capacity", Hamrah_5000_FrontStore_Capacity);
            info.AddValue("Hamrah_10000_FrontStore_Capacity", Hamrah_10000_FrontStore_Capacity);

            info.AddValue("Irancel_1000_FrontStore_Capacity", Irancel_1000_FrontStore_Capacity);
            info.AddValue("Irancel_2000_FrontStore_Capacity", Irancel_2000_FrontStore_Capacity);
            info.AddValue("Irancel_5000_FrontStore_Capacity", Irancel_5000_FrontStore_Capacity);
            info.AddValue("Irancel_10000_FrontStore_Capacity", Irancel_10000_FrontStore_Capacity);

            info.AddValue("Taliya_1000_FrontStore_Capacity", Taliya_1000_FrontStore_Capacity);
            info.AddValue("Taliya_2000_FrontStore_Capacity", Taliya_2000_FrontStore_Capacity);
            info.AddValue("Taliya_5000_FrontStore_Capacity", Taliya_5000_FrontStore_Capacity);
            info.AddValue("Taliya_10000_FrontStore_Capacity", Taliya_10000_FrontStore_Capacity);

            info.AddValue("Rightel_1000_FrontStore_Capacity", Rightel_1000_FrontStore_Capacity);
            info.AddValue("Rightel_2000_FrontStore_Capacity", Rightel_2000_FrontStore_Capacity);
            info.AddValue("Rightel_5000_FrontStore_Capacity", Rightel_5000_FrontStore_Capacity);
            info.AddValue("Rightel_10000_FrontStore_Capacity", Rightel_10000_FrontStore_Capacity);



            info.AddValue("Hamrah_1000_Server_Capacity", Hamrah_1000_Server_Capacity);
            info.AddValue("Hamrah_2000_Server_Capacity", Hamrah_2000_Server_Capacity);
            info.AddValue("Hamrah_5000_Server_Capacity", Hamrah_5000_Server_Capacity);
            info.AddValue("Hamrah_10000_Server_Capacity", Hamrah_10000_Server_Capacity);

            info.AddValue("Irancel_1000_Server_Capacity", Irancel_1000_Server_Capacity);
            info.AddValue("Irancel_2000_Server_Capacity", Irancel_2000_Server_Capacity);
            info.AddValue("Irancel_5000_Server_Capacity", Irancel_5000_Server_Capacity);
            info.AddValue("Irancel_10000_Server_Capacity", Irancel_10000_Server_Capacity);

            info.AddValue("Taliya_1000_Server_Capacity", Taliya_1000_Server_Capacity);
            info.AddValue("Taliya_2000_Server_Capacity", Taliya_2000_Server_Capacity);
            info.AddValue("Taliya_5000_Server_Capacity", Taliya_5000_Server_Capacity);
            info.AddValue("Taliya_10000_Server_Capacity", Taliya_10000_Server_Capacity);

            info.AddValue("Rightel_1000_Server_Capacity", Rightel_1000_Server_Capacity);
            info.AddValue("Rightel_2000_Server_Capacity", Rightel_2000_Server_Capacity);
            info.AddValue("Rightel_5000_Server_Capacity", Rightel_5000_Server_Capacity);
            info.AddValue("Rightel_10000_Server_Capacity", Rightel_10000_Server_Capacity);


        }
    }
}
