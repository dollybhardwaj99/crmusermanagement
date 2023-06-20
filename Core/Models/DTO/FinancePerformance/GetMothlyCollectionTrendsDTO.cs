using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Core.LeadManagement.Models.DTO.FinancePerformance
{
    public  class GetMothlyCollectionTrendsDTO
    {
        public long TotalBilledRaised { get; set; }

        public long TotalCollectionDone { get; set; }
    }
}



