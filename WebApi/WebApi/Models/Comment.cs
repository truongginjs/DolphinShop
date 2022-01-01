using System.Collections.Generic;

namespace WebApi.Models
{
    public class Comment : BaseModel
    {
        public string Content { get; set; }
        public int CommentatorId { get; set; }
        public User Commentator { get; set; }
        public HashSet<User> Voters { get; set; }
        public HashSet<Comment> Replyments { get; set; }
        public int Postid { get; set; }
        public Post Post { get; set; }
    }
}