using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a class BankAccount(AccountNumber, AccountHolder, Balance ) with default and parameterized constructors using constructor chaining.
//Add Deposit() which increments the balance and DisplayBalance() to display the account details methods

namespace Assignment_03
{
    internal class Bank
    {
        int AccNo;
        string AccHolder;
        double Balance;
        public Bank() {
            this.Balance = 0;
        }
        public Bank(int AccNo, string AccHolder) : this() {
            this.AccNo = AccNo;
            this.AccHolder = AccHolder;
        }

        public void Deposit(double balance) {
            if (balance > 0)
            {
                this.Balance += balance;
                Console.WriteLine($"{balance} Deposited");
            }
            else
            {
                Console.WriteLine("Enter a valid amount");
            }
        }

        public void Display()
        {
            Console.WriteLine($"Account Number: {AccNo}\nAccount Holder: {AccHolder}\nBalance: {Balance}");
        }
    }
}
