using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace yesilcam_cinema_information_system.Get
{
    internal class GetActors
    {
        private DatabaseConnection dbConnection;
        private NpgsqlDataAdapter dataAdapter;
        private DataSet dataSet;

        public GetActors()
        {
            dbConnection = new DatabaseConnection("localhost", 5432, "yesilcamCinemaInformationSystem", "postgres", "erdem123");
            dataAdapter = new NpgsqlDataAdapter();
            dataSet = new DataSet();
        }
        public DataTable GetAllActors()
        {
            DataTable actorsTable = new DataTable();

            try
            {
                // Bağlantıyı aç
                dbConnection.OpenConnection();

                // Veri setini temizle
                dataSet.Clear();

                // Verileri çek
                string query = "SELECT * FROM Actress";
                dataAdapter.SelectCommand = new NpgsqlCommand(query, dbConnection.GetConnection());
                dataAdapter.Fill(dataSet, "Actress");

                // DataTable'a veri setini atla
                actorsTable = dataSet.Tables["Actress"];
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

            return actorsTable;
        }
        public DataTable GetMoviesByActorId(int actorId)
        {
            DataTable moviesTable = new DataTable();

            try
            {
                // Bağlantıyı aç
                dbConnection.OpenConnection();

                // Verileri çek
                string query = "SELECT Movie.* FROM MovieActress " +
                               "JOIN Movie ON MovieActress.movieId = Movie.movieId " +
                               "WHERE MovieActress.actressId = @ActorId";

                dataAdapter.SelectCommand = new NpgsqlCommand(query, dbConnection.GetConnection());
                dataAdapter.SelectCommand.Parameters.AddWithValue("@ActorId", actorId);

                dataAdapter.Fill(dataSet, "MoviesByActor");

                // DataTable'a veri setini atla
                moviesTable = dataSet.Tables["MoviesByActor"];
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
