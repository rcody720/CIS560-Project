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
    /// <summary>
    /// CreateDirectorDataDelegate.cs is a delegate that handles
    /// interacting with the Movies.CreateDirector sql procedure.
    /// </summary>
    internal class CreateDirectorDataDelegate : DataDelegate
    {
        private string DirectorFirst;
        private string DirectorLast;

        /// <summary>
        /// Constructor for the class
        /// </summary>
        /// <param name="directorFirst">Director's first name</param>
        /// <param name="directorLast">Director's last name</param>
        public CreateDirectorDataDelegate(string directorFirst, string directorLast)
            :base ("Movies.CreateDirector")
        {
            this.DirectorFirst = directorFirst;
            this.DirectorLast = directorLast;
        }

        /// <summary>
        /// Method to add parameters to the command.
        /// </summary>
        /// <param name="command">Sql command</param>
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
