using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560Project.Models
{
    public class Genre
    {
        public int GenreId { get; }

        public enum GenreName
        {
            Action,
            Animation,
            Comedy,
            Crime,
            Drama,
            Experimental,
            Fantasy,
            Historical,
            Horror,
            Romance,
            ScienceFiction,
            Thriller,
            Western,
            Other
        }

        public GenreName Genrename { get; }

        public Genre(int genreId, GenreName genreName)
        {
            this.GenreId = genreId;
            this.Genrename = genreName;
        }
    }
}
