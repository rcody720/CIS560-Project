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
        private SqlMovieRepository repo = new SqlMovieRepository(@"Server=mssql.cs.ksu.edu;Database=rcody720;User ID=rcody720;Password=@dr93/cr99&Kr60&Cr53;Integrated Security=False;");
        public Form1()
        {
            InitializeComponent();

            IReadOnlyList<Movie> movies = repo.GetRecentMovies();

            foreach(Movie m in movies)
            {
                uxTopTenListView.Items.Add(m.MovieName);
            }
            
        }

        private void uxSearchButton_Click(object sender, EventArgs e)
        {
            if(uxSearchTextbox.Text != null)
            {
                Movie result = repo.GetMovie(uxSearchTextbox.Text);
                MessageBox.Show(string.Format($"Movie: {0}\n Rating: {1}\nRunTime: {2}\nReleaseDate: {3}",
                    result.MovieName, result.Rating, result.RunTime.ToString(), result.ReleaseDate));
            }
            else if (uxMovieIdTextbox.Text != null)
            {
                Movie result = repo.FetchMovie(Convert.ToInt32(uxMovieIdTextbox.Text));
                MessageBox.Show(string.Format($"Movie: {0}\n Rating: {1}\nRunTime: {2}\nReleaseDate: {3}", 
                    result.MovieName, result.Rating, result.RunTime.ToString(), result.ReleaseDate));
            }
            
        }
    }
}
