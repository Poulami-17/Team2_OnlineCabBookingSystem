using CabApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CabApp.API.Controllers.AdminController
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminViewCustomerController : ControllerBase
    {
        private readonly IAdminViewCustomerService _adminViewCustomerService;

        public AdminViewCustomerController(IAdminViewCustomerService adminViewCustomerService)
        {
            _adminViewCustomerService = adminViewCustomerService;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> ViewAllCustomer()
        {
            var details = await _adminViewCustomerService.ViewAllCustomerAsync();
            return Ok(details);
        }
    }
}
