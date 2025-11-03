using Hotel_Booking_System.Interfaces;
using Hotel_Booking_System.Models;
using Microsoft.EntityFrameworkCore;
public class RoomTypeService : IRoomTypeService
    {
        private readonly HotelDbContext _context;

        public RoomTypeService(HotelDbContext context)
        {
            _context = context;
        }

        public async Task<RoomType> AddAsync(RoomType roomType)
        {
            roomType.Rooms = null;
            _context.RoomTypes.Add(roomType);
            await _context.SaveChangesAsync();
            return roomType;
        }

        public async Task<RoomType> UpdateAsync(int id, RoomType roomType)
        {
            var existingRoomType = await _context.RoomTypes.FindAsync(id);
            if (existingRoomType == null)
                throw new KeyNotFoundException("RoomType not found");

            existingRoomType.TypeName = roomType.TypeName;
            existingRoomType.Description = roomType.Description;
            existingRoomType.Capacity = roomType.Capacity;

            await _context.SaveChangesAsync();
            return existingRoomType;
        }

        public async Task<RoomType> GetByIdAsync(int id)
        {
            var roomType = await _context.RoomTypes
                .Include(rt => rt.Rooms)
                .FirstOrDefaultAsync(rt => rt.Id == id);
            if (roomType == null)
                throw new KeyNotFoundException("RoomType not found");
            return roomType;
        }

        public async Task DeleteAsync(int id)
        {
            var roomType = await _context.RoomTypes.FindAsync(id);
            if (roomType == null)
                throw new KeyNotFoundException("RoomType not found");

            _context.RoomTypes.Remove(roomType);
            await _context.SaveChangesAsync();
        }

        public async Task<List<RoomType>> ListAsync()
        {
            return await _context.RoomTypes
                .Include(rt => rt.Rooms)
                .ToListAsync();
        }
    }
namespace Hotel_Booking_System.Services
{
    public class RoomTypeService : IRoomTypeService
    {
        private readonly HotelDbContext _context;

        public RoomTypeService(HotelDbContext context)
        {
            _context = context;
        }

        public async Task<RoomType> AddAsync(RoomType roomType)
        {
            roomType.Rooms = null;
            _context.RoomTypes.Add(roomType);
            await _context.SaveChangesAsync();
            return roomType;
        }

        public async Task<RoomType> UpdateAsync(int id, RoomType roomType)
        {
            var existingRoomType = await _context.RoomTypes.FindAsync(id);
            if (existingRoomType == null)
                throw new KeyNotFoundException("RoomType not found");

            existingRoomType.TypeName = roomType.TypeName;
            existingRoomType.Description = roomType.Description;
            existingRoomType.Capacity = roomType.Capacity;

            await _context.SaveChangesAsync();
            return existingRoomType;
        }

        public async Task<RoomType> GetByIdAsync(int id)
        {
            var roomType = await _context.RoomTypes
                .Include(rt => rt.Rooms)
                .FirstOrDefaultAsync(rt => rt.Id == id);
            if (roomType == null)
                throw new KeyNotFoundException("RoomType not found");
            return roomType;
        }

        public async Task DeleteAsync(int id)
        {
            var roomType = await _context.RoomTypes.FindAsync(id);
            if (roomType == null)
                throw new KeyNotFoundException("RoomType not found");

            _context.RoomTypes.Remove(roomType);
            await _context.SaveChangesAsync();
        }

        public async Task<List<RoomType>> ListAsync()
        {
            return await _context.RoomTypes
                .Include(rt => rt.Rooms)
                .ToListAsync();
        }
    }
}
