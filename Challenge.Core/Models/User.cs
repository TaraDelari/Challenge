using System;
using System.Collections.Generic;
using System.Linq;

namespace Challenge.Core.Models
{
    public class User
    {
        public string Id { get; private set; }
        public string Email { get; private set; }
        public string DisplayName { get; private set; }
        public string PasswordHash { get; private set; }
        public ICollection<Link> Links { get; private set; }
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

        private User()
        {
            Links = new List<Link>();
            UserRoles = new List<UserRole>();
        }

        public static User CreateNew(string email, string displayName, string passwordHash)
        {
            User user = new User();
            user.Id = Guid.NewGuid().ToString();
            user.Email = email;
            user.DisplayName = displayName;
            user.PasswordHash = passwordHash;
            return user;
        }

        public void AssignRole(Role role)
        {
            UserRole userRole = new UserRole { User = this, Role = role };
            if (UserRoles == null)
                UserRoles = new List<UserRole>();
            UserRoles.Add(userRole);
        }

        public override bool Equals(object obj)
        {
            var other = obj as User;

            if (ReferenceEquals(other, null))
                return false;

            if (ReferenceEquals(this, other))
                return true;

            if (other.GetType() != typeof(User))
                return false;

            if (Id == null || other.Id == null)
                return false;

            return Id == other.Id;
        }

        public static bool operator ==(User a, User b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;

            return a.Equals(b);
        }

        public static bool operator !=(User a, User b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return $"{typeof(User)}{Id}".GetHashCode();
        }
    }
}