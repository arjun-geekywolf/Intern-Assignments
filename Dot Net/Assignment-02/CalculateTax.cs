using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_02
{
    internal class CalculateTax
    {
        private decimal amount;
        private decimal tax;
        private decimal taxAmount;
        public void Calculate() {
            {
                Console.WriteLine("\n\n\nTax calculation program, input the amount and display the tax\n");
                Console.Write("Enter the Amount: ");
                if (decimal.TryParse(Console.ReadLine(), out amount))
                {

                    if (amount < 10000 && amount >= 0)
                        tax = 5;
                    else if (amount >= 10000 && amount < 15000)
                        tax = 7.5M;
                    else if (amount >= 15000 && amount < 20000)
                        tax = 10;
                    else if (amount >= 20000 && amount < 25000)
                        tax = 12.5M;
                    else if (amount >= 25000)
                        tax = 15;
                    else
                    {
                        Console.WriteLine("Enter a Valid Amount");
                        return;
                    }

                    taxAmount = (amount * tax) / 100;
                    Console.WriteLine("Tax percentage = " + tax);
                    Console.WriteLine("Tax amount is " + taxAmount);

                }
                else
                {
                    Console.WriteLine("Enter a valid amount");
                    return;
                }


            }

        }
    }
}
