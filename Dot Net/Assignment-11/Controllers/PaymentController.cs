using Hotel_Booking_System.DTOs;
using Hotel_Booking_System.Interfaces;
using Hotel_Booking_System.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hotel_Booking_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService _paymentService;

        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] PaymentDTO paymentDto)
        {
            var payment = new Payment {
             
                Amount = paymentDto.Amount,
                BookingId = paymentDto.BookingId,
                Method = paymentDto.Method,
                Status = paymentDto.Status,
                PaymentDate = paymentDto.PaymentDate,
            
            };

            var createdPayment = await _paymentService.AddAsync(payment);
            return CreatedAtAction(nameof(GetById), new { id = createdPayment.Id }, createdPayment);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] PaymentDTO paymentDto)
        {
            try
            {

                var payment = new Payment
                {

                    Amount = paymentDto.Amount,
                    BookingId = paymentDto.BookingId,
                    Method = paymentDto.Method,
                    Status = paymentDto.Status,
                    PaymentDate = paymentDto.PaymentDate,

                };
                var updatedPayment = await _paymentService.UpdateAsync(id, payment);
                return Ok(updatedPayment);
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
                var payment = await _paymentService.GetByIdAsync(id);
                return Ok(payment);
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
                await _paymentService.DeleteAsync(id);
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
            var payments = await _paymentService.ListAsync();
            return Ok(payments);
        }
    }
}
