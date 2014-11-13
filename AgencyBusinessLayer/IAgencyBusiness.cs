using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AgencyBusinessLayer
{
    interface IAgencyBusiness
    {
        bool IsValidAgency(Int64 username, string password);
        bool AgencyChangePassword(string oldpassword, string newpassword);
        void AgencyLogOut();

       string CheckAgencyCredit();

       DataSet RequestCharge(string OperatorName, string Category, int amountOfcharge, string tempOp, string tempCat);


        DataTable RequestDailyReport(DateTime FromDate, DateTime ToDate);


        DataTable RequestMonthlyReport(int year);

        DataTable NumberOfAgencySoldCharge(DateTime BeginDate, DateTime EndDate, Int64 AgencyID);
        DataSet TimeBase_AgencySoldDaily(DateTime Date, Int64 AgencyID);
        DataSet DayBase_AgencySoldDaily(DateTime BeginDate, DateTime EndDate, Int64 AgencyID);
        DataSet MonthBase_AgencySoldDaily(DateTime BeginDate, DateTime EndDate, Int64 AgencyID);

    }

}
