using CabApp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CabApp.API.Controllers.Admin
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminLoginController : ControllerBase
    {
        private readonly IAdminAccessService adminAccessService;

        public AdminLoginController(IAdminAccessService adminAccessService)
        {
            this. adminAccessService = adminAccessService;
        }

        [HttpPost]
        public IActionResult Post(AdminSignInRequest request)
        {
            try
            {
                var claims = this.adminAccessService.AdminSignIn(request);
                return Ok();
            }
            catch (Exception ex)
            {
                return Unauthorized();
            }

        }
    }
}
