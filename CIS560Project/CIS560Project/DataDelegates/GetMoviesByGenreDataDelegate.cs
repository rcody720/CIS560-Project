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
    internal class GetMoviesByGenreDataDelegate : DataReaderDelegate<IReadOnlyList<Movie>>
    {
        private readonly string Genre;

        public GetMoviesByGenreDataDelegate(string genre)
            : base("Movies.GetMoviesByGenre")
        {
            this.Genre = genre;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("Genre", SqlDbType.NVarChar);
            p.Value = Genre;
        }

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
