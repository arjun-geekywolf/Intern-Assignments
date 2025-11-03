using Hotel_Booking_System.Models;

namespace Hotel_Booking_System.Interfaces
{
    public interface IRoomTypeService
    {
        Task<RoomType> AddAsync(RoomType roomType);
        Task<RoomType> UpdateAsync(int id, RoomType roomType);
        Task<RoomType> GetByIdAsync(int id);
        Task DeleteAsync(int id);
        Task<List<RoomType>> ListAsync();
    }
}
