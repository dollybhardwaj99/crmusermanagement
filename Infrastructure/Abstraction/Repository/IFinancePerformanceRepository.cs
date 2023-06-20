using CRM.Core.LeadManagement.Models.DTO.FinancePerformance;
using CRM.Core.LeadManagement.Models.Parameters.FinancePerformance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Infrastructure.LeadManagement.Abstraction.Repository
{
    public  interface IFinancePerformanceRepository
    {
        
        Task<IEnumerable<GetFinancePentratrionPerfornceDTO>> GetFinancePentratrionPerfornce(GetFinancePentratrionPerfornceParameter RequestParameter);
        Task<IEnumerable<GetPayoutCarPerfornceDTO>> GetPayoutCarPerfornce(GetFinancePentratrionPerfornceParameter RequestParameter);
        Task<IEnumerable<FinanceWalletShareDTO>> GetFinanceWalletShare(FinanceWalletShareParameter RequestParameter);
        Task<IEnumerable<FinanceCurrentOutStandingDTO>> GetFinanceCurrentOutStanding(FinanceWalletShareParameter RequestParameter);

        Task<IEnumerable<AvvergeMonthlyCollectionDTO>> GetAvvergeMonthlyCollection(GetFinancePentratrionPerfornceParameter RequestParameter);
        Task<IEnumerable<GetAgeWiseOutStandingFinalDTO>> GetAgeWiseOutStanding(FinanceWalletShareParameter RequestParameter);
        Task<IEnumerable<GetFinancePentratrionDTO>> GetFinancePentratrion(GetFinancePentratrionParameter RequestParameter);
        Task<IEnumerable<GetFinancePentratrionListViewDTO>> GetFinancePentratrionListView(GetFinancePentratrionParameter RequestParameter);
        Task<IEnumerable<GetWalletShareFinalDTO>> GetWalletShare(GetFinancePentratrionPerfornceParameter RequestParameter);
        Task<IEnumerable<GetWalletShareListViewDTO>> GetWalletShareListView(GetFinancePentratrionPerfornceParameter RequestParameter);

        Task<IEnumerable<GetMothlyCollectionTrendsDTO>> GetMothlyCollectionTrends(GetMothlyCollectionTrendsParametre RequestParameter);
        Task<IEnumerable<GetMothlyCollectionTrendsListViewDTO>> GetMothlyCollectionTrendsListView(GetMothlyCollectionTrendsParametre RequestParameter);
        Task<IEnumerable<GetAvergePaymentTatFinalDTO>> GetAvergePaymentTat(GetAvergePaymentTatParemeter RequestParameter);

        Task<IEnumerable<GetAvergePaymentTatListViewDTO>> GetAvergePaymentTatListView(GetAvergePaymentTatParemeter RequestParameter);

    }
}
