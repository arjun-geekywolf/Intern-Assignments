using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Banking2
{
    internal class AccountOperations
    {

        public void add(Customer customer)
        {
            using (BankingAppDbContext context = new BankingAppDbContext())
            {
                context.Customers.Add(customer);
                context.SaveChanges();
                Console.WriteLine("New custmer added");
                
            }

        }


        public void DisplayAll()
        {
            using (BankingAppDbContext context = new BankingAppDbContext())
            {
                var customers = context.Customers
                         .Include(c => c.Address)
                         .Include(c => c.Accounts)
                         .Select(c => new
                         {
                             c.FullName,
                             Address = $"{c.Address.Street}, {c.Address.City}, {c.Address.State}, {c.Address.PostalCode}, {c.Address.Country}",
                             Accounts = c.Accounts.Select(a => new { a.AccountNumber, a.Balance }).ToList()
                         })
                         .ToList();

                foreach (var item in customers)
                {
                    Console.WriteLine($"Name: {item.FullName}");
                    Console.WriteLine($"Address: {item.Address}");

                        Console.WriteLine("Accounts:");
                        foreach (var account in item.Accounts)
                        {
                            Console.WriteLine($"  Account: {account.AccountNumber} ({account.Balance})");
                        }

                }
            }
        }



        public void AddAddress(int customerId, Address address)
        {
            using (var context = new BankingAppDbContext())
            {
                var customer = context.Customers.Include(c => c.Address).FirstOrDefault(c => c.Id == customerId);
                if (customer == null) throw new Exception("Customer not found.");

                if (customer.Address != null)
                {
                    customer.Address.Street = address.Street;
                    customer.Address.City = address.City;
                    customer.Address.State = address.State;
                    customer.Address.PostalCode = address.PostalCode;
                    customer.Address.Country = address.Country;
                    Console.WriteLine("Address updated.");
                }
                else
                {
                
                    address.Id = 0; 
                    customer.Address = address; 
                    context.Addresses.Add(address);
                    Console.WriteLine("Address added.");
                }
                context.SaveChanges();
            }
        }


        public void AddAccount(int customerId, Account account)
        {
            using (var context = new BankingAppDbContext())
            {
                var customer = context.Customers.Include(c => c.Accounts).FirstOrDefault(c => c.Id == customerId);
                if (customer == null) throw new Exception("Customer not found.");

                account.Customer = customer;
                customer.Accounts.Add(account);
                context.SaveChanges();
                Console.WriteLine("Account added.");
            }
        }

        public void DeleteAccount(int customerId, int accountId)
        {
            using (var context = new BankingAppDbContext())
            {
                var customer = context.Customers.Include(c => c.Accounts).FirstOrDefault(c => c.Id == customerId);
                if (customer == null) throw new Exception("Customer not found.");

                var account = customer.Accounts.FirstOrDefault(a => a.Id == accountId);
                if (account != null)
                {
                    customer.Accounts.Remove(account);
                    context.Accounts.Remove(account);
                    context.SaveChanges();
                    Console.WriteLine("Account deleted.");
                }
            }
        }

    }
}
