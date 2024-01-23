using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yesilcam_cinema_information_system.Get;

namespace yesilcam_cinema_information_system.CRUD_Operations.Director_Opt
{
    internal class DirectorUpdates
    {

        private DatabaseConnection dbConnection;

        public DirectorUpdates()
        {
            dbConnection = new DatabaseConnection("localhost", 5432, "yesilcamCinemaInformationSystem", "postgres", "erdem123");
        }

        public void UpdateDirector(int directorId, string directorName, DateTime directorDateOfBirth, string directorGender, int awardscount, DataGridView dataGridView)
        {
            try
            {
                // Bağlantıyı aç
                dbConnection.OpenConnection();

                // UPDATE sorgusunu hazırla
                string query = "UPDATE director " +
                               "SET directorname = @directorname, directordateofbirth = @directordateofbirth, directorgender = @directorgender, " +
                               "awardscount = @awardscount " +
                               "WHERE directorid = @directorid";

                // Sorguyu ve bağlantıyı kullanarak bir NpgsqlCommand oluştur
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, dbConnection.GetConnection()))
                {
                    // Parametreleri ekle
                    cmd.Parameters.AddWithValue("@directorid", directorId);
                    cmd.Parameters.AddWithValue("@directorname", directorName);
                    cmd.Parameters.AddWithValue("@directordateofbirth", directorDateOfBirth);
                    cmd.Parameters.AddWithValue("@directorgender", directorGender);
                    cmd.Parameters.AddWithValue("@directorawards", awardscount);

                    // Komutu çalıştır
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Yönetmen başarıyla güncellendi.", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Güncellenmiş yönetmen listesini göster
                GetDirector getDirectors = new GetDirector();
                dataGridView.DataSource = getDirectors.GetAllDirectors();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
                MessageBox.Show("Yönetmen güncellenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Bağlantıyı kapat
                dbConnection.CloseConnection();
            }
        }
    }
}
