using Hotel_Booking_System.Interfaces;
using Hotel_Booking_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Hotel_Booking_System.Services
{
    public class ReviewService : IReviewService
    {
        private readonly HotelDbContext _context;

        public ReviewService(HotelDbContext context)
        {
            _context = context;
        }

        public async Task<Review> AddAsync(Review review)
        {
            _context.Reviews.Add(review);
            await _context.SaveChangesAsync();
            return review;
        }

        public async Task<Review> UpdateAsync(int id, Review review)
        {
            var existingReview = await _context.Reviews.FindAsync(id);
            if (existingReview == null)
                throw new KeyNotFoundException("Review not found");

            existingReview.HotelId = review.HotelId;
            existingReview.CustomerId = review.CustomerId;
            existingReview.Rating = review.Rating;
            existingReview.Comment = review.Comment;
            existingReview.ReviewDate = review.ReviewDate;

            await _context.SaveChangesAsync();
            return existingReview;
        }

        public async Task<Review> GetByIdAsync(int id)
        {
            var review = await _context.Reviews
                .Include(r => r.Hotel)
                .Include(r => r.Customer)
                .FirstOrDefaultAsync(r => r.Id == id);
            if (review == null)
                throw new KeyNotFoundException("Review not found");
            return review;
        }

        public async Task DeleteAsync(int id)
        {
            var review = await _context.Reviews.FindAsync(id);
            if (review == null)
                throw new KeyNotFoundException("Review not found");

            _context.Reviews.Remove(review);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Review>> ListAsync()
        {
            return await _context.Reviews
                .Include(r => r.Hotel)
                .Include(r => r.Customer)
                .ToListAsync();
        }
    }
}
