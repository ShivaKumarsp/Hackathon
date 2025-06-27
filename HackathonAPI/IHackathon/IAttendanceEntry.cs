using HackathonAPI.HackathonDTO;
using Microsoft.AspNetCore.Mvc;

namespace HackathonAPI.IHackathon
{
    public interface IAttendanceEntry
    {
        public AttendanceEntryDTO GetData();
        public AttendanceEntryDTO SaveData(AttendanceEntryDTO dto);
    }
}
