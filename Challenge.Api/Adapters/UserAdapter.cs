using Challenge.Api.DataContracts.DTOs;
using Challenge.Core.Models;

namespace Challenge.Api.Adapters
{
    public class UserAdapter
    {
        public UserDTO ToDTO(User user)
        {
            UserDTO dto = new UserDTO() { Id = user.Id, Email = user.Email };
            return dto;
        }
    }
}