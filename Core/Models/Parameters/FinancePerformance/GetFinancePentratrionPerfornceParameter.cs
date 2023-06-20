using Core.Models;
using CRM.Core.LeadManagement.Models.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Core.LeadManagement.Models.Parameters.FinancePerformance
{
    public  class GetFinancePentratrionPerfornceParameter
    {

        [RequiredCustomList]
        public List<DealerIDListParameter> DealerID { get; set; }

        [RequiredCustomList]
        public List<ChannelIDListParameter> ChannelID { get; set; }

        [RequiredCustomList]
        public List<RegionIDListParameter> RegionID { get; set; }
        [RequiredCustomList]
        public List<LocationIDListParameter> LocationID { get; set; }
        [RequiredCustomList]
        public List<SRMIDListParameter> SRMID { get; set; }

        [RequiredCustomList]
        public List<RMIDListParameter> RMID { get; set; }

       

        [RequiredDate]
        public string FromDate { get; set; }
        [RequiredDate]
        public string ToDate { get; set; }

        

    }
}
