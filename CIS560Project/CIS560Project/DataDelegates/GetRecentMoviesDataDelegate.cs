using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using CIS560Project.Models;
using System.Data;
using System.Data.SqlClient;

namespace CIS560Project.DataDelegates
{
    internal class GetRecentMoviesDataDelegate : DataReaderDelegate<IReadOnlyList<Movie>>
    {

        public GetRecentMoviesDataDelegate()
            : base("Movies.GetRecentMovies")
        {
        }

        public override IReadOnlyList<Movie> Translate(SqlCommand command, IDataRowReader reader)
        {          
            var movies = new List<Movie>();

            while (reader.Read())
            {
                movies.Add(new Movie(reader.GetInt32("MovieId"), reader.GetString("MovieTitle"),
                    reader.GetString("Rating"), reader.GetInt32("RunTime"),
                    reader.GetDateTime("ReleaseDate")));
            }

            return movies;
        }
    }

}
