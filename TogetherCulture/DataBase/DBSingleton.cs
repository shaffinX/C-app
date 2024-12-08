using System;
using System.Data;
using Npgsql;

namespace TogetherCulture.DataBase
{
    public class DBSingleton
    {
        // Private static instance of the class
        private static readonly Lazy<DBSingleton> _instance = new Lazy<DBSingleton>(() => new DBSingleton());

        // Private connection string
        private readonly string _connectionString;

        // Private constructor to prevent instantiation from outside
        private DBSingleton()
        {
            // Retrieve connection string from your App.config or hard-code it if needed
            _connectionString = "Host=localhost;Port=5432;Username=postgres;Password=root;Database=together_culture;";
        }

        // Public property to get the singleton instance
        public static DBSingleton Instance => _instance.Value;

        // Method to execute a query and return a DataTable for SELECT statements
        public DataTable ExecuteQuery(string query)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(_connectionString))
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the error or rethrow as needed
                throw new Exception($"Error executing query: {ex.Message}", ex);
            }
            return dataTable;
        }

        // Method to execute non-SELECT queries and return a boolean value indicating success
        public bool ExecuteUpdate(string query)
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(_connectionString))
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the error or rethrow as needed
                throw new Exception($"Error executing non-query: {ex.Message}", ex);
            }
        }
    }
}
