using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Challenge.Api.Adapters;
using Challenge.Api.DataContracts.In;
using Challenge.Core.Models;
using Challenge.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Challenge.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private readonly AuthService authService;

        public AuthController(AuthService userService)
        {
            this.authService = userService;
        }

        /// <summary>
        /// User login.
        /// </summary>
        /// <param name="loginRequest">Login request object</param>
        /// <returns></returns>
        [HttpPost("login")]
        public ActionResult Login([FromBody] LoginRequest loginRequest)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            string result = authService.SignIn(loginRequest.Email, loginRequest.Password);
            return Ok(result);
        }

        /// <summary>
        /// Register user.
        /// </summary>
        /// <param name="registerRequest">Register request object</param>
        /// <returns></returns>
        [HttpPost("register")]
        public ActionResult Register([FromBody] RegisterRequest registerRequest)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            authService.CreateUser(registerRequest.Email, registerRequest.Password);
            return Ok();
        }
    }
}