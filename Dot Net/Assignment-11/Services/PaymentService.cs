using Hotel_Booking_System.Interfaces;
using Hotel_Booking_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Hotel_Booking_System.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly HotelDbContext _context;

        public PaymentService(HotelDbContext context)
        {
            _context = context;
        }

        public async Task<Payment> AddAsync(Payment payment)
        {
            _context.Payments.Add(payment);
            await _context.SaveChangesAsync();
            return payment;
        }

        public async Task<Payment> UpdateAsync(int id, Payment payment)
        {
            var existingPayment = await _context.Payments.FindAsync(id);
            if (existingPayment == null)
                throw new KeyNotFoundException("Payment not found");

            existingPayment.BookingId = payment.BookingId;
            existingPayment.PaymentDate = payment.PaymentDate;
            existingPayment.Amount = payment.Amount;
            existingPayment.Method = payment.Method;
            existingPayment.Status = payment.Status;

            await _context.SaveChangesAsync();
            return existingPayment;
        }

        public async Task<Payment> GetByIdAsync(int id)
        {
            var payment = await _context.Payments
                .Include(p => p.Booking)
                .FirstOrDefaultAsync(p => p.Id == id);
            if (payment == null)
                throw new KeyNotFoundException("Payment not found");
            return payment;
        }

        public async Task DeleteAsync(int id)
        {
            var payment = await _context.Payments.FindAsync(id);
            if (payment == null)
                throw new KeyNotFoundException("Payment not found");

            _context.Payments.Remove(payment);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Payment>> ListAsync()
        {
            return await _context.Payments
                .Include(p => p.Booking)
                .ToListAsync();
        }
    }
}
