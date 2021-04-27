using CIS560Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIS560Project.DataDelegates;
using DataAccess;

namespace CIS560Project
{
    public class SqlMovieRepository : IMovieRepository
    {

        private readonly SqlCommandExecutor executor;

        public SqlMovieRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public Movie CreateMovie(string movieName, string rating, int runTime, DateTime releaseDate)
        {
            if (string.IsNullOrWhiteSpace(movieName))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(movieName));

            if (string.IsNullOrWhiteSpace(rating))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(rating));

            if (runTime == 0)
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(runTime));

            var cmdd = new CreateMovieDataDelegate(movieName, rating, runTime, releaseDate);
            return executor.ExecuteNonQuery(cmdd);

        }

        public Movie FetchMovie(int movieId)
        {
            var d = new FetchMovieDataDelegate(movieId);
            return executor.ExecuteReader(d);
        }

        public Movie GetMovie(string movieName)
        {
            var d = new GetMovieDataDelegate(movieName);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<Movie> RetrieveMovies()
        {
            var d = new RetrieveMoviesDataDelegate();
            return executor.ExecuteReader(d);
        }

        public Dictionary<Movie, double> GetRecentMovies()
        {
            var d = new GetRecentMoviesDataDelegate();
            return executor.ExecuteReader(d);
        }

        public Dictionary<Movie, double> GetTheaterSales()
        {
            var d = new GetTheaterSalesDataDelegate();
            return executor.ExecuteReader(d);
        }

        public Dictionary<string, double> GetEarningsRankingsBasedOnRuntime()
        {
            var d = new GetEarningsRankingsBasedOnRuntimeDataDelegate();
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<(string, (string, string))> GetShowings(DateTime currentDate)
        {
            var d = new GetShowingsDataDelegate(currentDate);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<Movie> GetMovies(string genre)
        {
            var d = new GetMoviesByGenreDataDelegate(genre);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<Movie> GetMovies(string firstName, string lastName)
        {
            var d = new GetMoviesByActorDataDelegate(firstName, lastName);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<Movie> FetchMovies(string firstName, string lastName)
        {
            var d = new GetMoviesByDirectorDataDelegate(firstName, lastName);
            return executor.ExecuteReader(d);
        }

        public MovieReview CreateUserReview(string username, string movieTitle, double score)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(username));

            if (string.IsNullOrWhiteSpace(movieTitle))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(movieTitle));

            if (score == 0)
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(score));

            var curdd = new CreateUserReviewDataDelegate(username, movieTitle, score);
            return executor.ExecuteNonQuery(curdd);
        }
    }
}
