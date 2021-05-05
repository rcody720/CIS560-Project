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
    /// <summary>
    /// SqlMovieRepository class that implements IMovieRepository
    /// </summary>
    public class SqlMovieRepository : IMovieRepository
    {

        private readonly SqlCommandExecutor executor;

        /// <summary>
        /// The constructor for SqlMovieRepository
        /// </summary>
        /// <param name="connectionString">string to connect to the database</param>
        public SqlMovieRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        /// <summary>
        /// Creates a new movie in the database.
        /// </summary>
        /// <param name="movieId">Identifier of the movie.</param>
        /// <param name="movieName">Name of the movie.</param>
        /// <param name="rating">MPAA Rating of the movie.</param>
        /// <param name="runTime">Run time of the movie in minutes.</param>
        /// <param name="releaseDate">Date the movie is released.</param>
        /// <returns>The resulting instance of Movie.</returns>
        public Movie CreateMovie(string movieName, string rating, int runTime, DateTime releaseDate, string directorFirst, string directorLast, double directorSalary)
        {
            if (string.IsNullOrWhiteSpace(movieName))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(movieName));

            if (string.IsNullOrWhiteSpace(rating))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(rating));

            if (runTime == 0)
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(runTime));

            if (string.IsNullOrWhiteSpace(directorFirst))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(directorFirst));

            if (string.IsNullOrWhiteSpace(directorLast))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(directorLast));

            var cmdd = new CreateMovieDataDelegate(movieName, rating, runTime, releaseDate);
            CreateDirector(directorFirst, directorLast);
            CreateMovieDirector(directorFirst, directorLast, directorSalary, movieName);

            return executor.ExecuteNonQuery(cmdd);

        }

        /// <summary>
        /// Fetches the movie with the given <paramref name="movieId"/> if it exists.
        /// </summary>
        /// <param name="movieId">Identifier of the movie to fetch.</param>
        /// <returns> An instance of Movie containing the information of the requested movie.</returns>
        public Movie FetchMovie(int movieId)
        {
            var d = new FetchMovieDataDelegate(movieId);
            return executor.ExecuteReader(d);
        }

        /// <summary>
        /// Gets the movie with the given <paramref name="movieName"/> if it exists.
        /// </summary>
        /// <param name="movieName">Name of the movie to get.</param>
        /// <returns>The movie containing the information of the requesetd movie.</returns>
        public Movie GetMovie(string movieName)
        {
            var d = new GetMovieDataDelegate(movieName);
            return executor.ExecuteReader(d);
        }

        /// <summary>
        /// Retrieves all movies from the database.
        /// </summary>
        /// <returns> <see cref="IReadOnlyList{T}"/> containing all movies.</returns>
        public IReadOnlyList<Movie> RetrieveMovies()
        {
            var d = new RetrieveMoviesDataDelegate();
            return executor.ExecuteReader(d);
        }

        /// <summary>
        /// Gets the movies in order of current top scored
        /// </summary>
        /// <returns>Dictionary containing the movies and their respective score</returns>
        public Dictionary<Movie, double> GetRecentMovies()
        {
            var d = new GetRecentMoviesDataDelegate();
            return executor.ExecuteReader(d);
        }

        /// <summary>
        /// Gets the movies along with their theater sales
        /// </summary>
        /// <returns>Dictionary containing the movies and their respective theater sales</returns>
        public Dictionary<Movie, double> GetTheaterSales()
        {
            var d = new GetTheaterSalesDataDelegate();
            return executor.ExecuteReader(d);
        }

        /// <summary>
        /// Gets showtimes for a specific date
        /// </summary>
        /// <param name="currentDate">Specified date to show showtimes for</param>
        /// <returns>List of the movie, the theater name, and the showtimes</returns>
        public IReadOnlyList<(string, (string, string))> GetShowings(DateTime currentDate)
        {
            var d = new GetShowingsDataDelegate(currentDate);
            return executor.ExecuteReader(d);
        }

        /// <summary>
        /// Gets the earnings for 3 categories of runtimes, less than 90, between 90 & 120, and greater than 90.
        /// </summary>
        /// <returns>Dictionary containing the category of runtime and their respective earnings</returns>
        public Dictionary<string, double> GetEarningsRankingsBasedOnRuntime()
        {
            var d = new GetEarningsRankingsBasedOnRuntimeDataDelegate();
            return executor.ExecuteReader(d);
        }

        /// <summary>
        /// Gets the movies of a specified genre
        /// </summary>
        /// <param name="genre">The specified genre</param>
        /// <returns>List of the movies from the desired genre</returns>
        public IReadOnlyList<Movie> GetMovies(string genre)
        {
            var d = new GetMoviesByGenreDataDelegate(genre);
            return executor.ExecuteReader(d);
        }

        /// <summary>
        /// Gets the movies that have a specified actor
        /// </summary>
        /// <param name="firstName">Actor's first name</param>
        /// <param name="lastName">Actor's last name</param>
        /// <returns>List of movies containing the specified actor</returns>
        public IReadOnlyList<Movie> GetMovies(string firstName, string lastName)
        {
            var d = new GetMoviesByActorDataDelegate(firstName, lastName);
            return executor.ExecuteReader(d);
        }

        /// <summary>
        /// Fetchs the movies that have a specified director
        /// </summary>
        /// <param name="firstName">Director's first name</param>
        /// <param name="lastName">Director's last name</param>
        /// <returns>List of movies the specified director directed</returns>
        public IReadOnlyList<Movie> FetchMovies(string firstName, string lastName)
        {
            var d = new GetMoviesByDirectorDataDelegate(firstName, lastName);
            return executor.ExecuteReader(d);
        }

        /// <summary>
        /// Creates a user review for a specific movie
        /// </summary>
        /// <param name="username">User leaving the review</param>
        /// <param name="movieTitle">Title of the movie being reviewed</param>
        /// <param name="score">The score the user is giving</param>
        public void CreateUserReview(string username, string movieTitle, double score)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(username));

            if (string.IsNullOrWhiteSpace(movieTitle))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(movieTitle));

            CreateReviewer(username);

            var d = new CreateUserReviewDataDelegate(movieTitle, username, score);
            executor.ExecuteNonQuery(d);
        }

        /// <summary>
        /// Creates a new reviewer
        /// </summary>
        /// <param name="username">User leaving the review</param>
        public void CreateReviewer(string username)
        {
            var d = new CreateReviewerDataDelegate(username);
            executor.ExecuteNonQuery(d);
        }

        /// <summary>
        /// Adds a Director to the database
        /// </summary>
        /// <param name="directorFirst">The director's first name</param>
        /// <param name="directorLast">The director's last name</param>
        public void CreateDirector(string directorFirst, string directorLast)
        {
            var d = new CreateDirectorDataDelegate(directorFirst, directorLast);
            executor.ExecuteNonQuery(d);
        }

        /// <summary>
        /// Creates a new MovieDirector
        /// </summary>
        /// <param name="directorFirst">The director's first name</param>
        /// <param name="directorLast">The director's last name</param>
        /// <param name="directorSalary">The director's salary</param>
        /// <param name="movieTitle">The title of the movie this director directed</param>
        public void CreateMovieDirector(string directorFirst, string directorLast, double directorSalary, string movieTitle)
        {
            var d = new CreateMovieDirectorDataDelegate(directorFirst, directorLast, directorSalary, movieTitle);
            executor.ExecuteNonQuery(d);
        }
    }
}
