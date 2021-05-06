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
    /// CreateReviewerDataDelegate.cs is a delegate that handles
    /// interacting with the Movies.CreateReviewer sql procedure.
    /// </summary>
    public class CreateReviewerDataDelegate: DataDelegate
    {
        public readonly string Username;

        /// <summary>
        /// Constructor for the class
        /// </summary>
        /// <param name="username">username of the reviewer</param>
        public CreateReviewerDataDelegate(string username)
            : base("Movies.CreateReviewer")
        {
            this.Username = username;
        }

        /// <summary>
        /// Method to add parameters to the command.
        /// </summary>
        /// <param name="command">Sql command</param>
        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("Username", SqlDbType.NVarChar);
            p.Value = Username;
        }
    }
}
