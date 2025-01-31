﻿using Challenge.Api.DataContracts.Out;
using Challenge.Core.Models;
using System.Linq;

namespace Challenge.Api.Adapters
{
    static class LinkAdapter
    {
        internal static LinkDto ToDto(this Link link)
        {
            return link == null ? null : new LinkDto
            {
                Link = link.WebPage.Url,
                Tags = link.Tags.Select(x => x.Content).ToList()
            };
        }
    }
}
