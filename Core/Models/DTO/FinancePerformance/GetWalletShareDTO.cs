using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Core.LeadManagement.Models.DTO.FinancePerformance
{
    public  class GetWalletShareDTO
    {
        public string FinancerName { get; set; }
        public string TotalFinance { get; set; }
        public string InHouseFinance { get; set; }
    }
    public class GetWalletShareFinalDTO
    {
        public string FinancerName { get; set; }
        public List<GetWalletShare> values { get; set; }    
    }
    public class GetWalletShare
    {
        
        public string TotalFinance { get; set; }
        public string InHouseFinance { get; set; }
    }
}
