namespace HackathonAPI.HackathonDTO
{
    public class AttendanceEntryDTO
    {
        public int StaffId { get; set; }
        public int StaffAttendanceId { get; set; }
        public DateTime ShiftDate { get; set; }
        public TimeSpan CheckInTime { get; set; }
        public TimeSpan CheckOutTime { get; set; }
        public string? Status { get; set; }
        public string? Description { get; set; }
        public string? StaffName { get; set; }
        public string? response { get; set; }
        public Array? attendanceList { get; set; }
        public Array? staffList { get; set; }
    }
}
