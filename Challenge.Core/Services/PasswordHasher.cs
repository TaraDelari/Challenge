using Challenge.Core.Contracts;

namespace Challenge.Core.Services
{
    public class PasswordHasher : IHasher
    {

        public string Hash(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public bool Verify(string submittedPassword, string hashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(submittedPassword, hashedPassword);
        }
    }
}
