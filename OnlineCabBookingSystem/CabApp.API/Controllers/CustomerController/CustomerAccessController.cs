using CabApp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CabApp.API.Controllers.CustomerController
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerAccessController : ControllerBase
    {
        private readonly ICustomerAccessService customerAccessService;

        //injecting dependency in the constructor
        public CustomerAccessController(ICustomerAccessService customerAccessService)
        {
            this.customerAccessService = customerAccessService;
        }

        [HttpPost("SignIn")]
        public IActionResult CustomerSignIn(CustomerSignInRequest request)
        {
            var claims = customerAccessService.CustomerSignIn(request);

            if (claims != null)
            {
                //create and send back jwt token 
                string jwtToken = JwtTokenGenerator.GenerateToken(claims);
                return Ok(new { Token = jwtToken });
            }


            return Unauthorized();
        }

        [HttpPost("SignUp")]
        public IActionResult CustomerSignUp(CustomerSignUprequest request)
        {
            try
            {
                var customer = customerAccessService.CustomerSignUp(request);
                // Here you can return any additional data or success status as needed
                return Ok(customer);
            }
            catch (DuplicateEmailException ex)
            {
                return Conflict(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

    }
}
