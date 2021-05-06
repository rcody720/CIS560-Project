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
    /// <summary>
    /// FetchMovieDataDelegate.cs is a delegate that handles
    /// interacting with the Movies.FetchMovie sql procedure.
    /// </summary>
    internal class FetchMovieDataDelegate : DataReaderDelegate<Movie>
    {
        private readonly int MovieId;

        /// <summary>
        /// Constructor for the class
        /// </summary>
        /// <param name="movieId">The id of the movie being fetched</param>
        public FetchMovieDataDelegate(int movieId)
            : base("Movies.FetchMovie")
        {
            this.MovieId = movieId;
        }

        /// <summary>
        /// Method to add parameters to the command.
        /// </summary>
        /// <param name="command">Sql command</param>
        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("MovieId", SqlDbType.Int);
            p.Value = MovieId;
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
                throw new RecordNotFoundException(MovieId.ToString());

            return new Movie(MovieId, reader.GetString("MovieTitle"), reader.GetString("Rating"), reader.GetInt32("RuntimeMinutes"), reader.GetDateTime("ReleaseDate"));
        }
    }
}
