using CabApp.Entities;
using CabApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace CabApp.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminManageDriverController : ControllerBase
    {
        
        IAdminManageDriverService _adminManageDriverService;

        public AdminManageDriverController(IAdminManageDriverService adminManageDriverService)
        {
            this._adminManageDriverService = adminManageDriverService;
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddNewDriverPost()
        {
            NewDriver request = JsonSerializer.Deserialize<NewDriver>(
                                             HttpContext.Request.Form["data"]);

            if (HttpContext.Request.Form.Files.Count > 0)
            {
                request.DriverPhoto = HttpContext.Request.Form.Files["driverphoto"];
                request.LicenceCertificatePdf = HttpContext.Request.Form.Files["licenceCertificatePdf"];

            }

            var driver = await _adminManageDriverService.AddNewDrivers(request);

            return Ok(driver);
        }
    }
}
