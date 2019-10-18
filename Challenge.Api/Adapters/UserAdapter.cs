using Challenge.Api.DataContracts.Out;
using Challenge.Core.Models;

namespace Challenge.Api.Adapters
{
    static class UserAdapter
    {
        internal static UserDto ToDto(this User user)
        {
            UserDto dto = user == null ? null : new UserDto() { Id = user.Id, Email = user.Email };
            return dto;
        }
    }
}