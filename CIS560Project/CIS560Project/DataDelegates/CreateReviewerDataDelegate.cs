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
    public class CreateReviewerDataDelegate: DataDelegate
    {
        public readonly string Username;
        public CreateReviewerDataDelegate(string username)
            : base("Movies.CreateReviewer")
        {
            this.Username = username;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("Username", SqlDbType.NVarChar);
            p.Value = Username;
        }
    }
}
