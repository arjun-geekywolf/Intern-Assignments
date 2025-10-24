using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_07.Q05_Bank
{
    internal class PaymentProcessor
    {
        IPaymentService paymentService;
        public PaymentProcessor(IPaymentService service) {
        
            paymentService = service;
        }
        public void process(double amount) { 
        
        paymentService.MakePayment(amount);
        }

    }
}
