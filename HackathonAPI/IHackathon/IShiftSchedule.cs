using HackathonAPI.HackathonDTO;

namespace HackathonAPI.IHackathon
{
    public interface IShiftSchedule
    {
        public ShiftScheduleDTO getroleList();
        public ShiftScheduleDTO getStaffList(int id);
        public ShiftScheduleDTO SaveData(ShiftScheduleDTO dto);
    }
}
