using HackathonAPI.HackathonDTO;
using HackathonAPI.IHackathon;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Contracts;

namespace HackathonAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        public IStaff _staff;
        public StaffController(IStaff staff)
        {
            _staff = staff;
        }

        [Route("getData")]
        public StaffDTO GetData()
        {
            return _staff.GetData();
        }

        [Route("saveData")]
        public StaffDTO SaveData([FromBody]StaffDTO dto)
        {
            return _staff.SaveData(dto);
        }

    }
}
