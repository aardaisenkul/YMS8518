﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace FormApp1.Data
{
    public class ContactSendDto
    {
        [Required, MinLength(2), MaxLength(150)]
        public string FullName { get; set; }
        [Required, MinLength(6), MaxLength(345)]
        public string Email { get; set; }
        [Required, MinLength(2),MaxLength(1024)]
        public string Message { get; set; }
    }
}