using Core.Context;
using CRM.Core.LeadManagement.Models.DTO.FinancePerformance;
using CRM.Core.LeadManagement.Models.Parameters.FinancePerformance;
using CRM.Infrastructure.LeadManagement.Abstraction.Repository;
using Dapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CRM.Infrastructure.LeadManagement.Implementation.Repository
{
    public  class FinancePerformanceRepository: IFinancePerformanceRepository
    {
        private ApplicationDapperContext _context;

        public FinancePerformanceRepository(ApplicationDapperContext dapContext)
        {
            this._context = dapContext;
        }

      

       

        public async Task<IEnumerable<GetFinancePentratrionPerfornceDTO>> GetFinancePentratrionPerfornce(GetFinancePentratrionPerfornceParameter RequestParameter)
        {
            using (var connection = _context.CreateConnection())
            {
                var DealerID = JsonSerializer.Serialize(RequestParameter.DealerID.ToList());
                var RegionID = JsonSerializer.Serialize(RequestParameter.RegionID.ToList());
                var ChannelID = JsonSerializer.Serialize(RequestParameter.ChannelID.ToList());
                var SRMID = JsonSerializer.Serialize(RequestParameter.SRMID.ToList());
                var RMID = JsonSerializer.Serialize(RequestParameter.RMID.ToList());
                var LocationID = JsonSerializer.Serialize(RequestParameter.LocationID.ToList());

                var data = connection.Query<GetFinancePentratrionPerfornceDTO>("sp_GetFinancePentratrionPerfornce",
                    param: new { DealerID, RegionID, ChannelID, SRMID, RMID, LocationID,  RequestParameter.FromDate, RequestParameter.ToDate },
                     commandType: CommandType.StoredProcedure).ToList();
                return data;
            }
        }

        public async Task<IEnumerable<GetPayoutCarPerfornceDTO>> GetPayoutCarPerfornce(GetFinancePentratrionPerfornceParameter RequestParameter)
        {
            using (var connection = _context.CreateConnection())
            {
                var DealerID = JsonSerializer.Serialize(RequestParameter.DealerID.ToList());
                var RegionID = JsonSerializer.Serialize(RequestParameter.RegionID.ToList());
                var ChannelID = JsonSerializer.Serialize(RequestParameter.ChannelID.ToList());
                var SRMID = JsonSerializer.Serialize(RequestParameter.SRMID.ToList());
                var RMID = JsonSerializer.Serialize(RequestParameter.RMID.ToList());
                var LocationID = JsonSerializer.Serialize(RequestParameter.LocationID.ToList());

                var data = connection.Query<GetPayoutCarPerfornceDTO>("GetPayoutCarPerfornce",
                    param: new { DealerID, RegionID, ChannelID, SRMID, RMID, LocationID, RequestParameter.FromDate, RequestParameter.ToDate },
                     commandType: CommandType.StoredProcedure).ToList();
                return data;
            }
        }

        public async Task<IEnumerable<FinanceWalletShareDTO>> GetFinanceWalletShare(FinanceWalletShareParameter RequestParameter)

        {
            using (var connection = _context.CreateConnection())
            {
                var DealerID = JsonSerializer.Serialize(RequestParameter.DealerID.ToList());
                var RegionID = JsonSerializer.Serialize(RequestParameter.RegionID.ToList());
                var ChannelID = JsonSerializer.Serialize(RequestParameter.ChannelID.ToList());
                var SRMID = JsonSerializer.Serialize(RequestParameter.SRMID.ToList());
                var RMID = JsonSerializer.Serialize(RequestParameter.RMID.ToList());
                var LocationID = JsonSerializer.Serialize(RequestParameter.LocationID.ToList());
                var FinancerID = JsonSerializer.Serialize(RequestParameter.FinanceID.ToList());
                var data = connection.Query<FinanceWalletShareDTO>("SP_GetFinanceWalletShare",
                    param: new { DealerID, RegionID, ChannelID, SRMID, RMID, LocationID, FinancerID, RequestParameter.FromDate, RequestParameter.ToDate },
                     commandType: CommandType.StoredProcedure).ToList();
                return data;
            }
        }
        public async Task<IEnumerable<FinanceCurrentOutStandingDTO>> GetFinanceCurrentOutStanding(FinanceWalletShareParameter RequestParameter)
        {
            using (var connection = _context.CreateConnection())
            {
                var DealerID = JsonSerializer.Serialize(RequestParameter.DealerID.ToList());
                var RegionID = JsonSerializer.Serialize(RequestParameter.RegionID.ToList());
                var ChannelID = JsonSerializer.Serialize(RequestParameter.ChannelID.ToList());
                var SRMID = JsonSerializer.Serialize(RequestParameter.SRMID.ToList());
                var RMID = JsonSerializer.Serialize(RequestParameter.RMID.ToList());
                var LocationID = JsonSerializer.Serialize(RequestParameter.LocationID.ToList());
                var FinancerID = JsonSerializer.Serialize(RequestParameter.FinanceID.ToList()); var data = connection.Query<FinanceCurrentOutStandingDTO>("SP_GetFinanceCurrentOutStanding",
                    param: new { DealerID, RegionID, ChannelID, SRMID, RMID, LocationID, FinancerID, RequestParameter.FromDate, RequestParameter.ToDate },
                     commandType: CommandType.StoredProcedure).ToList();
                return data;
            }
        }

        public async Task<IEnumerable<AvvergeMonthlyCollectionDTO>> GetAvvergeMonthlyCollection(GetFinancePentratrionPerfornceParameter RequestParameter)
        {
            using (var connection = _context.CreateConnection())
            {
                var DealerID = JsonSerializer.Serialize(RequestParameter.DealerID.ToList());
                var RegionID = JsonSerializer.Serialize(RequestParameter.RegionID.ToList());
                var ChannelID = JsonSerializer.Serialize(RequestParameter.ChannelID.ToList());
                var SRMID = JsonSerializer.Serialize(RequestParameter.SRMID.ToList());
                var RMID = JsonSerializer.Serialize(RequestParameter.RMID.ToList());
                var LocationID = JsonSerializer.Serialize(RequestParameter.LocationID.ToList());

                var data = connection.Query<AvvergeMonthlyCollectionDTO>("SP_GetAvvergeMonthlyCollection",
                    param: new { DealerID, RegionID, ChannelID, SRMID, RMID, LocationID, RequestParameter.FromDate, RequestParameter.ToDate },
                     commandType: CommandType.StoredProcedure).ToList();
                return data;
            }
        }

        
        public async Task<IEnumerable<GetAgeWiseOutStandingFinalDTO>> GetAgeWiseOutStanding(FinanceWalletShareParameter RequestParameter)
        {



            var DataROW = new List<GetAgeWiseOutStandingDTO>();
            var Data = new List<GetAgeWiseOutStandingFinalDTO>();
            using (var connection = _context.CreateConnection())
            {
                var DealerID = JsonSerializer.Serialize(RequestParameter.DealerID.ToList());
                var RegionID = JsonSerializer.Serialize(RequestParameter.RegionID.ToList());
                var ChannelID = JsonSerializer.Serialize(RequestParameter.ChannelID.ToList());
                var SRMID = JsonSerializer.Serialize(RequestParameter.SRMID.ToList());
                var RMID = JsonSerializer.Serialize(RequestParameter.RMID.ToList());
                var LocationID = JsonSerializer.Serialize(RequestParameter.LocationID.ToList());
                var FinancerID = JsonSerializer.Serialize(RequestParameter.FinanceID.ToList());

                 DataROW = connection.Query<GetAgeWiseOutStandingDTO>("sp_GetAgeWiseOutStanding",
                    param: new { DealerID, RegionID, ChannelID, SRMID, RMID, LocationID, FinancerID, RequestParameter.FromDate, RequestParameter.ToDate },
                     commandType: CommandType.StoredProcedure).ToList();
               
            }


            var GroupData = DataROW.GroupBy(p => new { p.FinancerName }).ToList();
            GroupData.ForEach(xc => {
                var DataCheck = new GetAgeWiseOutStandingFinalDTO();
                DataCheck.FinancerName = xc.Key.FinancerName;


                DataCheck.Values = new List<GetAgeWiseOutStanding>();

                DataCheck.Values = xc.Select(p => new GetAgeWiseOutStanding()
                {
                    days30 = p.days30,
                    days60 = p.days60,
                    over60 = p.over60,
                    



                }).ToList();
                Data.Add(DataCheck);

            });
            return Data;
        }


        public async Task<IEnumerable<GetFinancePentratrionDTO>> GetFinancePentratrion(GetFinancePentratrionParameter RequestParameter)
        {
            using (var connection = _context.CreateConnection())
            {
                var DealerID = JsonSerializer.Serialize(RequestParameter.DealerID.ToList());
                var RegionID = JsonSerializer.Serialize(RequestParameter.RegionID.ToList());
                var ChannelID = JsonSerializer.Serialize(RequestParameter.ChannelID.ToList());
                var SRMID = JsonSerializer.Serialize(RequestParameter.SRMID.ToList());
                var RMID = JsonSerializer.Serialize(RequestParameter.RMID.ToList());
                var LocationID = JsonSerializer.Serialize(RequestParameter.LocationID.ToList());

                var data = connection.Query<GetFinancePentratrionDTO>("sp_GetFinancePentratrion",
                    param: new { DealerID, RegionID, ChannelID, SRMID, RMID, LocationID, RequestParameter.ViewType, RequestParameter.FromDate, RequestParameter.ToDate },
                     commandType: CommandType.StoredProcedure).ToList();
                return data;
            }
        }


        public async Task<IEnumerable<GetFinancePentratrionListViewDTO>> GetFinancePentratrionListView(GetFinancePentratrionParameter RequestParameter)
        {
            using (var connection = _context.CreateConnection())
            {
                var DealerID = JsonSerializer.Serialize(RequestParameter.DealerID.ToList());
                var RegionID = JsonSerializer.Serialize(RequestParameter.RegionID.ToList());
                var ChannelID = JsonSerializer.Serialize(RequestParameter.ChannelID.ToList());
                var SRMID = JsonSerializer.Serialize(RequestParameter.SRMID.ToList());
                var RMID = JsonSerializer.Serialize(RequestParameter.RMID.ToList());
                var LocationID = JsonSerializer.Serialize(RequestParameter.LocationID.ToList());

                var data = connection.Query<GetFinancePentratrionListViewDTO>("sp_GetFinancePentratrionListView",
                    param: new { DealerID, RegionID, ChannelID, SRMID, RMID, LocationID, RequestParameter.ViewType, RequestParameter.FromDate, RequestParameter.ToDate },
                     commandType: CommandType.StoredProcedure).ToList();
                return data;
            }
        }


        public async Task<IEnumerable<GetWalletShareFinalDTO>> GetWalletShare(GetFinancePentratrionPerfornceParameter RequestParameter)
        {

            var DataROW = new List<GetWalletShareDTO>();
            var Data = new List<GetWalletShareFinalDTO>();
            using (var connection = _context.CreateConnection())
            {
                var DealerID = JsonSerializer.Serialize(RequestParameter.DealerID.ToList());
                var RegionID = JsonSerializer.Serialize(RequestParameter.RegionID.ToList());
                var ChannelID = JsonSerializer.Serialize(RequestParameter.ChannelID.ToList());
                var SRMID = JsonSerializer.Serialize(RequestParameter.SRMID.ToList());
                var RMID = JsonSerializer.Serialize(RequestParameter.RMID.ToList());
                var LocationID = JsonSerializer.Serialize(RequestParameter.LocationID.ToList());

                 DataROW = connection.Query<GetWalletShareDTO>("sp_GetWalletShare",
                    param: new { DealerID, RegionID, ChannelID, SRMID, RMID, LocationID, RequestParameter.FromDate, RequestParameter.ToDate },
                     commandType: CommandType.StoredProcedure).ToList();
                
            }
            var GroupData = DataROW.GroupBy(p => new { p.FinancerName }).ToList();
            GroupData.ForEach(xc => {
                var DataCheck = new GetWalletShareFinalDTO();
                DataCheck.FinancerName = xc.Key.FinancerName;


                DataCheck.values = new List<GetWalletShare>();

                DataCheck.values = xc.Select(p => new GetWalletShare()
                {
                    TotalFinance = p.TotalFinance,
                    InHouseFinance = p.InHouseFinance,
                




                }).ToList();
                Data.Add(DataCheck);

            });
            return Data;

        }


        public async Task<IEnumerable<GetWalletShareListViewDTO>> GetWalletShareListView(GetFinancePentratrionPerfornceParameter RequestParameter)
        {
            using (var connection = _context.CreateConnection())
            {
                var DealerID = JsonSerializer.Serialize(RequestParameter.DealerID.ToList());
                var RegionID = JsonSerializer.Serialize(RequestParameter.RegionID.ToList());
                var ChannelID = JsonSerializer.Serialize(RequestParameter.ChannelID.ToList());
                var SRMID = JsonSerializer.Serialize(RequestParameter.SRMID.ToList());
                var RMID = JsonSerializer.Serialize(RequestParameter.RMID.ToList());
                var LocationID = JsonSerializer.Serialize(RequestParameter.LocationID.ToList());

                var data = connection.Query<GetWalletShareListViewDTO>("sp_GetWalletShareListView",
                   param: new { DealerID, RegionID, ChannelID, SRMID, RMID, LocationID, RequestParameter.FromDate, RequestParameter.ToDate },
                    commandType: CommandType.StoredProcedure).ToList();
                return data;
            }
        }

        public async Task<IEnumerable<GetMothlyCollectionTrendsDTO>> GetMothlyCollectionTrends(GetMothlyCollectionTrendsParametre RequestParameter)
        {
            using (var connection = _context.CreateConnection())
            {
                var DealerID = JsonSerializer.Serialize(RequestParameter.DealerID.ToList());
                var RegionID = JsonSerializer.Serialize(RequestParameter.RegionID.ToList());
                var ChannelID = JsonSerializer.Serialize(RequestParameter.ChannelID.ToList());
                var FinanceID = JsonSerializer.Serialize(RequestParameter.FinanceID.ToList());
                
                var LocationID = JsonSerializer.Serialize(RequestParameter.LocationID.ToList());

                var data = connection.Query<GetMothlyCollectionTrendsDTO>("sp_GetMothlyCollectionTrends",
                   param: new { DealerID, RegionID, ChannelID, FinanceID, LocationID, RequestParameter.FromDate, RequestParameter.ToDate },
                    commandType: CommandType.StoredProcedure).ToList();
                return data;
            }
        }

        public async Task<IEnumerable<GetMothlyCollectionTrendsListViewDTO>> GetMothlyCollectionTrendsListView(GetMothlyCollectionTrendsParametre RequestParameter)
        {
            using (var connection = _context.CreateConnection())
            {
                var DealerID = JsonSerializer.Serialize(RequestParameter.DealerID.ToList());
                var RegionID = JsonSerializer.Serialize(RequestParameter.RegionID.ToList());
                var ChannelID = JsonSerializer.Serialize(RequestParameter.ChannelID.ToList());
                var FinanceID = JsonSerializer.Serialize(RequestParameter.FinanceID.ToList());

                var LocationID = JsonSerializer.Serialize(RequestParameter.LocationID.ToList());

                var data = connection.Query<GetMothlyCollectionTrendsListViewDTO>("sp_GetMothlyCollectionTrendsListView",
                   param: new { DealerID, RegionID, ChannelID, FinanceID, LocationID, RequestParameter.FromDate, RequestParameter.ToDate },
                    commandType: CommandType.StoredProcedure).ToList();
                return data;
            }
        }


        public async Task<IEnumerable<GetAvergePaymentTatFinalDTO>> GetAvergePaymentTat(GetAvergePaymentTatParemeter RequestParameter)
        {


            var DataROW = new List<GetAvergePaymentTatDTO>();
            var Data = new List<GetAvergePaymentTatFinalDTO>();
            using (var connection = _context.CreateConnection())
            {
               
                var FinanceID = JsonSerializer.Serialize(RequestParameter.FinanceID.ToList());



                DataROW = connection.Query<GetAvergePaymentTatDTO>("sp_GetAvergePaymentTat",
                   param: new { FinanceID, RequestParameter.FromDate, RequestParameter.ToDate },
                    commandType: CommandType.StoredProcedure).ToList();
               
            }


            var GroupData = DataROW.GroupBy(p => new { p.FinancerName }).ToList();
            GroupData.ForEach(xc => {
                var DataCheck = new GetAvergePaymentTatFinalDTO();
                DataCheck.FinancerName = xc.Key.FinancerName;


                DataCheck.Data = new List<GetAvergePaymentTat>();

                DataCheck.Data = xc.Select(p => new GetAvergePaymentTat()
                {
                    Averagepaymentdays = p.Averagepaymentdays,
                   




                }).ToList();
                Data.Add(DataCheck);

            });
            return Data;
        }


        public async Task<IEnumerable<GetAvergePaymentTatListViewDTO>> GetAvergePaymentTatListView(GetAvergePaymentTatParemeter RequestParameter)
        {
            using (var connection = _context.CreateConnection())
            {

                var FinanceID = JsonSerializer.Serialize(RequestParameter.FinanceID.ToList());

              

                var data = connection.Query<GetAvergePaymentTatListViewDTO>("sp_GetAvergePaymentTatListView",
                   param: new {  FinanceID, RequestParameter.FromDate, RequestParameter.ToDate },
                    commandType: CommandType.StoredProcedure).ToList();
                return data;
            }
        }
    }
}






