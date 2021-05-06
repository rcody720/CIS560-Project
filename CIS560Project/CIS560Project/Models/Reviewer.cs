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

        /// <summary>
        /// Reviewer constructor
        /// </summary>
        /// <param name="reviewerId"></param>
        /// <param name="userName"></param>
        public Reviewer(int reviewerId, string userName)
        {
            this.ReviewerId = reviewerId;
            this.UserName = userName;
        }
    }
}
