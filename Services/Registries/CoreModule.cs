using Core.Context;
using Core.Environment;
using Core.Models;
using CRM.Services.LeadManagement.Filters;
using Infrastructure.Abstraction.Common;
using Infrastructure.Abstraction.Common.Email;
using Infrastructure.Abstraction.Repository;
using Infrastructure.Implementation.Common;
using Infrastructure.Implementation.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Registries
{
    public static class CoreModule
    {
        public static void Register(IServiceCollection services, IConfiguration Configuration)
        {            
            services.AddScoped<IUnitOfWork, UnitOfWork>();      
            services.AddScoped<IAuditableEntity, AuditableEntity>();
            services.AddScoped<IHelper, Helper>();
            services.AddSingleton<IEmailService, EmailService>();
            services.AddSingleton<ApplicationDapperContext>();
            services.AddSingleton<MarutiEnvironment>();
            services.AddScoped<AsyncDateActionFilter>();
        }
    }
}
