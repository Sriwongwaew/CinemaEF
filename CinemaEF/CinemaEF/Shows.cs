﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaEF
{
    public class Shows
    {
        public int Id { get; set; }
        public Salon SalonId { get; set; }
        public Movie MovieId { get; set; }
        public DateTime StartTime { get; set; }
    }
}
