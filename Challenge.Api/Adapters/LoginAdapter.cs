using Challenge.Api.DataContracts.Out;
using Challenge.Core.Models;

namespace Challenge.Api.Adapters
{
    static class LoginAdapter
    {
        internal static LoginDto ToDto(this LoginResult loginResult)
        {
            return loginResult == null ? null : new LoginDto
            {
                User = loginResult.User.ToDto(),
                Token = loginResult.Token
            };
        }
    }
}
