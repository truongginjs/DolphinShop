using System;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    [Obsolete]
    public class RefreshTokenTable
    {
        [Key]
        public string RefreshToken { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}