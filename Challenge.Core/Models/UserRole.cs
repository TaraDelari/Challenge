namespace Challenge.Core.Models
{
    public class UserRole
    {
        public string UserId { get; private set; }
        public string RoleName { get; private set; }
        public User User { get; internal set; }
        public Role Role { get; internal set; }
    }
}