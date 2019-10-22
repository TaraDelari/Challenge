using Challenge.Api.DataContracts.Out;
using Challenge.Core.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Security.Claims;

namespace Challenge.Api.Controllers
{
    public class BaseController : ControllerBase
    {
        protected string CurrentUserId => User.Claims.Single(x => x.Type == ClaimTypes.NameIdentifier).Value;

        protected ActionResult CreateErrorResponse(Result result)
        {
            if (result.Succeeded)
                throw new InvalidOperationException("Cannot create error response for successful result.");
            return BadRequest(new ErrorDto { Error = result.Error });
        }
    }
}
