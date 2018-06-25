using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using MovieVoting.Logic;

namespace MovieVoting
{
    public partial class CastVote : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string ipAddress = Request.UserHostAddress;
            string rawId = Request.QueryString["MovieID"];
            int movieId;
            if (!String.IsNullOrEmpty(rawId) && int.TryParse(rawId, out movieId))
            {
                using ( VoteActions voteActions = new VoteActions())
                {
                    voteActions.VoteMovie(ipAddress, Convert.ToInt16(rawId));
                }

            }
            else
            {
                Debug.Fail("ERROR : We should never get to Vote.aspx without a MovieId.");
                throw new Exception("ERROR : It is illegal to load Vote.aspx without setting a MovieId.");
            }
            Response.Redirect("Default.aspx");
        }
    }
}