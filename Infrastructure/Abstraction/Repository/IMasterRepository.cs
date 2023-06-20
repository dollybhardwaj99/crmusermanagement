using CRM.Core.LeadManagement.Models.DTO.MASTERDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Infrastructure.LeadManagement.Abstraction.Repository
{
    public  interface IMasterRepository
    {
        Task<IEnumerable<MasterDTO>> GetFinancePaymentStatusMaster();
    }
}
