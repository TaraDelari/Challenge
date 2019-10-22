using Challenge.Core.Contracts;
using Challenge.Core.Models;
using Challenge.Core.Options;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Challenge.Core.Services
{
    public class JwtTokenGenerator : ITokenGenerator
    {
        readonly JwtOptions jwtOptions;
        public JwtTokenGenerator(IOptions<JwtOptions> jwtOptionsAccessor)
        {
            this.jwtOptions = jwtOptionsAccessor.Value;
        }
        public string Generate(User user)
        {
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Id),
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