using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApi.Models.Enums;

namespace WebApi.Models
{
    public class Media : BaseModel
    {
        [Required]
        [StringLength(200)]
        public string Link { get; set; }
        [Column(TypeName = "nvarchar(24)")]
        public MediaType MediaType { get; set; }
        [Required]
        public int PostId { get; set; }
        public Post Post { get; set; }

    }
}