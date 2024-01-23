using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Health.Model
{
    public class LabTest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? LabTestId { get; set; }
        public string? TestName { get; set; }
        public string? Description { get; set; }
        public DateTime? ResultDate { get; set; }
        public string? ResultDetails { get; set; }
    }
}
