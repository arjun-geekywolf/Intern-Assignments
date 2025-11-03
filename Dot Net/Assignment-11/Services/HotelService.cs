using Hotel_Booking_System.DTOs;
using Hotel_Booking_System.Interfaces;
using Hotel_Booking_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Hotel_Booking_System.Services
{
    public class HotelService : IHotelService
    {
        private readonly HotelDbContext _context;

        public HotelService(HotelDbContext context)
        {
            _context = context;
        }

        public async Task<Hotel> AddAsync(Hotel hotel)
        {
            hotel.Rooms = null;
            hotel.Employees = null;
            hotel.Reviews = null;
            _context.Hotels.Add(hotel);
            await _context.SaveChangesAsync();
            return hotel;
        }

        public async Task<Hotel> UpdateAsync(int id, Hotel hotel)
        {
            var existing = await _context.Hotels
                                         .FirstOrDefaultAsync(h => h.Id == id);

            if (existing == null)
                throw new KeyNotFoundException($"Hotel with ID {id} not found.");

            existing.Name = string.IsNullOrWhiteSpace(hotel.Name) ? existing.Name : hotel.Name;
            existing.Address = string.IsNullOrWhiteSpace(hotel.Address) ? existing.Address : hotel.Address;
            existing.City = string.IsNullOrWhiteSpace(hotel.City) ? existing.City : hotel   .City;
            existing.Country = string.IsNullOrWhiteSpace(   hotel.Country) ? existing.Country : hotel.Country;
            existing.PhoneNumber = string.IsNullOrWhiteSpace(hotel.PhoneNumber) ? existing.PhoneNumber : hotel.PhoneNumber;

            var duplicate = await _context.Hotels
                .AnyAsync(h => h.Name == existing.Name &&
                               h.City == existing.City &&
                               h.Id != existing.Id);
            if (duplicate)
                throw new ArgumentException("A hotel with the same name and city already exists.");

            await _context.SaveChangesAsync();
            return existing;
        }

        public async Task<Hotel> GetByIdAsync(int id)
        {
            var hotel = await _context.Hotels
                .Include(h => h.Rooms)
                .Include(h => h.Employees)
                .Include(h => h.Reviews)
                .FirstOrDefaultAsync(h => h.Id == id);
            if (hotel == null)
                throw new KeyNotFoundException("Hotel not found");
            return hotel;
        }

        public async Task DeleteAsync(int id)
        {
            var hotel = await _context.Hotels.FindAsync(id);
            if (hotel == null)
                throw new KeyNotFoundException("Hotel not found");

            _context.Hotels.Remove(hotel);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Hotel>> ListAsync()
        {
            return await _context.Hotels.ToListAsync();
        }
    }
}
