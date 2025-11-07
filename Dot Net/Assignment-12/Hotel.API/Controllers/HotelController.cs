using Hotel.Application.DTOs;
using Hotel.Application.Hotel.Commands.CreateHotel;
using Hotel.Application.Hotel.Commands.UpdateHotel;
using Hotel.Application.Hotel.DeleteHotel;
using Hotel.Application.Hotel.Queries.GetCustomers;
using Hotel.Application.Hotel.Queries.GetHotelById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HotelController : ControllerBase
    {
        private readonly IMediator _mediator;

        public HotelController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            GetHotelsQuery query = new GetHotelsQuery();

            var result = await _mediator.Send(query);

            return result is not null ? Ok(result) : NotFound();
        }


        [HttpGet("{id}")]

        public async Task<ActionResult> GetHotelById(int id)
        {
            GetHotelByIdQuery query = new GetHotelByIdQuery();
            query.Id = id;

            var result = await _mediator.Send(query);

            return result is not null ? Ok(result) : NotFound();
        }

        [HttpPost]
        public async Task<ActionResult> AddHotel([FromBody] CreateHotelCommand command)
        {
            var hotelDto = await _mediator.Send(command);

            return CreatedAtAction(
                nameof(GetHotelById),
                new { id = hotelDto.Id },
                hotelDto
            );
        }

        [HttpPut("{id}")]

        public async Task<ActionResult> UpdateHotel(int id, UpdateHotelCommand command)
        {
            command.Id = id;
            return Ok(await  _mediator.Send(command));
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteHotel(int id)
        {
                var command = new DeleteHotelCommand();
                command.Id = id;

                bool result = await _mediator.Send(command);

                return result ? Ok("User Deleted") : NotFound();
        }
            
            
    }
}
