using CIS560Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560Project
{
    public class SqlMovieRepository : IMovieRepository
    {
        public Movie CreateMovie(int movieId, string movieName, string rating, int runTime, DateTime releaseDate)
        {
            throw new NotImplementedException();
        }

        public Movie FetchMovie(int movieId)
        {
            throw new NotImplementedException();
        }

        public Movie GetMovie(string movieName)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<Movie> RetrieveMovies()
        {
            throw new NotImplementedException();
        }
    }
}
