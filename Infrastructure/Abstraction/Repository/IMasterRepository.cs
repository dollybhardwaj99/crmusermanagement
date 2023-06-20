using CRM.Core.LeadManagement.Models.DTO.MASTERDTO;
using CRM.Core.LeadManagement.Models.Parameters.MASTERParmeter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Infrastructure.LeadManagement.Abstraction.Repository
{
    public  interface IMasterRepository
    {
        Task<IEnumerable<MasterDTO>> GetStudentDetailsMaster();
        Task<IEnumerable<MasterDTO>> GetStudentDetailsIdMaster(MasterIDparameter parameter);
    }
}
