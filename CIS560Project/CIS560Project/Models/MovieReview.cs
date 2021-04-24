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

        public int Score { get; }

        public MovieReview(int movieId, int reviewerId, int score)
        {
            this.MovieId = movieId;
            this.ReviewerId = reviewerId;
            this.Score = score;
        }
    }
}
