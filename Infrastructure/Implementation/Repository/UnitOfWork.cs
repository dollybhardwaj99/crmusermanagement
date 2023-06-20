using Core.Context;
using Core.Environment;

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
       
     
        private IMasterRepository _iMasterRepository;


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

    
  
  


        public IMasterRepository iMasterRepository
        {
            get
            {
                return _iMasterRepository ?? (_iMasterRepository = new MasterRepository(_dapContext));
            }
            set { }
        }

    }

}
