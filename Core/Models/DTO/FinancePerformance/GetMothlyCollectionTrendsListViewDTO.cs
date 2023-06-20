using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Core.LeadManagement.Models.DTO.FinancePerformance
{
    public  class GetMothlyCollectionTrendsListViewDTO
    {

        public string Month { get; set; }
        public string Zone { get; set; }

        public string Region { get; set; }
        public string Financer { get; set; }
        public string Fromdate { get; set; }
        public string Todate { get; set; }
        public string TotalBilledRaised { get; set; }
        public string TotalCollectionRecivied { get; set; }
    }
}
          
