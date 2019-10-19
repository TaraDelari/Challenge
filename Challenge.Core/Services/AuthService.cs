using Challenge.Core.Constants;
using Challenge.Core.Contracts;
using Challenge.Core.Models;
using Challenge.Core.Options;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace Challenge.Core.Services
{
    public class AuthService
    {
        readonly IUnitOfWork uow;
        readonly IHasher hasher;
        readonly JwtOptions jwtOptions;
        readonly AccountOptions accountOptions;

        public AuthService(IUnitOfWork uow, IHasher hasher, IOptions<JwtOptions> jwtOptionsAccessor, IOptions<AccountOptions> accountOptionsAccessor)
        {
            this.uow = uow;
            this.hasher = hasher;
            this.jwtOptions = jwtOptionsAccessor.Value;
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
                    string token = GenerateJwtToken(user);
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

        private string GenerateJwtToken(User user)
        {
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            foreach (Role role in user.Roles)
                claims.Add(new Claim("roles", role.Name));

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtOptions.JwtKey));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            DateTime expires = DateTime.Now.AddMinutes(Convert.ToDouble(jwtOptions.JwtExpireMinutes));

            var token = new JwtSecurityToken(
                jwtOptions.JwtIssuer,
                jwtOptions.JwtIssuer,
                claims,
                expires: expires,
                signingCredentials: creds
                
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}