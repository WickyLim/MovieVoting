using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieVoting.Models;

namespace MovieVoting.Logic
{
    public class VoteActions : IDisposable
    {
        private MovieContext _db = new MovieContext();
        public void VoteMovie(String ipAddress, int movieId)
        {
            var voteItem = _db.Votes.SingleOrDefault(v => v.IPAddress == ipAddress);
            if(voteItem == null)
            {
                voteItem = new Vote
                {
                    IPAddress = ipAddress,
                    VotedMovieID = movieId
                };
                _db.Votes.Add(voteItem);

                var votedMovie = _db.Movies.SingleOrDefault(m => m.MovieID == movieId);
                if(votedMovie != null)
                {
                    votedMovie.Votes++;
                }
            }
            else
            {
                var prevMovie = _db.Movies.SingleOrDefault(m => m.MovieID == voteItem.VotedMovieID);
                var newMovie = _db.Movies.SingleOrDefault(m => m.MovieID == movieId);
                if(prevMovie.Votes > 0)
                {

                    prevMovie.Votes--;
                }
                newMovie.Votes++;
                voteItem.VotedMovieID = movieId;
            }
            _db.SaveChanges();
        }

        public void Dispose()
        {
            if (_db != null)
            {
                _db.Dispose();
                _db = null;
            }
        }

        public int GetVotesCount(int movieId)
        {
            return _db.Votes.Where(v => v.VotedMovieID == movieId).Count();
        }
    }
}