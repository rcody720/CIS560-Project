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
    internal class GetShowingsDataDelegate : DataReaderDelegate<IReadOnlyList<(string, (string, string))>>
    {
        private readonly DateTime CurrentDate;

        public GetShowingsDataDelegate(DateTime currentDate)
            : base("Movies.GetShowings")
        {
            this.CurrentDate = currentDate;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
            var p = command.Parameters.Add("Date", SqlDbType.Date);
            p.Value = CurrentDate;
        }

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

