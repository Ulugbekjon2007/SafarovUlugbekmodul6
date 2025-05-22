using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;

namespace UserContacts.Bll.Helpers
{
    internal class JwtSecurityTokenHandler
    {
        public JwtSecurityTokenHandler()
        {
        }

        internal ClaimsPrincipal? ValidateToken(string token, TokenValidationParameters tokenValidationParameters, out object _)
        {
            throw new NotImplementedException();
        }

        internal string WriteToken(JwtSecurityToken token)
        {
            throw new NotImplementedException();
        }
    }
}