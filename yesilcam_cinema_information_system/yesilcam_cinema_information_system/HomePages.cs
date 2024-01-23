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
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using yesilcam_cinema_information_system.CRUD_Operations.Director_Opt;
using yesilcam_cinema_information_system.Get;
using yesilcam_cinema_information_system.CRUD_Operations.Movie_Opt;

namespace yesilcam_cinema_information_system
{
    public partial class HomePages : Form
    {
        private DatabaseConnection dbConnection;

        public HomePages()
        {
            InitializeComponent();
            dbConnection = new DatabaseConnection("localhost", 5432, "yesilcamCinemaInformationSystem", "postgres", "erdem123");
            GetMovies movieGetter = new GetMovies();
            dataGridView1.DataSource = movieGetter.GetMoviesWithGenres();

            if (dataGridView1.Columns.Contains("moviePoster"))
            {
                DataGridViewImageColumn imageColumn = (DataGridViewImageColumn)dataGridView1.Columns["moviePoster"];
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; // Resmi ölçeklendir

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // Sütun genişliklerini otomatik ayarla
            }
        }

        private void HomePages_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

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


        private void btnActress_Click_1(object sender, EventArgs e)
        {
            ActressOpf actressOpf = new ActressOpf();
            actressOpf.Show();
        }

        private void pbMoviePoster_Click_1(object sender, EventArgs e)
        {

        }

        private void btnDirector_Click_1(object sender, EventArgs e)
        {
            DirectorOpf directorOpf = new DirectorOpf();
            directorOpf.Show();
        }

        private void btnMovie_Click_1(object sender, EventArgs e)
        {
            MovieOpf movieOpf = new MovieOpf();
            movieOpf.Show();
        }

        private void btnImdbSırala_Click(object sender, EventArgs e)
        {
            Rating rating = new Rating();
            rating.Show();
        }

        private void btnActressView_Click_1(object sender, EventArgs e)
        {
            Actress actressForm = new Actress();
            actressForm.Show();
        }

        private void btnDirectorView_Click(object sender, EventArgs e)
        {
            Director director = new Director();
            director.Show();
        }

        private void btnOneMoreFilm_Click(object sender, EventArgs e)
        {
            OneMoreAct oneMoreAct = new OneMoreAct();
            oneMoreAct.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           

        }
    }
}
