using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_07.Q05_Bank
{
    public interface IPaymentService
    {
        void MakePayment(double amount);
    }


    public class CardPayment:IPaymentService
    {
        public void MakePayment(double amount)
        {
            Console.WriteLine($"Payment of {amount} is done through Card");
        }

    }

    public class UPIPayment : IPaymentService
    {
        public void MakePayment(double amount)
        {
            Console.WriteLine($"Payment of {amount} is done through UPI");

        }
    }
    public class NetBankingPayment : IPaymentService
    {
        public void MakePayment(double amount)
        {
            Console.WriteLine($"Payment of {amount} is done through Net Banking");

        }
    }
}
