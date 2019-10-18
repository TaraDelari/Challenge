using Challenge.Core.Contracts;
using Challenge.Core.Models;
using System.Linq;

namespace Challenge.Infrastructure.DataAccess
{
    public class RoleRepository : IRoleRepository
    {
        readonly ChallengeContext context;

        public RoleRepository(ChallengeContext context)
        {
            this.context = context;
        }

        public Role Get(string name)
        {
            Role role = this.context.Roles.SingleOrDefault(x => x.Name == name);
            return role;
        }
    }
}