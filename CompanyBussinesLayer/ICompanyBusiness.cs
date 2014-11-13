using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data;

namespace CompanyBussinesLayer
{
    interface ICompanyBusiness
    {

       bool SaveChargeSetting();
       bool RetriveChargeSetting();
       bool RetriveNumberOfChargeIn_FrontStore();
       bool RetriveNumberOfChargeIn_Store();
       bool RetriveNumberOfChargeIn_Server();

       DataTable NumberOfCompanyPurchasedCharge(DateTime BeginDate, DateTime EndDate);
       DataSet DayBase_AllChargesInWhole(DateTime BeginDate, DateTime EndDate);
       DataSet MonthBase_AllChargesInWhole(DateTime BeginDate, DateTime EndDate);
       DataSet TimeBase_AllChargesInWhole(DateTime Date);


       DataTable NumberOfCompanySoldCharge(DateTime BeginDate, DateTime EndDate);
       DataSet DayBase_CompanySoldDaily(DateTime BeginDate, DateTime EndDate);
       DataSet MonthBase_CompanySoldDaily(DateTime BeginDate, DateTime EndDate);
       DataSet TimeBase_CompanySoldDaily(DateTime Date);

       DataTable NumberOfAgencySoldCharge(DateTime BeginDate, DateTime EndDate,Int64 AgencyID);
       DataSet DayBase_AgencySoldDaily(DateTime BeginDate, DateTime EndDate, Int64 AgencyID);
       DataSet MonthBase_AgencySoldDaily(DateTime BeginDate, DateTime EndDate, Int64 AgencyID);
       DataSet TimeBase_AgencySoldDaily(DateTime Date, Int64 AgencyID);

        bool IsValidUser(Int64 username, string password,bool isOperator);

        bool AddNewAgency(Int64 username, string password, string firstname, string lastname, string fathername, string gender, string birthdate, string certificatecode, string certificateplace, string mobilenum, string email, string homepostalcode, string homeaddress, string storename, int creditbalance, string storetell, string storetype, string storeaddress, DateTime signupdate,DateTime lasteditdate, Int64 lasteditedby,bool statues);

        bool AddNewOperator(Int64 username, string password, string firstname, string lastname, string fathername, string gender, string birthdate, string certificatecode, string certificateplace, string mobilenum, string email, string homepostalcode, string homeaddress, DateTime signupdate, DateTime lasteditdate, Int64 lasteditedby, bool statues);


        DataTable AgenciesList();

        DataTable GetAgencyInformation(Int64 username);

        bool EditAgencyInformation(Int64 username, string password, string firstname, string lastname, string fathername, string gender, string birthdate, string certificatecode, string certificateplace, string mobilenum, string email, string homepostalcode, string homeaddress, string storename, int creditbalance, string storetell, string storetype, string storeaddress, DateTime signupdate, DateTime lasteditdate, Int64 lasteditedby, bool statues);


        DataSet AgencyInformationPrint(Int64 username, string password, string firstname, string lastname, string fathername, string gender, string birthdate, string certificatecode, string certificateplace, string mobilenum, string email, string homepostalcode, string homeaddress, string storename, string creditbalance, string storetell, string storetype, string storeaddress, string signupdate, DateTime lasteditdate, Int64 lasteditedby, bool statues);

        DataSet OperatorInformationPrint(Int64 username, string password, string firstname, string lastname, string fathername, string gender, string birthdate, string certificatecode, string certificateplace, string mobilenum, string email, string homepostalcode, string homeaddress, string signupdate, DateTime lasteditdate, Int64 lasteditedby, bool statues);

        DataTable OperatorsList();


        DataTable GetOperatorInformation(Int64 username);


        bool EditOperatorInformation(Int64 username, string password, string firstname, string lastname, string fathername, string gender, string birthdate, string certificatecode, string certificateplace, string mobilenum, string email, string homepostalcode, string homeaddress, DateTime signupdate, DateTime lasteditdate, Int64 lasteditedby, bool statues);

        bool AddCharge(DataTable dt);

        bool ImportChargeFromExcelToStore(string excelfilepath, string operatoname, int pricecategory, string providedcompany, int pricebuyed, DateTime datebuyed);

        bool TransferChargeFrom_Store_To_FrontStore(int ChargeCount, string operatorname, int pricecategory);
        bool TransferChargeFrom_FrontStore_To_Store(int ChargeCount, string operatorname, int pricecategory);


        void PrepareFor_TransferChargeFrom_Server_To_FrontStore(int ChargeCount, string operatorname, int pricecategory);
        bool TransferChargeFrom_Server_To_FrontStore();

        void PrepareFor_TransferChargeFrom_FrontStore_To_Server(int ChargeCount, string operatorname, int pricecategory);
        void TransferChargeFrom_FrontStore_To_Server();


        int ChargeOnStore(string operatorname, int pricecategory);
        int ChargeOnFrontStore(string operatorname, int pricecategory);

        string GetUniqueKey(int maxSize);

    }

    

      
}
