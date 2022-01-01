using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class Post : BaseModel
    {
        [Required]
        [StringLength(200)]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        public int AuthorId { get; set; }
        public User Author { get; set; }
        public int Counter { get; set; }
        public int EvaluateValue { get; set; }
        public HashSet<Tag> Tags { get; set; }
        public ICollection<Voter> Voters { get; set; }
        public ICollection<Sharer> Sharers { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Media> Media { get; set; }
    }
}