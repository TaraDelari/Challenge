using Challenge.Api.DataContracts.Out;
using Challenge.Core.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenge.Api.Controllers
{
    public class BaseController : ControllerBase
    {
        protected ActionResult CreateErrorResponse(Result result)
        {
            if (result.Succeeded)
                throw new InvalidOperationException("Cannot create error response for successful result.");
            return BadRequest(new ErrorDto { Error = result.Error });
        }
    }
}
