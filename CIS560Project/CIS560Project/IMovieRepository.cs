using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIS560Project.Models;

namespace CIS560Project
{
    public interface IMovieRepository
    {
        /// <summary>
        /// Retrieves all movies from the database.
        /// </summary>
        /// <returns> <see cref="IReadOnlyList{T}"/> containing all movies.</returns>
        IReadOnlyList<Movie> RetrieveMovies();  

        /// <summary>
        /// Fetches the movie with the given <paramref name="movieId"/> if it exists.
        /// </summary>
        /// <param name="movieId">Identifier of the movie to fetch.</param>
        /// <returns> An instance of Movie containing the information of the requested movie.</returns>
        Movie FetchMovie(int movieId);

        /// <summary>
        /// Gets the movie with the given <paramref name="movieName"/> if it exists.
        /// </summary>
        /// <param name="movieName">Name of the movie to get.</param>
        /// <returns>The movie containing the information of the requesetd movie.</returns>
        Movie GetMovie(string movieName);

        /// <summary>
        /// Creates a new movie in the database.
        /// </summary>
        /// <param name="movieId">Identifier of the movie.</param>
        /// <param name="movieName">Name of the movie.</param>
        /// <param name="rating">MPAA Rating of the movie.</param>
        /// <param name="runTime">Run time of the movie in minutes.</param>
        /// <param name="releaseDate">Date the movie is released.</param>
        /// <returns>The resulting instance of Movie.</returns>
        Movie CreateMovie(string movieName, string rating, int runTime, DateTime releaseDate);

        /// <summary>
        /// Gets the movies in order of current top scored
        /// </summary>
        /// <returns>Dictionary containing the movies and their respective score</returns>
        Dictionary<Movie, double> GetRecentMovies();

        /// <summary>
        /// Gets the movies along with their theater sales
        /// </summary>
        /// <returns>Dictionary containing the movies and their respective theater sales</returns>
        Dictionary<Movie, double> GetTheaterSales();

        /// <summary>
        /// Gets showtimes for a specific date
        /// </summary>
        /// <param name="currentDate">Specified date to show showtimes for</param>
        /// <returns>List of the movie, the theater name, and the showtimes</returns>
        IReadOnlyList<(string, (string, string))> GetShowings(DateTime currentDate);

        /// <summary>
        /// Gets the earnings for 3 categories of runtimes, less than 90, between 90 & 120, and greater than 90.
        /// </summary>
        /// <returns>Dictionary containing the category of runtime and their respective earnings</returns>
        Dictionary<string, double> GetEarningsRankingsBasedOnRuntime();

        /// <summary>
        /// Gets the movies of a specified genre
        /// </summary>
        /// <param name="genre">The specified genre</param>
        /// <returns>List of the movies from the desired genre</returns>
        IReadOnlyList<Movie> GetMovies(string genre);

        /// <summary>
        /// Gets the movies that have a specified actor
        /// </summary>
        /// <param name="firstName">Actor's first name</param>
        /// <param name="lastName">Actor's last name</param>
        /// <returns>List of movies containing the specified actor</returns>
        IReadOnlyList<Movie> GetMovies(string firstName, string lastName);

        /// <summary>
        /// Fetchs the movies that have a specified director
        /// </summary>
        /// <param name="firstName">Director's first name</param>
        /// <param name="lastName">Director's last name</param>
        /// <returns>List of movies the specified director directed</returns>
        IReadOnlyList<Movie> FetchMovies(string firstName, string lastName);

        /// <summary>
        /// Creates a user review for a specific movie
        /// </summary>
        /// <param name="username">User leaving the review</param>
        /// <param name="movieTitle">Title of the movie being reviewed</param>
        /// <param name="score">The score the user is giving</param>
        void CreateUserReview(string username, string movieTitle, double score);

        /// <summary>
        /// Creates a new reviewer
        /// </summary>
        /// <param name="username">User leaving the review</param>
        void CreateReviewer(string username);
    }
}
