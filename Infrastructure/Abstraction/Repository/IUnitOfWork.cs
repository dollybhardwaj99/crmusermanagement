using Core.Context;
using CRM.Infrastructure.InsuranceLeadManagement.Abstraction.Repository;
using CRM.Infrastructure.LeadManagement.Abstraction.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Abstraction.Repository
{
    public interface IUnitOfWork : IDisposable
    {
       
        IFinanceMasterRepository iFinanceMasterRepository { get; }
        IFinancePerformanceRepository iFinancePerformanceRepository { get; }
        void Commit();
    }
}
