using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaEf;

namespace CinemaEf
{
    public class Salon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SeatingAmount { get; set; }
        public bool IsChildFriendly { get; set; }
        public bool HasImax { get; set; }
        public bool Has3D { get; set; }
        public bool HasVIP { get; set; }
    }
}
