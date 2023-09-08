using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AzCelebrates.Models;
using Microsoft.AspNetCore.Mvc;

namespace AzCelebrates.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class HomeController : ControllerBase
    {

        [HttpGet("{id}")]
        public ActionResult<User> GetUser(int id)
        {
            var user = new User
            {
                Id = id,
                Username = "Test",
                Email = "Test"

            };

            return Ok(user);
        }
    }
}