using System.Collections.Generic;
using System.Data.Entity;

namespace MovieVoting.Models
{
    public class MovieDatabaseInitializer : DropCreateDatabaseIfModelChanges<MovieContext>
    {
        protected override void Seed(MovieContext context)
        {
            GetMovies().ForEach(p => context.Movies.Add(p));
        }

        private static List<Movie> GetMovies()
        {
            var movies = new List<Movie> {
                new Movie
                {
                    MovieID = 1,
                    MovieName = "Avengers Infinity War",
                    ImagePath = "avengers.jpg",
                    Votes = 0
                },
                new Movie
                {
                    MovieID = 2,
                    MovieName = "Deadpool 2",
                    ImagePath = "deadpool.jpg",
                    Votes = 0
                },
                new Movie
                {
                    MovieID = 3,
                    MovieName = "Incredibles 2",
                    ImagePath = "incredibles.jpg",
                    Votes = 0
                }
            };

            return movies;
        }
    }
}