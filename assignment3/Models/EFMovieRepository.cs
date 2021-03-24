using System;
using System.Linq;

namespace assignment3.Models
{
    public class EFMovieRepository : IMovieRepository
    {
        private MovieContext _context;

        public EFMovieRepository(MovieContext context)
        {
            _context = context;
        }

        public IQueryable<Films> films => (_context.films);

        //save film method that recieves a films object and updates the values
        //this is called in the controller in the edit film action
        public void SaveFilm(Films film)
        {
            Films dbEntry = _context.films
                .FirstOrDefault(f => f.id == film.id);
            if (dbEntry != null)
            {
                dbEntry.category = film.category;
                dbEntry.title = film.title;
                dbEntry.year = film.year;
                dbEntry.director = film.director;
                dbEntry.rating = film.rating;
                dbEntry.edited = film.edited;
                dbEntry.lent = film.lent;
                dbEntry.notes = film.notes;
            }
            _context.SaveChanges();
        }
    }
}
