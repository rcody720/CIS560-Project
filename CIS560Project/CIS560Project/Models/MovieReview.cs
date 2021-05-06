using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560Project.Models
{
    public class MovieReview
    {
        public int MovieId { get; }

        public int ReviewerId { get; }

        public double Score { get; }

        /// <summary>
        /// MovieReview constructor
        /// </summary>
        /// <param name="movieId"></param>
        /// <param name="reviewerId"></param>
        /// <param name="score"></param>
        public MovieReview(int movieId, int reviewerId, double score)
        {
            this.MovieId = movieId;
            this.ReviewerId = reviewerId;
            this.Score = score;
        }
    }
}
