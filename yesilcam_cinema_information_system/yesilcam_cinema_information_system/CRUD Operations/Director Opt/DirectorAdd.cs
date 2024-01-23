using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;


namespace yesilcam_cinema_information_system.CRUD_Operations.Director_Opt
{
    internal class DirectorAdd
    {
        private DatabaseConnection dbConnection;

        public DirectorAdd()
        {
            dbConnection = new DatabaseConnection("localhost", 5432, "yesilcamCinemaInformationSystem", "postgres", "erdem123");
        }

        public void AddDirector(string directorName, DateTime directorDateOfBirth, string directorGender, int awardsCount)
        {
            try
            {
                dbConnection.OpenConnection();
                string query = "INSERT INTO director (directorname, directordateofbirth, directorgender, awardscount) " +
                              "VALUES (@directorname, @directordateofbirth, @directorgender, @awardscount)";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, dbConnection.GetConnection()))
                {
                    // Parametreleri ekle
                    cmd.Parameters.AddWithValue("@directorname", directorName);
                    cmd.Parameters.AddWithValue("@directordateofbirth", directorDateOfBirth);
                    cmd.Parameters.AddWithValue("@directorgender", directorGender);
                    cmd.Parameters.AddWithValue("@awardscount", awardsCount);


                    // Komutu çalıştır
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Yönetmen başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

