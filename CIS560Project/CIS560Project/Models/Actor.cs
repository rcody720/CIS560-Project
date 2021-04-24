using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560Project.Models
{
    public class Actor
    {
        public int ActorId { get; }
        public string FirstName { get; }
        public string LastName { get; }

        public Actor(int actorid, string firstName, string lastName)
        {
            this.ActorId = actorid;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
