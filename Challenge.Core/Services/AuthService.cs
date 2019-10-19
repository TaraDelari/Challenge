using Challenge.Core.Constants;
using Challenge.Core.Contracts;
using Challenge.Core.Models;
using Challenge.Core.Options;
using Microsoft.Extensions.Options;
using System.Linq;

namespace Challenge.Core.Services
{
    public class AuthService
    {
        readonly IUnitOfWork uow;
        readonly IHasher hasher;
        readonly ITokenGenerator tokenGenerator;
        readonly AccountOptions accountOptions;

        public AuthService(IUnitOfWork uow, IHasher hasher, ITokenGenerator tokenGenerator, IOptions<AccountOptions> accountOptionsAccessor)
        {
            this.uow = uow;
            this.hasher = hasher;
            this.tokenGenerator = tokenGenerator;
            this.accountOptions = accountOptionsAccessor.Value;
        }

        public Result<LoginResult> Login(string email, string password)
        {
            Result<LoginResult> result = new Result<LoginResult>();

            User user = uow.UserRepository.Get().SingleOrDefault(x => x.Email == email);
            if (user == null)
                result.Error = ErrorMessages.INVALID_CREDENTIALS;
            else
            {
                bool validPassword = hasher.Verify(password, user.PasswordHash);
                if (validPassword)
                {
                    string token = tokenGenerator.Generate(user);
                    result.Data = new LoginResult(user, token);
                }
                else
                    result.Error = ErrorMessages.INVALID_CREDENTIALS;
            }

            return result;
        }

        public Result<User> CreateUser(string email, string password)
        {
            Result<User> result = new Result<User>();

            User existingUser = uow.UserRepository.Get().SingleOrDefault(x => x.Email == email);
            if (existingUser == null)
            {
                string passwordHash = hasher.Hash(password);
                User user = new User(email, passwordHash);
                Role role = uow.RoleRepository.Get(accountOptions.DefaultRole);
                user.AssignRole(role);
                uow.UserRepository.Insert(user);
                uow.SaveChanges();
                result.Data = user;
            }
            else
                result.Error = ErrorMessages.EMAIL_USED;

            return result;
        }
    }
}