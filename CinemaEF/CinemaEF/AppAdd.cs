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
            clearDatabse();
            AddCinema();
            addSalons();


        }

        private void clearDatabse()
        {
            foreach (var item in context.Cinema)
            {
                context.Remove(item);
            }

            foreach (var item in context.Salon)
            {
                context.Remove(item);
            }

            context.SaveChanges();

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
                    Salon = context.Salon.Single(x=> x.Name == "Salong 1"),
                    Cinema = context.Cinema.Single(x=> x.Name == "Rigoletto")
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
                    Genre = new Genre
                    {
                        Name = "Drama"
                    },
                    AgeLevel = 7,
                    Length = 123,
                    Language = "Svenska",
                    Subtitles = "Svenska",
                    MovieType = new MovieType
                    {
                        Type = "3D IMAX"
                    }
                }, new Movie
                {
                    Name = "The Nun",
                    Description = "När en ung nunna tar sitt liv på ett kloster i Rumänien skickar Vatikanen en präst och hans lärling för att utreda fallet. " +
                    "Tillsammans avslöjar de den skrämmande hemligheten… De riskerar inte bara sina egna liv, utan även sin tro och sina själar, " +
                    "då de tvingas konfrontera den onda kraften från den demoniska nunna som först skrämde världen i ”The Conjuring 2”..",
                    Genre = new Genre
                    {
                        Name = "Horror"
                    },
                    AgeLevel = 15,
                    Length = 97,
                    Language = "Engelska",
                    Subtitles = "Svenska",
                    MovieType = new MovieType
                    {
                        Type = "IMAX"
                    }
                }, new Movie
                {
                    Name = "Superhjältarna 2",
                    Description = "Allas vår favoritsuperhjältefamilj är tillbaka, men den här gången står mamma Helen i rampljuset, och pappa Bob stannar hemma med barnen Violet, " +
                    "Dash och Jack-Jack för att göra hjälteinsatser i vardagslivet och försöka sköta allt som har med ett ”normalt” familjeliv att göra. Det är en tuff omställning för alla, " +
                    "och det blir ännu tuffare, för ingen av dem har ännu en aning om lilla babyn Jack-Jacks alla superkrafter. När en ny skurk smider en genial och farlig plan måste " +
                    "familjen tillsammans med Fryzo samarbeta igen, vilket är lättare sagt än gjort, även om de alla är superhjältar.",
                    Genre = new Genre
                    {
                        Name = "Äventyr"
                    },
                    AgeLevel = 7,
                    Length = 126,
                    Language = "Engelska",
                    Subtitles = "Svenska",
                    MovieType = new MovieType
                    {
                        Type = "Standard"
                    }
                });

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
            var genreAdventure = new Genre { Name = "Äventyr" };

            context.AddRange(genreAction, genreComedy, genreDrama, genreHorror, genreRomance);
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
