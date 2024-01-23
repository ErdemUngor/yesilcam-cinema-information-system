using Npgsql;
using System;
using System.Windows.Forms;
using yesilcam_cinema_information_system.Get;

namespace yesilcam_cinema_information_system.CRUD_Operations.Movie_Opt
{
    internal class MovieUpdates
    {
        private DatabaseConnection dbConnection;

        public MovieUpdates()
        {
            dbConnection = new DatabaseConnection("localhost", 5432, "yesilcamCinemaInformationSystem", "postgres", "erdem123");
        }

        public void UpdateMovie(int movieId,string movieName, DateTime movieReleaseDate, double movieRating, decimal movieBoxOffice, byte[] moviePoster, int movieGenreId, DataGridView dataGridView)
        {
            try
            {
                // Bağlantıyı aç
                dbConnection.OpenConnection();

                // UPDATE sorgusunu hazırla
             
                string query = "UPDATE movie " +
                               "SET moviename = @moviename, moviedatecons = @moviedatecons, movierating = @movierating, " +
                               "movieboxoffice = @movieboxoffice, movieposter = @movieposter, moviegenreid = @moviegenreid " +
                               "WHERE movieid = @movieid";


                // Sorguyu ve bağlantıyı kullanarak bir NpgsqlCommand oluştur
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, dbConnection.GetConnection()))
                {
                    // Parametreleri ekle
                    cmd.Parameters.AddWithValue("@movieid", movieId);
                    cmd.Parameters.AddWithValue("@moviename", movieName);
                    cmd.Parameters.AddWithValue("@moviedatecons", movieReleaseDate);
                    cmd.Parameters.AddWithValue("@movierating", movieRating);
                    cmd.Parameters.AddWithValue("@movieboxoffice", movieBoxOffice);
                    cmd.Parameters.AddWithValue("@movieposter", moviePoster);
                    cmd.Parameters.AddWithValue("@moviegenreid", movieGenreId);
                    // Komutu çalıştır
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Film başarıyla güncellendi.", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Güncellenmiş film listesini göster
                GetMovies getMovies = new GetMovies();
                dataGridView.DataSource = getMovies.GetMoviesWithGenres();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.ToString());
                MessageBox.Show("Film güncellenirken bir hata oluştu.\n\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                // Bağlantıyı kapat
                dbConnection.CloseConnection();
            }
        }
    }
}
