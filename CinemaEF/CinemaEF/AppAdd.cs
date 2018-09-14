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
