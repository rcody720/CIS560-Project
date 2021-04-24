using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560Project.Models
{
    public class Reviewer
    {
        public int ReviewerId { get; }

        public string UserName { get; }

        public Reviewer(int reviewerId, string userName)
        {
            this.ReviewerId = reviewerId;
            this.UserName = userName;
        }
    }
}
