using CabApp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CabApp.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverAccessController : ControllerBase
    {
        //declaring object of dependency
        private readonly IDriverAccessService _driverAccessService;

        //injecting dependency in the constructor
        public DriverAccessController(IDriverAccessService driverAccessService)
        {
            this._driverAccessService = driverAccessService;
        }

        [HttpPost("SignIn")]
        public IActionResult DriverSignInPost(DriverSignInRequest request)
        {
            var claims = _driverAccessService.DriverSignIn(request);

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