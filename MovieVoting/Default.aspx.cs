using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Linq;
using MovieVoting.Models;
using MovieVoting.Logic;

namespace MovieVoting
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Movie> GetMovies()
        {
            var _db = new MovieVoting.Models.MovieContext();
            IQueryable<Movie> query = _db.Movies;
            return query;
        }
    }
}