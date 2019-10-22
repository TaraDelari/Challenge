using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Challenge.Api.Adapters;
using Challenge.Api.DataContracts.In;
using Challenge.Api.DataContracts.Out;
using Challenge.Core.Models;
using Challenge.Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Challenge.Api.Controllers
{
    [Authorize]
    [Route("[controller]")]
    [ApiController]
    public class LinksController : BaseController
    {
        private readonly LinksService linksService;

        public LinksController(LinksService linksService)
        {
            this.linksService = linksService;
        }

        /// <summary>
        /// Creates new link with specified tags.
        /// </summary>
        /// <param name="linkRequest">Link request object</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Post([FromBody] LinkRequest linkRequest)
        {
            Result result = linksService.AddLink(linkRequest.Link, linkRequest.Tags, CurrentUserId);
            if (result.Succeeded)
                return Ok();
            else
                return CreateErrorResponse(result);
        }

        /// <summary>
        /// Gets user links.
        /// </summary>
        /// <returns>User links along with tags</returns>
        [HttpGet]
        public ActionResult Get()
        {
            IEnumerable<Link> links = linksService.GetLinks(CurrentUserId);
            IEnumerable<LinkDto> linkDtos = links.Select(x => x.ToDto());
            return Ok(linkDtos);
        }

        /// <summary>
        /// Gets links for user by tags.
        /// </summary>
        /// <param name="searchRequest">Search request containing parameters.</param>
        /// <returns>Links containing given parameters.</returns>
        [HttpPost("search")]
        public ActionResult Search([FromBody] SearchRequest searchRequest)
        {
            IEnumerable<Link> links = linksService.SearchLinks(CurrentUserId, searchRequest.Tags);
            IEnumerable<LinkDto> linkDtos = links.Select(x => x.ToDto());
            return Ok(linkDtos);
        }

        /// <summary>
        /// Get suggested tags for existing link, based on the link content.
        /// </summary>
        /// <param name="linkUrl">Link URL.</param>
        /// <returns>Suggested tags.</returns>
        [HttpGet("tags-content-suggestions")]
        public ActionResult GetSuggestedTags(string linkUrl)
        {
            IEnumerable<string> tags = linksService.GetSuggestedTags(CurrentUserId, linkUrl);
            return Ok(tags);
        }
    }
}
