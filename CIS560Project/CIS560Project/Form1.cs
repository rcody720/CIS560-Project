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
        private readonly SqlDirectorRepository DirectorRepo = new SqlDirectorRepository(@"Server=...");
        public Form1()
        {
            InitializeComponent();

            IReadOnlyList<Movie> movies = MovieRepo.GetRecentMovies();

            foreach(Movie m in movies)
            {
                uxTopTenListView.Items.Add(m.MovieName);
            }
            
        }

        private void uxSearchButton_Click(object sender, EventArgs e)
        {
            if(uxSearchTextbox.Text != null)
            {
                Movie result = MovieRepo.GetMovie(uxSearchTextbox.Text);
                MessageBox.Show(string.Format("Movie: {0}\nRating: {1}\nRunTime: {2}\nReleaseDate: {3}",
                    result.MovieName, result.Rating, result.RunTime.ToString(), result.ReleaseDate));
            }
            else if (uxMovieIdTextbox.Text != null)
            {
                Movie result = MovieRepo.FetchMovie(Convert.ToInt32(uxMovieIdTextbox.Text));
                MessageBox.Show(string.Format("Movie: {0}\nRating: {1}\nRunTime: {2}\nReleaseDate: {3}", 
                    result.MovieName, result.Rating, result.RunTime.ToString(), result.ReleaseDate));
            }
            
        }

        private void uxMovieEarningsButton_Click(object sender, EventArgs e)
        {
            Dictionary<Movie, int> result = MovieRepo.GetTheaterSales();
            StringBuilder sb = new StringBuilder();
            foreach(var item in result)
            {
                sb.AppendFormat("{0} - {1}{2}", item.Key, item.Value, Environment.NewLine);
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
    }
}
