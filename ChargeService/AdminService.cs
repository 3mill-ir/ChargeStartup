using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChargeServiceContracts;
using System.Data.SqlClient;
using System.Drawing;
using System.Data;

namespace ChargeService
{
    class AdminService : IAdminService
    {
        public ChargeTable RetriveNumberOfChargeIn_Server()
        {
            string S = "Data Source=.;Initial Catalog=my_CHARGE_db;Integrated Security=True";
            SqlConnection SQLcon = new SqlConnection(S);
            SqlCommand SQLcom = new SqlCommand("NumberOfAllChargesIn_Server");
            SQLcom.Connection = SQLcon;
            SQLcom.CommandType = CommandType.StoredProcedure;
            SQLcon.Open();
            DataTable dt = new DataTable("NumberOfAllChargesIn_Server");
            SqlDataAdapter SQLda = new SqlDataAdapter(SQLcom);
            SQLda.Fill(dt);
            ChargeTable ct = new ChargeTable();
            ct.GetChargeTable = dt;
            SQLcon.Close();

            return ct;
        }
        public ChargeTable NumberOfCompanyPurchasedCharge(DateTime BeginDate, DateTime EndDate)
        {
            string S = "Data Source=.;Initial Catalog=my_CHARGE_db;Integrated Security=True";
            SqlConnection SQLcon = new SqlConnection(S);
            SqlCommand SQLcom = new SqlCommand("NumberOfAllChargesInWhole_Server");
            SQLcom.Connection = SQLcon;
            SQLcom.CommandType = CommandType.StoredProcedure;
            SQLcom.Parameters.AddWithValue("@BeginDate", BeginDate);
            SQLcom.Parameters.AddWithValue("@EndDate", EndDate);
            SQLcon.Open();
            DataTable dt = new DataTable("NumberOfAllChargesInWhole_Server");
            SqlDataAdapter SQLda = new SqlDataAdapter(SQLcom);
            SQLda.Fill(dt);
            ChargeTable ct = new ChargeTable();
            ct.GetChargeTable = dt;
            SQLcon.Close();

            return ct;
        }
        public ChargeTable TimeBase_AllChargesInWhole_Server(DateTime Date)
        {
            string S = "Data Source=.;Initial Catalog=my_CHARGE_db;Integrated Security=True";
            SqlConnection SQLcon = new SqlConnection(S);
            SqlCommand SQLcom = new SqlCommand("TimeBase_AllChargesInWhole_ServerNewVersion");
            SQLcom.Connection = SQLcon;
            SQLcom.CommandType = CommandType.StoredProcedure;
            SQLcom.Parameters.AddWithValue("@BeginDate", Date);
            SQLcon.Open();
            DataTable dt = new DataTable("TimeBase_AllChargesInWhole_ServerNewVersion");
            SqlDataAdapter SQLda = new SqlDataAdapter(SQLcom);
            SQLda.Fill(dt);
            ChargeTable ct = new ChargeTable();
            ct.GetChargeTable = dt;
            SQLcon.Close();

            return ct;
        }
       public ChargeTable DayBase_AllChargesInWhole_Server(DateTime BeginDate, DateTime EndDate) {
           string S = "Data Source=.;Initial Catalog=my_CHARGE_db;Integrated Security=True";
           SqlConnection SQLcon = new SqlConnection(S);
           SqlCommand SQLcom = new SqlCommand("DayBase_AllChargesInWhole_ServerNewVersion");
           SQLcom.Connection = SQLcon;
           SQLcom.CommandType = CommandType.StoredProcedure;
           SQLcom.Parameters.AddWithValue("@BeginDate", BeginDate);
           SQLcom.Parameters.AddWithValue("@EndDate", EndDate);
           SQLcon.Open();
           DataTable dt = new DataTable("DayBase_AllChargesInWhole_ServerNewVersions");
           SqlDataAdapter SQLda = new SqlDataAdapter(SQLcom);
           SQLda.Fill(dt);
           ChargeTable ct = new ChargeTable();
           ct.GetChargeTable = dt;
           SQLcon.Close();

           return ct;
       }
       public ChargeTable NumberOfCompanySoldCharge(DateTime BeginDate, DateTime EndDate)
       {
           string S = "Data Source=.;Initial Catalog=my_CHARGE_db;Integrated Security=True";
           SqlConnection SQLcon = new SqlConnection(S);
           SqlCommand SQLcom = new SqlCommand("NumberOfAllSoldCharges_Server");
           SQLcom.Connection = SQLcon;
           SQLcom.CommandType = CommandType.StoredProcedure;
           SQLcom.Parameters.AddWithValue("@BeginDate", BeginDate);
           SQLcom.Parameters.AddWithValue("@EndDate", EndDate);
           SQLcon.Open();
           DataTable dt = new DataTable("NumberOfAllSoldCharges_Server");
           SqlDataAdapter SQLda = new SqlDataAdapter(SQLcom);
           SQLda.Fill(dt);
           ChargeTable ct = new ChargeTable();
           ct.GetChargeTable = dt;
           SQLcon.Close();

           return ct;
       }
      public ChargeTable DayBase_CompanySoldDaily(DateTime BeginDate, DateTime EndDate) {

          string S = "Data Source=.;Initial Catalog=my_CHARGE_db;Integrated Security=True";
          SqlConnection SQLcon = new SqlConnection(S);
          SqlCommand SQLcom = new SqlCommand("DayBase_AllChargesSold_ServerNewVersion");
          SQLcom.Connection = SQLcon;
          SQLcom.CommandType = CommandType.StoredProcedure;
          SQLcom.Parameters.AddWithValue("@BeginDate", BeginDate);
          SQLcom.Parameters.AddWithValue("@EndDate", EndDate);
          SQLcon.Open();
          DataTable dt = new DataTable("DayBase_AllChargesSold_ServerNewVersion");
          SqlDataAdapter SQLda = new SqlDataAdapter(SQLcom);
          SQLda.Fill(dt);
          ChargeTable ct = new ChargeTable();
          ct.GetChargeTable = dt;
          SQLcon.Close();

          return ct;
      }
      public ChargeTable TimeBase_CompanySoldDaily(DateTime Date)
      {

          string S = "Data Source=.;Initial Catalog=my_CHARGE_db;Integrated Security=True";
          SqlConnection SQLcon = new SqlConnection(S);
          SqlCommand SQLcom = new SqlCommand("TimeBase_AllChargesSold_ServerNewVersion");
          SQLcom.Connection = SQLcon;
          SQLcom.CommandType = CommandType.StoredProcedure;
          SQLcom.Parameters.AddWithValue("@BeginDate", Date);
          SQLcon.Open();
          DataTable dt = new DataTable("TimeBase_AllChargesSold_ServerNewVersion");
          SqlDataAdapter SQLda = new SqlDataAdapter(SQLcom);
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
        public void PrepareFor_TransferChargeFrom_Server_To_FrontStore(int ChargeCount, string operatorname, int pricecategory)
        {

            string Query = string.Format("delete Top({0}) from Service_Charge  output deleted.Charge_Transation_Number, deleted.Charge_Operator,deleted.Charge_Price_Category, deleted.Charge_Password,deleted.Charge_Serial, deleted.Charge_Company_provided,deleted.Charge_Price_Buyed, deleted.Charge_Date_Buyed into Temp_Deleted_Charge where Charge_Operator='{1}' and Charge_Price_Category='{2}' ", ChargeCount, operatorname, pricecategory);
            string S = "Data Source=.;Initial Catalog=my_CHARGE_db;Integrated Security=True";
            SqlConnection SQLcon = new SqlConnection(S);
            SqlCommand SQLcom = new SqlCommand(Query);
            SQLcom.Connection = SQLcon;
            SQLcon.Open();
            SQLcom.ExecuteNonQuery();
            SQLcon.Close();
        }

        public ChargeTable TransferChargeFrom_Server_To_FrontStore()
        {

            string Query = "Select * from Temp_Deleted_Charge";
            string S = "Data Source=.;Initial Catalog=my_CHARGE_db;Integrated Security=True";
            SqlConnection SQLcon = new SqlConnection(S);
            SqlCommand SQLcom = new SqlCommand(Query);
            SQLcom.Connection = SQLcon;
            SQLcon.Open();
            SqlDataAdapter SQLda = new SqlDataAdapter(SQLcom);
            DataTable dt = new DataTable("Front_Charge_Store");
            SQLda.Fill(dt);
            ChargeTable ct = new ChargeTable();
            ct.GetChargeTable = dt;
            SQLcon.Close();

            ClearTable_Temp_Deleted_Charge();
            return ct;

        }
        private bool ClearTable_Temp_Deleted_Charge()
        {
            string query = "delete from Temp_Deleted_Charge";
            string ssqlconnectionstring = "Data Source=.;Initial Catalog=my_CHARGE_db;Integrated Security=True";
            //execute a query to erase any previous data from our destination table
            SqlConnection SQLcon = new SqlConnection(ssqlconnectionstring);
            SqlCommand SQLcom = new SqlCommand(query, SQLcon);
            SQLcon.Open();
            SQLcom.ExecuteNonQuery();
            SQLcon.Close();
            return true;
        }


        public bool TransferChargeFrom_FrontStore_To_Server(DataTable dt) {
            string S = "Data Source=.;Initial Catalog=my_CHARGE_db;Integrated Security=True";
            SqlConnection SQLcon = new SqlConnection(S);
            SqlCommand SQLcom = new SqlCommand();
            SQLcom.Connection = SQLcon;
            bool isSuccuss;
            //try
            //{
            SQLcon.Open();
            SqlBulkCopy bulkCopy = new SqlBulkCopy(SQLcon, SqlBulkCopyOptions.TableLock | SqlBulkCopyOptions.FireTriggers | SqlBulkCopyOptions.UseInternalTransaction, null);
            bulkCopy.DestinationTableName = dt.TableName;
            bulkCopy.WriteToServer(dt);
            isSuccuss = true;

            return isSuccuss;
        }

        public bool IsValidUser(Int64 username, string password, bool isOperator)
        {
            string post = "";
            if (isOperator)
                post = "Operator";
            else
                post = "Admin";

            string Query = string.Format("Select SA_ID,SA_Password from System_Admin where SA_ID='{0}' and SA_Password='{1}' and SA_Post='{2}'", username, password, post);

            string S = "Data Source=.;Initial Catalog=my_CHARGE_db;Integrated Security=True";

            SqlConnection SQLcon = new SqlConnection(S);
            SqlCommand SQLcom = new SqlCommand(Query);

            SQLcom.Connection = SQLcon;
            SQLcon.Open();
            SqlDataReader SQLdr = SQLcom.ExecuteReader();
            if (SQLdr.Read())
            {
                SQLcon.Close();
                return true;
            }
            else
            {
                SQLcon.Close();
                return false;
            }
        }


        public bool AddNewAgency(Int64 username, string password, string firstname, string lastname, string fathername, string gender, string birthdate, string certificatecode, string certificateplace, string mobilenum, string email, string homepostalcode, string homeaddress, string storename, int creditbalance, string storetell, string storetype, string storeaddress, DateTime signupdate, DateTime lasteditdate, Int64 lasteditedby, bool statues)
        {
            if (!CheckIfExistAgency(username))
            {
                Image img = null;
                int credit = 0;
                string Insert_Query = string.Format("Insert into Agency values ('{0}','{1}',N'{2}',N'{3}',N'{4}',N'{5}','{6}','{7}',N'{8}','{9}','{10}','{11}',N'{12}','{13}',N'{14}','{15}','{16}',N'{17}',N'{18}','{19}','{20}','{21}','{22}','{23}')", username, password, firstname, lastname, fathername, gender, birthdate, certificatecode, certificateplace, mobilenum, email, homepostalcode, homeaddress, img, storename, creditbalance, storetell, storetype, storeaddress, signupdate, lasteditdate, lasteditedby, statues,credit);

                string S = "Data Source=.;Initial Catalog=my_CHARGE_db;Integrated Security=True";

                SqlConnection SQLcon = new SqlConnection(S);
                SqlCommand SQLcom = new SqlCommand(Insert_Query, SQLcon);

                SQLcon.Open();
                SQLcom.ExecuteNonQuery();
                SQLcon.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AddNewOperator(Int64 username, string password ,string firstname, string lastname, string fathername, string gender, string birthdate, string certificatecode, string certificateplace, string mobilenum, string email, string homepostalcode, string homeaddress, DateTime signupdate, DateTime lasteditdate, Int64 lasteditedby, bool statues)
        {
           
            if (!CheckIfExistOperator(username))
            {
                Image img = null;
                string Insert_Query = string.Format("Insert into System_Admin values ('{0}','{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}','{8}',N'{9}','{10}','{11}',N'{12}',N'{13}','{14}','{15}','{16}','{17}','{18}')", username, password,"Operator",firstname, lastname, fathername, gender, birthdate, certificatecode, certificateplace, mobilenum, email, homepostalcode, homeaddress, img, signupdate, lasteditdate, lasteditedby, statues);

                string S = "Data Source=.;Initial Catalog=my_CHARGE_db;Integrated Security=True";

                SqlConnection SQLcon = new SqlConnection(S);
                SqlCommand SQLcom = new SqlCommand(Insert_Query, SQLcon);

                SQLcon.Open();
                SQLcom.ExecuteNonQuery();
                SQLcon.Close();
                return true;
            }
            else
            {
                return false;
            }


        }


        public ChargeTable AgenciesList()
        {

            string Query = "Select AG_StoreName,AG_ID ,AG_StoreAddress from Agency";
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


        public ChargeTable GetAgencyInformation(Int64 username)
        {
            string Query = string.Format("Select AG_ID ,AG_Password , AG_FirstName , AG_Lastname , AG_fatherName , AG_Gender , AG_BirthDate , AG_CertificateCode , AG_CertificatePlace , AG_MobileNumber , AG_Email , AG_HomePostalCode , AG_HomeAddress , AG_StoreName , AG_CreditBalance , AG_StoreTellNumber , AG_StoreType , AG_StoreAddress , AG_SignupDate , AG_LastEditedDate , AG_LastEditedBy ,AG_Statues from Agency where AG_ID='{0}'", username);

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



        public bool EditAgencyInformation(Int64 username, string password, string firstname, string lastname, string fathername, string gender, string birthdate, string certificatecode, string certificateplace, string mobilenum, string email, string homepostalcode, string homeaddress, string storename, int creditbalance, string storetell, string storetype, string storeaddress, DateTime signupdate, DateTime lasteditdate, Int64 lasteditedby, bool statues)
        {

            string Update_Query = string.Format("update Agency set AG_FirstName=N'{0}',AG_Lastname=N'{1}', AG_fatherName =N'{2}', AG_Gender=N'{3}', AG_BirthDate=N'{4}',AG_CertificateCode=N'{5}',AG_CertificatePlace=N'{6}',AG_MobileNumber='{7}',AG_Email='{8}',AG_HomePostalCode=N'{9}',AG_HomeAddress=N'{10}',AG_StoreName=N'{11}',AG_CreditBalance='{12}',AG_StoreTellNumber=N'{13}',AG_StoreType=N'{14}',AG_StoreAddress=N'{15}',AG_SignupDate='{16}',AG_LastEditedDate='{17}',AG_LastEditedBy='{18}',AG_Statues='{19}',AG_Password=N'{20}' where AG_ID ='{21}'", firstname, lastname, fathername, gender, birthdate, certificatecode, certificateplace, mobilenum, email, homepostalcode, homeaddress, storename, creditbalance, storetell, storetype, storeaddress, signupdate, lasteditdate, lasteditedby, statues, password, username);

            string S = "Data Source=.;Initial Catalog=my_CHARGE_db;Integrated Security=True";

            SqlConnection SQLcon = new SqlConnection(S);
            SqlCommand SQLcom = new SqlCommand(Update_Query, SQLcon);

            SQLcon.Open();
            SQLcom.ExecuteNonQuery();
            SQLcon.Close();
            return true;
        }





        public ChargeTable OperatorsList()
        {

            string Query = "Select SA_FirstName,SA_Lastname ,SA_ID  from System_Admin where SA_Post='Operator'";
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


        public ChargeTable GetOperatorInformation(Int64 username)
        {
            string Query = string.Format("Select SA_ID ,SA_Password ,SA_Post , SA_FirstName  , SA_Lastname  , SA_fatherName  , SA_Gender  , SA_BirthDate  , SA_CertificateCode  , SA_CertificatePlace  , SA_MobileNumber  , SA_Email  , SA_HomePostalCode  , SA_HomeAddress  , SA_SignupDate  , SA_LastEditedDate  , SA_LastEditedBy  , SA_Statues  from System_Admin where SA_ID='{0}'", username);

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



        public bool EditOperatorInformation(Int64 username, string password, string firstname, string lastname, string fathername, string gender, string birthdate, string certificatecode, string certificateplace, string mobilenum, string email, string homepostalcode, string homeaddress, DateTime signupdate, DateTime lasteditdate, Int64 lasteditedby, bool statues)
        {

            string Update_Query = string.Format("update System_Admin set SA_FirstName=N'{0}',SA_Lastname=N'{1}', SA_fatherName=N'{2}', SA_Gender=N'{3}', SA_BirthDate=N'{4}',SA_CertificateCode=N'{5}',SA_CertificatePlace=N'{6}',SA_MobileNumber='{7}',SA_Email='{8}',SA_HomePostalCode=N'{9}',SA_HomeAddress=N'{10}',SA_SignupDate=N'{11}',SA_LastEditedDate='{12}',SA_LastEditedBy=N'{13}',SA_Statues=N'{14}',SA_Password=N'{15}'  where SA_ID='{16}'", firstname, lastname, fathername, gender, birthdate, certificatecode, certificateplace, mobilenum, email, homepostalcode, homeaddress, signupdate, lasteditdate, lasteditedby, statues, password, username);

            string S = "Data Source=.;Initial Catalog=my_CHARGE_db;Integrated Security=True";

            SqlConnection SQLcon = new SqlConnection(S);
            SqlCommand SQLcom = new SqlCommand(Update_Query, SQLcon);

            SQLcon.Open();
            SQLcom.ExecuteNonQuery();
            SQLcon.Close();
            return true;
        }



        public bool AddCharge(ChargeTable ct)
        {
            string Agency_ID = string.Empty;
            DataTable dt = new DataTable();
            dt = ct.GetChargeTable;
            string Insert_Query="";
         //   string Insert_Query = string.Format("Insert into Service_Charge values ('{0}','{1}','{2}','{3}','{4}','{5}',N'{6}','{7}','{8}','{9}','{10}','{11}','{12}')", ChargeOperator, priceCat, TransactionID, ChargePass, ChargeSer, ChargeStatues, ChargeCompanyProvided, ChargepriceBuyed, ChargePriceSell, ChargeDateBuyed, ChargeDateSold, Agency_ID, OperatorID);

            string S = "Data Source=.;Initial Catalog=my_CHARGE_db;Integrated Security=True";

            SqlConnection SQLcon = new SqlConnection(S);
            SqlCommand SQLcom = new SqlCommand(Insert_Query, SQLcon);

            SQLcon.Open();
            SQLcom.ExecuteNonQuery();
            SQLcon.Close();
            return true;
        
        
        }

        private bool CheckIfExistAgency(Int64 username)
        {

            string Query = string.Format("Select AG_ID from Agency where AG_ID='{0}'", username);

            string S = "Data Source=.;Initial Catalog=my_CHARGE_db;Integrated Security=True";

            SqlConnection SQLcon = new SqlConnection(S);
            SqlCommand SQLcom = new SqlCommand(Query);

            SQLcom.Connection = SQLcon;
            SQLcon.Open();
            SqlDataReader SQLdr = SQLcom.ExecuteReader();
            if (SQLdr.Read())
            {
                SQLcon.Close();
                return true;
            }
            else
            {
                SQLcon.Close();
                return false;
            }

        }


        private bool CheckIfExistOperator(Int64 username)
        {

            string Query = string.Format("Select SA_ID from System_Admin where SA_ID='{0}'", username);

            string S = "Data Source=.;Initial Catalog=my_CHARGE_db;Integrated Security=True";

            SqlConnection SQLcon = new SqlConnection(S);
            SqlCommand SQLcom = new SqlCommand(Query);

            SQLcom.Connection = SQLcon;
            SQLcon.Open();
            SqlDataReader SQLdr = SQLcom.ExecuteReader();
            if (SQLdr.Read())
            {
                SQLcon.Close();
                return true;
            }
            else
            {
                SQLcon.Close();
                return false;
            }

        }




        public bool TransferChargeFrom_FrontStore_To_Server(int ChargeCount, string operatorname, int pricecategory)
        {

            string Query = string.Format("Select Top({0}) from Front_Charge_Store where Charge_Operator='{1}' and Charge_Price_Category='{2}'", ChargeCount, operatorname, pricecategory);
            string S = "Data Source=.;Initial Catalog=Local_Charge_db;Integrated Security=True";
            SqlConnection SQLcon = new SqlConnection(S);
            SqlCommand SQLcom = new SqlCommand(Query);
            SQLcom.Connection = SQLcon;
            SQLcon.Open();
            SqlDataAdapter SQLda = new SqlDataAdapter(SQLcom);
            DataTable dt_temp = new DataTable("Charge_Store");
            SQLda.Fill(dt_temp);
            SQLcon.Close();

            SQLcon.Open();
            SqlBulkCopy bulkCopy = new SqlBulkCopy(SQLcon, SqlBulkCopyOptions.TableLock | SqlBulkCopyOptions.FireTriggers | SqlBulkCopyOptions.UseInternalTransaction, null);
            bulkCopy.DestinationTableName = dt_temp.TableName;
            bulkCopy.WriteToServer(dt_temp);

            return true;
        }
    }
}
