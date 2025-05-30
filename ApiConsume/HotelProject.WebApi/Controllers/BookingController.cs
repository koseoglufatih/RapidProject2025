﻿using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpGet]
        public IActionResult BookingList()
        {
            var values = _bookingService.TGetList();
            return Ok(values);

        }
        [HttpPost]
        public IActionResult AddBooking(Booking booking)
        {
            _bookingService.TInsert(booking);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id)
        {
            var values = _bookingService.GetById(id);
            _bookingService.TDelete(values);
            return Ok();
        }

        [HttpPut("UpdateBooking")]
        public IActionResult UpdateBooking(Booking booking)
        {
            _bookingService.Update(booking);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetBooking(int id)
        {
            var values = _bookingService.GetById(id);
            return Ok(values);
        }

        [HttpPut("UpdateReservasion")]
        public IActionResult UpdateReservasion(Booking booking)
        {
            _bookingService.TBookingStatusChangeApproved(booking);
            return Ok();
        }

        [HttpPut("UpdateReservasion2")]
        public IActionResult UpdateReservasion2(int id)
        {
            _bookingService.TBookingStatusChangeApproved2(id);
            return Ok();
        }
    }
}

