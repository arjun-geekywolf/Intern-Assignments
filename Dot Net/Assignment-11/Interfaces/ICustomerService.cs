using Hotel_Booking_System.Models;

namespace Hotel_Booking_System.Interfaces
{
    public interface ICustomerService
    {
        Task<Customer> AddAsync(Customer customer);
        Task<Customer> UpdateAsync(int id, Customer customer);
        Task<Customer> GetByIdAsync(int id);
        Task DeleteAsync(int id);
        Task<List<Customer>> ListAsync();
    }
}
