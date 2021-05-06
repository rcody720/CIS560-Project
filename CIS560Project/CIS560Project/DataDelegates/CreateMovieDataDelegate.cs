using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIS560Project.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace CIS560Project.DataDelegates
{
    /// <summary>
    /// CreateMovieDataDelegate.cs is a delegate that handles
    /// interacting with the Movies.CreateMovie sql procedure.
    /// </summary>
    internal class CreateMovieDataDelegate : NonQueryDataDelegate<Movie>
    {
        private readonly string MovieName;
        private readonly string Rating;
        private readonly int RunTime;
        private readonly DateTime ReleaseDate;

        /// <summary>
        /// Constructor for the class
        /// </summary>
        /// <param name="movieName">The movie title</param>
        /// <param name="rating">The rating of the movie</param>
        /// <param name="runTime">The movie's runtime</param>
        /// <param name="releaseDate">The release date of the movie</param>
        public CreateMovieDataDelegate(string movieName, string rating, int runTime, DateTime releaseDate)
            : base("Movies.CreateMovie")
        {
            this.MovieName = movieName;
            this.Rating = rating;
            this.RunTime = runTime;
            this.ReleaseDate = releaseDate;
        }

        /// <summary>
        /// Method to add parameters to the command.
        /// </summary>
        /// <param name="command">Sql command</param>
        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("MovieName", SqlDbType.NVarChar);
            p.Value = MovieName;

            p = command.Parameters.Add("Rating", SqlDbType.NVarChar);
            p.Value = Rating;

            p = command.Parameters.Add("RunTime", SqlDbType.Int);
            p.Value = RunTime;

            p = command.Parameters.Add("ReleaseDate", SqlDbType.DateTime);
            p.Value = ReleaseDate;

            p = command.Parameters.Add("MovieId", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        /// <summary>
        /// Method to create the objects with the information 
        /// returned from the sql procedure.
        /// </summary>
        /// <param name="command">The Sql command</param>
        /// <returns>The movie created</returns>
        public override Movie Translate(SqlCommand command)
        {
            return new Movie((int)command.Parameters["MovieId"].Value, MovieName, Rating, RunTime, ReleaseDate);
        }
    }
}
