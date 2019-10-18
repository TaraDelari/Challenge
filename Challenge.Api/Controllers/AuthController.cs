using Challenge.Api.Adapters;
using Challenge.Api.DataContracts.In;
using Challenge.Api.DataContracts.Out;
using Challenge.Core.Models;
using Challenge.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Challenge.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthController : BaseController
    {

        private readonly AuthService authService;

        public AuthController(AuthService authService)
        {
            this.authService = authService;
        }

        /// <summary>
        /// User login.
        /// </summary>
        /// <param name="loginRequest">Login request object</param>
        /// <returns>Logged in user, along with access token.</returns>
        [HttpPost("login")]
        public ActionResult Login([FromBody] LoginRequest loginRequest)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            Result<LoginResult> loginResult = authService.Login(loginRequest.Email, loginRequest.Password);
            if (loginResult.Succeeded)
                return Ok(loginResult.Data.ToDto());
            else
                return CreateErrorResponse(loginResult);
        }

        /// <summary>
        /// Register user.
        /// </summary>
        /// <param name="registerRequest">Register request object</param>
        /// <returns>Newly created user.</returns>
        [HttpPost("register")]
        public ActionResult Register([FromBody] RegisterRequest registerRequest)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            Result<User> registrationResult = authService.CreateUser(registerRequest.Email, registerRequest.Password);
            if (registrationResult.Succeeded)
                return Ok(registrationResult.Data.ToDto());
            else
                return CreateErrorResponse(registrationResult);
        }
    }
}