﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5HW1.Dtos.Requests
{
    internal class RegisterRequest
    {
        public string Email { get; set; }
        public string Password { get; set; } = null!;
    }
}
