using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataAccess;
using System.Data;

namespace CIS560Project.DataDelegates
{
    internal class CreateMovieDirectorDataDelegate : DataDelegate
    {
        public CreateDirectorDataDelegate()
        {

        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);


        }
    }
}
