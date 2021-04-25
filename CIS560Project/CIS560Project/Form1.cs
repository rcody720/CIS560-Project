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
        private SqlMovieRepository repo = new SqlMovieRepository(@"Server=mssql.cs.ksu.;Database=CIS560;Integrated Security=SSPI;");
        public Form1()
        {
            InitializeComponent();

            IReadOnlyList<Movie> movies = repo.GetRecentMovies();

            foreach(Movie m in movies)
            {
                uxTopTenListView.Items.Add(m.MovieName);
            }
            
        }


    }
}
