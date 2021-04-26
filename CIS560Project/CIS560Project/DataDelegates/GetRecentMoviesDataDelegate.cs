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
    internal class GetRecentMoviesDataDelegate : DataReaderDelegate<Dictionary<Movie, double>>
    {

        public GetRecentMoviesDataDelegate()
            : base("Movies.GetRecentMovies")
        {
        }

        public override Dictionary<Movie, double> Translate(SqlCommand command, IDataRowReader reader)
        {
            var movies = new Dictionary<Movie, double>();

            while (reader.Read())
            {
                movies.Add(new Movie(reader.GetInt32("MovieId"), reader.GetString("MovieTitle"),
                    reader.GetString("Rating"), reader.GetInt32("RuntimeMinutes"),
                    reader.GetDateTime("ReleaseDate")), reader.GetDouble("UserScore"));
            }

            return movies;
        }
    }

}
