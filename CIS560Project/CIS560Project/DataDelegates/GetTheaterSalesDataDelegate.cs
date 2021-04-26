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
    internal class GetTheaterSalesDataDelegate : DataReaderDelegate<Dictionary<Movie, int>>
    { 
        public GetTheaterSalesDataDelegate()
            : base("Movies.TheaterSalesRank")
        {
        }

        public override Dictionary<Movie, int> Translate(SqlCommand command, IDataRowReader reader)
        {
            var movies = new Dictionary<Movie, int>();

            while (reader.Read())
            {
                movies.Add(new Movie(reader.GetInt32("MovieId"), reader.GetString("MovieTitle"), reader.GetString("Rating"),
                    reader.GetInt32("RuntimeMinutes"), reader.GetDateTime("ReleaseDate")), reader.GetInt32("TheaterSales"));
            }

            return movies;
        }
    }
}
