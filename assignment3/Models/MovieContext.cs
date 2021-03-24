using System;
using Microsoft.EntityFrameworkCore;

namespace assignment3.Models
{
    public class MovieContext : DbContext 
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base (options) { }

        public DbSet<Films> films { get; set; }
    }
}
