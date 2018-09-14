using System;
using CinemaEf;
using Microsoft.EntityFrameworkCore;

namespace CinemaEf
{
    class Program
    {
        private static CinemaContext context = new CinemaContext();

        static void Main(string[] args)
        {
            ClearDatabase();
            new AppAdd().Run();
            new App().Run();
        }

        private static void ClearDatabase()
        {
            context.RemoveRange(context.Cinema);
            context.RemoveRange(context.Customer);
            context.RemoveRange(context.Genre);
            context.RemoveRange(context.Location);
            context.RemoveRange(context.Movie);
            context.RemoveRange(context.MovieGenres);
            context.RemoveRange(context.MovieType);
            context.RemoveRange(context.Order);
            context.RemoveRange(context.Salon);
            context.RemoveRange(context.SalonInCinema);
            context.RemoveRange(context.Shows);
            context.RemoveRange(context.Ticket);
        }
    }
}
