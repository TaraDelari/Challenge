using System;
using System.Collections.Generic;
using Challenge.Api.Adapters;
using Challenge.Api.DataContracts.In;
using Challenge.Core.Models;
using Challenge.Core.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Challenge.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService userService;

        public UserController(UserService userService)
        {
            this.userService = userService;
        }

        // GET: api/User
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/User/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            throw new NotImplementedException();
            //return "value";
        }

        // POST: api/User
        /// <summary>
        /// Create user.
        /// </summary>
        /// <param name="userRequest">User request object</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Post([FromBody] UserRequest userRequest)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            UserAdapter adapter = new UserAdapter();
            User user = adapter.AdaptNew(userRequest);
            userService.Create(user);
            return Ok();
        }
    }
}
