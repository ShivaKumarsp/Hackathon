using HackathonAPI.HackathonDTO;

namespace HackathonAPI.IHackathon
{
    public interface IStaff
    {
        public StaffDTO GetData();
        public StaffDTO SaveData(StaffDTO dto);
        public StaffDTO GetDashboardData();
    }
}
