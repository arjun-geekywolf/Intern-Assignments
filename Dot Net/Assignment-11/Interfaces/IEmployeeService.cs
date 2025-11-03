using Hotel_Booking_System.Models;

namespace Hotel_Booking_System.Interfaces
{
    public interface IEmployeeService
    {
        Task<Employee> AddAsync(Employee employee);
        Task<Employee> UpdateAsync(int id, Employee employee);
        Task<Employee> GetByIdAsync(int id);
        Task DeleteAsync(int id);
        Task<List<Employee>> ListAsync();
    }
}
