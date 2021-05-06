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
    /// GetMoviesByGenreDataDelegate.cs is a delegate that handles
    /// interacting with the Movies.GetMoviesByGenre sql procedure.
    /// </summary>
    internal class GetMoviesByGenreDataDelegate : DataReaderDelegate<IReadOnlyList<Movie>>
    {
        private readonly string Genre;

        /// <summary>
        /// Constructor for the class
        /// </summary>
        /// <param name="genre">The genre of movie being searched for</param>
        public GetMoviesByGenreDataDelegate(string genre)
            : base("Movies.GetMoviesByGenre")
        {
            this.Genre = genre;
        }

        /// <summary>
        /// Method to add parameters to the command.
        /// </summary>
        /// <param name="command">Sql command</param>
        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("Genre", SqlDbType.NVarChar);
            p.Value = Genre;
        }

        /// <summary>
        /// Method to create the objects with the information 
        /// returned from the sql procedure.
        /// </summary>
        /// <param name="command">The Sql command</param>
        /// <param name="reader">The data row reader</param>
        /// <returns>The list of movies in the specified genre</returns>
        public override IReadOnlyList<Movie> Translate(SqlCommand command, IDataRowReader reader)
        {
            var movies = new List<Movie>();

            while (reader.Read())
            {
                movies.Add(new Movie(reader.GetInt32("MovieId"), reader.GetString("MovieTitle"), 
                                     reader.GetString("Rating"), reader.GetInt32("RuntimeMinutes"),
                                     reader.GetDateTime("ReleaseDate")));
            }

            return movies;
        }
    }
}
