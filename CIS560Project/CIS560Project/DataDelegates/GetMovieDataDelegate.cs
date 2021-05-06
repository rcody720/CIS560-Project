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
    /// <summary>
    /// GetMovieDataDelegate.cs is a delegate that handles
    /// interacting with the Movies.GetMovie sql procedure.
    /// </summary>
    internal class GetMovieDataDelegate : DataReaderDelegate<Movie>
    {
        private readonly string MovieName;

        /// <summary>
        /// Constructor for the class
        /// </summary>
        /// <param name="movieName">Name of the movie being searched for</param>
        public GetMovieDataDelegate(string movieName)
            : base("Movies.GetMovie")
        {
            this.MovieName = movieName;
        }

        /// <summary>
        /// Method to add parameters to the command.
        /// </summary>
        /// <param name="command">Sql command</param>
        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
            command.Parameters.AddWithValue("MovieName", MovieName);
        }

        /// <summary>
        /// Method to create the objects with the information 
        /// returned from the sql procedure.
        /// </summary>
        /// <param name="command">The Sql command</param>
        /// <param name="reader">The data row reader</param>
        /// <returns>The movie being searched for</returns>
        public override Movie Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new Movie(reader.GetInt32("MovieId"), MovieName, reader.GetString("Rating"), reader.GetInt32("RuntimeMinutes"), reader.GetDateTime("ReleaseDate"));
        }
    }
}
