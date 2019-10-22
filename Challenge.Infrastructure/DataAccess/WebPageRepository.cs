using Challenge.Core.Contracts;
using Challenge.Core.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Challenge.Infrastructure.DataAccess
{
    public class WebPageRepository : IWebPageRepository
    {
        readonly ChallengeContext context;

        public WebPageRepository(ChallengeContext context)
        {
            this.context = context;
        }

        public WebPage Get(string url)
        {
            WebPage webPage = context.WebPages
                .Include(x => x.Keywords)
            .SingleOrDefault(x => x.Url == url);
            return webPage;
        }

        public void Insert(WebPage webPage)
        {
            context.WebPages.Add(webPage);
        }
    }
}
