using CabApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace CabApp.API.Controllers.AdminController
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminVehicleManageController : ControllerBase
    {
        IAdminVehicleManagerService _adminVehicleManagerService;
        public AdminVehicleManageController(IAdminVehicleManagerService adminVehicleManagerService)
        {
            this._adminVehicleManagerService = adminVehicleManagerService;
        }

        [HttpPost]
        [Authorize]
        public IActionResult AddNewVehiclePost()
        {
            NewVehicle request = JsonSerializer.Deserialize<NewVehicle>(
                                             HttpContext.Request.Form["data"]);

            if (HttpContext.Request.Form.Files.Count > 0)
            {
                request.VehiclePhoto = HttpContext.Request.Form.Files[0];
            }

            var driver = _adminVehicleManagerService.AddNewVehicles(request);

            return Ok(driver);
        }
    }
}

