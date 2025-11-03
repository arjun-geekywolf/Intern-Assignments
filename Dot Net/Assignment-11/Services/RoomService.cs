using Hotel_Booking_System.Interfaces;
using Hotel_Booking_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Hotel_Booking_System.Services
{

        public class RoomService : IRoomService
        {
            private readonly HotelDbContext _context;

            public RoomService(HotelDbContext context)
            {
                _context = context;
            }

            public async Task<Room> AddAsync(Room room)
            {
                room.Bookings = null;
                _context.Rooms.Add(room);
                await _context.SaveChangesAsync();
                return room;
            }

        public async Task<Room> UpdateAsync(int id, Room room)
        {
            var existing = await _context.Rooms.FirstOrDefaultAsync(r => r.Id == id);
            if (existing == null)
                throw new KeyNotFoundException("Room not found");

            existing.RoomNumber = !string.IsNullOrWhiteSpace(room.RoomNumber) ? room.RoomNumber : existing.RoomNumber;
            existing.HotelId = room.HotelId > 0 ? room.HotelId : existing.HotelId;
            existing.RoomTypeId = room.RoomTypeId > 0 ? room.RoomTypeId : existing.RoomTypeId;
            existing.PricePerNight = room.PricePerNight > 0 ? room.PricePerNight : existing.PricePerNight;
            if (room.Status != 0) existing.Status = room.Status;

            var duplicate = await _context.Rooms
                .AnyAsync(r => r.RoomNumber == existing.RoomNumber &&
                               r.HotelId == existing.HotelId &&
                               r.Id != existing.Id);

            if (duplicate)
                throw new ArgumentException("Room number already exists.");

            await _context.SaveChangesAsync();
            return existing;
        }

        public async Task<Room> GetByIdAsync(int id)
            {
                var room = await _context.Rooms
                    //.Include(r => r.Hotel)
                    //.Include(r => r.RoomType)
                    //.Include(r => r.Bookings)
                    .FirstOrDefaultAsync(r => r.Id == id);
                if (room == null)
                    throw new KeyNotFoundException("Room not found");
                return room;
            }

            public async Task DeleteAsync(int id)
            {
                var room = await _context.Rooms.FindAsync(id);
                if (room == null)
                    throw new KeyNotFoundException("Room not found");

                _context.Rooms.Remove(room);
                await _context.SaveChangesAsync();
            }

            public async Task<List<Room>> ListAsync()
            {
                return await _context.Rooms.ToListAsync();
            }
        }
}
