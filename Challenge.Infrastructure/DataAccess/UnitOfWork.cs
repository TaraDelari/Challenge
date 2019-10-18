using Challenge.Core.Contracts;
using System;

namespace Challenge.Infrastructure.DataAccess
{
    public class UnitOfWork: IUnitOfWork
    {
        readonly ChallengeContext context;
        UserRepository userRepository;
        RoleRepository roleRepository;

        public UnitOfWork(ChallengeContext context)
        {
            this.context = context;
        }

        public IUserRepository UserRepository
        {
            get
            {
                if (userRepository == null)
                    userRepository = new UserRepository(context);
                return userRepository;
            }
        }

        public IRoleRepository RoleRepository
        {
            get
            {
                if (roleRepository == null)
                    roleRepository = new RoleRepository(context);
                return roleRepository;
            }
        }

        public void SaveChanges()
        {
            try
            {
                context.SaveChanges();

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}