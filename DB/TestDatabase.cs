using Microsoft.Data.SqlClient;

namespace BridgeLabzApp.DB
{
    public class TestDatabase
    {
        public void ConnectDatabase()
        {
            string connectionString =
                "Server=localhost,1433;" +
                "Database=accounts;" +
                "User Id=SA;" +
                "Password=Srikesh123;" +
                "Encrypt=True;" +
                "TrustServerCertificate=True;";
            using SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlTransaction sqlTransaction = sqlConnection.BeginTransaction();
            try
            {
                string query1 =
                    @"insert into billDetails.Bills (BillNumber,BillDate,TotalAmount,PaymentMode,CreatedBy,CreatedAt) values (@BillNumber,GETDATE(),@TotalAmount,@PaymentMode,@CreatedBy,GETDATE());SELECT SCOPE_IDENTITY();";
                using SqlCommand billsCommand = new SqlCommand(query1, sqlConnection, sqlTransaction);
                billsCommand.Parameters.AddWithValue("@BillNumber","BILL-1002");
                billsCommand.Parameters.AddWithValue("@TotalAmount", 1200);
                billsCommand.Parameters.AddWithValue("@PaymentMode", "CASH");
                billsCommand.Parameters.AddWithValue("@CreatedBy", "Srikesh");
              //  int bill = Convert.ToInt32(billsCommand.ExecuteScalar());

                string query2 = @"select * from billDetails.Bills";
                using SqlCommand selCmd = new SqlCommand(
                    query2, sqlConnection, sqlTransaction);
                SqlDataReader sqlData =  selCmd.ExecuteReader();

                while (sqlData.Read())
                {
                   int id =  sqlData.GetInt32(sqlData.GetOrdinal("Id"));
                   
                    Console.WriteLine(
                        $"{sqlData["Id"]} | {sqlData["BillNumber"]} | {sqlData["TotalAmount"]}");
                }

            }
            catch (SqlException e)
            {
                sqlTransaction.Rollback();
                Console.WriteLine(e);
                throw;
            }
        }
    }
}