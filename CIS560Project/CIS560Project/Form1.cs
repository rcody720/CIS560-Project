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
    public partial class uxOutputLabel : Form
    {
        private readonly SqlMovieRepository MovieRepo = new SqlMovieRepository(@"Server=(localdb)\MSSQLLocalDb;Integrated Security=False;");
        private readonly SqlDirectorRepository DirectorRepo = new SqlDirectorRepository(@"Server=(localdb)\MSSQLLocalDb;Integrated Security=False;");
        public uxOutputLabel()
        {
            InitializeComponent();

            Dictionary<Movie, double> movies = MovieRepo.GetRecentMovies();
            foreach(var item in movies)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("{0}    {1:F1}", item.Key.MovieName, item.Value);
                uxTopTenListView.Items.Add(sb.ToString());
            }
            
            
        }

        private void uxSearchButton_Click(object sender, EventArgs e)
        {
            if(uxSearchTextbox.Text != "")
            {
                Movie result = MovieRepo.GetMovie(uxSearchTextbox.Text);
                uxTopTenListView.Items.Clear();
                uxTopTenListView.Items.Add(string.Format("Movie: {0}\nRating: {1}\nRunTime: {2}\nReleaseDate: {3}",
                    result.MovieName, result.Rating, result.RunTime.ToString(), result.ReleaseDate.ToShortDateString()));
            }
            else if (uxMovieIdTextbox.Text != "")
            {
                Movie result = MovieRepo.FetchMovie(Convert.ToInt32(uxMovieIdTextbox.Text));
                uxTopTenListView.Items.Clear();
                uxTopTenListView.Items.Add(string.Format("Movie: {0}\nRating: {1}\nRunTime: {2}\nReleaseDate: {3}", 
                    result.MovieName, result.Rating, result.RunTime.ToString(), result.ReleaseDate.ToShortDateString()));
            }
            else if (uxGenreComboBox.Text != "")
            {
                IReadOnlyList<Movie> result = MovieRepo.GetMovies(uxGenreComboBox.SelectedItem.ToString());
                uxTopTenListView.Clear();
                foreach (Movie m in result)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendFormat("{0}  {1}  {2}  {3}", m.MovieName, m.Rating, m.RunTime.ToString(), m.ReleaseDate.ToShortDateString());
                    uxTopTenListView.Items.Add(sb.ToString());
                }
            }
            else if (uxActorTextbox.Text != "")
            {
                string[] actorName = uxActorTextbox.Text.Split(' ');
                IReadOnlyList<Movie> result = MovieRepo.GetMovies(actorName[0], actorName[1]);
                uxTopTenListView.Clear();
                foreach (Movie m in result)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendFormat("{0}  {1}  {2}  {3}", m.MovieName, m.Rating, m.RunTime.ToString(), m.ReleaseDate.ToShortDateString());
                    uxTopTenListView.Items.Add(sb.ToString());
                }
            }
            else
            {
                IReadOnlyList<Movie> result = MovieRepo.RetrieveMovies();
                uxTopTenListView.Items.Clear();
                foreach(Movie m in result)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendFormat("{0}  {1}  {2}  {3}", m.MovieName, m.Rating, m.RunTime.ToString(), m.ReleaseDate.ToShortDateString());
                    uxTopTenListView.Items.Add(sb.ToString());
                }
            }

            uxSearchTextbox.Clear();
            uxMovieIdTextbox.Clear();
            uxGenreComboBox.SelectedItem = "";
        }

        private void uxMovieEarningsButton_Click(object sender, EventArgs e)
        {
            Dictionary<Movie, double> result = MovieRepo.GetTheaterSales();
            uxTopTenListView.Items.Clear();
            foreach (var item in result)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("{0} - {1:C2}{2}", item.Key.ToString(), item.Value, Environment.NewLine);
                uxTopTenListView.Items.Add(sb.ToString());
            }
        }

        private void uxMostPopularDirectorsButton_Click(object sender, EventArgs e)
        {
            IReadOnlyList<Director> result = DirectorRepo.GetDirectorRatings();
            uxTopTenListView.Items.Clear();
            foreach (Director d in result)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("{0} {1}{2}", d.FirstName, d.LastName, Environment.NewLine);
                uxTopTenListView.Items.Add(sb.ToString());
            }
        }

        private void uxTotalEarningsPerRuntimeGroups_Click(object sender, EventArgs e)
        {
            Dictionary<string, double> result = MovieRepo.GetEarningsRankingsBasedOnRuntime();
            uxTopTenListView.Items.Clear();
            foreach (var item in result)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("{0} - {1:C2}{2}", item.Key.ToString(), item.Value, Environment.NewLine);
                uxTopTenListView.Items.Add(sb.ToString());
            }
        }

        private void uxDatePicker_ValueChanged(object sender, EventArgs e)
        {
            IReadOnlyList<(string, (string, string))> result = MovieRepo.GetShowings(uxDatePicker.Value);
            uxTopTenListView.Items.Clear();
            foreach(var item in result)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("{0} - {1} : {2}", item.Item1, item.Item2.Item1, item.Item2.Item2);
                uxTopTenListView.Items.Add(sb.ToString());
            }
        }

        private void uxAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                Movie result = MovieRepo.CreateMovie(uxMovieTitleTextbox.Text, uxRatingTextbox.Text, Convert.ToInt32(uxRuntimeMinutesTextbox.Text), uxReleaseDatePicker.Value);
                uxTopTenListView.Items.Clear();
                uxTopTenListView.Items.Add(string.Format("{0}  {1}  {2}  {3}", result.MovieName, result.Rating, result.RunTime.ToString(), result.ReleaseDate.ToShortDateString()));
            }
            catch
            {
                MessageBox.Show("Invalid Input. Try again.");
            }

            uxMovieTitleTextbox.Text = "";
            uxRatingTextbox.Text = "";
            uxRuntimeMinutesTextbox.Text = "";
        }
    }
}
