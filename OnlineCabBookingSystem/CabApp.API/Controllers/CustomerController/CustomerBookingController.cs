using CabApp.Entities;
using CabApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CabApp.API
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CustomerBookingController : ControllerBase
    {
        private readonly ICustomerBookingService _cusomerBookingService;

        public CustomerBookingController(ICustomerBookingService cusomerBookingService)
        {
            _cusomerBookingService = cusomerBookingService;
        }

        [HttpGet]
        public async Task<IActionResult> GetRiderDetails(int riderId) 
        {
            var details = await _cusomerBookingService.GetRiderDetails(riderId);
            return Ok(details);
        }



        [HttpPost("BookCab")]
        public async Task<IActionResult> BookCab(RideRequest request)
        {
            var id = HttpContext.User.Claims.FirstOrDefault(d => d.Type == "ID").Value;
            if (id != null)
            {
                request.CustomerId = int.Parse(id);
                var result = await _cusomerBookingService.BookCab(request);
                return Ok(result);
            }
            else
                return Unauthorized();
        }

        [HttpPost("CancelRides")]
        public async Task<IActionResult> CancelRides(int customerId, int rideId)
        {
            await _cusomerBookingService.CancelRide(customerId,rideId);
            return Ok();
        }
    }
}
