using System.ComponentModel.DataAnnotations;

namespace MovieVoting.Models
{
    public class Vote
    {
        [Key]
        public string IPAddress { get; set; }

        public int VotedMovieID { get; set; }
    }
}