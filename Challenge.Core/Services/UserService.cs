using Challenge.Core.Contracts;
using Challenge.Core.Models;

namespace Challenge.Core.Services
{
    public class UserService
    {
        readonly IUnitOfWork uow;

        public UserService(IUnitOfWork uow)
        {
            this.uow = uow;
        }

        public int Create(User user)
        {
            uow.UserRepository.Insert(user);
            uow.SaveChanges();
            return user.Id;
        }
    }
}