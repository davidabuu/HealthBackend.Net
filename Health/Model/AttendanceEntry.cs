namespace Health.Model
{
    public class AttendanceEntry
    {
        public int AttendanceEntryId { get; set; }
        public DateTime EntryTime { get; set; }
        public bool IsPresent { get; set; }
        public int StaffId { get; set; }
    }
}
