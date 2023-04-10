using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using VitrineCarrosApi.Models;

namespace VitrineCarrosApi.Authentication
{
    public static class TokenService
    {
        public const string Secret = "fedaf7d8863b48e197b9287d492b708e";
        public static string GenerateToken(Usuario usuario)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim("nome", usuario.nome),
                    new Claim("email", usuario.email),
                    // new Claim("photo", usuario.ToUrl()),
                    new Claim("id", usuario.id.ToString()),
                    // new Claim("representativeId", usuario.RepresentativeId.ToString()),
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(key),
                     SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
