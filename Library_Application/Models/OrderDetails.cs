﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Application.Models
{
    public class OrderDetails
    {
        public int Id { get; set; } 
        public Book  Book { get; set; }
    }
}
