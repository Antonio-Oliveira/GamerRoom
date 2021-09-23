using GamerRoom.API.Dtos.InputModel;
using GamerRoom.API.Entities;
using GamerRoom.API.Service.Interfaces;
using GamerRoom.API.Token;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerRoom.API.Service
{
    public class UserService : IUserService
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly TokenSettings _tokenSettings;

        public UserService(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager, IOptions<TokenSettings> tokenSettings)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _tokenSettings = tokenSettings.Value;
        }

        public async Task<string> GerarToken(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);

            if (user == null)
                throw new Exception("Email inválido");

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_tokenSettings.Secret);

            var tokenDescripter = new SecurityTokenDescriptor
            {
                Issuer = _tokenSettings.Emissor,
                Audience = _tokenSettings.ValidoEm,
                Expires = DateTime.UtcNow.AddHours(_tokenSettings.ExpiracaoHoras),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            return tokenHandler.WriteToken(tokenHandler.CreateToken(tokenDescripter));
        }

        public async Task Login(LoginInputModel loginIM)
        {
            var user = await _userManager.FindByEmailAsync(loginIM.Email);

            if (user == null)
                throw new Exception("Email ou Senha incorreto");

            var result = await _signInManager.PasswordSignInAsync(user, loginIM.Password, false, false);

            if (!result.Succeeded)
                throw new Exception("Email ou Senha incorreto");

        }

        public async Task Register(RegisterInputModel registerIM)
        {
            var user = new ApplicationUser()
            {
                Email = registerIM.Email,
                UserName = registerIM.UserName
            };

            var result = await _userManager.CreateAsync(user, registerIM.Password);

            if (!result.Succeeded)
            {
                Console.WriteLine(result.Errors);
                throw new Exception("Erro no cadastro do usuário");
            }

            await _signInManager.SignInAsync(user, false);
        }
    }
}
