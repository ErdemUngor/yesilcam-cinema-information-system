using System;
using Npgsql;

namespace yesilcam_cinema_information_system
{
    internal class ActressRemove
    {
        private DatabaseConnection dbConnection;

        public ActressRemove()
        {
            dbConnection = new DatabaseConnection("localhost", 5432, "yesilcamCinemaInformationSystem", "postgres", "erdem123");
        }

        public void RemoveActress(int actressId)
        {
            try
            {
                // Bağlantıyı aç
                dbConnection.OpenConnection();

                // DELETE sorgusunu hazırla
                string query = "DELETE FROM actress WHERE actressid = @actressid";

                // Sorguyu ve bağlantıyı kullanarak bir NpgsqlCommand oluştur
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, dbConnection.GetConnection()))
                {
                    // Parametreleri ekle
                    cmd.Parameters.AddWithValue("@actressid", actressId);

                    // Komutu çalıştır
                    cmd.ExecuteNonQuery();
                }

                Console.WriteLine("Oyuncu başarıyla silindi.");
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
