using Microsoft.Data.SqlClient;
namespace AdoNetDemo
{
    public class LearnADO
    {
        public class Users
        {
            public string FullName { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public string PasswordHash { get; set; }
            public bool IsActive { get; set; }
        }
        public LearnADO()
        {
            List<Users> list = new List<Users>()
            {
                new Users()
                {
                    Email = "srikesh1sa121@gmail.com", FullName = "Kotipalli Srikesh", IsActive = false,
                    PasswordHash = "Srikesh@2004", Phone = "+918904004503"
                },
                new Users()
                {
                    Email = "ganes11sa12h@gmail.com", FullName = "Ganesh", IsActive = true,
                    PasswordHash = "Srikesh@2001", Phone = "+918904004504"
                }
            };
            
            string connectionString =
                @"Server=localhost,1433;Database=OnlineBilling; User Id=SA; Password=Srikesh123;Encrypt=True; TrustServerCertificate=True;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlTransaction sqlTransaction = sqlConnection.BeginTransaction();

            /*try
            {
                foreach (Users users in list)
                {
                    SqlCommand insertCommand =
                        new SqlCommand(
                            "insert into OnlineBilling.Billing.Users (FullName,Email,Phone,PasswordHash,IsActive) values (@FullName,@Email,@Phone,@PasswordHash,@IsActive) select SCOPE_IDENTITY()",sqlConnection,sqlTransaction);
                    insertCommand.Parameters.AddWithValue("@FullName", System.Data.SqlDbType.VarChar).Value = users.FullName;
                    insertCommand.Parameters.AddWithValue("@Email", users.Email);
                    insertCommand.Parameters.AddWithValue("@Phone", users.Phone);
                    insertCommand.Parameters.AddWithValue("@PasswordHash", users.PasswordHash);
                    insertCommand.Parameters.AddWithValue("@IsActive", System.Data.SqlDbType.Bit).Value = Convert.ToByte(users.IsActive);
                   int UserId =  Convert.ToInt32(insertCommand.ExecuteScalar());
                   Console.WriteLine("User id is "+UserId);

                }

                Console.WriteLine("The values are inserted sucessfully");
                sqlTransaction.Commit();
            }
            catch (Exception e)
            {
                sqlTransaction.Rollback();
                Console.WriteLine(e);
                throw;
            }*/


            try
            {
                string email = "srikesh@gmail.com";
                string password = "Srikesh@2004";
                string selectCommand =
                    "select FullName, Phone, Email,PasswordHash from Billing.Users where Email=@email";
                SqlCommand command = new SqlCommand(selectCommand, sqlConnection, sqlTransaction);
                command.Parameters.AddWithValue("@email", email);
                SqlDataReader sqlDataReader = command.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    if (sqlDataReader.GetString(2).Equals(email)&&sqlDataReader.GetString(3).Equals(password))
                    {
                        Console.WriteLine("Name "+sqlDataReader["FullName"]);
                        Console.WriteLine("Phone Number "+sqlDataReader["Phone"]);
                        Console.WriteLine("Email "+sqlDataReader["Email"]);
                    }
                    else
                    {
                        Console.WriteLine("Wrong password");
                    }
                    
                }
                sqlDataReader.Close();
                sqlTransaction.Commit();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}