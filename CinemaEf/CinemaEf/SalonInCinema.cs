using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaEf
{
    public class SalonInCinema
    {
        public int SalonId { get; set; }
        public Salon Salon { get; set; }

        public int CinemaId { get; set; }
        public Cinema Cinema { get; set; }
    }
}
