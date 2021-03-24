using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace assignment3.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            MovieContext context = application.ApplicationServices.
                CreateScope().ServiceProvider.GetRequiredService<MovieContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.films.Any())
            {
                context.films.AddRange(
                    new Films
                    {
                        id = -6,
                        category = "Action/Adventure",
                        title = "The Avengers",
                        year = 2012,
                        director = "Joss Whedon",
                        rating = "PG-13",
                        edited = false,
                        lent = "",
                        notes = "Awesome"
                    },
                    new Films
                    {
                        id = -5,
                        category = "Action/Adventure",
                        title = "Batman Begins",
                        year = 2005,
                        director = "Christopher Nolan",
                        rating = "PG-13",
                        edited = false,
                        lent = "",
                        notes = ""
                    },
                    new Films
                    {
                        id = -4,
                        category = "Comedy",
                        title = "Ace Ventura: Pet Detective",
                        year = 1994,
                        director = "Tom Shadyac",
                        rating = "PG-13",
                        edited = false,
                        lent = "",
                        notes = ""
                    },
                    new Films
                    {
                        id = -3,
                        category = "Drama",
                        title = "The Shawshank Redemption",
                        year = 1994,
                        director = "Frank Darabont",
                        rating = "R",
                        edited = true,
                        lent = "",
                        notes = ""
                    },
                    new Films
                    {
                        id = -2,
                        category = "Family",
                        title = "Cars",
                        year = 2006,
                        director = "John Lasseter",
                        rating = "G",
                        edited = false,
                        lent = "Spencer",
                        notes = "the kids LOVED it"
                    },
                    new Films
                    {
                        id = -1,
                        category = "Horror/Suspense",
                        title = "The Ring",
                        year = 2002,
                        director = "Gore Verbinski",
                        rating = "PG-13",
                        edited = false,
                        lent = "",
                        notes = "never again"
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
