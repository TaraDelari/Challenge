using Challenge.Core.Constants;
using Challenge.Core.Contracts;
using Challenge.Core.Exceptions;
using System;

namespace Challenge.Infrastructure.DataAccess
{
    public class UnitOfWork: IUnitOfWork
    {
        readonly ChallengeContext context;
        UserRepository userRepository;
        RoleRepository roleRepository;
        LinkRepository linkRepository;

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

        public ILinkRepository LinkRepository
        {
            get
            {
                if (linkRepository == null)
                    linkRepository = new LinkRepository(context);
                return linkRepository;
            }
        }

        public void SaveChanges()
        {
            try
            {
                context.SaveChanges();

            }
            catch (Exception e)
            {
                throw new StorageException(ErrorMessages.STORAGE_ERROR, e);
            }
        }
    }
}