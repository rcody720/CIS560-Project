using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using CIS560Project.Models;
using System.Data.SqlClient;
using System.Data;

namespace CIS560Project.DataDelegates
{
    /// <summary>
    /// GetShowingsDataDelegate.cs is a delegate that handles
    /// interacting with the Movies.GetShowings sql procedure.
    /// </summary>
    internal class GetShowingsDataDelegate : DataReaderDelegate<IReadOnlyList<(string, (string, string))>>
    {
        private readonly DateTime CurrentDate;

        /// <summary>
        /// Constructor for the class
        /// </summary>
        /// <param name="currentDate">The date the user is looking for showtimes on</param>
        public GetShowingsDataDelegate(DateTime currentDate)
            : base("Movies.GetShowings")
        {
            this.CurrentDate = currentDate;
        }

        /// <summary>
        /// Method to add parameters to the command.
        /// </summary>
        /// <param name="command">Sql command</param>
        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
            var p = command.Parameters.Add("Date", SqlDbType.Date);
            p.Value = CurrentDate;
        }

        /// <summary>
        /// Method to create the objects with the information 
        /// returned from the sql procedure.
        /// </summary>
        /// <param name="command">The Sql command</param>
        /// <param name="reader">The data row reader</param>
        /// <returns>The list of movie titles, theater names, and showtimes for the specified date</returns>
        public override IReadOnlyList<(string, (string, string))> Translate(SqlCommand command, IDataRowReader reader)
        {
            var showings = new List<(string, (string, string))>();

            while (reader.Read())
            {
                showings.Add((reader.GetString("MovieTitle"), (reader.GetString("TheaterName"), reader.GetString("ShowTime"))));
            }

            return showings;
        }
    }
}

