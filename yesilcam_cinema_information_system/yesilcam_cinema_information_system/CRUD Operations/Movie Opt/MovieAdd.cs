using System;
using Npgsql;
using System.Windows.Forms;

namespace yesilcam_cinema_information_system.CRUD_Operations.Movie_Opt
{
    internal class MovieAdd
    {
        private DatabaseConnection dbConnection;

        public MovieAdd()
        {
            dbConnection = new DatabaseConnection("localhost", 5432, "yesilcamCinemaInformationSystem", "postgres", "erdem123");
        }


        // Movie Adder
        public void AddMovie(string movieName, DateTime movieReleaseDate, double movieRating, decimal movieBoxOffice, byte[] moviePoster, int movieGenreId, string directorName, string actressName)
        {
            try
            {
                dbConnection.OpenConnection();

                // Yönetmen ID'sini al
                int directorId = GetDirectorIdByName(directorName);
                int actressId = GetActressByName(actressName);

                // Movie tablosuna ekle
                string movieQuery = "INSERT INTO Movie (moviename, moviedatecons, movierating, movieboxoffice, movieposter, moviegenreid) " +
                                    "VALUES (@moviename, @moviedatecons, @movierating, @movieboxoffice, @movieposter, @moviegenreid) " +
                                    "RETURNING movieid";

                using (NpgsqlCommand movieCmd = new NpgsqlCommand(movieQuery, dbConnection.GetConnection()))
                {
                    dbConnection.OpenConnection();
                    movieCmd.Parameters.AddWithValue("@moviename", movieName);
                    movieCmd.Parameters.AddWithValue("@moviedatecons", movieReleaseDate);
                    movieCmd.Parameters.AddWithValue("@movierating", movieRating);
                    movieCmd.Parameters.AddWithValue("@movieboxoffice", movieBoxOffice);
                    movieCmd.Parameters.AddWithValue("@movieposter", moviePoster);
                    movieCmd.Parameters.AddWithValue("@moviegenreid", movieGenreId);

                    int movieId = (int)movieCmd.ExecuteScalar();

                    // MovieDirector tablosuna ekle
                    string directorQuery = "INSERT INTO moviedirector (movieid, directorid) VALUES (@movieid, @directorid)";
                    using (NpgsqlCommand directorCmd = new NpgsqlCommand(directorQuery, dbConnection.GetConnection()))
                    {
                        directorCmd.Parameters.AddWithValue("@movieid", movieId);
                        directorCmd.Parameters.AddWithValue("@directorid", directorId);
                        directorCmd.ExecuteNonQuery();
                    }
                    string actressQuery = "INSERT INTO movieactress (movieid, actressid) VALUES (@movieid, @actressid)";
                    using (NpgsqlCommand actressCmd = new NpgsqlCommand(actressQuery, dbConnection.GetConnection()))
                    {
                        actressCmd.Parameters.AddWithValue("@movieid", movieId);
                        actressCmd.Parameters.AddWithValue("@actressid", actressId);
                        actressCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Film başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }

        // Yönetmen adından yönetmen ID'sini bulan yardımcı fonksiyon
        private int GetDirectorIdByName(string directorName)
        {
            int directorId = -1;
            try
            {
                // Bağlantıyı aç
                dbConnection.OpenConnection();

                // Yönetmen ID'sini çek
                string query = "SELECT directorid FROM director WHERE directorname = @directorname";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, dbConnection.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@directorname", directorName);
                    directorId = (int)cmd.ExecuteScalar();
                }
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

            return directorId;
        }
        private int GetActressByName(string actressName)
        {
            int actressId = -1;
            try
            {
                // Bağlantıyı aç
                dbConnection.OpenConnection();

                // Yönetmen ID'sini çek
                string query = "SELECT actressid FROM actress WHERE actressname = @actressname";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, dbConnection.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@actressname", actressName);
                    actressId = (int)cmd.ExecuteScalar();
                }
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

            return actressId;
        }

        // Director to cmb
        public List<string> GetDirectorNames()
        {
            List<string> directorNames = new List<string>();

            try
            {
                // Bağlantıyı aç
                dbConnection.OpenConnection();

                // Yönetmen adlarını çek
                string query = "SELECT directorname FROM director";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, dbConnection.GetConnection()))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            directorNames.Add(reader["directorname"].ToString());
                        }
                    }
                }
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

            return directorNames;
        }
        public List<string> GetActressName()
        {
            List<string> actressNames = new List<string>();

            try
            {
                // Bağlantıyı aç
                dbConnection.OpenConnection();

                // Yönetmen adlarını çek
                string query = "SELECT actressname FROM actress";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, dbConnection.GetConnection()))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            actressNames.Add(reader["actressname"].ToString());
                        }
                    }
                }
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

            return actressNames;
        }


    }
}
