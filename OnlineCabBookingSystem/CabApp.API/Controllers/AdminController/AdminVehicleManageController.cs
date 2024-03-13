using CabApp.Entities;
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


        [HttpGet]
       
        public async Task<ActionResult> ViewAllVehicle()
        {
            var vehicleList = await _adminVehicleManagerService.ViewAllVehicle();
            return Ok(vehicleList);
        }


        [HttpPost]
       
        public async Task<IActionResult> AddNewVehiclePost()
        {
            NewVehicle request = JsonSerializer.Deserialize<NewVehicle>(
                                             HttpContext.Request.Form["data"]);

            if (HttpContext.Request.Form.Files.Count > 0)
            {
                request.VehiclePhoto = HttpContext.Request.Form.Files["vehiclePhoto"];
            }

            var vehicle = await _adminVehicleManagerService.AddNewVehicles(request);

            return Ok(vehicle);
        }

        [HttpPut("{id}")]
       
        public async Task<IActionResult> UpdateVehicle(Vehicle updateRequest)
        {
            var modifyVehicle = await _adminVehicleManagerService.UpdateVehicle(updateRequest);

            return Ok(modifyVehicle);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetVehicleById(int id)
        {
            var employee = await _adminVehicleManagerService.GetVehicleById(id);
            return Ok(employee);
        }


        [HttpDelete("{id}")]
     
        public async Task<ActionResult> DeleteVehicle(int VehicleId)
        {
            await _adminVehicleManagerService.DeleteVehicle(VehicleId);
            return Ok();
        }

    }
}

