using Challenge.Core.Constants;
using Challenge.Core.Contracts;
using Challenge.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace Challenge.Core.Services
{
    public class LinksService
    {
        readonly IUnitOfWork uow;
        readonly UrlFormatter formater;

        public LinksService(IUnitOfWork uow, UrlFormatter formater)
        {
            this.uow = uow;
            this.formater = formater;
        }
        public Result AddLink(string originalUrl, string[] tags, string userId)
        {
            Result result = new Result();

            User user = uow.UserRepository.Get(userId);
            string formattedUrl = formater.Format(originalUrl);

            if (user.Links.Count > 0 && user.Links.Any(x => x.WebPageUrl == formattedUrl))
                result.Error = ErrorMessages.LINK_ALREADY_ADDED;
            else
            {
                // Check if we already have that web page
                WebPage webPage = this.uow.WebPageRepository.Get(formattedUrl);
                if (webPage == null)
                {
                    webPage = new WebPage(formattedUrl);
                    //TODO: Add keywords
                    this.uow.WebPageRepository.Insert(webPage);
                }
                IEnumerable<Tag> tagObjects = tags.Select(x => new Tag(x));
                Link link = new Link(webPage, user);
                link.AddTags(tagObjects);
                uow.LinkRepository.Insert(link);
                uow.SaveChanges();
            }

            return result;
        }

        public IEnumerable<Link> GetLinks(string userId)
        {
            User user = uow.UserRepository.Get(userId);
            //TODO: Check if user is null
            IEnumerable<Link> userLinks = user.Links.Where(x => x.UserId == userId);
            return userLinks;
        }

        public IEnumerable<Link> SearchLinks(string userId, string[] tags)
        {
            User user = uow.UserRepository.Get(userId);
            IEnumerable<Link> userLinks = user.Links.Where(x => x.UserId == userId);
            IEnumerable<string> tagsLower = tags.Select(x => x.ToLower());
            List<Link> result = new List<Link>();
            foreach(Link link in userLinks)
            {
                IEnumerable<string> linkTags = link.Tags.Select(x => x.Content.ToLower());
                if (ContainsAll(linkTags, tagsLower))
                    result.Add(link);
            }
            return result;
        }

        private bool ContainsAll(IEnumerable<string> original, IEnumerable<string> filter)
        {
            return !filter.Except(original).Any();
        }
    }
}
