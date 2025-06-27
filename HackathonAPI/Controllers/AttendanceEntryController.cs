using HackathonAPI.HackathonDTO;
using HackathonAPI.IHackathon;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HackathonAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendanceEntryController : ControllerBase
    {
        IAttendanceEntry _att;
        public AttendanceEntryController(IAttendanceEntry att)
        {
            _att = att;
        }
        [Route("getData")]
        public AttendanceEntryDTO GetData()
        {
            return _att.GetData();
        }

        [Route("saveData")]
        public AttendanceEntryDTO SaveData([FromBody] AttendanceEntryDTO dto)
        {
            return _att.SaveData(dto);
        }
    }
}
