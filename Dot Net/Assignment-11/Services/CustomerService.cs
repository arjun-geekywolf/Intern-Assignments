using Hotel_Booking_System.Interfaces;
using Hotel_Booking_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Hotel_Booking_System.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly HotelDbContext _context;

        public CustomerService(HotelDbContext context)
        {
            _context = context;
        }

        public async Task<Customer> AddAsync(Customer customer)
        {
            customer.Bookings = null;
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();
            return customer;
        }

        public async Task<Customer> UpdateAsync(int id, Customer customer)
        {
            var existingCustomer = await _context.Customers.FindAsync(id);
            if (existingCustomer == null)
                throw new KeyNotFoundException("Customer not found");

            existingCustomer.FullName = customer.FullName;
            existingCustomer.Email = customer.Email;
            existingCustomer.PhoneNumber = customer.PhoneNumber;
            existingCustomer.IdProofNumber = customer.IdProofNumber;

            await _context.SaveChangesAsync();
            return existingCustomer;
        }

        public async Task<Customer> GetByIdAsync(int id)
        {
            var customer = await _context.Customers
                .Include(c => c.Bookings)
                .FirstOrDefaultAsync(c => c.Id == id);
            if (customer == null)
                throw new KeyNotFoundException("Customer not found");
            return customer;
        }

        public async Task DeleteAsync(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
                throw new KeyNotFoundException("Customer not found");

            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Customer>> ListAsync()
        {
            return await _context.Customers
                .Include(c => c.Bookings)
                .ToListAsync();
        }
    }
}
