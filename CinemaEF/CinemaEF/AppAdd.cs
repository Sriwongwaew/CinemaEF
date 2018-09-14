using System;
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
            AddCinema();
            AddMovies();
            addSalons();

        }

        private void addSalons()
        {
            context.Salon.AddRange(
            new Salon
            { Name = "Salong 1",
            SeatingAmount = 50,
            IsChildFriendly = false,
            Has3D = true,
            HasImax = true,
            HasVIP = false
            }, 
            new Salon
            {
                Name = "Salong 2",
                SeatingAmount = 100,
                IsChildFriendly = true,
                HasVIP = false,
                HasImax = false,
                Has3D = true
            },
            new Salon
            {
                Name = "Salong 3",
                SeatingAmount = 80,
                IsChildFriendly = true,
                Has3D = true,
                HasImax = false,
                HasVIP = false
            },
            new Salon
            {
                Name = "Salong 4",
                SeatingAmount = 120,
                IsChildFriendly = false,
                Has3D = true,
                HasVIP = false,
                HasImax = true
            }
            );

            context.SaveChanges();

            context.SalonInCinema.AddRange(
                new SalonInCinema
                {
                    SalonId = context.Salon.Where(x=> x.Name == "Salong 1",
                    CinemaId = context.Cinema.Where(x=> x.Name == "Filmstaden Kista")
                },
                );
        }

        private void AddMovies()
        {
            using (var context = new CinemaContext())
            {
                context.Movie.AddRange(Movie1, Movie2);
                context.SaveChanges();
            }
        }
        private static Movie Movie1
        {
            get
            {
                return new Movie
                {
                    Name = "The Predator",
                    Description = "Genetiskt uppgraderade med DNA från andra arter är universums farligaste jägare den här " +
                                  "gången starkare, smartare och dödligare än någonsin. När en ung pojke av misstag råkar trigga " +
                                  "deras återkomst till jorden kan bara ett gäng avdankade ex-soldater och en missnöjd NO-lärare förhindra slutet för mänskligheten.",
                    Genre = "Action",
                    AgeLevel = 15,
                    Length = 108,
                    Language = "Engelska",
                    Subtitles = "Svenska"


                };
            }
        }
        private static Movie Movie2
        {
            get
            {
                return new Movie
                {
                    Name = "Unga Astrid",
                    Description = "När Astrid Lindgren var väldigt ung hände något som påverkade henne fundamentalt, " +
                    "en kombination av mirakel och missöde som kom att forma hela hennes liv. Det var en händelse som " +
                    "gjorde henne till en av de mest nyskapande kvinnorna i vår tid och den sagoberättare en hel värld kom att älska." +
                    " Det här är berättelsen om när en ung Astrid, trots tidens förväntningar och religiösa påbud, bestämde sig för att " +
                    "bryta mot samhällets normer och följa sitt hjärta. Unga Astrid är en fri tolkning av händelser i Astrid Lindgrens tidiga liv.",
                    Genre = "Drama",
                    AgeLevel = 7,
                    Length = 123,
                    Language = "Svenska",
                    Subtitles = "Svenska"


                };
            }
        }

        public void AddCinema()
        {
            context.Cinema.AddRange(new Cinema
            {
                Name = "Rigoletto",
                Location = new Location
                {
                    Name = "Kungsgatan 16"
                }
            },
            new Cinema
            {
                Name = "Filmstaden Heron City",
                Location = new Location
                {
                    Name = "Dialoggatan 2"
                }
            },
            new Cinema
            {
                Name = "Filmstaden Kista",
                Location = new Location
                {
                    Name = "Kista Galleria"
                }
            },
            new Cinema
            {
                Name = "Filmstaden Sergel",
                Location = new Location
                {
                    Name = "Hötorget"
                }
            },
            new Cinema
            {
                Name = "Filmstaden Scandinavia",
                Location = new Location
                {
                    Name = "Mall of Scandinavia"
                }
            }
            );

            context.SaveChanges();

        }
    }
}
