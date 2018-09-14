using System;
using CinemaEf;

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
            foreach (var customer in context.Customer)
            {
                context.Remove(customer);
            }
        }
    }
}
