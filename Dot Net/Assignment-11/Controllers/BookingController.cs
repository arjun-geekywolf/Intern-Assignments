using Hotel_Booking_System.DTOs;
using Hotel_Booking_System.Interfaces;
using Hotel_Booking_System.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Hotel_Booking_System.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpPost]
        
        public async Task <IActionResult> Add([FromBody] BookingDTO bookingDTO)
        {
            var booking = new Booking
            {
                CustomerId = bookingDTO.CustomerId,
                RoomId = bookingDTO.RoomId,
                CheckInDate = bookingDTO.CheckInDate,
                CheckOutDate = bookingDTO.CheckOutDate,
                Status = bookingDTO.Status,
                TotalAmount = bookingDTO.TotalAmount,

            };

            var createdBooking = await _bookingService.AddAsync(booking);

            return Ok(createdBooking);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var bookingList = await _bookingService.ListAsync();

            return Ok(bookingList);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var booking = new Booking();

            booking = await _bookingService.GetByIdAsync(id);

            return Ok(booking);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id,BookingDTO bookingDTO)
        {
            var Booking = new Booking
            {
                CustomerId = bookingDTO.CustomerId,
                CheckInDate = bookingDTO.CheckInDate,
                CheckOutDate = bookingDTO.CheckOutDate,
                RoomId = bookingDTO.RoomId,
                Status = bookingDTO.Status,
                TotalAmount = bookingDTO.TotalAmount

            };

            var updatedList = await _bookingService.UpdateAsync(id,Booking);


            return Ok(updatedList);

        }


        [HttpDelete("{id}")]

        public async Task<IActionResult> Delete(int id)
        {
            await _bookingService.DeleteAsync(id);

            return Ok();
        }


    }
}
