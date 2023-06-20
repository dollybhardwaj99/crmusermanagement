using Core.Model_Validation;
using CRM.Core.LeadManagement.Models.Parameters;
using CRM.Infrastructure.LeadManagement.Implementation.Common;
using Infrastructure.Abstraction.Common;
using Infrastructure.Implementation.Common;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.Services.LeadManagement.Filters
{
    public interface AsyncDateActionSMRReportFilter : IAsyncActionFilter
    {
     
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            // execute any code before the action executes
            //Object agentMetricsTopFiveRefuesForServiceParameter = null;
            


            IHelper _Helper = new Helper();
            //context.ActionArguments.TryGetValue("agentMetricsTopFiveRefuesForServiceParameter", out agentMetricsTopFiveRefuesForServiceParameter);
            //var outagentMetricsTopFiveRefuesForServiceParameterParam = agentMetricsTopFiveRefuesForServiceParameter ;





            //if (outagentMetricsTopFiveRefuesForServiceParameterParam != null)
            //{
            //    ModelValidationHelper.ValidateDateCompareSmallLarze(outagentMetricsTopFiveRefuesForServiceParameterParam.FromDate, outagentMetricsTopFiveRefuesForServiceParameterParam.ToDate, "");
            //    outagentMetricsTopFiveRefuesForServiceParameterParam.FromDate = (outagentMetricsTopFiveRefuesForServiceParameterParam.FromDate.Length > 0 ? _Helper.ConvertStringToDate(outagentMetricsTopFiveRefuesForServiceParameterParam.FromDate) : DateTime.Now.IndianTime()).ToString("dd-MMM-yyyy");
            //    outagentMetricsTopFiveRefuesForServiceParameterParam.ToDate = (outagentMetricsTopFiveRefuesForServiceParameterParam.ToDate.Length > 0 ? _Helper.ConvertStringToDate(outagentMetricsTopFiveRefuesForServiceParameterParam.ToDate) : DateTime.Now.IndianTime()).ToString("dd-MMM-yyyy");
            //}
            


            var result = await next();
        }
    }
}


