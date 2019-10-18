using Challenge.Core.Models;
using System.Linq;

namespace Challenge.Core.Contracts
{
    public interface IUserRepository
    {
        User Get(int id);
        IQueryable<User> Get();
        void Insert(User user);
        void Delete(int id);
    }
}