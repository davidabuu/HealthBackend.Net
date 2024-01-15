using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Health.Model
{
    public class Supplier
    {

        [Key]
         [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SupplierId { get; set; }
            public string? Name { get; set; }
            public string? ContactNumber { get; set; }
         
       
    }
}
