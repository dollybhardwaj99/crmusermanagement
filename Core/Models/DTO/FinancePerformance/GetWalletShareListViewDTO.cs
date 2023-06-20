using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace CRM.Core.LeadManagement.Models.DTO.FinancePerformance
{
    public  class GetWalletShareListViewDTO
    {

        public string FinancerName { get; set; }
        public string Zone { get; set; }
        public string Region { get; set; }
        public string Fromdate { get; set; }
        public string Todate { get; set; }
        public long Totalretail { get; set; }
        public long TotalFinance { get; set; }
        public decimal Walletshareper { get; set; }
        public long InHouseFinance { get; set; }
        public decimal InHouseFinanceper { get; set; }
    }
}
