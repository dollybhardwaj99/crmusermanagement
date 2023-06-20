using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Core.LeadManagement.Models.DTO.FinancePerformance
{
    public  class GetFinancePentratrionListViewDTO
    {
        public string Zone { get; set; }
        public string Region { get; set; }
        public string Channel { get; set; }
        public string Location { get; set; }
        public string Fromdate { get; set; }
        public string Todate { get; set; }
        public string SRM { get; set; }

        public string RM { get; set; }
        public long  TotalSale { get; set; }
        public long TotalFinance { get; set; }
        public long InHouseFinance { get; set; }

    }
}

