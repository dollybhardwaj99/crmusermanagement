
using CRM.Core.LeadManagement.Models.DTO.FinanceMaster;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Infrastructure.InsuranceLeadManagement.Abstraction.Repository
{
    public   interface IFinanceMasterRepository
    {


        

        Task<IEnumerable<MasterDTO>> GetFinancePaymentStatusMaster();
        Task<IEnumerable<MasterDTO>> GetFinancePayoutinvoiceStageMaster();
        Task<IEnumerable<MasterDTO>> GetFinanceStatusMaster();
        Task<IEnumerable<MasterDTO>> GetFinanceStageMaster();
        Task<IEnumerable<MasterDTO>> GetModelMaster();
        Task<IEnumerable<MasterAbbrDTO>> GetTitelMaster();

        Task<IEnumerable<MasterAbbrDTO>> GetFinanceMaster();
        Task<IEnumerable<MasterAbbrDTO>> GetFinanceBranchMaster();
        Task<IEnumerable<MasterAbbrDTO>> GetRegionMaster();
        Task<IEnumerable<MasterAbbrDTO>> GetFuelTypeMaster();
        Task<IEnumerable<MasterAbbrDTO>> GetLoanTypeMaster();
        Task<IEnumerable<MasterVariantDTO>> GetVariantTypeMaster();
        Task<IEnumerable<MasterColorTypeDTO>> GetColorTypeMaster();
        Task<IEnumerable<TeamLeadMasterDTO>> GetTeamLeadMaster();

        Task<IEnumerable<DSETypeMasterDTO>> GetDSETypeMaster();






    }

}
