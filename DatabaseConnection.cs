using System;
using Microsoft.Data.SqlClient;

namespace MidTerm_DNet
{
    public class DatabaseConnection
    {
        private readonly string connectionString =
            @"Data Source=MSI;Initial Catalog=MidTermDotNet_M_Tour;User ID=sa;Password=Thothang28@;TrustServerCertificate=true;";

        public SqlConnection GetConnection()
        {
            var connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                return connection;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Connection Error: " + ex.Message);
                connection.Dispose();
                return null;
            }
        }

        public bool TryGetConnection(out SqlConnection connection)
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Connection Error: " + ex.Message);
                connection.Dispose();
                connection = null;
                return false;
            }
        }

        public void CloseConnection(SqlConnection connection)
        {
            if (connection?.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                connection.Dispose();
            }
        }
    }
}