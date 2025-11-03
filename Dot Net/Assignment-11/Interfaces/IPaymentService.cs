using Hotel_Booking_System.Models;

namespace Hotel_Booking_System.Interfaces
{
    public interface IPaymentService
    {
        Task<Payment> AddAsync(Payment payment);
        Task<Payment> UpdateAsync(int id, Payment payment);
        Task<Payment> GetByIdAsync(int id);
        Task DeleteAsync(int id);
        Task<List<Payment>> ListAsync();
    }
}
