using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using WebApi.DTOs.Responses;
using WebApi.Models.Enums;

namespace WebApi.Models
{
    public class UserResDTO : BaseResDTO
    {

        public string Email { get; set; }
        public string Fullname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Message { get; set; }
        public string PhoneNumber { get; set; }
        public GenderType Gender { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}