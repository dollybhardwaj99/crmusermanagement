using Core.Context;

using CRM.Infrastructure.LeadManagement.Abstraction.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Abstraction.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        IMasterRepository iMasterRepository { get; }
        
        void Commit();
    }
}
