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
            double less90 = 0;
            double middle = 0;
            double greater120 = 0;
            while (reader.Read())
            {
                string s = reader.GetString("MovieLength");
                if (s == "The Movie is Less Than 90 Minutes")
                {
                    less90 += reader.GetDouble("TicketSales");
                }
                else if (s == "This Movie is Between 90 and 120 Minutes")
                {
                    middle += reader.GetDouble("TicketSales");
                }
                else
                {
                    greater120 += reader.GetDouble("TicketSales");
                }             
            }

            movies.Add("The Movie is Less Than 90 Minutes", less90);
            movies.Add("This Movie is Between 90 and 120 Minutes", middle);
            movies.Add("This Movie is Longer Than 120 minutes", greater120);

            return movies;
        }
    }
}
