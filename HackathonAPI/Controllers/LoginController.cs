using HackathonAPI.HackathonDTO;
using HackathonAPI.IHackathon;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HackathonAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        ILogin _login;
        public LoginController(ILogin login)
        {
            _login = login;
        }

        [Route("login")]
        public LoginDTO Login(LoginDTO dto)
        {
            return _login.Login(dto);
        }
    }
}
