using System.Linq;
using Challenge.Core.Contracts;
using Challenge.Core.Models;

namespace Challenge.Infrastructure.DataAccess
{
    class StopwordRepository : IStopwordRepository
    {
        readonly ChallengeContext context;

        public StopwordRepository(ChallengeContext context)
        {
            this.context = context;
        }
        public IQueryable<Stopword> Get()
        {
            return context.Stopwords;

        }
    }
}