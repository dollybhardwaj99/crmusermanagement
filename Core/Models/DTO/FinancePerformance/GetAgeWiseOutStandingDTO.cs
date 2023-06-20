using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Core.LeadManagement.Models.DTO.FinancePerformance
{
    public  class GetAgeWiseOutStandingDTO
    {

        public string  FinancerName { get; set; }
        public long days30 { get; set; }
        public long days60 { get; set; }
        public long over60 { get; set; }

    }


    public class GetAgeWiseOutStandingFinalDTO
    {

        public string FinancerName { get; set; }
         public List <GetAgeWiseOutStanding>  Values { get; set; }

    }


    public class GetAgeWiseOutStanding
    {

       
        public long days30 { get; set; }
        public long days60 { get; set; }
        public long over60 { get; set; }

    }
}

