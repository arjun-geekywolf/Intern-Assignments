using Hotel_Booking_System.DTOs;
using Hotel_Booking_System.Interfaces;
using Hotel_Booking_System.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Hotel_Booking_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomTypeController : ControllerBase
    {
        private readonly IRoomTypeService _roomTypeService;

        public RoomTypeController(IRoomTypeService roomTypeService)
        {
            _roomTypeService = roomTypeService;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] RoomTypeDTO roomType)
        {
            var RoomType = new RoomType
            {
                TypeName = roomType.TypeName,
                Description = roomType.Description,
                Capacity = roomType.Capacity,
            };

            var createdRoomType = await _roomTypeService.AddAsync(RoomType);
            return Ok(createdRoomType);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] RoomTypeDTO roomType)
        {
            try
            {
                var RoomType = new RoomType
                {
                    TypeName = roomType.TypeName,
                    Description = roomType.Description,
                    Capacity = roomType.Capacity,
                };
                var updatedRoomType = await _roomTypeService.UpdateAsync(id, RoomType);
                return Ok(updatedRoomType);
            }
            catch (KeyNotFoundException e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var roomType = await _roomTypeService.GetByIdAsync(id);
                return Ok(roomType);
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
                await _roomTypeService.DeleteAsync(id);
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
            var roomTypes = await _roomTypeService.ListAsync();
            return Ok(roomTypes);
        }
    }
}
