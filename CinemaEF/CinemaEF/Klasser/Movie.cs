﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaEf.Klasser;

namespace CinemaEf
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Genre Genre { get; set; }
        public int AgeLevel { get; set; }
        public int Length { get; set; }
        public string Language { get; set; }
        public string Subtitles { get; set; }
        public MovieType MovieType { get; set; }
        public List<MovieGenre> MovieGenres { get; set; }
    }
}
