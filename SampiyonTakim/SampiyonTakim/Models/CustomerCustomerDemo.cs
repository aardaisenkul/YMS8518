using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SampiyonTakim.Models
{
    
    public class CustomerCustomerDemo
    {
      
    

        [Required, MaxLength(10)]
        public string Id { get; set; }

        [Required, MaxLength(5)]
        public string CustomerId { get; set; }

        public Customer Customer { get; set; }

        public CustomerDemographic CustomerDemographic { get; set; }

    }
}
