using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace ChargeServiceContracts
{
    [ServiceContract(Namespace = "http://www.thatindigogirl.com/samples/2006/06")]
    public interface IAgencyService
    {
       
        [OperationContract]
        Int64 AgencyValidator(Int64 username,string password);
        [OperationContract]
        void AgencyLogOut(Int64 username,Int64 sessiontoken);
        [OperationContract]
        string CheckAgencyCredit(Int64 username);

        [OperationContract]
        bool AgencyChangePassword(Int64 username, string oldpassword, string newpassword);

        [OperationContract]
        ChargeTable RequestCharge(string Operator, string Category, int amountOfcharge, Int64 AgencyID);

        [OperationContract]
        ChargeTable RequestDailyReport(Int64 AgencyID, DateTime FromDate, DateTime ToDate);

        [OperationContract]
        ChargeTable RequestMonthlyReport(Int64 AgencyID, int year);

        [OperationContract]
        ChargeTable NumberOfAgencySoldCharge(DateTime BeginDate, DateTime EndDate, Int64 AgencyID);
        [OperationContract]
        ChargeTable DayBase_AgencySoldDaily(DateTime BeginDate, DateTime EndDate, Int64 AgencyID);
        [OperationContract]
        ChargeTable TimeBase_AgencySoldDaily(DateTime Date, Int64 AgencyID);
    }


    //[DataContract]
    //public class ChargeTable
    //{
    //    [DataMember]
    //    public DataTable GetChargeTable
    //    {
    //        get;
    //        set;
    //    }
    //}
}
