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
            try
            {
                var claims = this.driverAccessService.DriverSignIn(request);
                //jwt
                return Ok();
            }
            catch (Exception ex)
            {
                return Unauthorized();
            }
        }
    }
}
