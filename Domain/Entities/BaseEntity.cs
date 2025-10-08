
namespace Domain.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        //audit purposes
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; } = DateTime.Now;
        public string? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }

        //concurrency operation
        public string ConcurrencyStamp { get; set; } = Guid.NewGuid().ToString("N");
    }
}
