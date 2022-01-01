using System.Collections.Generic;

namespace WebApi.Models
{
    public class Tag : BaseModel
    {
        public string Name { get; set; }
        public string Descriptions { get; set; }
        public HashSet<User> InterestingMember { get; set; }
        public HashSet<Post> Posts { get; set; }
    }
}