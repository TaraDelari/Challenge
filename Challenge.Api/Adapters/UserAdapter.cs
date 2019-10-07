using Challenge.Api.DataContracts.DTOs;
using Challenge.Api.DataContracts.In;
using Challenge.Core.Models;

namespace Challenge.Api.Adapters
{
    public class UserAdapter
    {
        public User AdaptNew(UserRequest userRequest)
        {

            User user = new User(userRequest.FirstName, userRequest.LastName);
            return user;
        }

        public UserDTO ToDTO(User user)
        {
            UserDTO dto = new UserDTO() { Id = user.Id, FirstName = user.FirstName, LastName = user.LastName };
            return dto;
        }
    }
}