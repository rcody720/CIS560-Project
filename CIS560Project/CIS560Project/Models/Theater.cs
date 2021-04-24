using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560Project.Models
{
    public class Theater
    {
        public int TheaterId { get; }

        public double TicketPrice { get; }

        public Theater(int theaterId, double ticketPrice)
        {
            this.TheaterId = theaterId;
            this.TicketPrice = ticketPrice;
        }
    }
}
