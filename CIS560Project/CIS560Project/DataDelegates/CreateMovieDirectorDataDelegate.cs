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
    /// <summary>
    /// CreateMovieDirectorDataDelegate.cs is a delegate that handles
    /// interacting with the Movies.CreateMovieDirector sql procedure.
    /// </summary>
    internal class CreateMovieDirectorDataDelegate : DataDelegate
    {
        private string DirectorFirst;
        private string DirectorLast;
        private double DirectorSalary;
        private string MovieTitle;

        /// <summary>
        /// Constructor for the class
        /// </summary>
        /// <param name="directorFirst">Director's first name</param>
        /// <param name="directorLast">Director's last name</param>
        /// <param name="directorSalary">The director's salary</param>
        /// <param name="movieTitle">The title of the movie</param>
        public CreateMovieDirectorDataDelegate(string directorFirst, string directorLast, double directorSalary, string movieTitle)
            : base("Movies.CreateMovieDirector")
        {
            this.DirectorFirst = directorFirst;
            this.DirectorLast = directorLast;
            this.DirectorSalary = directorSalary;
            this.MovieTitle = movieTitle;
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

            p = command.Parameters.Add("DirectorSalary", SqlDbType.Float);
            p.Value = DirectorSalary;

            p = command.Parameters.Add("MovieTitle", SqlDbType.NVarChar);
            p.Value = MovieTitle;
        }
    }
}
