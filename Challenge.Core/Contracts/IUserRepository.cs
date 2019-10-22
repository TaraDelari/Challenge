using Challenge.Core.Models;
using System.Linq;

namespace Challenge.Core.Contracts
{
    public interface IUserRepository
    {
        User Get(string id);
        IQueryable<User> Get();
        void Insert(User user);
        void Delete(string id);
    }
}