using Infrastructure.Abstraction.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using System.Threading.Tasks;
using System;
using CRM.Core.LeadManagement.Models.Parameters.FinancePerformance;
using Infrastructure.Implementation.Common;
using Infrastructure.Abstraction.Common;
using CRM.Core.LeadManagement.Models.DTO.FinancePerformance;
using System.Collections.Generic;

namespace CRM.Services.LeadManagement.Controllers
{


    [Route("api/financeperformance")]
    [ApiController]
    [EnableCors("AllowOrigin")]

    public class FinancePerformanceController : Controller
    {


        private readonly IUnitOfWork _iUow;
        private ILogger _logger;
        private readonly IHelper _Helper;
        public FinancePerformanceController(IUnitOfWork unit, ILogger logger, IHelper helper)
        {
            _iUow = unit;
            _logger = logger;
            _Helper = helper;
        }
        [HttpPost]
        [Route("getfinancepentratrionperfornce")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetFinancePentratrionPerfornce([FromBody] GetFinancePentratrionPerfornceParameter financeParameter)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    financeParameter.FromDate = (financeParameter.FromDate.Length > 0 ? _Helper.ConvertStringToDate(financeParameter.FromDate) : DateTime.Now.AddDays(-30)).ToString("yyyy-MM-dd");
                    financeParameter.ToDate = (financeParameter.ToDate.Length > 0 ? _Helper.ConvertStringToDate(financeParameter.ToDate) : DateTime.Now.AddDays(60)).ToString("yyyy-MM-dd");
                    _logger.Information("Called financeperformance - getfinancepentratrionperfornce Method with Request : {0}" + financeParameter);
                    var result = await _iUow.iFinancePerformanceRepository.GetFinancePentratrionPerfornce(financeParameter);

                    return Ok(result);

                }
                else

                {

                    return BadRequest(new { Message = ModelState.ErrorCount });
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Exception at financeperformance - getfinancepentratrionperfornce Method; Details: - {0})", ex.StackTrace); return StatusCode(StatusCodes.Status500InternalServerError, "Exception Occured Contact Admin");


            }

        }


        [HttpPost]
        [Route("getpayoutcarperfornce")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)] 

        public async Task<IActionResult> GetPayoutCarPerfornce([FromBody] GetFinancePentratrionPerfornceParameter financeParameter)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    financeParameter.FromDate = (financeParameter.FromDate.Length > 0 ? _Helper.ConvertStringToDate(financeParameter.FromDate) : DateTime.Now.AddDays(-30)).ToString("yyyy-MM-dd");
                    financeParameter.ToDate = (financeParameter.ToDate.Length > 0 ? _Helper.ConvertStringToDate(financeParameter.ToDate) : DateTime.Now.AddDays(60)).ToString("yyyy-MM-dd");
                    _logger.Information("Called financeperformance - GetPayoutCarPerfornce Method with Request : {0}" + financeParameter);
                    var result = await _iUow.iFinancePerformanceRepository.GetPayoutCarPerfornce(financeParameter);

                    return Ok(result);

                }
                else

                {

                    return BadRequest(new { Message = ModelState.ErrorCount });
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Exception at financeperformance - GetPayoutCarPerfornce Method; Details: - {0})", ex.StackTrace); return StatusCode(StatusCodes.Status500InternalServerError, "Exception Occured Contact Admin");


            }

        }



        [HttpPost]
        [Route("getfinancewalletshare")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> GetFinanceWalletShare([FromBody] FinanceWalletShareParameter financeParameter)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    financeParameter.FromDate = (financeParameter.FromDate.Length > 0 ? _Helper.ConvertStringToDate(financeParameter.FromDate) : DateTime.Now.AddDays(-30)).ToString("yyyy-MM-dd");
                    financeParameter.ToDate = (financeParameter.ToDate.Length > 0 ? _Helper.ConvertStringToDate(financeParameter.ToDate) : DateTime.Now.AddDays(60)).ToString("yyyy-MM-dd");
                    _logger.Information("Called financeperformance - GetFinanceWalletShare Method with Request : {0}" + financeParameter);
                    var result = await _iUow.iFinancePerformanceRepository.GetFinanceWalletShare(financeParameter);

                    return Ok(result);

                }
                else

                {

                    return BadRequest(new { Message = ModelState.ErrorCount });
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Exception at financeperformance - GetFinanceWalletShare Method; Details: - {0})", ex.StackTrace); return StatusCode(StatusCodes.Status500InternalServerError, "Exception Occured Contact Admin");


            }

        }


        [HttpPost]
        [Route("getfinancecurrentoutstanding")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> GetFinanceCurrentOutStanding([FromBody] FinanceWalletShareParameter financeParameter)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    financeParameter.FromDate = (financeParameter.FromDate.Length > 0 ? _Helper.ConvertStringToDate(financeParameter.FromDate) : DateTime.Now.AddDays(-30)).ToString("yyyy-MM-dd");
                    financeParameter.ToDate = (financeParameter.ToDate.Length > 0 ? _Helper.ConvertStringToDate(financeParameter.ToDate) : DateTime.Now.AddDays(60)).ToString("yyyy-MM-dd");
                    _logger.Information("Called financeperformance - GetFinanceCurrentOutStanding Method with Request : {0}" + financeParameter);
                    var result = await _iUow.iFinancePerformanceRepository.GetFinanceCurrentOutStanding(financeParameter);

                    return Ok(result);

                }
                else

                {

                    return BadRequest(new { Message = ModelState.ErrorCount });
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Exception at financeperformance - GetFinanceCurrentOutStanding Method; Details: - {0})", ex.StackTrace); return StatusCode(StatusCodes.Status500InternalServerError, "Exception Occured Contact Admin");


            }

        }


        [HttpPost]
        [Route("getavvergemonthlycollection")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> GetAvvergeMonthlyCollection([FromBody] GetFinancePentratrionPerfornceParameter financeParameter)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    financeParameter.FromDate = (financeParameter.FromDate.Length > 0 ? _Helper.ConvertStringToDate(financeParameter.FromDate) : DateTime.Now.AddDays(-30)).ToString("yyyy-MM-dd");
                    financeParameter.ToDate = (financeParameter.ToDate.Length > 0 ? _Helper.ConvertStringToDate(financeParameter.ToDate) : DateTime.Now.AddDays(60)).ToString("yyyy-MM-dd");
                    _logger.Information("Called financeperformance - GetAvvergeMonthlyCollection Method with Request : {0}" + financeParameter);
                    var result = await _iUow.iFinancePerformanceRepository.GetAvvergeMonthlyCollection(financeParameter);

                    return Ok(result);

                }
                else

                {

                    return BadRequest(new { Message = ModelState.ErrorCount });
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Exception at financeperformance - GetAvvergeMonthlyCollection Method; Details: - {0})", ex.StackTrace); return StatusCode(StatusCodes.Status500InternalServerError, "Exception Occured Contact Admin");


            }

        }
        [HttpPost]
        [Route("getagewiseoutstanding")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> GetAgeWiseOutStanding([FromBody] FinanceWalletShareParameter financeParameter)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    financeParameter.FromDate = (financeParameter.FromDate.Length > 0 ? _Helper.ConvertStringToDate(financeParameter.FromDate) : DateTime.Now.AddDays(-30)).ToString("yyyy-MM-dd");
                    financeParameter.ToDate = (financeParameter.ToDate.Length > 0 ? _Helper.ConvertStringToDate(financeParameter.ToDate) : DateTime.Now.AddDays(60)).ToString("yyyy-MM-dd");
                    _logger.Information("Called financeperformance - GetAgeWiseOutStanding Method with Request : {0}" + financeParameter);
                    var result = await _iUow.iFinancePerformanceRepository.GetAgeWiseOutStanding(financeParameter);

                    return Ok(result);

                }
                else

                {

                    return BadRequest(new { Message = ModelState.ErrorCount });
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Exception at financeperformance - GetAgeWiseOutStanding Method; Details: - {0})", ex.StackTrace); return StatusCode(StatusCodes.Status500InternalServerError, "Exception Occured Contact Admin");


            }

        }


        [HttpPost]
        [Route("getfinancepentratrion")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> GetFinancePentratrion([FromBody] GetFinancePentratrionParameter financeParameter)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    financeParameter.FromDate = (financeParameter.FromDate.Length > 0 ? _Helper.ConvertStringToDate(financeParameter.FromDate) : DateTime.Now.AddDays(-30)).ToString("yyyy-MM-dd");
                    financeParameter.ToDate = (financeParameter.ToDate.Length > 0 ? _Helper.ConvertStringToDate(financeParameter.ToDate) : DateTime.Now.AddDays(60)).ToString("yyyy-MM-dd");
                    _logger.Information("Called financeperformance - GetFinancePentratrion Method with Request : {0}" + financeParameter);
                    var result = await _iUow.iFinancePerformanceRepository.GetFinancePentratrion(financeParameter);

                    return Ok(result);

                }
                else

                {

                    return BadRequest(new { Message = ModelState.ErrorCount });
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Exception at financeperformance - GetFinancePentratrion Method; Details: - {0})", ex.StackTrace); return StatusCode(StatusCodes.Status500InternalServerError, "Exception Occured Contact Admin");


            }

        }


        [HttpPost]
        [Route("getfinancepentratrionlistview")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> GetFinancePentratrionListView([FromBody] GetFinancePentratrionParameter financeParameter)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    financeParameter.FromDate = (financeParameter.FromDate.Length > 0 ? _Helper.ConvertStringToDate(financeParameter.FromDate) : DateTime.Now.AddDays(-30)).ToString("yyyy-MM-dd");
                    financeParameter.ToDate = (financeParameter.ToDate.Length > 0 ? _Helper.ConvertStringToDate(financeParameter.ToDate) : DateTime.Now.AddDays(60)).ToString("yyyy-MM-dd");
                    _logger.Information("Called financeperformance - GetFinancePentratrionListView Method with Request : {0}" + financeParameter);
                    var result = await _iUow.iFinancePerformanceRepository.GetFinancePentratrionListView(financeParameter);

                    return Ok(result);

                }
                else

                {

                    return BadRequest(new { Message = ModelState.ErrorCount });
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Exception at financeperformance - GetFinancePentratrionListView Method; Details: - {0})", ex.StackTrace); return StatusCode(StatusCodes.Status500InternalServerError, "Exception Occured Contact Admin");


            }

        }



        [HttpPost]
        [Route("getwalletshare")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> GetWalletShare([FromBody] GetFinancePentratrionPerfornceParameter financeParameter)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    financeParameter.FromDate = (financeParameter.FromDate.Length > 0 ? _Helper.ConvertStringToDate(financeParameter.FromDate) : DateTime.Now.AddDays(-30)).ToString("yyyy-MM-dd");
                    financeParameter.ToDate = (financeParameter.ToDate.Length > 0 ? _Helper.ConvertStringToDate(financeParameter.ToDate) : DateTime.Now.AddDays(60)).ToString("yyyy-MM-dd");
                    _logger.Information("Called financeperformance - GetWalletShare Method with Request : {0}" + financeParameter);
                    var result = await _iUow.iFinancePerformanceRepository.GetWalletShare(financeParameter);

                    return Ok(result);

                }
                else

                {

                    return BadRequest(new { Message = ModelState.ErrorCount });
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Exception at financeperformance - GetWalletShare Method; Details: - {0})", ex.StackTrace); return StatusCode(StatusCodes.Status500InternalServerError, "Exception Occured Contact Admin");


            }

        }


        [HttpPost]
        [Route("getwalletsharelistview")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> GetWalletShareListView([FromBody] GetFinancePentratrionPerfornceParameter financeParameter)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    financeParameter.FromDate = (financeParameter.FromDate.Length > 0 ? _Helper.ConvertStringToDate(financeParameter.FromDate) : DateTime.Now.AddDays(-30)).ToString("yyyy-MM-dd");
                    financeParameter.ToDate = (financeParameter.ToDate.Length > 0 ? _Helper.ConvertStringToDate(financeParameter.ToDate) : DateTime.Now.AddDays(60)).ToString("yyyy-MM-dd");
                    _logger.Information("Called financeperformance - GetWalletShareListView Method with Request : {0}" + financeParameter);
                    var result = await _iUow.iFinancePerformanceRepository.GetWalletShareListView(financeParameter);

                    return Ok(result);

                }
                else

                {

                    return BadRequest(new { Message = ModelState.ErrorCount });
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Exception at financeperformance - GetWalletShareListView Method; Details: - {0})", ex.StackTrace); return StatusCode(StatusCodes.Status500InternalServerError, "Exception Occured Contact Admin");


            }

        }


        [HttpPost]
        [Route("getmothlycollectiontrends")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> GetMothlyCollectionTrends([FromBody] GetMothlyCollectionTrendsParametre financeParameter)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    financeParameter.FromDate = (financeParameter.FromDate.Length > 0 ? _Helper.ConvertStringToDate(financeParameter.FromDate) : DateTime.Now.AddDays(-30)).ToString("yyyy-MM-dd");
                    financeParameter.ToDate = (financeParameter.ToDate.Length > 0 ? _Helper.ConvertStringToDate(financeParameter.ToDate) : DateTime.Now.AddDays(60)).ToString("yyyy-MM-dd");
                    _logger.Information("Called financeperformance - GetMothlyCollectionTrends Method with Request : {0}" + financeParameter);
                    var result = await _iUow.iFinancePerformanceRepository.GetMothlyCollectionTrends(financeParameter);

                    return Ok(result);

                }
                else

                {

                    return BadRequest(new { Message = ModelState.ErrorCount });
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Exception at financeperformance - GetMothlyCollectionTrends Method; Details: - {0})", ex.StackTrace); return StatusCode(StatusCodes.Status500InternalServerError, "Exception Occured Contact Admin");


            }

        }

        [HttpPost]
        [Route("getmothlycollectiontrendslistview")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> GetMothlyCollectionTrendsListView([FromBody] GetMothlyCollectionTrendsParametre financeParameter)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    financeParameter.FromDate = (financeParameter.FromDate.Length > 0 ? _Helper.ConvertStringToDate(financeParameter.FromDate) : DateTime.Now.AddDays(-30)).ToString("yyyy-MM-dd");
                    financeParameter.ToDate = (financeParameter.ToDate.Length > 0 ? _Helper.ConvertStringToDate(financeParameter.ToDate) : DateTime.Now.AddDays(60)).ToString("yyyy-MM-dd");
                    _logger.Information("Called financeperformance - GetMothlyCollectionTrendsListView Method with Request : {0}" + financeParameter);
                    var result = await _iUow.iFinancePerformanceRepository.GetMothlyCollectionTrendsListView(financeParameter);

                    return Ok(result);

                }
                else

                {

                    return BadRequest(new { Message = ModelState.ErrorCount });
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Exception at financeperformance - GetMothlyCollectionTrendsListView Method; Details: - {0})", ex.StackTrace); return StatusCode(StatusCodes.Status500InternalServerError, "Exception Occured Contact Admin");


            }

        }



        [HttpPost]
        [Route("getavergepaymenttat")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> GetAvergePaymentTat([FromBody] GetAvergePaymentTatParemeter financeParameter)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    financeParameter.FromDate = (financeParameter.FromDate.Length > 0 ? _Helper.ConvertStringToDate(financeParameter.FromDate) : DateTime.Now.AddDays(-30)).ToString("yyyy-MM-dd");
                    financeParameter.ToDate = (financeParameter.ToDate.Length > 0 ? _Helper.ConvertStringToDate(financeParameter.ToDate) : DateTime.Now.AddDays(60)).ToString("yyyy-MM-dd");
                    _logger.Information("Called financeperformance - GetAvergePaymentTat Method with Request : {0}" + financeParameter);
                    var result = await _iUow.iFinancePerformanceRepository.GetAvergePaymentTat(financeParameter);

                    return Ok(result);

                }
                else

                {

                    return BadRequest(new { Message = ModelState.ErrorCount });
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Exception at financeperformance - GetAvergePaymentTat Method; Details: - {0})", ex.StackTrace); return StatusCode(StatusCodes.Status500InternalServerError, "Exception Occured Contact Admin");


            }

        }


        [HttpPost]
        [Route("getavergepaymenttatlistview")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> GetAvergePaymentTatListView([FromBody] GetAvergePaymentTatParemeter financeParameter)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    financeParameter.FromDate = (financeParameter.FromDate.Length > 0 ? _Helper.ConvertStringToDate(financeParameter.FromDate) : DateTime.Now.AddDays(-30)).ToString("yyyy-MM-dd");
                    financeParameter.ToDate = (financeParameter.ToDate.Length > 0 ? _Helper.ConvertStringToDate(financeParameter.ToDate) : DateTime.Now.AddDays(60)).ToString("yyyy-MM-dd");
                    _logger.Information("Called financeperformance - GetAvergePaymentTatListView Method with Request : {0}" + financeParameter);
                    var result = await _iUow.iFinancePerformanceRepository.GetAvergePaymentTatListView(financeParameter);

                    return Ok(result);

                }
                else

                {

                    return BadRequest(new { Message = ModelState.ErrorCount });
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Exception at financeperformance - GetAvergePaymentTatListView Method; Details: - {0})", ex.StackTrace); return StatusCode(StatusCodes.Status500InternalServerError, "Exception Occured Contact Admin");


            }

        }
    }
}





