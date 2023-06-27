using CRM.Core.LeadManagement.Models.DTO;
using CRM.Core.LeadManagement.Models.DTO.MASTERDTO;
using CRM.Core.LeadManagement.Models.Parameters;
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
        Task<IEnumerable<MasterDTO>> GetclasssubjectMaster();
        Task<IEnumerable<MasterDTO>> GetclasssubjectIdMaster(MasterIDparameter parameter);
        Task<IEnumerable<MasterDTO>> GetbookMaster();
        Task<IEnumerable<MasterDTO>> GetbookIdMaster(MasterIDparameter parameter);
        Task<IEnumerable<MasterDTO>> GetclassMaster();
        Task<IEnumerable<MasterDTO>> GetclassIDMaster(MasterIDparameter parameter);
        Task<IEnumerable<MasterDTO>> GetexamMaster();
        Task<IEnumerable<MasterDTO>> GetexamIdMaster(MasterIDparameter parameter);
        Task<IEnumerable<MasterDTO>> GethouseMaster();
        Task<IEnumerable<MasterDTO>> GethouseIdMaster(MasterIDparameter parameter);
        Task<IEnumerable<MasterDTO>> GetschoolMaster();
        Task<IEnumerable<MasterDTO>> GetschoolIdMaster(MasterIDparameter parameter);
        Task<IEnumerable<MasterDTO>> GetsessionMaster();
        Task<IEnumerable<MasterDTO>> GetsessionIdMaster(MasterIDparameter parameter);
        Task<IEnumerable<MasterDTO>> GetstudentMaster();
        Task<IEnumerable<MasterDTO>> GetstudentIdMaster(MasterIDparameter parameter);
        Task<IEnumerable<MasterDTOMessage>> submitExammaster(SubmitExammasterparmeter parameter);
        Task<updatedto> PutclassMaster(updateclassmaster parameter);


    }
}
