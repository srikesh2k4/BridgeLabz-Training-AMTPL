using Microsoft.Data.SqlClient;
using System;

namespace BridgeLabzApp.DB
{
    public class TestDatabase
    {
        public void ConnectDatabase()
        {
            string connectionString =
                "Server=127.0.0.1,1433;" +
                "Database=master;" +
                "User Id=SA;" +
                "Password=Srikesh123;" +
                "TrustServerCertificate=True;" +
                "Encrypt=False;";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                try
                {
                    using (SqlCommand cmd =
                           new SqlCommand("CREATE DATABASE accounts", sqlConnection))
                    {
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("Database created.");
                    }
                }
                catch (SqlException ex) when (ex.Number == 1801)
                {
                    Console.WriteLine("Database already exists.");
                }
            }
        }
    }
}