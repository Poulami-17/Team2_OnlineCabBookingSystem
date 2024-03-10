using CabApp.Entities;
using CabApp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CabApp.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverRideController : ControllerBase
    {
        //declaring object of dependency
        private readonly IDriverRideService _driverRideService;

        //injecting dependency in the constructor
        public DriverRideController(IDriverRideService driverRideService)
        {
            this._driverRideService = driverRideService;
        }

        [HttpGet]
        public async Task <IActionResult> GetPendingRides() 
        {
            var pendingList = await _driverRideService.GetPendingRide();
            return Ok(pendingList);
        }

        [HttpPost]
        public async Task<IActionResult> AcceptRides( int rideId, int driverId)
        {
            await _driverRideService.AcceptRide(rideId,driverId);
            return Ok();
        }
    }
}
