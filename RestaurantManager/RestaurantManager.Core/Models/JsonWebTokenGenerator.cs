using Microsoft.IdentityModel.Tokens;
using RestaurantManager.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Core.Models
{
    public class JsonWebTokenGenerator : ITokenProvider
    {
        string securityKey;
        public JsonWebTokenGenerator(string securityKey)
        {
            this.securityKey = securityKey;
        }
        public string GenerateToken(int minutesToExpire)
        {
            //string securityKey = "gZME8qOzalOF91zlbaE5E0IA5DQwlPme0nNsKs0himDDJaFPmEhEsoskRh7y";

            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));

            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256Signature);

            var token = new JwtSecurityToken(
                issuer: "RestaurantManager",
                audience: "Client",
                expires: DateTime.Now.AddMinutes(minutesToExpire),
                signingCredentials: signingCredentials
                );


            return (new JwtSecurityTokenHandler().WriteToken(token));
        }
    }
}
