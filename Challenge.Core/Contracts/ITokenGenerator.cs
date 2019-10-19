using Challenge.Core.Models;

namespace Challenge.Core.Contracts
{
    public interface ITokenGenerator
    {
        string Generate(User user);
    }
}