using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sage_HW3.Models
{
    public class Data
    {
        private static List<EnterMovie> enterMovies = new List<EnterMovie>();

        public static IEnumerable<EnterMovie> EnterMovies => enterMovies;
        public static void AddMovie(EnterMovie movie)
        {
            if (movie.Title != "Independence Day")
            {
                enterMovies.Add(movie);
            }
        }
    }
}
