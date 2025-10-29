using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking2
{
    public class Account
    {
        public int Id { get; set; }
        public string AccountNumber { get; set; }   
        public double Balance { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }


}
