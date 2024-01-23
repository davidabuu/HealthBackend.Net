using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Health.Model
{
    public class MedicalHistoryEntry
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? MedicalHistoryEntryId { get; set; }
        public DateTime? DateTimeNow { get; set; }
        public string? TypeOfIllness { get; set; }
        public string? Description { get; set; }
        public int PatientId { get; set; }
    }

}
