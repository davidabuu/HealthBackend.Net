
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Health.Model
{
    public class LabRadiologyOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int OrderId { get; set; }
        public PatientRegistration? Patient { get; set; }
        public DoctorRegistration? OrderingDoctor { get; set; }
        public DateTime OrderDate { get; set; }
        public List<LabTest>? OrderedTests { get; set; }
        public bool IsCompleted { get; set; }
    }
}
