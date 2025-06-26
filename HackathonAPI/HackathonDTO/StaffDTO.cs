using System.Numerics;

namespace HackathonAPI.HackathonDTO
{
    public class StaffDTO
    {
        public int StaffId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set;}
        public long Mobile { get; set;}
        public int RoleId { get; set;}
        public Array? roleList { get; set; }
        public Array? staffList { get; set; }
        public string? response { get; set; }
    }
}
