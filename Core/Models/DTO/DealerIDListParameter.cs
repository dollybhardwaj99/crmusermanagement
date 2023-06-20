using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Core.LeadManagement.Models.DTO
{
    public  class DealerIDListParameter
    {
        [RequiredInt64]
        public Int64 DealerID { get; set; }
    }


    public class ChannelIDListParameter 
    {


        [RequiredInt64]
        public Int64 ChannelID { get; set; }


    }
    public class RegionIDListParameter
    {


        [RequiredInt64]
        public Int64 RegionID { get; set; }


    }
    public class LocationIDListParameter
    {


        [RequiredInt64]
        public Int64 LocationID { get; set; }


    }
    public class SRMIDListParameter
    {


        [RequiredInt64]
        public Int64 SRMID { get; set; }


    }
    public class RMIDListParameter
    {


        [RequiredInt64]
        public Int64 RMID { get; set; }


    }

    public class FinanceIDListParameter
    {


        [RequiredInt64]
        public Int64 FinanceID { get; set; }


    }
}

