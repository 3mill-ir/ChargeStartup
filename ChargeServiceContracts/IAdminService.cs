using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Drawing;
using System.Data;

namespace ChargeServiceContracts
{
    [ServiceContract(Namespace = "http://www.thatindigogirl.com/samples/2006/06")]
    public interface IAdminService
    {
        [OperationContract]
        ChargeTable RetriveNumberOfChargeIn_Server();
        [OperationContract]
        ChargeTable NumberOfCompanyPurchasedCharge(DateTime BeginDate, DateTime EndDate);
        [OperationContract]
        ChargeTable DayBase_AllChargesInWhole_Server(DateTime BeginDate, DateTime EndDate);
        [OperationContract]
        ChargeTable TimeBase_AllChargesInWhole_Server(DateTime Date);
        [OperationContract]
        ChargeTable NumberOfCompanySoldCharge(DateTime BeginDate, DateTime EndDate);
        [OperationContract]
        ChargeTable DayBase_CompanySoldDaily(DateTime BeginDate, DateTime EndDate);
        [OperationContract]
        ChargeTable TimeBase_CompanySoldDaily(DateTime Date);
        [OperationContract]
        ChargeTable NumberOfAgencySoldCharge(DateTime BeginDate, DateTime EndDate, Int64 AgencyID);
       
        [OperationContract]
        ChargeTable DayBase_AgencySoldDaily(DateTime BeginDate, DateTime EndDate,Int64 AgencyID);
        [OperationContract]
        ChargeTable TimeBase_AgencySoldDaily(DateTime Date, Int64 AgencyID);
       

        [OperationContract]
        bool IsValidUser(Int64 username, string password,bool isOperator);

        [OperationContract]
        bool AddNewAgency(Int64 username, string password, string firstname, string lastname, string fathername, string gender, string birthdate, string certificatecode, string certificateplace, string mobilenum, string email, string homepostalcode, string homeaddress, string storename, int creditbalance, string storetell, string storetype, string storeaddress, DateTime signupdate,DateTime lasteditdate, Int64 lasteditedby,bool statues);

        [OperationContract]
        bool AddNewOperator(Int64 username, string password, string firstname, string lastname, string fathername, string gender, string birthdate, string certificatecode, string certificateplace, string mobilenum, string email, string homepostalcode, string homeaddress, DateTime signupdate, DateTime lasteditdate, Int64 lasteditedby, bool statues);


        [OperationContract]
        ChargeTable AgenciesList();

        [OperationContract]
        ChargeTable GetAgencyInformation(Int64 username);



        [OperationContract]
        bool EditAgencyInformation(Int64 username, string password, string firstname, string lastname, string fathername, string gender, string birthdate, string certificatecode, string certificateplace, string mobilenum, string email, string homepostalcode, string homeaddress, string storename, int creditbalance, string storetell, string storetype, string storeaddress, DateTime signupdate, DateTime lasteditdate, Int64 lasteditedby, bool statues);



        [OperationContract]
        ChargeTable OperatorsList();

        [OperationContract]
        ChargeTable GetOperatorInformation(Int64 username);



        [OperationContract]
        bool EditOperatorInformation(Int64 username, string password, string firstname, string lastname, string fathername, string gender, string birthdate, string certificatecode, string certificateplace, string mobilenum, string email, string homepostalcode, string homeaddress, DateTime signupdate, DateTime lasteditdate, Int64 lasteditedby, bool statues);

        [OperationContract]
        bool AddCharge(ChargeTable ct);


        [OperationContract]
        void PrepareFor_TransferChargeFrom_Server_To_FrontStore(int ChargeCount, string operatorname, int pricecategory);



        [OperationContract]
        ChargeTable TransferChargeFrom_Server_To_FrontStore();

        [OperationContract]
        bool TransferChargeFrom_FrontStore_To_Server(DataTable dt);
    }

}
