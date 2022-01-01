using System.ComponentModel.DataAnnotations;
using WebApi.Models;
using WebApi.Models.Enums;

namespace WebApi.DTOs.Requests.Auth
{
    public class UserRegisterReqDTO
    {
        // private const int V = 100;
        [Required]
        public string Email { get; set; }
        [Required]
        public string Fullname { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        [Required]
        public GenderType Gender { get; set; }
        [Required]
        public int RoleId { get; set; }
    }
}