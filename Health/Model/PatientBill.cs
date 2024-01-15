using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Health.Model
{
    public class PatientBill
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? BillId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime IssueDate { get; set; }
        public List<BillItem>? BillItems { get; set; }
        public decimal? TotalAmount { get; set; }
        public bool? IsPaid { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}
