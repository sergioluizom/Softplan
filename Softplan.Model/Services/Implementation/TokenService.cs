using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Softplan.Domain.Services.Interfaces;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace Softplan.Domain.Services.Implementation
{
    public class TokenService : ITokenService
    {
        private readonly IConfiguration configuration;
        private readonly ILogger<TokenService> logger;
        public TokenService(IConfiguration configuration, ILogger<TokenService> logger)
        {
            this.configuration = configuration;
            this.logger = logger;
        }
        public string GenerateToken()
        {
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.ASCII.GetBytes(configuration["apiToken"]);
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Expires = DateTime.UtcNow.AddHours(2),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                };
                var token = tokenHandler.CreateToken(tokenDescriptor);
                return tokenHandler.WriteToken(token);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
