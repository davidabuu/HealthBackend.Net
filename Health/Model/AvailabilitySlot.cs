namespace Health.Model
{
    public class AvailabilitySlot
    {
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }

        public int? DoctorId { get; set; }

        public int? PatientId { get; set; }// Here the patient will add  his id to know who wants the appointment

        public bool Approved { get; set; }// docotr will now have to approve it 
    }
}
