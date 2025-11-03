using Hotel_Booking_System.DTOs;
using Hotel_Booking_System.Interfaces;
using Hotel_Booking_System.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hotel_Booking_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CustomerDTO customerDto)
        {
            var customer = new Customer { 
                FullName = customerDto.FullName,
                PhoneNumber = customerDto.PhoneNumber,
                IdProofNumber = customerDto.IdProofNumber,
                Email = customerDto.Email
            
            };


            var createdCustomer = await _customerService.AddAsync(customer);
            return CreatedAtAction(nameof(GetById), new { id = createdCustomer.Id }, createdCustomer);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] CustomerDTO customerDto)
        {
            try
            {
                var customer = new Customer
                {
                    FullName = customerDto.FullName,
                    PhoneNumber = customerDto.PhoneNumber,
                    IdProofNumber = customerDto.IdProofNumber,
                    Email = customerDto.Email

                };

                var updatedCustomer = await _customerService.UpdateAsync(id, customer);
                return Ok(updatedCustomer);
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
                var customer = await _customerService.GetByIdAsync(id);
                return Ok(customer);
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
                await _customerService.DeleteAsync(id);
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
            var customers = await _customerService.ListAsync();
            return Ok(customers);
        }
    }
}
