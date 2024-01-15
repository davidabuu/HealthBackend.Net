using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Health.Model
{

    public enum StaffRole
    {
        Administrator,
        Doctor,
        Nurse,
        Receptionist,
        // Add more roles as needed
    }
    public class StaffManagment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StaffId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? ContactNumber { get; set; }
        public string? Email { get; set; }
        public StaffRole Role { get; set; }
        public byte[]? Image { get; set; }

        public List<AttendanceEntry>? Attendance { get; set; }
    }
}
