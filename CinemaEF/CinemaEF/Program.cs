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
<<<<<<< HEAD
            var appadd = new AppAdd();
            appadd.Run();
=======
            //new AppAdd().Run();
>>>>>>> FeliciasAddApp
        }
    }
}
