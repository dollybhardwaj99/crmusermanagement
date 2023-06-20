using Infrastructure.Abstraction.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using System.Threading.Tasks;
using System;


namespace CRM.Services.InsuranceLeadManagement.Controllers
{

    [Route("api/financemaster")]
    [ApiController]
    [EnableCors("AllowOrigin")]

    public class FinanceMasterController : Controller
    {
        private readonly IUnitOfWork _iUow;
        private ILogger _logger;
        public FinanceMasterController(IUnitOfWork unit, ILogger logger)
        {
            _iUow = unit;
            _logger = logger;
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("getfinancepaymentstatusmaster")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetFinancePaymentStatusMaster()
        {
            try
            {
                _logger.Information("Called financemasterController - GetFinancePaymentStatusMaster Method with Request");
                if (ModelState.IsValid)
                {
                    var response = await _iUow.iFinanceMasterRepository.GetFinancePaymentStatusMaster();
                    return Ok(response);
                }
                else
                {
                    return BadRequest(new { Message = ModelState.ErrorCount });
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Exception at financemasterController - GetFinancePaymentStatusMaster Method; Details: - {0)", ex.StackTrace);
                return StatusCode(StatusCodes.Status500InternalServerError, "Exception Occured Contact Admin");
            }
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("getfinancepayoutinvoicestagemaster")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetFinancePayoutinvoiceStageMaster()
        {
            try
            {
                _logger.Information("Called financemasterController - GetFinancePayoutinvoiceStageMaster Method with Request");
                if (ModelState.IsValid)
                {
                    var response = await _iUow.iFinanceMasterRepository.GetFinancePayoutinvoiceStageMaster();
                    return Ok(response);
                }
                else
                {
                    return BadRequest(new { Message = ModelState.ErrorCount });
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Exception at financemasterController - GetFinancePayoutinvoiceStageMaster Method; Details: - {0)", ex.StackTrace);
                return StatusCode(StatusCodes.Status500InternalServerError, "Exception Occured Contact Admin");
            }
        }
        [AllowAnonymous]
        [HttpGet]
        [Route("getfinancestatusmaster")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetFinanceStatusMaster()
        {
            try
            {
                _logger.Information("Called financemasterController - GetFinanceStatusMaster Method with Request");
                if (ModelState.IsValid)
                {
                    var response = await _iUow.iFinanceMasterRepository.GetFinanceStatusMaster();
                    return Ok(response);
                }
                else
                {
                    return BadRequest(new { Message = ModelState.ErrorCount });
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Exception at financemasterController - GetFinanceStatusMaster Method; Details: - {0)", ex.StackTrace);
                return StatusCode(StatusCodes.Status500InternalServerError, "Exception Occured Contact Admin");
            }
        }
        [AllowAnonymous]
        [HttpGet]
        [Route("getfinancestagesmaster")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetFinanceStageMaster()
        {
            try
            {
                _logger.Information("Called financemasterController - GetFinanceStageMaster Method with Request");
                if (ModelState.IsValid)
                {
                    var response = await _iUow.iFinanceMasterRepository.GetFinanceStageMaster();
                    return Ok(response);
                }
                else
                {
                    return BadRequest(new { Message = ModelState.ErrorCount });
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Exception at financemasterController - GetFinanceStageMaster Method; Details: - {0)", ex.StackTrace);
                return StatusCode(StatusCodes.Status500InternalServerError, "Exception Occured Contact Admin");
            }
        }
        [AllowAnonymous]
        [HttpGet]
        [Route("getmodelmaster")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetModelMaster()
        {
            try
            {
                _logger.Information("Called financemasterController - GetModelMaster Method with Request");
                if (ModelState.IsValid)
                {
                    var response = await _iUow.iFinanceMasterRepository.GetModelMaster();
                    return Ok(response);
                }
                else
                {
                    return BadRequest(new { Message = ModelState.ErrorCount });
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Exception at financemasterController - GetModelMaster Method; Details: - {0)", ex.StackTrace);
                return StatusCode(StatusCodes.Status500InternalServerError, "Exception Occured Contact Admin");
            }
        }
        [AllowAnonymous]
        [HttpGet]
        [Route("getfinancetitelmaster")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetTitelMaster()
        {
            try
            {
                _logger.Information("Called financemasterController - GetTitelMaster Method with Request");
                if (ModelState.IsValid)
                {
                    var response = await _iUow.iFinanceMasterRepository.GetTitelMaster();
                    return Ok(response);
                }
                else
                {
                    return BadRequest(new { Message = ModelState.ErrorCount });
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Exception at financemasterController - GetTitelMaster Method; Details: - {0)", ex.StackTrace);
                return StatusCode(StatusCodes.Status500InternalServerError, "Exception Occured Contact Admin");
            }
        }
        [AllowAnonymous]
        [HttpGet]
        [Route("getfinancemaster")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetFinanceMaster()
        {
            try
            {
                _logger.Information("Called financemasterController - GetFinanceMaster Method with Request");
                if (ModelState.IsValid)
                {
                    var response = await _iUow.iFinanceMasterRepository.GetFinanceMaster();
                    return Ok(response);
                }
                else
                {
                    return BadRequest(new { Message = ModelState.ErrorCount });
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Exception at financemasterController - GetFinanceMaster Method; Details: - {0)", ex.StackTrace);
                return StatusCode(StatusCodes.Status500InternalServerError, "Exception Occured Contact Admin");
            }
        }
        [AllowAnonymous]
        [HttpGet]
        [Route("getfinancebranchmaster")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetFinanceBranchMaster()
        {
            try
            {
                _logger.Information("Called financemasterController - GetFinanceBranchMaster Method with Request");
                if (ModelState.IsValid)
                {
                    var response = await _iUow.iFinanceMasterRepository.GetFinanceBranchMaster();
                    return Ok(response);
                }
                else
                {
                    return BadRequest(new { Message = ModelState.ErrorCount });
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Exception at financemasterController - GetFinanceBranchMaster Method; Details: - {0)", ex.StackTrace);
                return StatusCode(StatusCodes.Status500InternalServerError, "Exception Occured Contact Admin");
            }
        }
        [AllowAnonymous]
        [HttpGet]
        [Route("getregionmaster")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetRegionMaster()
        {
            try
            {
                _logger.Information("Called financemasterController - GetRegionMaster Method with Request");
                if (ModelState.IsValid)
                {
                    var response = await _iUow.iFinanceMasterRepository.GetRegionMaster();
                    return Ok(response);
                }
                else
                {
                    return BadRequest(new { Message = ModelState.ErrorCount });
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Exception at financemasterController - GetRegionMaster Method; Details: - {0)", ex.StackTrace);
                return StatusCode(StatusCodes.Status500InternalServerError, "Exception Occured Contact Admin");
            }
        }
        [AllowAnonymous]
        [HttpGet]
        [Route("getfinancefueltypemaster")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetFuelTypeMaster()
        {
            try
            {
                _logger.Information("Called financemasterController - GetFuelTypeMaster Method with Request");
                if (ModelState.IsValid)
                {
                    var response = await _iUow.iFinanceMasterRepository.GetFuelTypeMaster();
                    return Ok(response);
                }
                else
                {
                    return BadRequest(new { Message = ModelState.ErrorCount });
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Exception at financemasterController - GetFuelTypeMaster Method; Details: - {0)", ex.StackTrace);
                return StatusCode(StatusCodes.Status500InternalServerError, "Exception Occured Contact Admin");
            }
        }
        [AllowAnonymous]
        [HttpGet]
        [Route("getfinanceloantypemaster")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetLoanTypeMaster()
        {
            try
            {
                _logger.Information("Called financemasterController - GetLoanTypeMaster Method with Request");
                if (ModelState.IsValid)
                {
                    var response = await _iUow.iFinanceMasterRepository.GetLoanTypeMaster();
                    return Ok(response);
                }
                else
                {
                    return BadRequest(new { Message = ModelState.ErrorCount });
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Exception at financemasterController - GetLoanTypeMaster Method; Details: - {0)", ex.StackTrace);
                return StatusCode(StatusCodes.Status500InternalServerError, "Exception Occured Contact Admin");
            }
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("getvarianttypemaster")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetVariantTypeMaster()
        {
            try
            {
                _logger.Information("Called financemasterController - GetVariantTypeMaster Method with Request");
                if (ModelState.IsValid)
                {
                    var response = await _iUow.iFinanceMasterRepository.GetVariantTypeMaster();
                    return Ok(response);
                }
                else
                {
                    return BadRequest(new { Message = ModelState.ErrorCount });
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Exception at financemasterController - GetVariantTypeMaster Method; Details: - {0)", ex.StackTrace);
                return StatusCode(StatusCodes.Status500InternalServerError, "Exception Occured Contact Admin");
            }
        }
        [AllowAnonymous]
        [HttpGet]
        [Route("getcolortypemaster")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetColorTypeMaster()
        {
            try
            {
                _logger.Information("Called financemasterController - GetColorTypeMaster Method with Request");
                if (ModelState.IsValid)
                {
                    var response = await _iUow.iFinanceMasterRepository.GetColorTypeMaster();
                    return Ok(response);
                }
                else
                {
                    return BadRequest(new { Message = ModelState.ErrorCount });
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Exception at financemasterController - GetColorTypeMaster Method; Details: - {0)", ex.StackTrace);
                return StatusCode(StatusCodes.Status500InternalServerError, "Exception Occured Contact Admin");
            }
        }



        [AllowAnonymous]
        [HttpGet]
        [Route("getteamleadmaster")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetTeamLeadMaster()
        {
            try
            {
                _logger.Information("Called financemasterController - GetTeamLeadMaster Method with Request");
                if (ModelState.IsValid)
                {
                    var response = await _iUow.iFinanceMasterRepository.GetTeamLeadMaster();
                    return Ok(response);
                }
                else
                {
                    return BadRequest(new { Message = ModelState.ErrorCount });
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Exception at financemasterController - GetTeamLeadMaster Method; Details: - {0)", ex.StackTrace);
                return StatusCode(StatusCodes.Status500InternalServerError, "Exception Occured Contact Admin");
            }
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("getdsetypemaster")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetDSETypeMaster()
        {
            try
            {
                _logger.Information("Called financemasterController - GetDSETypeMaster Method with Request");
                if (ModelState.IsValid)
                {
                    var response = await _iUow.iFinanceMasterRepository.GetDSETypeMaster();
                    return Ok(response);
                }
                else
                {
                    return BadRequest(new { Message = ModelState.ErrorCount });
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Exception at financemasterController - GetDSETypeMaster Method; Details: - {0)", ex.StackTrace);
                return StatusCode(StatusCodes.Status500InternalServerError, "Exception Occured Contact Admin");
            }
        }
    }


}
