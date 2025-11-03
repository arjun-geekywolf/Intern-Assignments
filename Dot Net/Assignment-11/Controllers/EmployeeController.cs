using Hotel_Booking_System.DTOs;
using Hotel_Booking_System.Interfaces;
using Hotel_Booking_System.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hotel_Booking_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] EmployeeDTO employeeDto)

        {
            var employee = new Employee
            {
                HotelId = employeeDto.HotelId,
                FullName = employeeDto.FullName,
                Role = employeeDto.Role,
                Email = employeeDto.Email,
            };

            var createdEmployee = await _employeeService.AddAsync(employee);
            return CreatedAtAction(nameof(GetById), new { id = createdEmployee.Id }, createdEmployee);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] EmployeeDTO employeeDto)
        {
            try
            {

                var employee = new Employee
                {
                    HotelId = employeeDto.HotelId,
                    FullName = employeeDto.FullName,
                    Role = employeeDto.Role,
                    Email = employeeDto.Email,
                };

                var updatedEmployee = await _employeeService.UpdateAsync(id, employee);
                return Ok(updatedEmployee);
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
                var employee = await _employeeService.GetByIdAsync(id);
                return Ok(employee);
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
                await _employeeService.DeleteAsync(id);
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
            var employees = await _employeeService.ListAsync();
            return Ok(employees);
        }
    }
}
