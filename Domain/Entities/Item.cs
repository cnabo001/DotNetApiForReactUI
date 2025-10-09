
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Item : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        [Column(TypeName ="decimal(18,2)")]
        public decimal Price { get; set; }
        public bool IsActive { get; set; }

    }
}
