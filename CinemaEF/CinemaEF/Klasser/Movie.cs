using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaEf;

namespace CinemaEf
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public string AgeLevel { get; set; }
        public TimeSpan Length { get; set; }
        public string Language { get; set; }
        public string Subtitles { get; set; }
    }
}
