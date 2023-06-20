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
    public class AsyncDateActionFilter : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            // execute any code before the action executes
            Object SMRParameter = null;
            Object ParamFollowup = null;
            Object ParamSubmitsmrappointmentParameter = null;
            Object PramSubmitsmrRefuseForServiceParameter = null;
            Object ParamSmrappointmentRescheduledParameter = null;
            object ParamsmrDataGenerateCampaignWiseParameter = null;
            object paramsmrdataGenerateCampaignWiseAsingDataListParameter = null;
            object parammonthTargetSettingSubmit = null;
            object paramdayTargetSettingSubmit = null;
            object paramRequestSMREAssingedLeadCampaignDataParameter = null;
            object paramRequestSMREAssingedLeadCampaignDataListParameter = null;
            object paramsubmitGlobalSMRAppointmentParameter = null;

           
            //--SMREAssingedLeadCampaignDataParameter RequestSMREAssingedLeadCampaignDataParameter

            IHelper _Helper = new Helper();
            context.ActionArguments.TryGetValue("SMRParameter", out SMRParameter);
            var outSMRParameterParam = SMRParameter ;

            context.ActionArguments.TryGetValue("Submitconnectedandnonconnected", out ParamFollowup);

            var OutSubmitNonandConnectParameter = ParamFollowup ;
            context.ActionArguments.TryGetValue("SubmitsmrappointmentParameter", out ParamSubmitsmrappointmentParameter);
            var outSubmitsmrappointmentParameter = ParamSubmitsmrappointmentParameter ;

            
                

                         context.ActionArguments.TryGetValue("submitGlobalSMRAppointmentParameter", out paramsubmitGlobalSMRAppointmentParameter);
            var outsubmitGlobalSMRAppointmentParameter = paramsubmitGlobalSMRAppointmentParameter as SubmitGlobalSMRAppointmentParameter;




            context.ActionArguments.TryGetValue("RequestParameter", out ParamSmrappointmentRescheduledParameter);
            var outSubmitsmrRefuseForServiceParameter = PramSubmitsmrRefuseForServiceParameter;

            context.ActionArguments.TryGetValue("SmrappointmentRescheduledParameter", out ParamSmrappointmentRescheduledParameter);
            var outSmrappointmentRescheduledParameter = ParamSmrappointmentRescheduledParameter ;



            context.ActionArguments.TryGetValue("smrdataGenerateCampaignWiseParameter", out ParamsmrDataGenerateCampaignWiseParameter);
            var outsmrDataGenerateCampaignWiseParameter = ParamsmrDataGenerateCampaignWiseParameter ;


            context.ActionArguments.TryGetValue("smrdataGenerateCampaignWiseAsingDataListParameter", out paramsmrdataGenerateCampaignWiseAsingDataListParameter);
            var outsMRDataGenerateCampaignWiseAsingDataListParameter = paramsmrdataGenerateCampaignWiseAsingDataListParameter ;

            context.ActionArguments.TryGetValue("monthTargetSettingSubmit", out parammonthTargetSettingSubmit);
            var outmonthTargetSettingSubmit = parammonthTargetSettingSubmit ;



            context.ActionArguments.TryGetValue("dayTargetSettingSubmit", out paramdayTargetSettingSubmit);
            var outdayTargetSettingSubmit = paramdayTargetSettingSubmit ;

            context.ActionArguments.TryGetValue("RequestSMREAssingedLeadCampaignDataParameter", out paramRequestSMREAssingedLeadCampaignDataParameter);
            var outSMREAssingedLeadCampaignDataParameter = paramRequestSMREAssingedLeadCampaignDataParameter ;

            context.ActionArguments.TryGetValue("RequestSMREAssingedLeadCampaignDataListParameter", out paramRequestSMREAssingedLeadCampaignDataListParameter);
            var outRequestSMREAssingedLeadCampaignDataListParameter = paramRequestSMREAssingedLeadCampaignDataListParameter  ;

        




          

            


            var result = await next();
        }
    }
}
