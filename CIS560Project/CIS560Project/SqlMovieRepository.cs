﻿using CIS560Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIS560Project.DataDelegates;
using DataAccess;

namespace CIS560Project
{
    public class SqlMovieRepository : IMovieRepository
    {

        private readonly SqlCommandExecutor executor;

        public SqlMovieRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public Movie CreateMovie(string movieName, string rating, int runTime, DateTime releaseDate)
        {
            if (string.IsNullOrWhiteSpace(movieName))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(movieName));

            if (string.IsNullOrWhiteSpace(rating))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(rating));

            if (runTime == 0)
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(runTime));

            if (releaseDate == default)
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(rating));

            var cmdd = new CreateMovieDataDelegate(movieName, rating, runTime, releaseDate);
            return executor.ExecuteNonQuery(cmdd);

        }

        public Movie FetchMovie(int movieId)
        {
            throw new NotImplementedException();
        }

        public Movie GetMovie(string movieName)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<Movie> RetrieveMovies()
        {
            throw new NotImplementedException();
        }
    }
}