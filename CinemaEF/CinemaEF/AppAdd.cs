﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaEf
{
    public class AppAdd
    {
        static CinemaContext context = new CinemaContext();

        // Här händer bara tillägg i SQL
        public void Run()
        {
            //AddCinema();

            AddGenre();
        }

        public void AddCinema()
        {
          //  context.Cinema.Addrange();
        }
        public void AddGenre()
        {
            var genreAction = new Genre { Name = "Action" };
            var genreHorror = new Genre { Name = "Drama" };
            var genreDrama = new Genre { Name = "Horror" };
            var genreRomance = new Genre { Name = "Romance" };
            var genreComedy = new Genre { Name = "Comedy" };
            var genreChild = new Genre { Name = "Child" };

            context.AddRange(genreAction, genreComedy, genreDrama, genreHorror, genreRomance, genreChild);
        }

        public void AddCustomer()
        {
            Customer customer = new Customer
            {
                Name = "Isabelle Eriksson",
                Mail = "ofinns@hotmail.com",
                Password = "123",               
            };

            context.Customer.Add(customer);
            context.SaveChanges();
        }
    }
}