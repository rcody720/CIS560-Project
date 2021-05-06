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
    /// <summary>
    /// CreateUserReviewDataDelegate.cs is a delegate that handles
    /// interacting with the Movies.CreateUserReview sql procedure.
    /// </summary>
    internal class CreateUserReviewDataDelegate : DataDelegate
    {
        private readonly double Score;
        private readonly string Username;
        private readonly string MovieTitle;

        /// <summary>
        /// Constructor for the class
        /// </summary>
        /// <param name="movieTitle">Title of the movie</param>
        /// <param name="username">The reviewer's username</param>
        /// <param name="score">The score the reviewer is leaving</param>
        public CreateUserReviewDataDelegate(string movieTitle, string username, double score)
            : base("Movies.CreateUserReview")
        {
            this.MovieTitle = movieTitle;
            this.Username = username;
            this.Score = score;
        }

        /// <summary>
        /// Method to add parameters to the command.
        /// </summary>
        /// <param name="command">Sql command</param>
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

    }
}
