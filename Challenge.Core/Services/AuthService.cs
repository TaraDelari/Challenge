using Challenge.Core.Configuration;
using Challenge.Core.Contracts;
using Challenge.Core.Models;
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

        public AuthService(IUnitOfWork uow, IHasher hasher, IOptions<JwtOptions> jwtOptionsAccessor)
        {
            this.uow = uow;
            this.hasher = hasher;
            jwtOptions = jwtOptionsAccessor.Value;
        }

        public string SignIn(string email, string password)
        {
            string passwordHash = hasher.Hash(password);
            User user = uow.UserRepository.Get().SingleOrDefault(x => x.Email == email);
            if (user != null)
            {
                bool validPassword = hasher.Verify(password, user.PasswordHash);
                if (!validPassword)
                    return "Error";
            }
            return GenerateJwtToken(user);
        }

        public int CreateUser(string email, string password)
        {
            string passwordHash = hasher.Hash(password);
            User user = new User(email, passwordHash);
            Role role = new Role("Admin", "Admin");
            user.AssignRole(role);
            uow.UserRepository.Insert(user);
            uow.SaveChanges();
            return user.Id;
        }

        private string GenerateJwtToken(User user)
        {
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            foreach (Role role in user.Roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role.Name));

            }

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtOptions.JwtKey));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            DateTime expires = DateTime.Now.AddDays(Convert.ToDouble(jwtOptions.JwtExpireDays));

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