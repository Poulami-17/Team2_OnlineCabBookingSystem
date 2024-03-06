using CabApp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CabApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverAccessController : ControllerBase
    {
        //object of IDriverAccessService Dependency
        private readonly IDriverAccessService driverAccessService;

        //injecting the dependency in the constructor
        public DriverAccessController(IDriverAccessService driverAccessService)
        {
            driverAccessService = driverAccessService;
        }

        [HttpPost]
        public IActionResult Post(DriverSignInRequest request)
        {
            var claims = driverAccessService.DriverSignIn(request);

            if (claims != null)
            {
                //create and send back jwt token 
                string jwtToken = JwtTokenGenerator.GenerateToken(claims);
                return Ok(new { Token = jwtToken });
            }


            return Unauthorized();
        }
    }
}
