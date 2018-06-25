using System.ComponentModel.DataAnnotations;

namespace MovieVoting.Models
{
    public class Movie
    {
        [ScaffoldColumn(false)]
        public int MovieID { get; set; }

        [Required, StringLength(100), Display(Name = "Name")]
        public string MovieName { get; set; }

        public string ImagePath { get; set; }

        public int Votes { get; set; }
    }
}