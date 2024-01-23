using System;
using System.Data;
using Npgsql;

namespace yesilcam_cinema_information_system.Get
{
    internal class GetMovies
    {
        private DatabaseConnection dbConnection;
        private NpgsqlDataAdapter dataAdapter;
        private DataSet dataSet;

        public GetMovies()
        {
            dbConnection = new DatabaseConnection("localhost", 5432, "yesilcamCinemaInformationSystem", "postgres", "erdem123");
            dataAdapter = new NpgsqlDataAdapter();
            dataSet = new DataSet();
        }

        public DataTable GetMoviesWithGenres()
        {
            DataTable moviesTable = new DataTable();

            try
            {
                // Bağlantıyı aç
                dbConnection.OpenConnection();

                // Veri setini temizle
                dataSet.Clear();

                // Verileri çek
                string query = "SELECT Movie.*, MovieGenre.movieGenreName " +
                               "FROM Movie " +
                               "INNER JOIN MovieGenre ON Movie.movieGenreId = MovieGenre.movieGenreId";

                dataAdapter.SelectCommand = new NpgsqlCommand(query, dbConnection.GetConnection());
                dataAdapter.Fill(dataSet, "MoviesWithGenres");

                // DataTable'a veri setini atla
                moviesTable = dataSet.Tables["MoviesWithGenres"];
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

            return moviesTable;
        }

    }
}
