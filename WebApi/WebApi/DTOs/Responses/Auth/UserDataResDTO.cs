using System;

namespace WebApi.DTOs.Responses.Auth
{
    public class UserDataResDTO
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public string Message { get; set; }
        public int Exp { get; set; }
        public string Token { get; set; }
        public string RefreshToken { get; set; }
        public string Role { get; set; }
    }
}