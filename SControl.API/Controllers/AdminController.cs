using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SControl.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdminController : ControllerBase
    {
        // Solo accesible por usuarios con rol "Admin"
        [HttpGet("dashboard")]
        [Authorize(Roles = "Admin")]
        public IActionResult GetAdminData()
        {
            return Ok(new { message = "Solo los administradores pueden ver esto." });
        }

        // Accesible por cualquier usuario autenticado (no anónimo)
        [HttpGet("general")]
        [Authorize]
        public IActionResult GetGeneralData()
        {
            return Ok(new { message = "Cualquier usuario autenticado puede ver esto." });
        }
    }
}
