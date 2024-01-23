using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yesilcam_cinema_information_system.Get;
using yesilcam_cinema_information_system.GetFunction;

namespace yesilcam_cinema_information_system.CRUD_Operations.Movie_Opt
{
    public partial class MovieUpdate : Form
    {

        private string posterPath;
        private RatingList ratingList;
        private int selectedMovieId;
        DataGridView dataGridView = new DataGridView();


        public MovieUpdate(int movieId, DataGridView dataGridViews)
        {
            InitializeComponent();
            selectedMovieId = movieId;
            dataGridView = dataGridViews;
            ratingList = new RatingList();
            ratingList.FillCategories(cmbMovieCategory);
            MovieAdd movie = new MovieAdd();
            List<string> directorNames = movie.GetDirectorNames();
            List<string> actressNames = movie.GetActressName();

            // ComboBox'a yönetmen adlarını ekle
            comboBox1.DataSource = new BindingSource(directorNames, null);
            cmbActress.DataSource = new BindingSource(actressNames, null);
        }

        private void btnSelectedMovieUpdate_Click(object sender, EventArgs e)
        {
            int movieId = selectedMovieId;

            byte[] imageBytes = File.ReadAllBytes(posterPath);
            string movieName = txtMovieName.Text;
            DateTime movieReleaseDate = dtpMoveDateTime.Value;
            double movieRating = Convert.ToDouble(nudMovieRating.Value);
            decimal movieBoxOffice = nudMovieBoxOffice.Value;
            int movieGenreId = Convert.ToInt32(cmbMovieCategory.SelectedValue);

            // MovieAdd sınıfını oluştur
            MovieUpdates movieUpdates = new MovieUpdates();
            movieUpdates.UpdateMovie(movieId, movieName, movieReleaseDate, movieRating, movieBoxOffice, imageBytes, movieGenreId, dataGridView);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbMovieCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBrowsePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Title = "Select Movie Poster";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Seçilen posterin yolunu global değişkene atayın
                posterPath = openFileDialog.FileName;
                // TextBox ya da başka bir kontrolde göstermek için
                lblPosterPath.Text = posterPath;
            }
        }

        private void lblPosterPath_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void nudMovieBoxOffice_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudMovieRating_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpMoveDateTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtMovieName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbActress_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MovieUpdate_Load(object sender, EventArgs e)
        {

        }
    }
}
