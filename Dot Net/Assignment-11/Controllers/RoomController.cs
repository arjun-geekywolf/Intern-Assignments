using Hotel_Booking_System.DTOs;
using Hotel_Booking_System.Interfaces;
using Hotel_Booking_System.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hotel_Booking_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;

        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] RoomDTO roomDto)
        {
            var room = new Room
            {
                RoomNumber = roomDto.RoomNumber,
                HotelId = roomDto.HotelId,
                PricePerNight = roomDto.PricePerNight,
                Status = roomDto.Status,
                RoomTypeId = roomDto.RoomTypeId

            };

            var createdRoom = await _roomService.AddAsync(room);
            return CreatedAtAction(nameof(GetById), new { id = createdRoom.Id }, createdRoom);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] RoomDTO roomDto)
        {
            try
            {
                var room = new Room
                {
                    RoomNumber = roomDto.RoomNumber,
                    HotelId = roomDto.HotelId,
                    PricePerNight = roomDto.PricePerNight,
                    Status = roomDto.Status,
                    RoomTypeId = roomDto.RoomTypeId

                };
                var updatedRoom = await _roomService.UpdateAsync(id, room);
                return Ok(updatedRoom);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var room = await _roomService.GetByIdAsync(id);
                return Ok(room);
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
                await _roomService.DeleteAsync(id);
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
            var rooms = await _roomService.ListAsync();
            return Ok(rooms);
        }
    }
}
