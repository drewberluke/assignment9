using System;
using System.Collections.Generic;
using System.Linq;

namespace assignment3.Models
{
    public class TempStorage
    {
        private static List<Films> FilmsList = new List<Films>();

        public static IEnumerable<Films> films => FilmsList;

        public static void AddFilm(Films film)
        {
            FilmsList.Add(film);
        }
    }
}
