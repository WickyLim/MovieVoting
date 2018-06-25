using System.Data.Entity;

namespace MovieVoting.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext() : base("MovieVoting")
        {
        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Vote> Votes { get; set; }
    }
}