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
    /// <summary>
    /// GetTheaterSalesDataDelegate.cs is a delegate that handles
    /// interacting with the Movies.TheaterSalesRank sql procedure.
    /// </summary>
    internal class GetTheaterSalesDataDelegate : DataReaderDelegate<Dictionary<Movie, double>>
    { 
        /// <summary>
        /// Constructor for the class
        /// </summary>
        public GetTheaterSalesDataDelegate()
            : base("Movies.TheaterSalesRank")
        {
        }

        /// <summary>
        /// Method to create the objects with the information 
        /// returned from the sql procedure.
        /// </summary>
        /// <param name="command">The Sql command</param>
        /// <param name="reader">The data row reader</param>
        /// <returns>A dictionary with the Movie as the key and the theater sales as the value</returns>
        public override Dictionary<Movie, double> Translate(SqlCommand command, IDataRowReader reader)
        {
            var movies = new Dictionary<Movie, double>();

            while (reader.Read())
            {
                movies.Add(new Movie(reader.GetInt32("MovieId"), reader.GetString("MovieTitle"), reader.GetString("Rating"),
                    reader.GetInt32("RuntimeMinutes"), reader.GetDateTime("ReleaseDate")), reader.GetDouble("TheaterSales"));
            }

            return movies;
        }
    }
}
