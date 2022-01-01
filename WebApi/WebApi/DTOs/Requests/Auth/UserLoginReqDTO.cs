using System.ComponentModel.DataAnnotations;

namespace WebApi.DTOs.Requests.Auth
{
    public class UserLoginReqDTO
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}