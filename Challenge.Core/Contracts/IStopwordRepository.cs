using Challenge.Core.Models;
using System.Linq;

namespace Challenge.Core.Contracts
{
    public interface IStopwordRepository
    {
        IQueryable<Stopword> Get();
    }
}
