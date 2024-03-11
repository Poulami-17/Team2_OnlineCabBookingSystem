using CabApp.Entities;
using CabApp.Services;
using CabApp.Services.Admin;
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



        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> ModifyDriverPut(ModifyDriver driver)
        {
            var modifydriver = await _adminManageDriverService.ModifyDriver(driver);

            return Ok(modifydriver);
        }






        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> DeleteDriver(int driverId)
        {
            await _adminManageDriverService.DeleteDriver(driverId);
            return Ok();
        }

    }
}
    
