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
    /// <summary>
    /// RetrieveMoviesDataDelegate.cs is a delegate that handles
    /// interacting with the Movies.RetrieveMovies sql procedure.
    /// </summary>
    internal class RetrieveMoviesDataDelegate : DataReaderDelegate<IReadOnlyList<Movie>>
    {
        /// <summary>
        /// Constructor for the class
        /// </summary>
        public RetrieveMoviesDataDelegate()
            : base("Movies.RetrieveMovies")
        {
        }

        /// <summary>
        /// Method to create the objects with the information 
        /// returned from the sql procedure.
        /// </summary>
        /// <param name="command">The Sql command</param>
        /// <param name="reader">The data row reader</param>
        /// <returns>The list of all movies in the database</returns>
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
