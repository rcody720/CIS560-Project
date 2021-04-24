using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560Project.Models
{
    public class MovieTheater
    {
        public int MovieId { get; }

        public int TheaterId { get; }

        public int TicketsSold { get; }

        public string ShowTimes { get; }

        public DateTime ShowingFromDate { get; }

        public DateTime ShowingToDate { get; }

        public MovieTheater(int movieId, int theaterId, int ticketsSold, string showTimes, DateTime showingFromDate, DateTime showingToDate)
        {
            this.MovieId = movieId;
            this.TheaterId = theaterId;
            this.TicketsSold = ticketsSold;
            this.ShowTimes = showTimes;
            this.ShowingFromDate = showingFromDate;
            this.ShowingToDate = showingToDate;
        }
    }
}
