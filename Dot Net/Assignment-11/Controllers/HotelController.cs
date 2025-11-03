using Hotel_Booking_System.DTOs;
using Hotel_Booking_System.Interfaces;
using Hotel_Booking_System.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hotel_Booking_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly IHotelService _hotelService;

        public HotelController(IHotelService hotelService)
        {
            _hotelService = hotelService;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] HotelDto hotel)


        {
            var Hotel = new Hotel
            {
                Name = hotel.Name,
                Address = hotel.Address,
                City = hotel.City,
                Country = hotel.Country,
                PhoneNumber = hotel.PhoneNumber,
            };

            var createdHotel = await _hotelService.AddAsync(Hotel);

            var createdHotelDto = new HotelDto
            {

                Name = createdHotel.Name,
                Address = createdHotel.Address,
                City = createdHotel.City,
                Country = createdHotel.Country,
                PhoneNumber = createdHotel.PhoneNumber,
            };


            return Ok(createdHotelDto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] HotelDto hotelDto)
        {

            var hotel = new Hotel
            {
                Name = hotelDto.Name,
                Address = hotelDto.Address,
                City = hotelDto.City,
                Country = hotelDto.Country,
                PhoneNumber = hotelDto.PhoneNumber

            };

            var updatedHotel = await _hotelService.UpdateAsync(id, hotel);
                return Ok(updatedHotel);
            
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var hotel = await _hotelService.GetByIdAsync(id);
                return Ok(hotel);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                
                await _hotelService.DeleteAsync(id);
                return NoContent();
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var hotels = await _hotelService.ListAsync();

            return Ok(hotels);
        }
    }
}
