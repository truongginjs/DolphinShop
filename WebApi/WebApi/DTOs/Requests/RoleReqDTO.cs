using Microsoft.EntityFrameworkCore;

namespace WebApi.DTOs.Requests
{
    public class RoleReqDTO : BaseReqDTO
    {
        public string Name { get; set; }
    }
}