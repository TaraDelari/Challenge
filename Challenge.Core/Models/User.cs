namespace Challenge.Core.Models
{
    public class User
    {
        public int Id { get; private set; }
        public string Email { get; private set; }
        public string PasswordHash { get; private set; }

        public User(string email, string passwordHash)
        {
            Email = email;
            PasswordHash = passwordHash;
        }
    }
}