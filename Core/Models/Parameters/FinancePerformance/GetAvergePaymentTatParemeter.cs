using Core.Models;
using CRM.Core.LeadManagement.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Core.LeadManagement.Models.Parameters.FinancePerformance
{
    public  class GetAvergePaymentTatParemeter
    {

        [RequiredCustomList]
        public List<FinanceIDListParameter> FinanceID { get; set; }

        [RequiredDate]
        public string FromDate { get; set; }
        [RequiredDate]
        public string ToDate { get; set; }
    }
}
