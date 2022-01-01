using Microsoft.EntityFrameworkCore;

namespace WebApi.DTOs.Responses
{
    public class RoleResDTO : BaseResDTO
    {
        public string Name { get; set; }
    }
}