using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using AuthService.Shared;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace AuthService.Domain
{
    public class AuthService
    {
        private readonly IInsuranceAgents _agents;

        private readonly AppSettings _appSettings;

        public AuthService(IInsuranceAgents agents, IOptions<AppSettings> appSettings)
        {
            _agents = agents;
            _appSettings = appSettings.Value;
        }

        public string Authenticate(string login, string password)
        {
            var agent = _agents.FindByLogin(login);

            if (agent == null)
                return null;
            else if (!agent.PasswordMatches(password))
                return null;

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim("sub", agent.Login),
                    new Claim(ClaimTypes.Name, agent.Login),
                    new Claim(ClaimTypes.Role, "SALESMAN"),
                    new Claim(ClaimTypes.Role, "USER"),
                    new Claim("avatar", agent.Avatar),
                    new Claim("userType", "SALESMAN"),
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        public InsuranceAgent AgentFromLogin(string login)
        {
            return _agents.FindByLogin(login);
        }
    }
}