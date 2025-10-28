using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Banking_EFCore
{
    public class BankingAppDbContext:DbContext
    {
        protected override void  OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=localhost,1433;Initial Catalog=Banking;User ID=sa;Password=arjun@123;Trust Server Certificate=True");
        }

    public DbSet<Customer> Customers {  get; set; }
    }
}
