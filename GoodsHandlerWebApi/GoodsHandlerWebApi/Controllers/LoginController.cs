using GoodsHandlerWebApi.Interface;
using GoodsHandlerWebApi.Modells;
using Microsoft.AspNetCore.Mvc;

namespace GoodsHandlerWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : Controller
    {
        private readonly ILoginRepository _loginRepository;


        public LoginController(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;

        }
        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(401)]
        public IActionResult GetLogin([FromBody] Login accountToCheck)
        {
            var login = _loginRepository.Login(
                accountToCheck.AccountName,
                accountToCheck.Password
                );
            if(!login)
                return Unauthorized("Nem megfelelő felhasználónév vagy jelszó!");

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok();
        }

    }
}
