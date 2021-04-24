using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data.SqlClient;
using CIS560Project.Models;
using System.Data;

namespace CIS560Project.DataDelegates
{
    internal class FetchMovieDataDelegate : DataReaderDelegate<Movie>
    {
        private readonly int MovieId;

        public FetchMovieDataDelegate(int movieId)
            : base("Movies.FetchMovie")
        {
            this.MovieId = movieId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("MovieId", SqlDbType.Int);
            p.Value = MovieId;
        }

        public override Movie Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(MovieId.ToString());

            return new Movie(MovieId, reader.GetString("MovieName"), reader.GetString("Rating"), reader.GetInt32("RunTime"), reader.GetDateTime("ReleaseDate"));
        }
    }
}
