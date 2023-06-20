using Infrastructure.Abstraction.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using System.Threading.Tasks;
using System;
using CRM.Core.LeadManagement.Models.Parameters.MASTERParmeter;

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
        [Route("getstudentdetailsmaster")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetStudentDetailsMaster()
        {
            try
            {
                _logger.Information("Called lickomasterController - GetStudentDetailsMaster Method with Request");
                if (ModelState.IsValid)
                {
                    var response = await _iUow.iMasterRepository.GetStudentDetailsMaster();
                    return Ok(response);
                }
                else
                {
                    return BadRequest(new { Message = ModelState.ErrorCount });
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Exception at lickomasterController - GetStudentDetailsMaster Method; Details: - {0)", ex.StackTrace);
                return StatusCode(StatusCodes.Status500InternalServerError, "Exception Occured Contact Admin");
            }
        }




        [AllowAnonymous]
        [HttpPost]
        [Route("getstudentdetailsidmaster")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetStudentDetailsIdMaster(MasterIDparameter parm)
        {
            try
            {
                _logger.Information("Called lickomasterController - GetStudentDetailsIdMaster Method with Request");
                if (ModelState.IsValid)
                {
                    var response = await _iUow.iMasterRepository.GetStudentDetailsIdMaster(parm);
                    return Ok(response);
                }
                else
                {
                    return BadRequest(new { Message = ModelState.ErrorCount });
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Exception at lickomasterController - GetStudentDetailsIdMaster Method; Details: - {0)", ex.StackTrace);
                return StatusCode(StatusCodes.Status500InternalServerError, "Exception Occured Contact Admin");
            }
        }
    }
}
