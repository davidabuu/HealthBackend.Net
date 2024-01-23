using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Health.Model
{
    public class DoctorRegistration
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DoctorId { get; set; }
        
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Specialization { get; set; }
        public string? ContactNumber { get; set; }
        public string? Email { get; set; }
        public string? Department { get; set; }
        public byte[]? Image { get; set; }
        public List<AvailabilitySlot>? Availability { get; set; }
    }
}
