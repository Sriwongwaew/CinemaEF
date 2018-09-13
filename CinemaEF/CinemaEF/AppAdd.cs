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
            //AddCinema();

            AddGenre();
        }

        public void AddCinema()
        {
          //  context.Cinema.Addrange();
        }
        public void AddGenre()
        {
            var genreAction = new Genre { Name = "Action" };
            var genreHorror = new Genre { Name = "Drama" };
            var genreDrama = new Genre { Name = "Drama" };
            var genreRomance = new Genre { Name = "Romance" };
            var genreComedy = new Genre { Name = "Comedy" };

            context.AddRange(genreAction, genreComedy, genreDrama, genreHorror, genreRomance);
        }
    }
}