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

        public MovieGenre(int movieId, int genreId)
        {
            this.MovieId = movieId;
            this.GenreId = genreId;
        }
    }
}
