using System;
using System.Collections.Generic;
using System.Linq;

namespace assignment3.Models
{
    public interface IMovieRepository
    {
        IQueryable<Films> films { get; }
        void SaveFilm(Films film);
    }

    public static class Repository
    {
        private static List<Films> films = new List<Films>();
        public static IEnumerable<Films> Filmz => films;
        //add film to be called in the controller when the user adds a new record
        public static void AddFilm(Films film)
        {
            films.Add(film);
        }
    }
}
