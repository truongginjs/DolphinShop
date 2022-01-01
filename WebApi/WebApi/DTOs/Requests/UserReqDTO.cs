using WebApi.Models;
using WebApi.Models.Enums;

namespace WebApi.DTOs.Requests
{
    public class UserReqDTO : BaseReqDTO
    {
        // private const int V = 100;

        public string Email { get; set; }
        public string Fullname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public GenderType Gender { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}