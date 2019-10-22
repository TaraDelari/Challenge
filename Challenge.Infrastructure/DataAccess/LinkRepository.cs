using Challenge.Core.Contracts;
using Challenge.Core.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Challenge.Infrastructure.DataAccess
{
    class LinkRepository : ILinkRepository
    {
        readonly ChallengeContext context;

        public LinkRepository(ChallengeContext context)
        {
            this.context = context;
        }

        public Link Get(string url, string userId)
        {
            Link link = context.Links
                .Include(x => x.User)
            .SingleOrDefault(x => x.Url == url);
            return link;
        }

        public IQueryable<Link> Get()
        {
            return context.Links.Include(x => x.Tags).Include(k => k.Keywords);
        }

        public void Insert(Link link)
        {
            context.Links.Add(link);
        }
    }
}