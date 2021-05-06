using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using CIS560Project.Models;
using System.Data.SqlClient;

namespace CIS560Project.DataDelegates
{
    /// <summary>
    /// GetDirectorRatings.cs is a delegate that handles
    /// interacting with the Movies.GetDirectorRatings sql procedure.
    /// </summary>
    internal class GetDirectorRatings : DataReaderDelegate<IReadOnlyList<Director>>
    {
        /// <summary>
        /// Constructor for the class
        /// </summary>
        public GetDirectorRatings()
            : base("Movies.DirectorRatings")
        {

        }

        /// <summary>
        /// Method to create the objects with the information 
        /// returned from the sql procedure.
        /// </summary>
        /// <param name="command">The Sql command</param>
        /// <param name="reader">The data row reader</param>
        /// <returns>A list of all the directors in the order of most popular</returns>
        public override IReadOnlyList<Director> Translate(SqlCommand command, IDataRowReader reader)
        {
            var directors = new List<Director>();

            while (reader.Read())
            {
                directors.Add(new Director(reader.GetInt32("DirectorId"), reader.GetString("FirstName"), reader.GetString("LastName")));
            }

            return directors;


        }
    }
}
