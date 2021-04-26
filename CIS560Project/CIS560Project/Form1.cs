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
    public partial class uxForm : Form
    {
        private readonly SqlMovieRepository MovieRepo = new SqlMovieRepository(@"Server=(localdb)\MSSQLLocalDb;Integrated Security=False;");
        private readonly SqlDirectorRepository DirectorRepo = new SqlDirectorRepository(@"Server=(localdb)\MSSQLLocalDb;Integrated Security=False;");
        public uxForm()
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
                DisplayMovie(result);
                
            }
            else if (uxMovieIdTextbox.Text != "")
            {
                Movie result = MovieRepo.FetchMovie(Convert.ToInt32(uxMovieIdTextbox.Text));
                DisplayMovie(result);
            }
            else if (uxGenreComboBox.Text != "")
            {
                IReadOnlyList<Movie> result = MovieRepo.GetMovies(uxGenreComboBox.SelectedItem.ToString());
                DisplayMovies(result);
                
            }
            else if (uxActorTextbox.Text != "")
            {
                string[] actorName = uxActorTextbox.Text.Split(' ');
                IReadOnlyList<Movie> result = MovieRepo.GetMovies(actorName[0], actorName[1]);
                DisplayMovies(result);
            }
            else
            {
                IReadOnlyList<Movie> result = MovieRepo.RetrieveMovies();
                DisplayMovies(result);
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

        private void DisplayMovie(Movie m)
        {
            uxTopTenListView.Items.Clear();
            uxTopTenListView.Items.Add(string.Format("Movie: {0}\nRating: {1}\nRunTime: {2}\nReleaseDate: {3}",
                m.MovieName, m.Rating, m.RunTime.ToString(), m.ReleaseDate.ToShortDateString()));
        }

        private void DisplayMovies(IReadOnlyList<Movie> movies)
        {
            uxTopTenListView.Clear();
            foreach (Movie m in movies)
            {                
                uxTopTenListView.Items.Add(string.Format("{0}  {1}  {2}  {3}",
                m.MovieName, m.Rating, m.RunTime.ToString(), m.ReleaseDate.ToShortDateString()));
            }
        }
    }
}
