using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaEf;

namespace CinemaEf
{
    public class Ticket
    {
        public int Id { get; set; }
        public int ShowId { get; set; }
        public Shows Shows { get; set; }
    }
}
