using Core.Context;

using CRM.Core.LeadManagement.Models.DTO.FinanceMaster;

using CRM.Infrastructure.InsuranceLeadManagement.Abstraction.Repository;
using CRM.Infrastructure.LeadManagement.Implementation.Common;
using Dapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CRM.Infrastructure.InsuranceLeadManagement.Implementation.Repository
{
    public class FinanceMasterRepository : IFinanceMasterRepository
    {
        private ApplicationDapperContext _context;

        public FinanceMasterRepository(ApplicationDapperContext dapContext)
        {
            this._context = dapContext;
        }
      public async Task<IEnumerable<MasterDTO>> GetFinancePaymentStatusMaster()
        {
            using (var connection = _context.CreateConnectionFinance())
            {
                List<MasterDTO> data = new List<MasterDTO>();
               
                data = connection.Query<MasterDTO>("Sp_PaymentStatusMaster", 
                     commandType: CommandType.StoredProcedure).ToList();
                return data;
            }
        }



        public async Task<IEnumerable<MasterDTO>> GetFinancePayoutinvoiceStageMaster()
        {
            using (var connection = _context.CreateConnectionFinance())
            {
                List<MasterDTO> data = new List<MasterDTO>();

                data = connection.Query<MasterDTO>("Sp_payoutinvoicestagemaster",
                     commandType: CommandType.StoredProcedure).ToList();
                return data;
            }
        }


        public async Task<IEnumerable<MasterDTO>> GetFinanceStatusMaster()
        {
            using (var connection = _context.CreateConnectionFinance())
            {
                List<MasterDTO> data = new List<MasterDTO>();

                data = connection.Query<MasterDTO>("Sp_FinanceStatusMaster",
                     commandType: CommandType.StoredProcedure).ToList();
                return data;
            }
        }



        public async Task<IEnumerable<MasterDTO>> GetFinanceStageMaster()
        {
            using (var connection = _context.CreateConnectionFinance())
            {
                List<MasterDTO> data = new List<MasterDTO>();

                data = connection.Query<MasterDTO>("Sp_financestagemaster",
                     commandType: CommandType.StoredProcedure).ToList();
                return data;
            }
        }



        public async Task<IEnumerable<MasterDTO>> GetModelMaster()
        {
            using (var connection = _context.CreateConnectionFinance())
            {
                List<MasterDTO> data = new List<MasterDTO>();

                data = connection.Query<MasterDTO>("Sp_modelmaster",
                     commandType: CommandType.StoredProcedure).ToList();
                return data;
            }
        }



        public async Task<IEnumerable<MasterAbbrDTO>> GetTitelMaster()
        {
            using (var connection = _context.CreateConnectionFinance())
            {
                List<MasterAbbrDTO> data = new List<MasterAbbrDTO>();

                data = connection.Query<MasterAbbrDTO>("Sp_TitleMaster",
                     commandType: CommandType.StoredProcedure).ToList();
                return data;
            }
        }



        public async Task<IEnumerable<MasterAbbrDTO>> GetFinanceMaster()
        {
            using (var connection = _context.CreateConnectionFinance())
            {
                List<MasterAbbrDTO> data = new List<MasterAbbrDTO>();

                data = connection.Query<MasterAbbrDTO>("Sp_FinanceMaster",
                     commandType: CommandType.StoredProcedure).ToList();
                return data;
            }
        }
        public async Task<IEnumerable<MasterAbbrDTO>> GetFinanceBranchMaster()
        {
            using (var connection = _context.CreateConnectionFinance())
            {
                List<MasterAbbrDTO> data = new List<MasterAbbrDTO>();

                data = connection.Query<MasterAbbrDTO>("Sp_FinanceBranchMaster",
                     commandType: CommandType.StoredProcedure).ToList();
                return data;
            }
        }
        public async Task<IEnumerable<MasterAbbrDTO>> GetRegionMaster()
        {
            using (var connection = _context.CreateConnectionFinance())
            {
                List<MasterAbbrDTO> data = new List<MasterAbbrDTO>();

                data = connection.Query<MasterAbbrDTO>("Sp_RegionMaster",
                     commandType: CommandType.StoredProcedure).ToList();
                return data;
            }
        }
        public async Task<IEnumerable<MasterAbbrDTO>> GetFuelTypeMaster()
        {
            using (var connection = _context.CreateConnectionFinance())
            {
                List<MasterAbbrDTO> data = new List<MasterAbbrDTO>();

                data = connection.Query<MasterAbbrDTO>("Sp_FuelMaster",
                     commandType: CommandType.StoredProcedure).ToList();
                return data;
            }
        }
        public async Task<IEnumerable<MasterAbbrDTO>> GetLoanTypeMaster()
        {
            using (var connection = _context.CreateConnectionFinance())
            {
                List<MasterAbbrDTO> data = new List<MasterAbbrDTO>();

                data = connection.Query<MasterAbbrDTO>("Sp_LoanMaster",
                     commandType: CommandType.StoredProcedure).ToList();
                return data;
            }
        }



        public async Task<IEnumerable<MasterVariantDTO>> GetVariantTypeMaster()
        {
            using (var connection = _context.CreateConnectionFinance())
            {
                List<MasterVariantDTO> data = new List<MasterVariantDTO>();

                data = connection.Query<MasterVariantDTO>("Sp_GetVariantTypeMaster",
                     commandType: CommandType.StoredProcedure).ToList();
                return data;
            }
        }




        public async Task<IEnumerable<MasterColorTypeDTO>> GetColorTypeMaster()
        {
            using (var connection = _context.CreateConnectionFinance())
            {
                List<MasterColorTypeDTO> data = new List<MasterColorTypeDTO>();

                data = connection.Query<MasterColorTypeDTO>("Sp_GetcolorTypeMaster",
                     commandType: CommandType.StoredProcedure).ToList();
                return data;
            }
        }



        public async Task<IEnumerable<TeamLeadMasterDTO>> GetTeamLeadMaster()
        {
            using (var connection = _context.CreateConnectionFinance())
            {
                List<TeamLeadMasterDTO> data = new List<TeamLeadMasterDTO>();

                data = connection.Query<TeamLeadMasterDTO>("Sp_GetTeamLeadMaster",
                     commandType: CommandType.StoredProcedure).ToList();
                return data;
            }
        }



        public async Task<IEnumerable<DSETypeMasterDTO>> GetDSETypeMaster()
        {
            using (var connection = _context.CreateConnectionFinance())
            {
                List<DSETypeMasterDTO> data = new List<DSETypeMasterDTO>();

                data = connection.Query<DSETypeMasterDTO>("SP_GetDSETypeMaster",
                     commandType: CommandType.StoredProcedure).ToList();
                return data;
            }
        }
    }

    }







