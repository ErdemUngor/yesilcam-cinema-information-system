using System;
using System.Collections.Generic;
using System.Data;
using Npgsql;

namespace yesilcam_cinema_information_system.Get
{
    internal class GetDirector
    {
        private DatabaseConnection dbConnection;
        private NpgsqlDataAdapter dataAdapter;
        private DataSet dataSet;

        public GetDirector()
        {
            dbConnection = new DatabaseConnection("localhost", 5432, "yesilcamCinemaInformationSystem", "postgres", "erdem123");
            dataAdapter = new NpgsqlDataAdapter();
            dataSet = new DataSet();
        }

        public DataTable GetAllDirectors()
        {
            DataTable directorsTable = new DataTable();

            try
            {
                // Bağlantıyı aç
                dbConnection.OpenConnection();

                // Veri setini temizle
                dataSet.Clear();

                // Verileri çek
                string query = "SELECT * FROM Director";
                dataAdapter.SelectCommand = new NpgsqlCommand(query, dbConnection.GetConnection());
                dataAdapter.Fill(dataSet, "Director");

                // DataTable'a veri setini atla
                directorsTable = dataSet.Tables["Director"];
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

            return directorsTable;
        }

        public DataTable GetCollaboratedActorsAndFilmCounts(int directorId)
        {
            DataTable collaboratedActorsTable = new DataTable();

            try
            {
                // Bağlantıyı aç
                dbConnection.OpenConnection();

                // Veri setini temizle
                dataSet.Clear();

                // Verileri çek
                string query = "SELECT a.actressname, COUNT(m.movieid) AS filmcount " +
                               "FROM movie m " +
                               "JOIN moviedirector md ON m.movieid = md.movieid " +
                               "JOIN director d ON md.directorid = d.directorid " +
                               "JOIN movieactress ma ON m.movieid = ma.movieid " +
                               "JOIN actress a ON ma.actressid = a.actressid " +
                               "WHERE d.directorid = @directorId " +
                               "GROUP BY a.actressname";

                NpgsqlCommand command = new NpgsqlCommand(query, dbConnection.GetConnection());
                command.Parameters.AddWithValue("@directorId", directorId);
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dataSet, "CollaboratedActors");

                // DataTable'a veri setini atla
                collaboratedActorsTable = dataSet.Tables["CollaboratedActors"];
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

            return collaboratedActorsTable;
        }
    }
}
