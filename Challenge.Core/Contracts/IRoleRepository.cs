using Challenge.Core.Models;

namespace Challenge.Core.Contracts
{
    public interface IRoleRepository
    {
        Role Get(string name);
    }
}