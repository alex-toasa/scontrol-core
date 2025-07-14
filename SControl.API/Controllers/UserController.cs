using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SControl.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        // Solo usuarios con rol "User"
        [HttpGet("dashboard")]
        [Authorize(Roles = "User")]
        public IActionResult GetUserDashboard()
        {
            return Ok(new { message = "Bienvenido usuario estándar." });
        }

        // Accesible para cualquier usuario autenticado
        [HttpGet("general")]
        [Authorize]
        public IActionResult GetGeneralInfo()
        {
            return Ok(new { message = "Todos los usuarios autenticados pueden acceder aquí." });
        }
    }
}
