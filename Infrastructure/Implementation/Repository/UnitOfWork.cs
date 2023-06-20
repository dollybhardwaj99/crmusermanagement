using Core.Context;
using Core.Environment;
using CRM.Infrastructure.InsuranceLeadManagement.Abstraction.Repository;
using CRM.Infrastructure.InsuranceLeadManagement.Implementation.Repository;
using CRM.Infrastructure.LeadManagement.Abstraction.Repository;
using CRM.Infrastructure.LeadManagement.Implementation.Repository;
using Infrastructure.Abstraction.Repository;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Implementation.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDapperContext _dapContext { get; }
        private MarutiEnvironment _marutiEnvironment { get; }
       
        private IFinanceMasterRepository _iFinanceMasterRepository;
            


        private IFinancePerformanceRepository _iFinancePerformanceRepository;
      

        public UnitOfWork(ApplicationDapperContext dapContext, MarutiEnvironment marutiEnvironment)
        {
            _dapContext = dapContext;
            _marutiEnvironment = marutiEnvironment;
        }
        public void Commit()
        {
            //Context.SaveChanges();
        }

        public void Dispose()
        {
            //Context.Dispose();

        }

    
        public IFinanceMasterRepository iFinanceMasterRepository
        {
            get
            {
                return _iFinanceMasterRepository ?? (_iFinanceMasterRepository = new FinanceMasterRepository(_dapContext));
            }
            set { }
        }

        public IFinancePerformanceRepository iFinancePerformanceRepository        {
            get
            {
                return _iFinancePerformanceRepository ?? (_iFinancePerformanceRepository = new FinancePerformanceRepository(_dapContext));
            }
            set { }
        }


    }

}
