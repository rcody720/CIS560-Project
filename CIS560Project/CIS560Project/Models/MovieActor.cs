using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560Project.Models
{
    public class MovieActor
    {
        public int MovieId { get; }

        public int ActorId { get; }

        public double Salary { get; }

        /// <summary>
        /// MovieActor constructor
        /// </summary>
        /// <param name="movieId"></param>
        /// <param name="actorId"></param>
        /// <param name="salary"></param>
        public MovieActor(int movieId, int actorId, double salary)
        {
            this.MovieId = movieId;
            this.ActorId = actorId;
            this.Salary = salary;
        }
    }
}
