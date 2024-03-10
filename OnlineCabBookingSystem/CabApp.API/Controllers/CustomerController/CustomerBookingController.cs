﻿using CabApp.Entities;
using CabApp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CabApp.API
{
    [Route("api/[controller]")]
    [ApiController]
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
            var result = await _cusomerBookingService.BookCab(request);
            return Ok(result);
        }

        [HttpPost("CancelRides")]
        public async Task<IActionResult> CancelRides(int customerId, int rideId)
        {
            await _cusomerBookingService.CancelRide(customerId,rideId);
            return Ok();
        }
    }
}
