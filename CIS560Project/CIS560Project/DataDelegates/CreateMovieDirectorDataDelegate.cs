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
        private string DirectorFirst;
        private string DirectorLast;
        private double DirectorSalary;
        private string MovieTitle;
        public CreateMovieDirectorDataDelegate(string directorFirst, string directorLast, double directorSalary, string movieTitle)
            : base("Movies.CreateMovieDirector")
        {
            this.DirectorFirst = directorFirst;
            this.DirectorLast = directorLast;
            this.DirectorSalary = directorSalary;
            this.MovieTitle = movieTitle;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("DirectorFirst", SqlDbType.NVarChar);
            p.Value = DirectorFirst;

            p = command.Parameters.Add("DirectorLast", SqlDbType.NVarChar);
            p.Value = DirectorLast;

            p = command.Parameters.Add("DirectorSalary", SqlDbType.Float);
            p.Value = DirectorSalary;

            p = command.Parameters.Add("MovieTitle", SqlDbType.NVarChar);
            p.Value = MovieTitle;
        }
    }
}
