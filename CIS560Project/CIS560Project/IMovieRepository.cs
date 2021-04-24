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
        /// <returns>The movie containing the information of the requesetd person.</returns>
        Movie GetMovie(string movieName);

        /// <summary>
        /// Creates a new movie in the repository.
        /// </summary>
        /// <param name="movieId">Identifier of the movie.</param>
        /// <param name="movieName">Name of the movie.</param>
        /// <param name="rating">MPAA Rating of the movie.</param>
        /// <param name="runTime">Run time of the movie in minutes.</param>
        /// <param name="releaseDate">Date the movie is released.</param>
        /// <returns>The resulting instance of Movie.</returns>
        Movie CreateMovie(string movieName, string rating, int runTime, DateTime releaseDate);


    }
}
