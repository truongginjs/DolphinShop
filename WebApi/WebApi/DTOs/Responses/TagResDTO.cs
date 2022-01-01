using System.Collections.Generic;
using WebApi.Models;

namespace WebApi.DTOs.Responses
{
    public class TagResDTO : BaseResDTO
    {
        public string Name { get; set; }
        public string Descriptions { get; set; }
        public HashSet<User> InterestingMember { get; set; }
        public HashSet<Post> Posts { get; set; }
    }
}