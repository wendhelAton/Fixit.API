using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fix.API.Infrastructure.Domain.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fix.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        readonly private DefaultDbContext _context;

        public UsersController(DefaultDbContext context)
        {
            _context = context;
        }

        [HttpGet,Route("api/index")]
        public IActionResult Index()
        {
            return Ok("OK");
        }
    }
}