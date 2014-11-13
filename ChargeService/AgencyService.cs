using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChargeServiceContracts;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Security.Cryptography;

namespace ChargeService
{
    public class AgencyService : IAgencyService
    {
        private Int64 GenerateSessionToken(Int64 username) {
            int year = (DateTime.Now.Year % 2000)*100000;
            int month = (DateTime.Now.Month)*100;
            int day = DateTime.Now.Day*10000;
            int second=DateTime.Now.Second;


            Int64 sessiontoken = username * (year + month + day + second);
            return sessiontoken;
        }



        public Int64 AgencyValidator(Int64 username, string password)
        {
            
            string Query = string.Format("Select AG_ID,AG_Password from Agency where AG_ID='{0}' and AG_Password='{1}'", username, password);
            string S = "Data Source=.;Initial Catalog=my_CHARGE_db;Integrated Security=True";
            SqlConnection SQLcon = new SqlConnection(S);
            SqlCommand SQLcom = new SqlCommand(Query);

            SQLcom.Connection = SQLcon;
            SQLcon.Open();
            SqlDataReader SQLdr = SQLcom.ExecuteReader();
            if (SQLdr.Read())
            {
                Int64 sessiontoken = GenerateSessionToken(username);
                SQLcon.Close();
                AgencyLogin(username, sessiontoken);
                return sessiontoken;
            }
            else
            {
                SQLcon.Close();
                return 0;
            }

        }

        private void AgencyLogin(Int64 username, Int64 sessiontoken)
        {

            string Query = string.Format("Insert into Agency_Log (Agency_ID,SessionKey,Agency_Login) values ('{0}','{1}','{2}') ", username, sessiontoken, DateTime.Now);
            string S = "Data Source=.;Initial Catalog=my_CHARGE_db;Integrated Security=True";
            SqlConnection SQLcon = new SqlConnection(S);
            SqlCommand SQLcom = new SqlCommand(Query);

            SQLcom.Connection = SQLcon;
            SQLcon.Open();
            SQLcom.ExecuteNonQuery();
            SQLcon.Close();
            
        }



        public void AgencyLogOut(Int64 username, Int64 sessionkey)
        {

            string Query = string.Format("update Agency_Log set Agency_LogOut='{0}' where Agency_ID='{1}' and  SessionKey='{2}'", DateTime.Now,username,sessionkey);
            string S = "Data Source=.;Initial Catalog=my_CHARGE_db;Integrated Security=True";
            SqlConnection SQLcon = new SqlConnection(S);
            SqlCommand SQLcom = new SqlCommand(Query);
            SQLcom.Connection = SQLcon;
            SQLcon.Open();
            SQLcom.ExecuteNonQuery();
            SQLcon.Close();
        
        }
        public bool AgencyChangePassword(Int64 username, string oldpassword, string newpassword)
        {
            string update_query = string.Format("update Agency set AG_Password='{0}' where AG_ID='{1}' and AG_Password='{2}' ", newpassword, username, oldpassword);
            string S = "Data Source=.;Initial Catalog=my_CHARGE_db;Integrated Security=True";

            SqlConnection SQLcon = new SqlConnection(S);
            SqlCommand SQL_update = new SqlCommand();
            SQL_update.Connection = SQLcon;
            SQLcon.Open();
            SQL_update.CommandText = update_query;
            SQL_update.ExecuteNonQuery();
            SQLcon.Close();
            return true;
        }


        public string CheckAgencyCredit(Int64 username) {

            string Query = string.Format("Select AG_CreditBalance,AG_Credit from Agency where AG_ID='{0}' ", username);
            string S = "Data Source=.;Initial Catalog=my_CHARGE_db;Integrated Security=True";
            SqlConnection SQLcon = new SqlConnection(S);
            SqlCommand SQLcom = new SqlCommand(Query);

            SQLcom.Connection = SQLcon;
            SQLcon.Open();
            SqlDataReader SQLdr = SQLcom.ExecuteReader();
            int credit_balance=0;
            int credit=0;
            if (SQLdr.Read()) {
                credit_balance = SQLdr.GetInt32(0);
                credit = SQLdr.GetInt32(1);
            }
            int actualCredit = credit_balance - credit;
            string result = credit_balance.ToString() + "," + actualCredit.ToString()+",";
            return result;  
        }

        private int CanBuyCharge(int cat, int amountofcharge, Int64 AgencyID)
        {

            string Query = string.Format("Select AG_CreditBalance,AG_Credit from Agency where AG_ID='{0}' ", AgencyID);
            string S = "Data Source=.;Initial Catalog=my_CHARGE_db;Integrated Security=True";
            SqlConnection SQLcon = new SqlConnection(S);
            SqlCommand SQLcom = new SqlCommand(Query);

            SQLcom.Connection = SQLcon;
            SQLcon.Open();
            SqlDataReader SQLdr = SQLcom.ExecuteReader();
            int credit_balance = 0;
            int credit = 0;
            if (SQLdr.Read())
            {
                credit_balance = SQLdr.GetInt32(0);
                credit = SQLdr.GetInt32(1);
            }
            SQLcon.Close();
            int afterrequestCredit = credit + (cat * amountofcharge);
            if (afterrequestCredit <= credit_balance)
                return afterrequestCredit;
            else
                return -1;

        }
        public ChargeTable RequestCharge(string Operator, string Category, int amountOfcharge, Int64 AgencyID)
        {

            string temp_op = "";
            int temp_cat = 0;

            switch (Operator)
            {
                case "H":
                    temp_op = "HamrahAval";
                    break;
                case "I":
                    temp_op = "Irancel";
                    break;
                case "T":
                    temp_op = "Taliya";
                    break;
                case "R":
                    temp_op = "Rightel";
                    break;
            }
            switch (Category)
            {
                case "1":
                    temp_cat = 1000;
                    break;
                case "2":
                    temp_cat = 2000;
                    break;
                case "5":
                    temp_cat = 5000;
                    break;
                case "10":
                    temp_cat = 10000;
                    break;
            }

            int AfterRequestCredit = CanBuyCharge(temp_cat, amountOfcharge, AgencyID);
            if (AfterRequestCredit >= 0)
            {
                string S = "Data Source=.;Initial Catalog=my_CHARGE_db;Integrated Security=True";
                SqlConnection SQLcon = new SqlConnection(S);
                SqlCommand SQLcom = new SqlCommand("Agency_Request_Charge");
                SQLcom.Connection = SQLcon;
                SQLcom.CommandType = CommandType.StoredProcedure;
                SQLcom.Parameters.AddWithValue("@OperatorName", temp_op);
                SQLcom.Parameters.AddWithValue("@Category", temp_cat);
                SQLcom.Parameters.AddWithValue("@AmountOfCharge", amountOfcharge);
                SQLcom.Parameters.AddWithValue("@AgencyID", AgencyID);
                SQLcom.Parameters.AddWithValue("@Date_solved", DateTime.Now);
                SQLcom.Parameters.AddWithValue("@AfterCredit", AfterRequestCredit);
                //SqlParameter TransactionParam = new SqlParameter("@TransactionNumber", SqlDbType.BigInt);
                //TransactionParam.Direction = ParameterDirection.Output;
                //SQLcom.Parameters.Add(TransactionParam);
                //SqlParameter PasswordParam = new SqlParameter("@Password", SqlDbType.BigInt);
                //PasswordParam.Direction = ParameterDirection.Output;
                //SQLcom.Parameters.Add(PasswordParam);
                //SqlParameter SerialParam = new SqlParameter("@Serial", SqlDbType.BigInt);
                //SerialParam.Direction = ParameterDirection.Output;
                //SQLcom.Parameters.Add(SerialParam);
                SQLcon.Open();
                DataTable dt = new DataTable("Agency_Request_Charge");
                SqlDataAdapter SQLda = new SqlDataAdapter(SQLcom);
                SQLda.Fill(dt);
                ChargeTable ct = new ChargeTable();
                ct.GetChargeTable = dt;
                SQLcon.Close();

                //string Query = string.Format("Select top(1) Charge_Transation_Number ,Charge_Password ,Charge_Serial from Service_Charge where Charge_Operator ='{0}' and Charge_Price_Category='{1}' and Charge_Status='true'", temp_op, temp_cat);
                //string S = "Data Source=.;Initial Catalog=my_CHARGE_db;Integrated Security=True";
                //SqlConnection SQLcon = new SqlConnection(S);
                //SqlCommand SQLcom = new SqlCommand(Query);

                //SQLcom.Connection = SQLcon;
                //SQLcon.Open();
                //SqlDataReader SQLdr = SQLcom.ExecuteReader();
                //string Result = "";
                //decimal dec0 = 0;
                //decimal dec1 = 0;
                //decimal dec2 = 0;
                //bool do_update = false;
                //if (SQLdr.Read())
                //{
                //    dec0 = SQLdr.GetInt64(0);
                //    dec1 = SQLdr.GetInt64(1);
                //    dec2 = SQLdr.GetInt64(2);
                //    Result = dec0 + "*@*" + dec1 + "*@*" + dec2;
                //    do_update = true;
                //}
                //else
                //{
                //    Result = "NO CHARGE.";
                //    do_update = false;
                //}
                //SQLcon.Close();

                //PersianCalendar PC = new PersianCalendar();
                //DateTime date = new DateTime(PC.GetYear(DateTime.Now), PC.GetMonth(DateTime.Now), PC.GetDayOfMonth(DateTime.Now));
                //if (do_update)
                //{
                //    string update_query = string.Format("update Service_Charge set Charge_Status ='false' ,Agency_ID ='{0}',Charge_Date_Solved='{1}' where Charge_Transation_Number='{2}' and Charge_Password='{3}' and Charge_Serial='{4}' ", AgencyID, date, dec0, dec1, dec2);
                //    SqlCommand SQL_update = new SqlCommand();
                //    SQL_update.Connection = SQLcon;
                //    SQLcon.Open();
                //    SQL_update.CommandText = update_query;
                //    SQL_update.ExecuteNonQuery();
                //    SQLcon.Close();
                //}
                return ct;
            }
            else {
                DataTable dt = new DataTable();
                dt.Columns.Add("Charge_Transation_Number", typeof(Int64));
                dt.Columns.Add("Charge_Password", typeof(Int64));
                dt.Columns.Add("Charge_Serial", typeof(Int64));
                ChargeTable ct = new ChargeTable();
                ct.GetChargeTable = dt;
                return ct;
            }
          
        }

        public ChargeTable RequestDailyReport(Int64 AgencyID, DateTime FromDate, DateTime ToDate)
        {
            string Query = string.Format("Select Charge_Operator,Charge_Price_Category ,Charge_Serial,Charge_Transation_Number ,Charge_Date_Solved  from Service_Charge where Agency_ID ='{0}' and Charge_Date_Solved>='{1}' and Charge_Date_Solved<='{2}'", AgencyID, FromDate, ToDate);
            string S = "Data Source=.;Initial Catalog=my_CHARGE_db;Integrated Security=True";
            SqlConnection SQLcon = new SqlConnection(S);
            SqlCommand SQLcom = new SqlCommand(Query);
            SQLcom.Connection = SQLcon;
            SQLcon.Open();
            SqlDataAdapter SQLda = new SqlDataAdapter(SQLcom);
            DataTable dt = new DataTable("Paging");
            SQLda.Fill(dt);
            ChargeTable ct = new ChargeTable();
            ct.GetChargeTable = dt;
            SQLcon.Close();
            return ct;
        }
        public ChargeTable NumberOfAgencySoldCharge(DateTime BeginDate, DateTime EndDate, Int64 AgencyID)
        {
            string S = "Data Source=.;Initial Catalog=my_CHARGE_db;Integrated Security=True";
            SqlConnection SQLcon = new SqlConnection(S);
            SqlCommand SQLcom = new SqlCommand("NumberOfAgencySoldCharges_Server");
            SQLcom.Connection = SQLcon;
            SQLcom.CommandType = CommandType.StoredProcedure;
            SQLcom.Parameters.AddWithValue("@BeginDate", BeginDate);
            SQLcom.Parameters.AddWithValue("@EndDate", EndDate);
            SQLcom.Parameters.AddWithValue("@AgencyID", AgencyID);
            SQLcon.Open();
            DataTable dt = new DataTable("NumberOfAgencySoldCharges_Server");
            SqlDataAdapter SQLda = new SqlDataAdapter(SQLcom);
            SQLda.Fill(dt);
            ChargeTable ct = new ChargeTable();
            ct.GetChargeTable = dt;
            SQLcon.Close();

            return ct;
        }
        public ChargeTable DayBase_AgencySoldDaily(DateTime BeginDate, DateTime EndDate, Int64 AgencyID)
        {

            string S = "Data Source=.;Initial Catalog=my_CHARGE_db;Integrated Security=True";
            SqlConnection SQLcon = new SqlConnection(S);
            SqlCommand SQLcom = new SqlCommand("DayBase_AgencyChargesSold_ServerNewVersion");
            SQLcom.Connection = SQLcon;
            SQLcom.CommandType = CommandType.StoredProcedure;
            SQLcom.Parameters.AddWithValue("@BeginDate", BeginDate);
            SQLcom.Parameters.AddWithValue("@EndDate", EndDate);
            SQLcom.Parameters.AddWithValue("@AgencyID", AgencyID);
            SQLcon.Open();
            DataTable dt = new DataTable("DayBase_AgencyChargesSold_ServerNewVersion");
            SqlDataAdapter SQLda = new SqlDataAdapter(SQLcom);
            SQLda.Fill(dt);
            ChargeTable ct = new ChargeTable();
            ct.GetChargeTable = dt;
            SQLcon.Close();

            return ct;
        }
        public ChargeTable TimeBase_AgencySoldDaily(DateTime Date, Int64 AgencyID)
        {

            string S = "Data Source=.;Initial Catalog=my_CHARGE_db;Integrated Security=True";
            SqlConnection SQLcon = new SqlConnection(S);
            SqlCommand SQLcom = new SqlCommand("TimeBase_AgencyChargesSold_ServerNewVersion");
            SQLcom.Connection = SQLcon;
            SQLcom.CommandType = CommandType.StoredProcedure;
            SQLcom.Parameters.AddWithValue("@BeginDate", Date);
            SQLcom.Parameters.AddWithValue("@AgencyID", AgencyID);
            SQLcon.Open();
            DataTable dt = new DataTable("TimeBase_AgencyChargesSold_ServerNewVersion");
            SqlDataAdapter SQLda = new SqlDataAdapter(SQLcom);
            SQLda.Fill(dt);
            ChargeTable ct = new ChargeTable();
            ct.GetChargeTable = dt;
            SQLcon.Close();

            return ct;
        }

        public ChargeTable RequestMonthlyReport(Int64 AgencyID, int year)
        {
            DateTime YearBegin = new DateTime(year, 1, 1);
            DateTime YearEnd = new DateTime(year + 1, 1, 1);
            string Query = string.Format("Select Charge_Operator,Charge_Price_Category ,Charge_Date_Solved  from Service_Charge where Agency_ID ='{0}' and Charge_Date_Solved>='{1}' and Charge_Date_Solved<'{2}'", AgencyID, YearBegin, YearEnd);
            string S = "Data Source=.;Initial Catalog=my_CHARGE_db;Integrated Security=True";
            SqlConnection SQLcon = new SqlConnection(S);
            SqlCommand SQLcom = new SqlCommand(Query);
            SQLcom.Connection = SQLcon;
            SQLcon.Open();
            SqlDataAdapter SQLda = new SqlDataAdapter(SQLcom);
            DataTable dt = new DataTable("FirstPaging");

            SQLda.Fill(dt);


            var newSort = from row in dt.AsEnumerable()
                          group row by new { ID = row.Field<string>("Charge_Operator"), time1 = row.Field<DateTime>("Charge_Date_Solved") } into grp
                          orderby grp.Key.time1.Month
                          select new
                          {
                              Charge_Operator = grp.Key.ID,
                              Charge_Date_Solved = grp.Key.time1.Month,
                              Sum = grp.Sum(r => r.Field<int>("Charge_Price_Category"))
                          };

            DataTable tempTable = new DataTable("Paging");

            tempTable.Columns.Add("HamrahAval", typeof(int));
            tempTable.Columns.Add("Irancel", typeof(int));
            tempTable.Columns.Add("Taliya", typeof(int));
            tempTable.Columns.Add("Rightel", typeof(int));
            int[,] tempArray = new int[4, 12];
            for (int i = 0; i < tempArray.GetLength(0); i++)
                for (int j = 0; j < tempArray.GetLength(1); j++)
                {
                    tempArray[i, j] = 0;
                }

            foreach (var t in newSort)
            {
                if (t.Charge_Operator.ToString() == "HamrahAval")
                    tempArray[0, Convert.ToInt32(t.Charge_Date_Solved) - 1] = t.Sum;
                else if (t.Charge_Operator.ToString() == "Irancel")
                    tempArray[1, Convert.ToInt32(t.Charge_Date_Solved) - 1] = t.Sum;
                else if (t.Charge_Operator.ToString() == "taliya")
                    tempArray[2, Convert.ToInt32(t.Charge_Date_Solved) - 1] = t.Sum;
                else if (t.Charge_Operator.ToString() == "Rightel")
                    tempArray[3, Convert.ToInt32(t.Charge_Date_Solved) - 1] = t.Sum;
            }
            for (int i = 0; i < tempArray.GetLength(1); i++)
            {
                tempTable.Rows.Add(tempArray[0, i], tempArray[1, i], tempArray[2, i], tempArray[3, i]);
            }

            ChargeTable ct = new ChargeTable();
            ct.GetChargeTable = tempTable;
            SQLcon.Close();


            return ct;
        }


    }
}
