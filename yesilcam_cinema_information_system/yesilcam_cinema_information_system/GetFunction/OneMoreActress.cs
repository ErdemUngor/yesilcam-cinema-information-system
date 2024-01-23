using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace yesilcam_cinema_information_system.Get
{
    internal class OneMoreActress
    {
        private DatabaseConnection dbConnection;
        private NpgsqlDataAdapter dataAdapter;
        private DataSet dataSet;

        public OneMoreActress()
        {
            dbConnection = new DatabaseConnection("localhost", 5432, "yesilcamCinemaInformationSystem", "postgres", "erdem123");
            dataAdapter = new NpgsqlDataAdapter();
            dataSet = new DataSet();
        }
        public DataTable GetActressesWithMovieCount()
        {
            DataTable actressesTable = new DataTable();

            try
            {
                // Bağlantıyı aç
                dbConnection.OpenConnection();

                // Veri setini temizle
                dataSet.Clear();

                // Verileri çek
                string query = "SELECT a.actressname, STRING_AGG(m.moviename, ', ') AS movies " +
                               "FROM movieactress ma " +
                               "JOIN actress a ON ma.actressid = a.actressid " +
                               "JOIN movie m ON ma.movieid = m.movieid " +
                               "GROUP BY a.actressname " +
                               "ORDER BY COUNT(DISTINCT ma.movieid) DESC";

                dataAdapter.SelectCommand = new NpgsqlCommand(query, dbConnection.GetConnection());
                dataAdapter.Fill(dataSet, "ActressesWithMovieCount");

                // DataTable'a veri setini atla
                actressesTable = dataSet.Tables["ActressesWithMovieCount"];
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

            return actressesTable;
        }
    }
}
