using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIS560Project.Models;

namespace CIS560Project
{
    public interface IDirectorRepository
    {
        /// <summary>
        /// retrieves all director from the database
        /// </summary>
        /// <returns></returns>
        IReadOnlyList<Director> GetDirectorRatings();
    }
}
