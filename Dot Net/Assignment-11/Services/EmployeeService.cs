using Hotel_Booking_System.Interfaces;
using Hotel_Booking_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Hotel_Booking_System.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HotelDbContext _context;

        public EmployeeService(HotelDbContext context)
        {
            _context = context;
        }

        public async Task<Employee> AddAsync(Employee employee)
        {
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();
            return employee;
        }

        public async Task<Employee> UpdateAsync(int id, Employee employee)
{
               var existing = await _context.Employees.FirstOrDefaultAsync(e => e.Id == id);
            if (existing == null)
                throw new KeyNotFoundException("Employee not found");

            existing.FullName = !string.IsNullOrWhiteSpace(employee.FullName) ? employee.FullName : existing.FullName;
            existing.Role     = !string.IsNullOrWhiteSpace(employee.Role)     ? employee.Role     : existing.Role;
            existing.Email    = !string.IsNullOrWhiteSpace(employee.Email)    ? employee.Email    : existing.Email;
            existing.HotelId  = employee.HotelId > 0 ? employee.HotelId : existing.HotelId;

            var duplicate = await _context.Employees
                .AnyAsync(e => e.Email == existing.Email && e.Id != existing.Id);

            if (duplicate)
                throw new ArgumentException("Email already in use.");

            await _context.SaveChangesAsync();
            return existing;
        }

        public async Task<Employee> GetByIdAsync(int id)
        {
            var employee = await _context.Employees
                .Include(e => e.Hotel)
                .FirstOrDefaultAsync(e => e.Id == id);
            if (employee == null)
                throw new KeyNotFoundException("Employee not found");
            return employee;
        }

        public async Task DeleteAsync(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            if (employee == null)
                throw new KeyNotFoundException("Employee not found");

            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Employee>> ListAsync()
        {
            return await _context.Employees
                .Include(e => e.Hotel)
                .ToListAsync();
        }
    }
}
