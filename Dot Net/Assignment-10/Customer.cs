﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking2
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string FullName { get; set; }

        [Required]
        [MaxLength(256)]
        public string Email { get; set; }
        
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }

        public int AddressId { get; set; }
        public Address Address { get; set; }

        public List<Account> Accounts { get; set; } = new List<Account>();


    }

}
