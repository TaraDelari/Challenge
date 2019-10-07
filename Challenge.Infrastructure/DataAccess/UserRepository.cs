using Challenge.Core.Contracts;
using Challenge.Core.Models;
using System;
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

        public User Get(int id, bool includeRelated = true)
        {
            IQueryable<User> userSource = context.Users;
            if (includeRelated)
                userSource = IncludeRelated(userSource);
            User user = userSource.SingleOrDefault(x => x.Id == id);
            return user;
        }

        public IQueryable<User> Get(bool includeRelated = true)
        {
            IQueryable<User> userSource = context.Users;
            if (includeRelated)
                userSource = IncludeRelated(userSource);
            return userSource;
        }

        public void Insert(User user)
        {
            context.Users.Add(user);
        }

        public void Delete(int id)
        {
            User user = context.Users.SingleOrDefault(x => x.Id == id);
            context.Remove(user);
        }

        private IQueryable<User> IncludeRelated(IQueryable<User> usersSource)
        {
            throw new NotImplementedException();
            //return usersSource.Include(x => x.FirstThingToInclude).Include(x => x.SecondToInclude);
        }
    }
}