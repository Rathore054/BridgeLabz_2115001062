using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Interface;
using ModelLayer.DTO;
using NLog;

namespace HelloApp1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        private readonly IRegisterHelloBL _registerHelloBL;
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public HelloController(IRegisterHelloBL registerHelloBL)
        {
            _registerHelloBL = registerHelloBL;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                logger.Info("GET request received for HelloController.");
                string result = _registerHelloBL.registration(" Suyash");
                return Ok(new ResponseModel<string>
                {
                    Success = true,
                    Message = "Data fetched successfully",
                    Data = result
                });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error in Get method");
                return StatusCode(500, new ResponseModel<string>
                {
                    Success = false,
                    Message = "Internal Server Error",
                    Data = ex.Message
                });
            }
        }

        [HttpPost]
        public IActionResult LoginUser([FromBody] LoginDTO loginDTO)
        {
            try
            {
                logger.Info("POST request received for LoginUser.");
                bool result = _registerHelloBL.loginuser(loginDTO);

                if (result)
                {
                    return Ok(new ResponseModel<string>
                    {
                        Success = true,
                        Message = "Login Successful",
                        Data = loginDTO.username
                    });
                }

                return NotFound(new ResponseModel<string>
                {
                    Success = false,
                    Message = "Login failed",
                    Data = ""
                });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error in LoginUser method");
                return BadRequest(new ResponseModel<string>
                {
                    Success = false,
                    Message = "Login failed",
                    Data = ex.Message
                });
            }
        }
    }
}
