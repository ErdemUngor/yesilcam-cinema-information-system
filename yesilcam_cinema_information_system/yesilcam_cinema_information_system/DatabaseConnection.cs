using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;


namespace yesilcam_cinema_information_system
{
    internal class DatabaseConnection
    {
        public DatabaseConnection() { }
        private NpgsqlConnection connection;
        private string connectionString;

        public DatabaseConnection(string host, int port, string database, string username, string password)
        {
            // Bağlantı bilgilerini oluştur
            connectionString = $"Host={host};Port={port};Database={database};Username={username};Password={password}";
            connection = new NpgsqlConnection(connectionString);
        }
        public NpgsqlConnection GetConnection()
        {
            return connection;
        }
        public void OpenConnection()
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }


    }
}
