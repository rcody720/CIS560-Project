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
    internal class GetEarningsRankingsBasedOnRuntimeDataDelegate : DataReaderDelegate<Dictionary<string, double>>
    {
        public GetEarningsRankingsBasedOnRuntimeDataDelegate()
            : base("Movies.EarningsRankingsBasedOnRuntime")
        {

        }

        public override Dictionary<string, double> Translate(SqlCommand command, IDataRowReader reader)
        {
            var movies = new Dictionary<string, double>();

            while (reader.Read())
            {
                movies.Add(reader.GetString("MovieLength"), reader.GetDouble("TicketSales"));
            }

            return movies;
        }
    }
}
