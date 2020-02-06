using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace RestaurantManager.Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost("token")]
        public ActionResult getToken()
        {
            string securityKey = "gZME8qOzalOF91zlbaE5E0IA5DQwlPme0nNsKs0himDDJaFPmEhEsoskRh7y";

            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));

            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256Signature);

            var token = new JwtSecurityToken(
                issuer: "RestaurantManager",
                audience: "Client",
                expires: DateTime.Now.AddHours(12),
                signingCredentials: signingCredentials
                );


            return Ok(new JwtSecurityTokenHandler().WriteToken(token));
        }
    }
}