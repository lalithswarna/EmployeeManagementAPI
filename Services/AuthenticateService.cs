using EmployeeManagementAPI.Models;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementAPI.Services
{
    public class AuthenticateService : IAuthenticateService
    {
        public readonly AppSettings _appSettings;
        private readonly AppDBContext _appDbContext;
        public AuthenticateService(IOptions<AppSettings> appsettings, AppDBContext appDBContext)
        {
            _appSettings = appsettings.Value;
            _appDbContext = appDBContext;
        }

        public User Authenticate(string username, string password)
        {
            var user = _appDbContext.Users
              .FirstOrDefault(e => e.UserName.ToLower() == username.ToLower() && e.Password == password);

            if (user == null)
            {
                return null;
            }

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.SecretKey);
            var tokenDescriptor = new Microsoft.IdentityModel.Tokens.SecurityTokenDescriptor
            {
                Subject = new System.Security.Claims.ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.UserName.ToString()),
                    new Claim(ClaimTypes.Role, "Admin")
                }),
                Expires = DateTime.UtcNow.AddMinutes(15),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)

             };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            user.Token = tokenHandler.WriteToken(token);
            user.Password = null;
            return user;
        }
    }
}
