using Hotel_Booking_System.DTOs;
using Hotel_Booking_System.Models;

namespace Hotel_Booking_System.Interfaces
{
    public interface IHotelService
    {
        Task<Hotel> AddAsync(Hotel hotel);
        Task<Hotel> UpdateAsync(int id, Hotel hotel);
        Task<Hotel> GetByIdAsync(int id);
        Task DeleteAsync(int id);
        Task<List<Hotel>> ListAsync();
    }
}
