using Hotel_Booking_System.Interfaces;
using Hotel_Booking_System.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace Hotel_Booking_System.Services
{
    public class BookingService : IBookingService
    {
        private readonly HotelDbContext _context;

        public BookingService(HotelDbContext context)
        {
            _context = context;
        }

        public async Task<Booking> AddAsync(Booking booking)
        {
            booking.Payment = null;
            _context.Bookings.Add(booking);
            await _context.SaveChangesAsync();
            return booking;
        }

        public async Task<Booking> UpdateAsync(int id, Booking booking)
        {
            var existingBooking = await _context.Bookings.FindAsync(id);
            if (existingBooking == null)
                throw new KeyNotFoundException("Booking not found");

            existingBooking.CustomerId = booking.CustomerId;
            existingBooking.RoomId = booking.RoomId;
            existingBooking.CheckInDate = booking.CheckInDate;
            existingBooking.CheckOutDate = booking.CheckOutDate;
            existingBooking.Status = booking.Status;
            existingBooking.TotalAmount = booking.TotalAmount;

            await _context.SaveChangesAsync();
            return existingBooking;
        }

        public async Task<Booking> GetByIdAsync(int id)
        {
            var booking = await _context.Bookings.FirstOrDefaultAsync(b => b.Id == id);
            if (booking == null)
                throw new KeyNotFoundException("Booking not found");
            return booking;
        }

        public async Task DeleteAsync(int id)
        {
            var booking = await _context.Bookings.FindAsync(id);
            if (booking == null)
                throw new KeyNotFoundException("Booking not found");

            _context.Bookings.Remove(booking);
            await _context.SaveChangesAsync();

           
        }

        public async Task<List<Booking>> ListAsync()
        {
         return await _context.Bookings.ToListAsync();

            
        }
    }
}
