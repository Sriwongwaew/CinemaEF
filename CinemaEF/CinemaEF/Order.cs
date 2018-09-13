using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaEf;

namespace CinemaEf
{
    public class Order
    {
        public int TicketId { get; set; }
        public int Id { get; set; }
        public Ticket Ticket { get; set; }
        
        public string DeliveryMethod { get; set; }

    }
}
