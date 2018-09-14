using System;
using CinemaEf;

namespace CinemaEf
{
    class Program
    {
        private static CinemaContext context = new CinemaContext();

        static void Main(string[] args)
        {
            new App().Run();
            var appadd = new AppAdd();
            appadd.Run();
        }
    }
}
