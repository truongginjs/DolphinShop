using System.Collections.Generic;
using WebApi.Models;

namespace WebApi.DTOs.Requests
{
    public class TagReqDTO : BaseReqDTO
    {
        public string Name { get; set; }
        public string Descriptions { get; set; }
        public HashSet<User> InterestingMember { get; set; }
        public HashSet<Post> Posts { get; set; }
    }
}