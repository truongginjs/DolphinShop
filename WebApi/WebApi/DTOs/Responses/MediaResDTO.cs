using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApi.Models;
using WebApi.Models.Enums;

namespace WebApi.DTOs.Responses
{
    public class MediaResDTO : BaseResDTO
    {
        [Required]
        public string Link { get; set; }
        public MediaType MediaType { get; set; }
        [Required]
        public int PostId { get; set; }
        public Post Post { get; set; }

    }
}