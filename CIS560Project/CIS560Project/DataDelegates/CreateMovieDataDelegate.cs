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
    internal class CreateMovieDataDelegate : NonQueryDataDelegate<Movie>
    {
        private readonly string MovieName;
        private readonly string Rating;
        private readonly int RunTime;
        private readonly DateTime ReleaseDate;

        public CreateMovieDataDelegate(string movieName, string rating, int runTime, DateTime releaseDate)
            : base("Movie.CreateMovie")
        {
            this.MovieName = movieName;
            this.Rating = rating;
            this.RunTime = runTime;
            this.ReleaseDate = releaseDate;
        }

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

        public override Movie Translate(SqlCommand command)
        {
            return new Movie((int)command.Parameters["MovieId"].Value, MovieName, Rating, RunTime, ReleaseDate);
        }
    }
}
