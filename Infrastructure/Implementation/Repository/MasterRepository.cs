﻿using Core.Context;
using CRM.Core.LeadManagement.Models.DTO.MASTERDTO;
using CRM.Infrastructure.LeadManagement.Abstraction.Repository;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Infrastructure.LeadManagement.Implementation.Repository
{
    public  class MasterRepository :IMasterRepository
    {


        private ApplicationDapperContext _context;

        public MasterRepository(ApplicationDapperContext dapContext)
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
    }
}