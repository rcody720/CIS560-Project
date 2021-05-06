using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560Project.Models
{
    public class MovieGenre
    {
        public int MovieId { get; }

        public int GenreId { get; }

        /// <summary>
        /// MovieGenre constructor
        /// </summary>
        /// <param name="movieId"></param>
        /// <param name="genreId"></param>
        public MovieGenre(int movieId, int genreId)
        {
            this.MovieId = movieId;
            this.GenreId = genreId;
        }
    }
}
