using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Health.Model
{
    public class OrderHistory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? OrderHistoryId { get; set; }
        public DateTime? OrderDate { get; set; }
        public int? QuantityOrdered { get; set; }
        public int? Price { get; set; }
    }
}
