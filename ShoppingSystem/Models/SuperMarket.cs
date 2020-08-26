﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingSystem.Models
{
    public class SuperMarket
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public Order Order { get; set; }

        //public ICollection<Order> Orders { get; set; }
    }
}
