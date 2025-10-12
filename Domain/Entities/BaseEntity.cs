
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        public Guid Id { get; set; } = new Guid();

        //audit purposes
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; } = DateTime.Now;
        public string? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }

        //concurrency operation
        public string ConcurrencyStamp { get; set; } = Guid.NewGuid().ToString("N");
    }
}
