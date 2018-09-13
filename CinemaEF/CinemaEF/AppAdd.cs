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
            AddGenre();
            //AddCinema();
            //AddMovies();
           // AddCinema();

        }

        private void AddMovies()
        {
            using (var context = new CinemaContext())
            {
                //context.Movie.AddRange(Movie1, Movie2);
                context.Movie.AddRange(new Movie
                {
                    Name = "The Predator",
                    Description = "Genetiskt uppgraderade med DNA från andra arter är universums farligaste jägare den här " +
                                  "gången starkare, smartare och dödligare än någonsin. När en ung pojke av misstag råkar trigga " +
                                  "deras återkomst till jorden kan bara ett gäng avdankade ex-soldater och en missnöjd NO-lärare förhindra slutet för mänskligheten.",
                    Genre = new Genre
                    {
                        Name = "Action"
                    },
                    AgeLevel = 15,
                    Length = 108,
                    Language = "Engelska",
                    Subtitles = "Svenska"
                }, new Movie
                {
                    Name = "Unga Astrid",
                    Description = "När Astrid Lindgren var väldigt ung hände något som påverkade henne fundamentalt, " +
                    "en kombination av mirakel och missöde som kom att forma hela hennes liv. Det var en händelse som " +
                    "gjorde henne till en av de mest nyskapande kvinnorna i vår tid och den sagoberättare en hel värld kom att älska." +
                    " Det här är berättelsen om när en ung Astrid, trots tidens förväntningar och religiösa påbud, bestämde sig för att " +
                    "bryta mot samhällets normer och följa sitt hjärta. Unga Astrid är en fri tolkning av händelser i Astrid Lindgrens tidiga liv.",
                    Genre = new Genre
                    {
                        Name = "Drama"
                    },
                    AgeLevel = 7,
                    Length = 123,
                    Language = "Svenska",
                    Subtitles = "Svenska"
                });

                context.SaveChanges();
            }
        }
        
       

        public void AddCinema()
        {
            //.Cinema.Addrange();
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
        public void AddGenre()
        {
            var genreAction = new Genre { Name = "Action" };
            var genreComedy = new Genre { Name = "Comedy" };
            var genreDrama = new Genre { Name = "Drama" };
            var genreHorror = new Genre { Name = "Horror" };
            var genreRomance = new Genre { Name = "Romance" };

            context.AddRange(genreAction, genreComedy, genreDrama, genreHorror, genreRomance);
            context.SaveChanges();

        }
    }
}
