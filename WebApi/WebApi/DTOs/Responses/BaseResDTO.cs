using System;

namespace WebApi.DTOs.Responses
{
    public abstract class BaseResDTO
    {
        public int Id { get; set; }
        public virtual string Description { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime UpdatedDate { get; set; }
    }
}