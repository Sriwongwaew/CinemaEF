using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaEf;

namespace CinemaEf
{
    public class Shows
    {
        public int Id { get; set; }
        public int SalonId { get; set; }
        public Salon Salon { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public DateTime StartTime { get; set; }
    }
}
