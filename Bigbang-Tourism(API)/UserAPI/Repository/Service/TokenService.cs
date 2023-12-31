﻿using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using UserAPI.DTO;
using UserAPI.Interface;

namespace UserAPI.Repository.Service
{
    public class TokenService : ITokenGenerate
    {
        private readonly SymmetricSecurityKey _key;

        /// <summary>
        /// This method is used to inject the dependencies
        /// </summary>
        /// <param name="configuration"></param>
        public TokenService(IConfiguration configuration)
        {
            _key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["TokenKey"]));
        }

        /// <summary>
        /// This method is used to generate a token
        /// </summary>
        /// <param name="user"></param>
        /// <returns>string</returns>
        public string GenerateToken(UserDTO user)
        {
            string token = string.Empty;
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Name, user.User_Id),
                new Claim(ClaimTypes.Role, user.Role.ToString()), // Convert UserRole to string representation
            };
            var cred = new SigningCredentials(_key, SecurityAlgorithms.HmacSha256);
            var tokenDescription = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(3),
                SigningCredentials = cred
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var myToken = tokenHandler.CreateToken(tokenDescription);
            token = tokenHandler.WriteToken(myToken);
            return token;
        }
    }
}
