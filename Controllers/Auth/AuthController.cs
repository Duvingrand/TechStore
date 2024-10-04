using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechStore.Models;

namespace TechStore.Controllers.Auth
{
    [ApiController]
    [Route("api/v1/auth")]
    public class AuthController : ControllerBase
    {
        //metodo que genera JWT
        [HttpGet("token")]
        public async Task<IActionResult> GenerateJWTToken(User user){
            return Ok("Token");
        }
    }
}