using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using yesilcam_cinema_information_system.CRUD_Operations.Director_Opt;
using yesilcam_cinema_information_system.Get;
using yesilcam_cinema_information_system.GetFunction;

namespace yesilcam_cinema_information_system.CRUD_Operations.Movie_Opt
{
    public partial class MovieOpf : Form
    {
        GetMovies getMovies = new GetMovies();
        private string posterPath;
        private RatingList ratingList;
        private string selectedDirectorName;



        public MovieOpf()
        {
            InitializeComponent();
            ratingList = new RatingList();
            ratingList.FillCategories(cmbMovieCategory);



            MovieAdd movie = new MovieAdd();
            List<string> directorNames = movie.GetDirectorNames();
            List<string> actressNames = movie.GetActressName();

            // ComboBox'a yönetmen adlarını ekle
            comboBox1.DataSource = new BindingSource(directorNames, null);
            cmbActress.DataSource = new BindingSource(actressNames, null);
        }

        private void MovieOpf_Load(object sender, EventArgs e)
        {

        }

        private void btnMovieList_Click(object sender, EventArgs e)
        {

            dgvMovies.DataSource = getMovies.GetMoviesWithGenres();

            if (dgvMovies.Columns.Contains("moviePoster"))
            {
                DataGridViewImageColumn imageColumn = (DataGridViewImageColumn)dgvMovies.Columns["moviePoster"];
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; // Resmi ölçeklendir

                dgvMovies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // Sütun genişliklerini otomatik ayarla
            }

        }

        private void dgvMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMovies.Rows[e.RowIndex];

                // DataGridView'den moviePoster sütununun değerini al
                byte[] posterBytes = (byte[])row.Cells["moviePoster"].Value;

                // Poster verisini PictureBox'a göster
                if (posterBytes != null && posterBytes.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(posterBytes))
                    {
                        Image img = Image.FromStream(ms);
                        pbMoviePoster.Image = img;

                        // PictureBox'a uygun ölçekleme ayarları
                        pbMoviePoster.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }
                else
                {
                    // Eğer poster verisi null ise ya da boş ise PictureBox'ı temizle
                    pbMoviePoster.Image = null;
                }
            }
        }

        private void pbMoviePoster_Click(object sender, EventArgs e)
        {

        }

        private void btnMovieAdd_Click(object sender, EventArgs e)
        {


            // Buradan seçilen dosyanın yolunu alabilirsiniz.
            // Şimdi bu yolu AddMovie metoduna geçirelim.

            // Diğer film bilgilerini de alalım

            byte[] imageBytes = File.ReadAllBytes(posterPath);
            string movieName = txtMovieName.Text;
            DateTime movieReleaseDate = dtpMoveDateTime.Value;
            double movieRating = Convert.ToDouble(nudMovieRating.Value);
            decimal movieBoxOffice = nudMovieBoxOffice.Value;
            int movieGenreId = Convert.ToInt32(cmbMovieCategory.SelectedValue);

            // MovieAdd sınıfını oluştur
            MovieAdd movieAdd = new MovieAdd();
            string directorName = comboBox1.SelectedItem.ToString();
            string actressName = cmbActress.SelectedItem.ToString();

            movieAdd.AddMovie(movieName, movieReleaseDate, movieRating, movieBoxOffice, imageBytes, movieGenreId, directorName, actressName);






        }


        private void btnBrowsePoster_Click(object sender, EventArgs e)
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

        private void cmbMovieCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMovieBoxOffice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMovieRating_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpMoveDateTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtMovieName_TextChanged(object sender, EventArgs e)
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

        private void nudMovieRating_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudMovieBoxOffice_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSelectedMovieRemove_Click(object sender, EventArgs e)
        {
            if (dgvMovies.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvMovies.SelectedRows[0];
                int movieId = Convert.ToInt32(row.Cells["movieId"].Value);

                MovieRemove movieRemove = new MovieRemove();
                movieRemove.RemoveMovie(movieId);

                //Refresh to data gried
                dgvMovies.DataSource = getMovies.GetMoviesWithGenres();

            }
            else
            {
                MessageBox.Show("Lütfen bir film seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Seçili oyuncunun ID'sini al
            if (dgvMovies.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvMovies.SelectedRows[0];
                int movieid = Convert.ToInt32(row.Cells["movieid"].Value);

                // ActressUpdates formunu oluştur ve seçili oyuncunun ID'sini aktar
                MovieUpdate movieUpdate = new MovieUpdate(movieid, dgvMovies);
                movieUpdate.Show();
            }
            else
            {
                MessageBox.Show("Lütfen bir Film seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmbActress_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
