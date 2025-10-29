﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking2
{
    public class Address
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Street { get; set; }

        [Required]
        [MaxLength(100)]
        public string City { get; set; }

        [Required]
        [MaxLength(100)]
        public string State { get; set; }

        [Required]
        [MaxLength(100)]
        public string PostalCode { get; set; }

        [Required]
        [MaxLength(100)]
        public string Country { get; set; }

        public Customer Customer { get; set; }


    }
}
