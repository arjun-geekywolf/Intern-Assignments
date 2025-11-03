using Hotel_Booking_System.DTOs;
using Hotel_Booking_System.Interfaces;
using Hotel_Booking_System.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hotel_Booking_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private readonly IReviewService _reviewService;

        public ReviewController(IReviewService reviewService)
        {
            _reviewService = reviewService;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] ReviewDTO reviewDto)
        {
            var review = new Review { 
                HotelId = reviewDto.HotelId,
                CustomerId = reviewDto.CustomerId,
                Rating = reviewDto.Rating,
                Comment = reviewDto.Comment,
                ReviewDate = reviewDto.ReviewDate
            
            };

            var createdReview = await _reviewService.AddAsync(review);
            return CreatedAtAction(nameof(GetById), new { id = createdReview.Id }, createdReview);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] ReviewDTO reviewDto)
        {
            try
            {
                var review = new Review
                {
                    HotelId = reviewDto.HotelId,
                    CustomerId = reviewDto.CustomerId,
                    Rating = reviewDto.Rating,
                    Comment = reviewDto.Comment,
                    ReviewDate = reviewDto.ReviewDate

                };
                var updatedReview = await _reviewService.UpdateAsync(id, review);
                return Ok(updatedReview);
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

                var review = await _reviewService.GetByIdAsync(id);
                return Ok(review);
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
                await _reviewService.DeleteAsync(id);
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
            var reviews = await _reviewService.ListAsync();
            return Ok(reviews);
        }
    }
}
