using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CIS560Project.Models;

namespace CIS560Project
{
    public partial class Form1 : Form
    {
        private readonly SqlMovieRepository MovieRepo = new SqlMovieRepository(@"Server=(localdb)\MSSQLLocalDb;Integrated Security=False;");
        private readonly SqlDirectorRepository DirectorRepo = new SqlDirectorRepository(@"Server=(localdb)\MSSQLLocalDb;Integrated Security=False;");
        public Form1()
        {
            InitializeComponent();

            Dictionary<Movie, double> movies = MovieRepo.GetRecentMovies();

            foreach(var item in movies)
            {
                uxTopTenListView.Items.Add("{0}\t{1}", item.Key.MovieName, item.Value.ToString());
            }
            
        }

        private void uxSearchButton_Click(object sender, EventArgs e)
        {
            if(uxSearchTextbox.Text != "")
            {
                Movie result = MovieRepo.GetMovie(uxSearchTextbox.Text);
                MessageBox.Show(string.Format("Movie: {0}\nRating: {1}\nRunTime: {2}\nReleaseDate: {3}",
                    result.MovieName, result.Rating, result.RunTime.ToString(), result.ReleaseDate));
            }
            else if (uxMovieIdTextbox.Text != "")
            {
                Movie result = MovieRepo.FetchMovie(Convert.ToInt32(uxMovieIdTextbox.Text));
                MessageBox.Show(string.Format("Movie: {0}\nRating: {1}\nRunTime: {2}\nReleaseDate: {3}", 
                    result.MovieName, result.Rating, result.RunTime.ToString(), result.ReleaseDate));
            }
            else
            {
                IReadOnlyList<Movie> result = MovieRepo.RetrieveMovies();
                StringBuilder sb = new StringBuilder();
                foreach(Movie m in result)
                {
                    sb.AppendFormat("{0}{1}{2}{3}{4}{5}{6}{7}{8}", m.MovieName, Environment.NewLine, m.Rating, Environment.NewLine,
                        m.RunTime.ToString(), Environment.NewLine, m.ReleaseDate, Environment.NewLine, Environment.NewLine);
                }
                MessageBox.Show(sb.ToString());
            }
            
        }

        private void uxMovieEarningsButton_Click(object sender, EventArgs e)
        {
            Dictionary<Movie, double> result = MovieRepo.GetTheaterSales();
            StringBuilder sb = new StringBuilder();
            foreach(var item in result)
            {
                sb.AppendFormat("{0} - {1}{2}", item.Key.ToString(), item.Value, Environment.NewLine);
            }
            MessageBox.Show(sb.ToString().TrimEnd());
        }

        private void uxMostPopularDirectorsButton_Click(object sender, EventArgs e)
        {
            IReadOnlyList<Director> result = DirectorRepo.GetDirectorRatings();
            StringBuilder sb = new StringBuilder();
            foreach(Director d in result)
            {
                sb.AppendFormat("{0} {1}{2}", d.FirstName, d.LastName, Environment.NewLine);
            }
            MessageBox.Show(sb.ToString().TrimEnd());
        }

        private void uxTotalEarningsPerRuntimeGroups_Click(object sender, EventArgs e)
        {
            Dictionary<string, double> result = MovieRepo.GetEarningsRankingsBasedOnRuntime();
            StringBuilder sb = new StringBuilder();
            foreach (var item in result)
            {
                sb.AppendFormat("{0} - {1}{2}", item.Key.ToString(), item.Value, Environment.NewLine);
            }
            MessageBox.Show(sb.ToString().TrimEnd());
        }
    }
}
