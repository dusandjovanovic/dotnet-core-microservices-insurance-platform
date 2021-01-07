using AuthService.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthService.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly Domain.AuthService _authService;

        public UserController(Domain.AuthService authService)
        {
            _authService = authService;
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Post([FromBody] AuthRequest user)
        {
            var token = _authService.Authenticate(user.Login, user.Password);

            if (token == null)
                return BadRequest(new {message = "Username or password incorrect."});
            return Ok(new {Token = token});
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_authService.AgentFromLogin(HttpContext.User.Identity.Name));
        }
    }
}