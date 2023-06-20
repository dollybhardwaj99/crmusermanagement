using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Core.LeadManagement.Models.DTO.FinancePerformance
{
    public class GetAvergePaymentTatListViewDTO
    {
        public string Month { get;set;}
        public string Zone { get; set; }
        public string Region { get; set; }

        public int Periods { get; set; }
        public long  Averagepaymentdays { get; set; }
    }
}
    