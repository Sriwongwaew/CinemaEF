using CinemaEf;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CinemaEF
{
    public class CinemaContext : DbContext
    {
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<MovieType> MovieType { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderHistory> OrderHistory { get; set; }
        public DbSet<Salon> Salon { get; set; }
        public DbSet<Shows> Shows { get; set; }
        public DbSet<Ticket> Ticket { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
              "Server = (localdb)\\mssqllocaldb; Database = CinemaEf;");
        }
    }
}
