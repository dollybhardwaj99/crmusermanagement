using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Core.LeadManagement.Models.DTO.FinancePerformance
{
    public  class GetAvergePaymentTatDTO
    {
        public string FinancerName { get; set; }

        public long  Averagepaymentdays { get; set; }
        
    }
    public class GetAvergePaymentTatFinalDTO
    {
        public string FinancerName { get; set; }

     public List<GetAvergePaymentTat> Data { get; set; }

    }
    public class GetAvergePaymentTat
    {
    

        public long Averagepaymentdays { get; set; }

    }
}
