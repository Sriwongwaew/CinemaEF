using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaEf;

namespace CinemaEf
{
    public class OrderHistory
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public Order Order { get; set; }
    }
}
