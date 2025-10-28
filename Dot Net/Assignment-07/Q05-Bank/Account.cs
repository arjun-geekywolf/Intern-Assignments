using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_07.Q05_Bank
{
   interface IAccount
    {
        void Deposit(double amount);
        void Withdraw(double amount);
        double GetBalance();
    }

    public class SavingsAccount:IAccount
        {
        double balance = 0;
        public void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine($"{amount} Deposited in savings");
        }

        public void Withdraw(double amount)
        {
            if (balance > amount)
            {
                balance -= amount;
                Console.WriteLine($"{amount} withdrawed from savings");
            }
            else
                Console.WriteLine("Not enough money in savings");
        }

        public double GetBalance()
        {
            return balance;
        }
        }


    public class CurrentAccount : IAccount
    {
        double balance = 0;
        public void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine($"{amount} Deposited in current");
        }

        public void Withdraw(double amount)
        {
            if (balance > amount)
            {
                balance -= amount;
                Console.WriteLine($"{amount} withdrawed from current");
            }
            else
                Console.WriteLine("Not enough money in current");
        }

        public double GetBalance()
        {
            return balance;
        }
    }
}
