using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CompanyBussinesLayer
{
     [DataContract]
    class CompanyBusinessChargeTable
    {
        [DataMember]
        public DataTable GetChargeTable
        {
            get;
            set;
        }
    }
}
