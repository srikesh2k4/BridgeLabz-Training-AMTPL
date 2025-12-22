using System;
using Microsoft.Data.SqlClient;

namespace AdoNetDemo
{
    class Program
    {
        static void Main()
        {
            string connectionString =
                "Server=localhost,1433;Database=accounts;User Id=SA;Password=YourPassword;TrustServerCertificate=True;";

            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            SqlTransaction tx = conn.BeginTransaction();

            try
            {
                SqlCommand insert = new SqlCommand(
                    "INSERT INTO Users(Name) VALUES(@name)", conn, tx);
                insert.Parameters.AddWithValue("@name", "Srikesh");
                insert.ExecuteNonQuery();

                SqlCommand select = new SqlCommand(
                    "SELECT * FROM Users", conn, tx);

                using SqlDataReader reader = select.ExecuteReader();
                while (reader.Read())
                    Console.WriteLine(reader["Name"]);

                tx.Commit();
            }
            catch
            {
                tx.Rollback();
            }
        }
    }
}