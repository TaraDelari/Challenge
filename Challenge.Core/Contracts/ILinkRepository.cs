using Challenge.Core.Models;
using System.Linq;

namespace Challenge.Core.Contracts
{
    public interface ILinkRepository
    {
        Link Get(string url, string userId);
        IQueryable<Link> Get();
        void Insert(Link link);
    }
}