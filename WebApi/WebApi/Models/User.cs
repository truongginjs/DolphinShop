using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using WebApi.Models.Enums;

namespace WebApi.Models
{
    [Index(nameof(Email), nameof(Username), nameof(PhoneNumber))]
    public class User : BaseModel
    {
        [StringLength(100)]
        public string Email { get; set; }
        [StringLength(100)]
        public string Fullname { get; set; }
        [StringLength(100)]
        public string Username { get; set; }
        [StringLength(200)]
        public string Password { get; set; }
        [StringLength(20)]
        public string PhoneNumber { get; set; }
        [Column(TypeName = "nvarchar(24)")]
        public GenderType Gender { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}