using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560Project.Models
{
    public class Movie
    {
        public int MovieId { get; }
        public string MovieName { get; }

        public string Rating { get; }

        public int RunTime { get; }

        public DateTime ReleaseDate { get; }

        /// <summary>
        /// Movie constructor
        /// </summary>
        /// <param name="movieid"></param>
        /// <param name="movieName"></param>
        /// <param name="rating"></param>
        /// <param name="runTime"></param>
        /// <param name="releaseDate"></param>
        public Movie(int movieid, string movieName, string rating, int runTime, DateTime releaseDate)
        {
            this.MovieId = movieid;
            this.MovieName = movieName;
            this.Rating = rating;
            this.RunTime = runTime;
            this.ReleaseDate = releaseDate;
        }

        public override string ToString()
        {
            return MovieName;
        }

    }
}
