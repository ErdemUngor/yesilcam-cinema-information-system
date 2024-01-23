// RatingList.cs
using System;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Npgsql;

namespace yesilcam_cinema_information_system.GetFunction
{
    internal class RatingList
    {
        private DatabaseConnection dbConnection;
        private NpgsqlDataAdapter dataAdapter;
        private DataSet dataSet;

        public RatingList()
        {
            dbConnection = new DatabaseConnection("localhost", 5432, "yesilcamCinemaInformationSystem", "postgres", "erdem123");
            dataAdapter = new NpgsqlDataAdapter();
            dataSet = new DataSet();

        }

        public void FillDataGridView(DataGridView dataGridView, int categoryId)
        {

            //Resmi Ölçeklendirme
            if (dataGridView.Columns.Contains("moviePoster"))
            {
                DataGridViewImageColumn moviePoster = (DataGridViewImageColumn)dataGridView.Columns["moviePoster"];
                moviePoster.ImageLayout = DataGridViewImageCellLayout.Zoom; // Resmi ölçeklendir

                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // Sütun genişliklerini otomatik ayarla
            }
            try
            {
                dbConnection.OpenConnection();

                // Veri setini temizle
                dataSet.Clear();

                // Filmleri çek
                string query = "SELECT * FROM Movie WHERE movieGenreId = @movieGenreId ORDER BY movieRating DESC LIMIT 10";
                dataAdapter.SelectCommand = new NpgsqlCommand(query, dbConnection.GetConnection());
                dataAdapter.SelectCommand.Parameters.AddWithValue("@movieGenreId", categoryId);
                dataAdapter.Fill(dataSet, "MoviesByCategory");

                // DataTable'a veri setini atla
                DataTable moviesTable = dataSet.Tables["MoviesByCategory"];

                // DataGridView'e yeni veriyi ata
                dataGridView.DataSource = moviesTable;


            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
            }
            finally
            {
                // Bağlantıyı kapat
                dbConnection.CloseConnection();
            }
        }
        public void FillCategories(ComboBox cmbCategory)
        {
            try
            {
                dbConnection.OpenConnection();

                // Veri setini temizle
                dataSet.Clear();

                // Kategorileri çek
                string query = "SELECT * FROM MovieGenre";
                dataAdapter.SelectCommand = new NpgsqlCommand(query, dbConnection.GetConnection());
                DataSet genreDataSet = new DataSet();
                dataAdapter.Fill(genreDataSet, "MovieGenres");

                // ComboBox'ı verilerle doldur
                cmbCategory.DisplayMember = "movieGenreName"; // Burada genreName sütununu seçiyorsunuz, doğru olduğundan emin olun
                cmbCategory.ValueMember = "movieGenreId"; // Burada genreId sütununu seçiyorsunuz, doğru olduğundan emin olun
                cmbCategory.DataSource = genreDataSet.Tables["MovieGenres"];
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
            }
            finally
            {
                // Bağlantıyı kapat
                dbConnection.CloseConnection();
            }
        }



    }
}
