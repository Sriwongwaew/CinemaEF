using CinemaEf.Klasser;
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
            addSalons();


        }

        private void addSalons()
        {
            context.Salon.AddRange(
            new Salon
            {
                Name = "Salong 1",
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
                    Salon = context.Salon.Single(x => x.Name == "Salong 1"),
                    Cinema = context.Cinema.Single(x => x.Name == "Rigoletto")
                },
                new SalonInCinema
                {
                    Salon = context.Salon.Single(x => x.Name == "Salong 2"),
                    Cinema = context.Cinema.Single(x => x.Name == "Rigoletto")
                },
                new SalonInCinema
                {
                    Salon = context.Salon.Single(x => x.Name == "Salong 3"),
                    Cinema = context.Cinema.Single(x => x.Name == "Rigoletto")
                },
                new SalonInCinema
                {
                    Salon = context.Salon.Single(x => x.Name == "Salong 4"),
                    Cinema = context.Cinema.Single(x => x.Name == "Rigoletto")
                },
                new SalonInCinema
                {
                    Salon = context.Salon.Single(x => x.Name == "Salong 1"),
                    Cinema = context.Cinema.Single(x => x.Name == "Filmstaden Heron City")
                },
                new SalonInCinema
                {
                    Salon = context.Salon.Single(x => x.Name == "Salong 2"),
                    Cinema = context.Cinema.Single(x => x.Name == "Filmstaden Heron City")
                },
                new SalonInCinema
                {
                    Salon = context.Salon.Single(x => x.Name == "Salong 3"),
                    Cinema = context.Cinema.Single(x => x.Name == "Filmstaden Heron City")
                },
                new SalonInCinema
                {
                    Salon = context.Salon.Single(x => x.Name == "Salong 2"),
                    Cinema = context.Cinema.Single(x => x.Name == "Filmstaden Kista")
                },
                new SalonInCinema
                {
                    Salon = context.Salon.Single(x => x.Name == "Salong 1"),
                    Cinema = context.Cinema.Single(x => x.Name == "Filmstaden Kista")
                },
                new SalonInCinema
                {
                    Salon = context.Salon.Single(x => x.Name == "Salong 1"),
                    Cinema = context.Cinema.Single(x => x.Name == "Filmstaden Sergel")
                },
                new SalonInCinema
                {
                    Salon = context.Salon.Single(x => x.Name == "Salong 2"),
                    Cinema = context.Cinema.Single(x => x.Name == "Filmstaden Sergel")
                },
                new SalonInCinema
                {
                    Salon = context.Salon.Single(x => x.Name == "Salong 3"),
                    Cinema = context.Cinema.Single(x => x.Name == "Filmstaden Sergel")
                },
                new SalonInCinema
                {
                    Salon = context.Salon.Single(x => x.Name == "Salong 1"),
                    Cinema = context.Cinema.Single(x => x.Name == "Filmstaden Scandinavia")
                },
                new SalonInCinema
                {
                    Salon = context.Salon.Single(x => x.Name == "Salong 2"),
                    Cinema = context.Cinema.Single(x => x.Name == "Filmstaden Scandinavia")
                },
                new SalonInCinema
                {
                    Salon = context.Salon.Single(x => x.Name == "Salong 3"),
                    Cinema = context.Cinema.Single(x => x.Name == "Filmstaden Scandinavia")
                },
                new SalonInCinema
                {
                    Salon = context.Salon.Single(x => x.Name == "Salong 4"),
                    Cinema = context.Cinema.Single(x => x.Name == "Filmstaden Scandinavia")
                }
                );

            context.SaveChanges();

        }

        private void AddMovies()
        {
            var genreAction = new Genre { Name = "Action" };
            var genreComedy = new Genre { Name = "Comedy" };
            var genreDrama = new Genre { Name = "Drama" };
            var genreHorror = new Genre { Name = "Horror" };
            var genreRomance = new Genre { Name = "Romance" };
            var genreAdventure = new Genre { Name = "Äventyr" };

            context.AddRange(genreAction, genreComedy, genreDrama, genreHorror, genreRomance);
            context.SaveChanges();

            var movie = new Movie
            {
                Name = "Unga Astrid",
                Description = "När Astrid Lindgren var väldigt ung hände något som påverkade henne fundamentalt, " +
                     "en kombination av mirakel och missöde som kom att forma hela hennes liv. Det var en händelse som " +
                     "gjorde henne till en av de mest nyskapande kvinnorna i vår tid och den sagoberättare en hel värld kom att älska." +
                     " Det här är berättelsen om när en ung Astrid, trots tidens förväntningar och religiösa påbud, bestämde sig för att " +
                     "bryta mot samhällets normer och följa sitt hjärta. Unga Astrid är en fri tolkning av händelser i Astrid Lindgrens tidiga liv.",
                MovieGenres = new List<MovieGenre> { new MovieGenre { Genre = genreAction }, new MovieGenre { Genre = genreDrama } },
                AgeLevel = 7,
                Length = 123,
                Language = "Svenska",
                Subtitles = "Svenska"
            };
            var movie1 = new Movie
            {
                Name = "The Nun",
                Description = "Jätte läskig film om en nunna som typ är ett spöke? Eller demon? Vad är ens skillnaden? Snälla säg inte 'Google is your friend' då blir jag arg och lite våldsam",
                MovieGenres = new List<MovieGenre> { new MovieGenre { Genre = genreHorror } },
                AgeLevel = 15,
                Length = 97,
                Language = "Engelska",
                Subtitles = "Svenska"
            };
            var movie3 = new Movie
            {
                Name = "The Predator",
                Description = "Jättecool film, tror vi, ingen har sett den, men verkar fan rätt schysst alltså. 5 av 5 hypotetiska brödrostar i betyg.",
                MovieGenres = new List<MovieGenre> { new MovieGenre { Genre = genreAction }, new MovieGenre { Genre = genreHorror } },
                AgeLevel = 15,
                Length = 108,
                Language = "Engelska",
                Subtitles = "Svenska"
            };
            var movie4 = new Movie
            {
                Name = "Ensamma i rymden",
                Description = "Animerad familjefilm. Två syskon blir vän med en utomjording. Kul.... 1 av 5 hypotetiska brödrostar i betyg",
                MovieGenres = new List<MovieGenre> { new MovieGenre { Genre = genreAction }, new MovieGenre { Genre = genreHorror } },
                AgeLevel = 7,
                Length = 83,
                Language = "Engelska",
                Subtitles = "Svenska"
            };
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

