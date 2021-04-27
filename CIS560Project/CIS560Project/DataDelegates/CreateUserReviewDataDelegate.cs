using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;
using CIS560Project.Models;
using System.Data.SqlClient;

namespace CIS560Project.DataDelegates
{
    internal class CreateUserReviewDataDelegate : NonQueryDataDelegate<MovieReview>
    {
        private readonly double Score;
        private readonly string Username;
        private readonly string MovieTitle;

        public CreateUserReviewDataDelegate(string movieTitle, string username, double score)
            : base("Movies.CreateUserReview")
        {
            this.MovieTitle = movieTitle;
            this.Username = username;
            this.Score = score;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("MovieTitle", SqlDbType.NVarChar);
            p.Value = MovieTitle;

            p = command.Parameters.Add("Username", SqlDbType.NVarChar);
            p.Value = Username;

            p = command.Parameters.Add("Score", SqlDbType.Float);
            p.Value = Score;
        }

        public override MovieReview Translate(SqlCommand command)
        {
            return new MovieReview((int)command.Parameters["MovieId"].Value, (int)command.Parameters["ReviewerId"].Value, Score);
        }
    }
}
