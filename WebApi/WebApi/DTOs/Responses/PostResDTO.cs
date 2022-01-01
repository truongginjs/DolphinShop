using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WebApi.Models;

namespace WebApi.DTOs.Responses
{
    public class PostResDTO : BaseResDTO
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        public int AuthorId { get; set; }
        public User Author { get; set; }
        public int Counter { get; set; }
        public int EvaluateValue { get; set; }
        public HashSet<Tag> Tags { get; set; }
        public HashSet<User> Voters { get; set; }
        public HashSet<User> Sharers { get; set; }
        public HashSet<Comment> Comments { get; set; }
        public HashSet<Media> Media { get; set; }
    }
}