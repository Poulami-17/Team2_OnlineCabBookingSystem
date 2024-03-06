using CabApp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CabApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminAccessController : ControllerBase
    {
        //decclaring object of dependency
        private readonly IAdminAccessService _adminAccessService;

       //injecting dependency in the constructor
        public AdminAccessController(IAdminAccessService adminAccessService)
        {
            this._adminAccessService = adminAccessService;
        }

        [HttpPost]
        public IActionResult AdminSignInPost(AdminSignInRequest request)
        {
             
            var claims = _adminAccessService.AdminSignIn(request);
            if(claims != null)
            {
                string jwtToken = JwtTokenGenerator.GenerateToken(claims);
                return Ok(new {Token =  jwtToken});
            }

            return Unauthorized();
        }
    }
}
