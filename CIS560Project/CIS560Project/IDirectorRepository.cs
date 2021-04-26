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
        IReadOnlyList<Director> GetDirectorRatings();
    }
}
