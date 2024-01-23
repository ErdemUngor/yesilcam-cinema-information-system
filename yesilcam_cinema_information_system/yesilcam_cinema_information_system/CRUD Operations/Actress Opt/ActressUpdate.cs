using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;
using yesilcam_cinema_information_system.Get;

namespace yesilcam_cinema_information_system
{
    internal class ActressUpdate
    {
        private DatabaseConnection dbConnection;

        public ActressUpdate()
        {
            dbConnection = new DatabaseConnection("localhost", 5432, "yesilcamCinemaInformationSystem", "postgres", "erdem123");
        }

        public void UpdateActress(int actressId, string actressName, string actressStageName, DateTime actressDateOfBirth, string actressGender, int actressAwards, DataGridView dataGridView)
        {
            try
            {
                // Bağlantıyı aç
                dbConnection.OpenConnection();

                // UPDATE sorgusunu hazırla
                string query = "UPDATE actress " +
                               "SET actressname = @actressname, actressstagename = @actressstagename, actressdateofbirth = @actressdateofbirth, " +
                               "actressgender = @actressgender, actresawards = @actresawards " +
                               "WHERE actressid = @actressid";

                // Sorguyu ve bağlantıyı kullanarak bir NpgsqlCommand oluştur
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, dbConnection.GetConnection()))
                {
                    // Parametreleri ekle
                    cmd.Parameters.AddWithValue("@actressid", actressId);
                    cmd.Parameters.AddWithValue("@actressname", actressName);
                    cmd.Parameters.AddWithValue("@actressstagename", actressStageName);
                    cmd.Parameters.AddWithValue("@actressdateofbirth", actressDateOfBirth);
                    cmd.Parameters.AddWithValue("@actressgender", actressGender);
                    cmd.Parameters.AddWithValue("@actresawards", actressAwards);

                    // Komutu çalıştır
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Oyuncu başarıyla güncellendi.", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Güncellenmiş oyuncu listesini göster
                GetActors getActors = new GetActors();
                dataGridView.DataSource = getActors.GetAllActors();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
                MessageBox.Show("Oyuncu güncellenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Bağlantıyı kapat
                dbConnection.CloseConnection();
            }
        }
    }
}
