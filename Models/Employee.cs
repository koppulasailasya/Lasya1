﻿using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Age { get; set; }
        public string? Address { get; set; }
    }
}
