using System;
using Npgsql;

namespace yesilcam_cinema_information_system
{
    internal class ActressAdd
    {
        private DatabaseConnection dbConnection;

        public ActressAdd()
        {
            dbConnection = new DatabaseConnection("localhost", 5432, "yesilcamCinemaInformationSystem", "postgres", "erdem123");
        }

        public void AddActress(string actressName, string actressStageName, DateTime actressDateOfBirth, string actressGender, int actressAwards)
        {
            try
            {
                // Tüm gerekli alanları kontrol et
                if (string.IsNullOrWhiteSpace(actressName) || string.IsNullOrWhiteSpace(actressStageName) || actressDateOfBirth == null)
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Bağlantıyı aç
                dbConnection.OpenConnection();

                // INSERT sorgusunu hazırla
                string query = "INSERT INTO actress (actressname, actressstagename, actressdateofbirth, actressgender, actresawards) " +
                               "VALUES (@actressname, @actressstagename, @actressdateofbirth, @actressgender, @actresawards)";

                // Sorguyu ve bağlantıyı kullanarak bir NpgsqlCommand oluştur
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, dbConnection.GetConnection()))
                {
                    // Parametreleri ekle
                    cmd.Parameters.AddWithValue("@actressname", actressName);
                    cmd.Parameters.AddWithValue("@actressstagename", actressStageName);
                    cmd.Parameters.AddWithValue("@actressdateofbirth", actressDateOfBirth);
                    cmd.Parameters.AddWithValue("@actressgender", actressGender);
                    cmd.Parameters.AddWithValue("@actresawards", actressAwards);

                    // Komutu çalıştır
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Oyuncu başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Bağlantıyı kapat
                dbConnection.CloseConnection();
            }
        }


    }
}
