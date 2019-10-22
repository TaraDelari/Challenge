using Challenge.Core.Contracts;
using Challenge.Core.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Challenge.Infrastructure.DataAccess
{
    public class UserRepository : IUserRepository
    {
        readonly ChallengeContext context;

        public UserRepository(ChallengeContext context)
        {
            this.context = context;
        }

        public User Get(string id)
        {
            User user = context.Users
                .Include(x => x.Links)
                    .ThenInclude(x => x.Tags)
                .Include(x => x.UserRoles)
                    .ThenInclude(x => x.Role)
                .SingleOrDefault(x => x.Id == id);
            return user;
        }

        public IQueryable<User> Get()
        {
            return context.Users.Include(x => x.UserRoles).ThenInclude(x => x.Role);
        }

        public void Insert(User user)
        {
            context.Users.Add(user);
        }

        public void Delete(string id)
        {
            User user = context.Users.SingleOrDefault(x => x.Id == id);
            context.Remove(user);
        }
    }
}