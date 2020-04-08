using System;
using System.Linq;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebBlogAPI.Models;

using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;

namespace WebBlogAPI.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    [EnableCors("AllowAll")]
    public class RegisterAccController : Controller
    {

        ILogger<RegisterAccController> _logger;

        public RegisterAccController(ILogger<RegisterAccController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok();
            }
            catch (Exception)
            {
                _logger.LogError("Failed to execute GET");
                return BadRequest();
            }
        }

        [HttpPost("insertproacc")]
        public IActionResult Post([FromBody] Member model)
        {
            try
            {

                byte[] salt = new byte[128/8];
                using(var rng = RandomNumberGenerator.Create())
                {
                    rng.GetBytes(salt);
                }
                
                return Created("", null);
            }
            catch (Exception)
            {
                _logger.LogError("Failed to execute POST");
                return BadRequest();
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody] Member model)
        {
            try
            {
                return Ok();
            }
            catch (Exception)
            {
                _logger.LogError("Failed to execute PUT");
                return BadRequest();
            }
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                return Ok();
            }
            catch (Exception)
            {
                _logger.LogError("Failed to execute DELETE");
                return BadRequest();
            }
        }
    }
}