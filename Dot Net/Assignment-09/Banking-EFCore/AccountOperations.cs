using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_EFCore
{
    public class AccountOperations
    {
       

        public void Add(Customer customer)
    {
            using (BankingAppDbContext context = new BankingAppDbContext())
            {

                context.Customers.Add(customer);
                context.SaveChanges();

                Console.WriteLine("Customer Added");

            }
    }

    public void Update(int id, string address) {

            using (BankingAppDbContext context = new BankingAppDbContext())
            {

                Customer customer = context.Customers.Find(id);
                if (customer == null)
                {
                    Console.WriteLine("Customer not found");
                }
                else
                {
                    customer.Address = address;
                    context.SaveChanges();

                    Console.WriteLine("address updated");
                }
            }

    }

        public void Delete(int id) {

            using (BankingAppDbContext context = new BankingAppDbContext()) {


                Customer customer = context.Customers.Find(id);

                if (customer == null)
                {

                    Console.WriteLine("Customer not found");
                }
                else
                {
                    context.Customers.Remove(customer);
                    context.SaveChanges();
                    Console.WriteLine("Customer Deleted");

                }
                
            
            }
        
        
        }

        public void Display(int id) {

            using (BankingAppDbContext context = new BankingAppDbContext()) {

                Customer customer = context.Customers.Find(id);

                if(customer != null)
                {
                    Console.WriteLine("Customer Details");
                    Console.WriteLine($"Name: {customer.FullName}");
                    Console.WriteLine($"email: {customer.Email}");
                    Console.WriteLine($"Address: {customer.Address}");
                }
                else
                {
                    Console.WriteLine("Customer not found");
                }
            
            }
        
        }

}


}
