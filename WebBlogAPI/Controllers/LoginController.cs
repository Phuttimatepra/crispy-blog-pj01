using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebBlogAPI.DataAccess;
using WebBlogAPI.Models;

namespace WebBlogAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [EnableCors("AllowAll")]
    public class LoginController : ControllerBase
    {

        ILogger<LoginController> _logger;
        public DatabaseContext _databaseContext { get; }

        public LoginController(ILogger<LoginController> logger, DatabaseContext databaseContext) : base()
        {
            _databaseContext = databaseContext;
            _logger = logger;
        }

        // Read
        [HttpGet("showall")]
        public ActionResult<Member> ShowDataAll()
        {
            try
            {
                var data = _databaseContext.Members.ToList();
                return Ok(data);
            }
            catch (Exception ex)
            {
                // _logger.LogError("Failed to execute GET");
                return BadRequest(ex);
            }
        }

        [HttpGet("show/{id}")]
        public ActionResult<Member> ShowByID(int id)
        {
            try
            {
                var data = _databaseContext.Members.Find(id); // datatype เป็น var หรือ Model Name ก็ได้ แต่ถ้าเป็นโมเดล จะลดความผิดพลาดมากกว่า
                
                if (data != null)
                {
                    return Ok(data);
                }
                else
                {
                    return null; // จะ return null หรือ NotFound() ก็ได้ เพราะ Find() หาไม่เจอจะได้ค่า null
                }

            }
            catch (Exception ex)
            {
                
                return BadRequest(ex);
            }
        }

        // create
        [HttpPost("addData")]
        public IActionResult InsertPost([FromBody] Member model)
        {
            try
            {
                _databaseContext.Members.Add(model);
                _databaseContext.SaveChanges();
                // return Created("", null);
                return Ok();
            }
            catch (Exception ex)
            {
                // _logger.LogError("Failed to execute POST");
                return BadRequest(ex);
            }
        }

        // update
        // m => m.MemberID == id
        [HttpPut("updateAll/{id}")]
        public ActionResult Put([FromBody] Member model, int id)
        {
            try
            {
                Member data = _databaseContext.Members.Find(id);
                
                if (data != null)
                {
                    data.Username = model.Username;
                    data.Password = model.Password;
                    data.Email = model.Email;

                    _databaseContext.Members.Update(data);
                    _databaseContext.SaveChanges();
                    return Ok(data);
                    
                }else
                {
                    return null;
                    
                }
                    
            }
            catch (Exception ex)
            {
                _logger.LogError("Failed to execute PUT");
                return BadRequest(ex);
            }
        }

        [HttpPatch("updatesome/{id}")]
        public ActionResult EditSome([FromBody] Member model, int id)
        {
            try
            {
                var data = _databaseContext.Members.Find(id);
                
                if (data != null)
                {
                    data.Email = model.Email;

                    _databaseContext.Members.Update(data);
                    _databaseContext.SaveChanges();
                    return Ok(data);
                    
                }else
                {
                    return NotFound();
                    
                }
                    
            }
            catch (Exception ex)
            {
                _logger.LogError("Failed to execute PUT");
                return BadRequest(ex);
            }
        }

        // del
        [HttpDelete("del/{id}")]
        public IActionResult DelData(int id)
        {
            try
            {
                Member data = _databaseContext.Members.Find(id);
                
                if (data != null)
                {
                    
                    _databaseContext.Members.Remove(data);
                    _databaseContext.SaveChanges();
                    return Ok();
                    
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError("Failed to execute DELETE");
                return BadRequest(ex);
            }
        }
    }
}