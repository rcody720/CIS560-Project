using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using CIS560Project.DataDelegates;
using CIS560Project.Models;


namespace CIS560Project
{
    public class SqlDirectorRepository : IDirectorRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlDirectorRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public IReadOnlyList<Director> GetDirectorRatings()
        {
            var d = new GetDirectorRatings();
            return executor.ExecuteReader(d);
        }
    }
}
