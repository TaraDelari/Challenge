using System.Collections.Generic;
using System.Linq;

namespace Challenge.Core.Models
{
    public class User
    {
        public int Id { get; private set; }
        public string Email { get; private set; }
        public string PasswordHash { get; private set; }
        //Only used by EF
        public ICollection<UserRole> UserRoles { get; private set; }
        //Ignored by EF
        public ICollection<Role> Roles
        {
            get
            {
                return UserRoles?.Select(x => x.Role).ToList();
            }
        }

        public User(string email, string passwordHash)
        {
            Email = email;
            PasswordHash = passwordHash;
        }
    }
}