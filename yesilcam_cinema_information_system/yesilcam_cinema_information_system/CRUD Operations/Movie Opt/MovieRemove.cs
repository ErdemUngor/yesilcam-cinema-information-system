using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yesilcam_cinema_information_system.CRUD_Operations.Movie_Opt
{
    internal class MovieRemove
    {
        DatabaseConnection dbConnection;
        public MovieRemove()
        {
            dbConnection = new DatabaseConnection("localhost", 5432, "yesilcamCinemaInformationSystem", "postgres", "erdem123");
        }

        public void RemoveMovie(int movieId)
        {
            try
            {
                // Bağlantıyı aç
                dbConnection.OpenConnection();

                // DELETE sorgusunu hazırla
                string query = "DELETE FROM movie WHERE movieid = @movieid";

                // Sorguyu ve bağlantıyı kullanarak bir NpgsqlCommand oluştur
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, dbConnection.GetConnection()))
                {
                    // Parametreleri ekle
                    cmd.Parameters.AddWithValue("@movieid", movieId);

                    // Komutu çalıştır
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Film başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
