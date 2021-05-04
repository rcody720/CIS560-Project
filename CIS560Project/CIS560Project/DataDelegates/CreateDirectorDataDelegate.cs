using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataAccess;
using System.Data;
using CIS560Project.Models;

namespace CIS560Project.DataDelegates
{
    internal class CreateDirectorDataDelegate : DataDelegate
    {
        private string DirectorFirst;
        private string DirectorLast;

        public CreateDirectorDataDelegate(string directorFirst, string directorLast)
            :base ("Movies.CreateDirector")
        {
            this.DirectorFirst = directorFirst;
            this.DirectorLast = directorLast;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("DirectorFirst", SqlDbType.NVarChar);
            p.Value = DirectorFirst;

            p = command.Parameters.Add("DirectorLast", SqlDbType.NVarChar);
            p.Value = DirectorLast;
        }
    }
}
