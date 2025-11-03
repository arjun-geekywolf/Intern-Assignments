using Hotel_Booking_System.Models;

namespace Hotel_Booking_System.Interfaces
{
    public interface IReviewService
    {
        Task<Review> AddAsync(Review review);
        Task<Review> UpdateAsync(int id, Review review);
        Task<Review> GetByIdAsync(int id);
        Task DeleteAsync(int id);
        Task<List<Review>> ListAsync();
    }
}
