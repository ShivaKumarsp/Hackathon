namespace HackathonAPI.HackathonDTO
{
    public class ShiftScheduleDTO
    {
        public int StaffId { get; set; }
        public int ShiftId { get; set; }
        public string? StaffName { get; set; }
        public Array? staffList { get; set; }
        public int RoleId { get; set; }
        public string? RoleName { get; set; }
        public Array? roleList { get; set; }
        public DateTime ShiftDate { get; set; }
        public string? response { get; set; }
        public Array? scheduleList { get; set; }

    }
}
