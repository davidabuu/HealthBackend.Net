using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Health.Model
{
    public class InventoryItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CurrentStock { get; set; }
        public int ReorderLevel { get; set; }
        public Supplier Supplier { get; set; }
        public List<OrderHistoryEntry> OrderHistory { get; set; }
    }
}
