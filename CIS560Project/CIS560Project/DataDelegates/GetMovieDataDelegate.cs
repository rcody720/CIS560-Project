using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;
using System.Data.SqlClient;
using CIS560Project.Models;

namespace CIS560Project.DataDelegates
{
    internal class GetMovieDataDelegate : DataReaderDelegate<Movie>
    {
        private readonly string MovieName;

        public GetMovieDataDelegate(string movieName)
            : base("Movies.GetMovie")
        {
            this.MovieName = movieName;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
            command.Parameters.AddWithValue("MovieName", MovieName);
        }

        public override Movie Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new Movie(reader.GetInt32("MovieId"), MovieName, reader.GetString("Rating"), reader.GetInt32("RunTime"), reader.GetDateTime("ReleaseDate"));
        }
    }
}
