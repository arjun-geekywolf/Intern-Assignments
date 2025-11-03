using Hotel_Booking_System.Models;

namespace Hotel_Booking_System.Interfaces
{
    public interface IBookingService
    {
        Task<Booking> AddAsync(Booking booking);
        Task<Booking> UpdateAsync(int id, Booking booking);
        Task<Booking> GetByIdAsync(int id);
        Task DeleteAsync(int id);
        Task<List<Booking>> ListAsync();
    }
}
