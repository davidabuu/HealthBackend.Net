namespace Health.Model
{
    public class MedicalHistoryEntry
    {
        public DateTime? DateTime { get; set; }
        public string? TypeOfIllness { get; set; }
        public string? Description { get; set; }
        public int PatientId { get; set; }
    }

}
