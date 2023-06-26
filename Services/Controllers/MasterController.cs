using Infrastructure.Abstraction.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using System.Threading.Tasks;
using System;
using CRM.Core.LeadManagement.Models.Parameters.MASTERParmeter;
using CRM.Core.LeadManagement.Models.DTO.MASTERDTO;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data;
using CRM.Core.LeadManagement.Models.Parameters;

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

        [AllowAnonymous]
        [HttpGet]
        [Route("getbookmaster")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetbookMaster()
        {
            try
            {
                _logger.Information("Called lickomasterController - GetbookMaster Method with Request");
                if (ModelState.IsValid)
                {
                    var response = await _iUow.iMasterRepository.GetbookMaster();
                    return Ok(response);
                }
                else
                {
                    return BadRequest(new { Message = ModelState.ErrorCount });
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Exception at lickomasterController - GetbookMaster Method; Details: - {0)", ex.StackTrace);
                return StatusCode(StatusCodes.Status500InternalServerError, "Exception Occured Contact Admin");
            }
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("getbookidmaster")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetbookIdMaster(MasterIDparameter parm)
        {
            try
            {
                _logger.Information("Called lickomasterController - GetbookIdMaster Method with Request");
                if (ModelState.IsValid)
                {
                    var response = await _iUow.iMasterRepository.GetbookIdMaster(parm);
                    return Ok(response);
                }
                else
                {
                    return BadRequest(new { Message = ModelState.ErrorCount });
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Exception at lickomasterController - GetbookIdMaster Method; Details: - {0)", ex.StackTrace);
                return StatusCode(StatusCodes.Status500InternalServerError, "Exception Occured Contact Admin");
            }
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("getclasssubjectmaster")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetsubjectMaster()
        {
            try
            {
                _logger.Information("Called lickomasterController - GetclasssubjectMaster Method with Request");
                if (ModelState.IsValid)
                {
                    var response = await _iUow.iMasterRepository.GetclasssubjectMaster();
                    return Ok(response);
                }
                else
                {
                    return BadRequest(new { Message = ModelState.ErrorCount });
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Exception at lickomasterController - GetclasssubjectMaster Method; Details: - {0)", ex.StackTrace);
                return StatusCode(StatusCodes.Status500InternalServerError, "Exception Occured Contact Admin");
            }
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("getclasssubjectidmaster")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetclasssubjectIdMaster(MasterIDparameter parm)
        {
            try
            {
                _logger.Information("Called lickomasterController - GetclasssubjectIdMaster Method with Request");
                if (ModelState.IsValid)
                {
                    var response = await _iUow.iMasterRepository.GetclasssubjectIdMaster(parm);
                    return Ok(response);
                }
                else
                {
                    return BadRequest(new { Message = ModelState.ErrorCount });
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Exception at lickomasterController - GetclasssubjectIdMaster Method; Details: - {0)", ex.StackTrace);
                return StatusCode(StatusCodes.Status500InternalServerError, "Exception Occured Contact Admin");
            }
        }
        [AllowAnonymous]
        [HttpGet]
        [Route("getclassmaster")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetexamMaster()
        {
            try
            {
                _logger.Information("Called lickomasterController - GetclassMaster Method with Request");
                if (ModelState.IsValid)
                {
                    var response = await _iUow.iMasterRepository.GetclassMaster();
                    return Ok(response);
                }
                else
                {
                    return BadRequest(new { Message = ModelState.ErrorCount });
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Exception at lickomasterController - GetclassMaster Method; Details: - {0)", ex.StackTrace);
                return StatusCode(StatusCodes.Status500InternalServerError, "Exception Occured Contact Admin");
            }
        }
        [AllowAnonymous]
        [HttpGet]
        [Route("getexammastername")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetexamMastername()
        {
            try
            {
                _logger.Information("Called lickomasterController - GetexamMaster Method with Request");
                if (ModelState.IsValid)
                {
                    var response = await _iUow.iMasterRepository.GetexamMaster();
                    return Ok(response);
                }
                else
                {
                    return BadRequest(new { Message = ModelState.ErrorCount });
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Exception at lickomasterController - GetexamMaster Method; Details: - {0)", ex.StackTrace);
                return StatusCode(StatusCodes.Status500InternalServerError, "Exception Occured Contact Admin");
            }
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("getexamidmaster")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetexamIdMaster(MasterIDparameter parm)
        {
            try
            {
                _logger.Information("Called lickomasterController - GetexamIdMaster Method with Request");
                if (ModelState.IsValid)
                {
                    var response = await _iUow.iMasterRepository.GetclasssubjectIdMaster(parm);
                    return Ok(response);
                }
                else
                {
                    return BadRequest(new { Message = ModelState.ErrorCount });
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Exception at lickomasterController - GetexamIdMaster Method; Details: - {0)", ex.StackTrace);
                return StatusCode(StatusCodes.Status500InternalServerError, "Exception Occured Contact Admin");
            }
        }
        [AllowAnonymous]
        [HttpGet]
        [Route("gethousemaster")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GethouseMaster()
        {
            try
            {
                _logger.Information("Called lickomasterController - GethouseMaster Method with Request");
                if (ModelState.IsValid)
                {
                    var response = await _iUow.iMasterRepository.GethouseMaster();
                    return Ok(response);
                }
                else
                {
                    return BadRequest(new { Message = ModelState.ErrorCount });
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Exception at lickomasterController - GethouseMaster Method; Details: - {0)", ex.StackTrace);
                return StatusCode(StatusCodes.Status500InternalServerError, "Exception Occured Contact Admin");
            }
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("gethouseidmaster")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GethouseIdMaster(MasterIDparameter parm)
        {
            try
            {
                _logger.Information("Called lickomasterController - GethouseIdMaster Method with Request");
                if (ModelState.IsValid)
                {
                    var response = await _iUow.iMasterRepository.GethouseIdMaster(parm);
                    return Ok(response);
                }
                else
                {
                    return BadRequest(new { Message = ModelState.ErrorCount });
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Exception at lickomasterController - GethouseIdMaster Method; Details: - {0)", ex.StackTrace);
                return StatusCode(StatusCodes.Status500InternalServerError, "Exception Occured Contact Admin");
            }
        }


        [AllowAnonymous]
        [HttpGet]
        [Route("getschoolmaster")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetschoolMaster()
        {
            try
            {
                _logger.Information("Called lickomasterController - GetschoolMaster Method with Request");
                if (ModelState.IsValid)
                {
                    var response = await _iUow.iMasterRepository.GetschoolMaster();
                    return Ok(response);
                }
                else
                {
                    return BadRequest(new { Message = ModelState.ErrorCount });
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Exception at lickomasterController - GetschoolMaster Method; Details: - {0)", ex.StackTrace);
                return StatusCode(StatusCodes.Status500InternalServerError, "Exception Occured Contact Admin");
            }
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("getschoolidmaster")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetschoolIdMaster(MasterIDparameter parm)
        {
            try
            {
                _logger.Information("Called lickomasterController - GetschoolIdMaster Method with Request");
                if (ModelState.IsValid)
                {
                    var response = await _iUow.iMasterRepository.GetschoolIdMaster(parm);
                    return Ok(response);
                }
                else
                {
                    return BadRequest(new { Message = ModelState.ErrorCount });
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Exception at lickomasterController - GetschoolIdMaster Method; Details: - {0)", ex.StackTrace);
                return StatusCode(StatusCodes.Status500InternalServerError, "Exception Occured Contact Admin");
            }
        }
        [AllowAnonymous]
        [HttpGet]
        [Route("getsessionmaster")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetsessionMaster()
        {
            try
            {
                _logger.Information("Called lickomasterController - Getsessionmaster Method with Request");
                if (ModelState.IsValid)
                {
                    var response = await _iUow.iMasterRepository.GetsessionMaster();
                    return Ok(response);
                }
                else
                {
                    return BadRequest(new { Message = ModelState.ErrorCount });
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Exception at lickomasterController - Getsessionmaster Method; Details: - {0)", ex.StackTrace);
                return StatusCode(StatusCodes.Status500InternalServerError, "Exception Occured Contact Admin");
            }
        }
        [AllowAnonymous]
        [HttpGet]
        [Route("getstudentmaster")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetstudentMaster()
        {
            try
            {
                _logger.Information("Called lickomasterController - GetstudentMaster Method with Request");
                if (ModelState.IsValid)
                {
                    var response = await _iUow.iMasterRepository.GetstudentMaster();
                    return Ok(response);
                }
                else
                {
                    return BadRequest(new { Message = ModelState.ErrorCount });
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Exception at lickomasterController - GetstudentMaster Method; Details: - {0)", ex.StackTrace);
                return StatusCode(StatusCodes.Status500InternalServerError, "Exception Occured Contact Admin");
            }
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("getstudentidmaster")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetStudentIdMaster(MasterIDparameter parm)
        {
            try
            {
                _logger.Information("Called lickomasterController - GetStudentIdMaster Method with Request");
                if (ModelState.IsValid)
                {
                    var response = await _iUow.iMasterRepository.GetstudentIdMaster(parm);
                    return Ok(response);
                }
                else
                {
                    return BadRequest(new { Message = ModelState.ErrorCount });
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Exception at lickomasterController - GetStudentIdMaster Method; Details: - {0)", ex.StackTrace);
                return StatusCode(StatusCodes.Status500InternalServerError, "Exception Occured Contact Admin");
            }
        }



        [AllowAnonymous]
        [HttpPost]
        [Route("submitexammaster")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> submitExammaster(SubmitExammasterparmeter parm)
        {
            try
            {
                _logger.Information("Called lickomasterController - submitExammaster Method with Request");
                if (ModelState.IsValid)
                {
                    var response = await _iUow.iMasterRepository.submitExammaster(parm);
                    return Ok(response);
                }
                else
                {
                    return BadRequest(new { Message = ModelState.ErrorCount });
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Exception at lickomasterController - submitExammaster Method; Details: - {0)", ex.StackTrace);
                return StatusCode(StatusCodes.Status500InternalServerError, "Exception Occured Contact Admin");
            }
        }
    }
}

      