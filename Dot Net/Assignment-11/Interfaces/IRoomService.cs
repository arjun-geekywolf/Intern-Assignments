using Hotel_Booking_System.Models;

namespace Hotel_Booking_System.Interfaces
{
    public interface IRoomService
    {
        Task<Room> AddAsync(Room room);
        Task<Room> UpdateAsync(int id, Room room);
        Task<Room> GetByIdAsync(int id);
        Task DeleteAsync(int id);
        Task<List<Room>> ListAsync();
    }
}
