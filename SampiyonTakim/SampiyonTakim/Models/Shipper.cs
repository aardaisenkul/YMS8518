﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SampiyonTakim.Models
{
    public class Shipper
    {
        public int Id { get; set; }
        [Required, MaxLength(40)]
        public string CompanyName { get; set; }
        [Required, MaxLength(24)]
        public string Phone { get; set; }
    }
}
