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
    internal class GetDirectorRatings : DataReaderDelegate<IReadOnlyList<Director>>
    {
        public GetDirectorRatings()
            : base("Movies.DirectorRatings")
        {

        }

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
