using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Health.Model
{
    public class AttendanceEntry
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? AttendanceEntryId { get; set; }
        public DateTime? EntryTime { get; set; }
        public bool? IsPresent { get; set; }
        public int? StaffId { get; set; }
    }
}
