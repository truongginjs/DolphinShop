using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    public abstract class BaseModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(255)]
        public virtual string Description { get; set; }
        public virtual bool IsDeleted { get; set; } = false;
        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime UpdatedDate { get; set; }
        public virtual int UserCreateId { get; set; }
        [NotMapped]
        public User UserCreate { get; set; }
        public virtual int UserUpdateId { get; set; }
        [NotMapped]
        public User UserUpdate { get; set; }

    }
}