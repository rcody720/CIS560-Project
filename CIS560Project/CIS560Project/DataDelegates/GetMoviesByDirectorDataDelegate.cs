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
    internal class GetMoviesByDirectorDataDelegate : DataReaderDelegate<IReadOnlyList<Movie>>
    {
        private readonly string FirstName;
        private readonly string LastName;

        public GetMoviesByDirectorDataDelegate(string firstName, string lastName)
            : base("Movies.GetMoviesByDirector")
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("DirectorFirst", SqlDbType.NVarChar);
            p.Value = FirstName;

            p = command.Parameters.Add("DirectorLast", SqlDbType.NVarChar);
            p.Value = LastName;
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
