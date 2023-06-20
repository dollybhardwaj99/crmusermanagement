using Infrastructure.Abstraction.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using System.Threading.Tasks;
using System;

namespace CRM.Services.LeadManagement.Controllers
{

      [Route("api/lickomaster")]
    [ApiController]
    [EnableCors("AllowOrigin")]

    public class MasterController : Controller
    {
        private readonly IUnitOfWork _iUow;
        private ILogger _logger;
        public MasterController(IUnitOfWork unit, ILogger logger)
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
                    var response = await _iUow.iMasterRepository.GetFinancePaymentStatusMaster();
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
    }
}
