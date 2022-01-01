using Microsoft.EntityFrameworkCore;

namespace WebApi.Models
{
    [Index(nameof(Name))]
    public class Role : BaseModel
    {
        public string Name { get; set; }
    }
}