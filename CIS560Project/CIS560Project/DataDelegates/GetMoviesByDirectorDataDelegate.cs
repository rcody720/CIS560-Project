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
    /// GetMoviesByDirectorDataDelegate.cs is a delegate that handles
    /// interacting with the Movies.GetMoviesByDirector sql procedure.
    /// </summary>
    internal class GetMoviesByDirectorDataDelegate : DataReaderDelegate<IReadOnlyList<Movie>>
    {
        private readonly string FirstName;
        private readonly string LastName;

        /// <summary>
        /// Constructor for the class
        /// </summary>
        /// <param name="firstName">First name of the director being searched for</param>
        /// <param name="lastName">Last name of the director being searched for</param>
        public GetMoviesByDirectorDataDelegate(string firstName, string lastName)
            : base("Movies.GetMoviesByDirector")
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        /// <summary>
        /// Method to add parameters to the command.
        /// </summary>
        /// <param name="command">Sql command</param>
        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("DirectorFirst", SqlDbType.NVarChar);
            p.Value = FirstName;

            p = command.Parameters.Add("DirectorLast", SqlDbType.NVarChar);
            p.Value = LastName;
        }

        /// <summary>
        /// Method to create the objects with the information 
        /// returned from the sql procedure.
        /// </summary>
        /// <param name="command">The Sql command</param>
        /// <param name="reader">The data row reader</param>
        /// <returns>The list of movies the specified director directed</returns>
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
