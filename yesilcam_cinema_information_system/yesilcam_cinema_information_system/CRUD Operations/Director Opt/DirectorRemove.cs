using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace yesilcam_cinema_information_system.CRUD_Operations.Director_Opt
{
    
    internal class DirectorRemove
    {
        private DatabaseConnection dbConnection;
        public DirectorRemove()
        {
            dbConnection = new DatabaseConnection("localhost", 5432, "yesilcamCinemaInformationSystem", "postgres", "erdem123");
        }
        public void RemoveDirector(int directorId)
        {
            try
            {
                // Bağlantıyı aç
                dbConnection.OpenConnection();

                // DELETE sorgusunu hazırla
                string query = "DELETE FROM director WHERE directorid = @directorid";

                // Sorguyu ve bağlantıyı kullanarak bir NpgsqlCommand oluştur
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, dbConnection.GetConnection()))
                {
                    // Parametreleri ekle
                    cmd.Parameters.AddWithValue("@directorid", directorId);

                    // Komutu çalıştır
                    cmd.ExecuteNonQuery();
                }

                Console.WriteLine("Yönetmen başarıyla silindi.");
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
