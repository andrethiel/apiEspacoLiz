using apiEspacoLiz.Models;
using apiEspacoLiz.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace apiEspacoLiz.Controllers
{
    [Route("v1/Agenda")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpPost]
        [Route("User")]
        public async Task<IActionResult> agendaHorario([FromBody] Users user)
        {
            var response = _userRepository.Login(user);

            if(response == null)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

    }
}
