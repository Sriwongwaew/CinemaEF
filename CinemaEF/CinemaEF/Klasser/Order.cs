﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaEf;

namespace CinemaEf
{
    public class Order
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }

        public string DeliveryMethod { get; set; }

    }
}
