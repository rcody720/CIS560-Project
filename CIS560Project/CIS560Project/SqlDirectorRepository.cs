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

        /// <summary>
        /// sqlDirectiryRepository constructor
        /// </summary>
        /// <param name="connectionString"></param>
        public SqlDirectorRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        /// <summary>
        /// retrieves all director from database
        /// </summary>
        /// <returns></returns>
        public IReadOnlyList<Director> GetDirectorRatings()
        {
            var d = new GetDirectorRatings();
            return executor.ExecuteReader(d);
        }
    }
}
