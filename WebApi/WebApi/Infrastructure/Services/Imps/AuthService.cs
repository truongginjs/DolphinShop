using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using WebApi.DTOs.Requests.Auth;
using WebApi.DTOs.Responses;
using WebApi.DTOs.Responses.Auth;
using WebApi.Helpers.Extensions;
using WebApi.Models;

namespace WebApi.Infrastructure.Services.Imps
{
    public class AuthService : IAuthService
    {
        private readonly IConfiguration _configuration;
        private readonly DBContext _context;
        private readonly IMapper _mapper;

        public AuthService(IConfiguration configuration, DBContext context, IMapper mapper)
        {
            _configuration = configuration;
            _context = context;
            _mapper = mapper;
        }

        public async Task<UserDataResDTO> LoginAsync(UserLoginReqDTO UserForm)
        {
            var user = await _context.User.Where(u => u.Username == UserForm.Username)
                .Include(x => x.Role).FirstOrDefaultAsync();

            if (user == null)
            {
                return new UserDataResDTO { Message = "User not Found!" };
            }

            if (!UserForm.Password.VerifyPassword(UserForm.Username, user.Password))
            {
                return new UserDataResDTO { Message = "Username & Password Incorrent!" };
            }

            string token = GenerateToken(user);
            // string rfToken = GenerateRefreshToken(user);

            var userResult = _mapper.Map<UserDataResDTO>(user);
            userResult.Message = "Ok";
            userResult.Token = token;
            // userResult.RefreshToken = rfToken;

            return userResult;
        }

        public async Task<UserDataResDTO> RegisterAsync(UserRegisterReqDTO registerUser)
        {
            var user = _mapper.Map<User>(registerUser);
            user.Password = registerUser.Password.HashPassword(registerUser.Username);
            var exist = await CheckExistUser(user);
            if(exist){
                return new UserDataResDTO{ Message= "Username is Exist!"};
            }
            await _context.User.AddAsync(user);
            await _context.SaveChangesAsync();

            var userResult = _mapper.Map<User,UserDataResDTO>(user);

            string token = GenerateToken(user);
            userResult.Message = "Ok";
            userResult.Token = token;

            return userResult;
        }

        private async Task<bool> CheckExistUser(User user)
        {
            var result = await _context.User.Where(x=>x.Username==user.Username).CountAsync();
            return result > 0;
        }

        public Task<bool> LogoutAsync()
        {
           return Task.FromResult(true);
        }

        public Task<UserDataResDTO> RefreshTokenAsync(string refreshToken)
        {
           return Task.FromResult(new UserDataResDTO{Message="OK"});
        }

        private string GenerateToken(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            List<Claim> claims = GetClaims(user);
            var tokenDescriptor = NewSecurityTokenDescriptor(claims);

            var token = tokenHandler.CreateToken(tokenDescriptor);


            return tokenHandler.WriteToken(token);
        }

        private SecurityTokenDescriptor NewSecurityTokenDescriptor(List<Claim> claims)
        {
            return new SecurityTokenDescriptor
            {
                Issuer = _configuration["Jwt:Issuer"],
                Audience = _configuration["Jwt:Audience"],
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddMinutes(int.Parse(_configuration["Jwt.Expires"])),
                SigningCredentials = GetSigningCredentials()
            };
        }

        private SigningCredentials GetSigningCredentials()
        {
            var key = Encoding.ASCII.GetBytes(_configuration["Jwt:Secret"]);

            return new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature);
        }
        public List<Claim> GetClaims(User user)
        {
            var claims = new List<Claim> {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.Fullname ?? "null"),
                new Claim(ClaimTypes.Email, user.Email ?? "null"),
                new Claim(ClaimTypes.Role, user.Role.Name)
            };
            return claims;
        }
    }
}