using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data.SqlClient;
using CIS560Project.Models;

namespace CIS560Project.DataDelegates
{
    internal class RetrieveMoviesDataDelegate : DataReaderDelegate<IReadOnlyList<Movie>>
    {
        public RetrieveMoviesDataDelegate()
            : base("Movies.RetrieveMovies")
        {
        }

        public override IReadOnlyList<Movie> Translate(SqlCommand command, IDataRowReader reader)
        {
            var movies = new List<Movie>();

            while (reader.Read())
            {
                movies.Add(new Movie(reader.GetInt32("MovieId"), reader.GetString("MovieTitle"), reader.GetString("Rating"), reader.GetInt32("RuntimeMinutes"), reader.GetDateTime("ReleaseDate")));
            }

            return movies;
        }
    }
}
