using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Health.Model
{
    public class BillItem
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? BillItemId { get; set; }
        public string? Description { get; set; }
        public decimal? Amount { get; set; }
    
}
}
