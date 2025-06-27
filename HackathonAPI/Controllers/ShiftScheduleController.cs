using HackathonAPI.HackathonDTO;
using HackathonAPI.IHackathon;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HackathonAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShiftScheduleController : ControllerBase
    {
        public IShiftSchedule _sfiftSchedule;
        public ShiftScheduleController(IShiftSchedule sfiftSchedule)
        {
            _sfiftSchedule = sfiftSchedule;
        }

        [Route("getroleList")]
        public ShiftScheduleDTO getroleList()
        {
            return _sfiftSchedule.getroleList();
        }

        [Route("getStaffList/{id:int}")]
        public ShiftScheduleDTO getStaffList(int id)
        {
            return _sfiftSchedule.getStaffList(id);
        }

        [Route("saveData")]
        public ShiftScheduleDTO SaveData(ShiftScheduleDTO dto)
        {
            return _sfiftSchedule.SaveData(dto);
        }
        
    }
}
