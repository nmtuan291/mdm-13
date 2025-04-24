using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MDM_13.Models;

namespace MDM_13.Services
{
    public static class SQLService
    {
        private static readonly string _connectionString = "Server=MSI;Database=MDM;User Id=sa;Password=291003291003aA;";

        public static void InsertUser(string userId, string userName, string email, string phoneNumber, string passwordHash)
        {
            string query = "INSERT INTO Accounts(userID, userName, email, phoneNumber, passwordHash, accountStatus) VALUES (@userID, @userName, @email, @phoneNumber, @passwordHash, @accountStatus)";
            using (var connection = new SqlConnection(_connectionString))
            {
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userID", userId);
                    command.Parameters.AddWithValue("@userName", userName);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                    command.Parameters.AddWithValue("@passwordHash", passwordHash);
                    command.Parameters.AddWithValue("@accountStatus", "active");

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public static User FindUser(string userName, string email, string phoneNumber)
        {
            string query = "SELECT * FROM Accounts WHERE userName = @userName OR email = @email OR phoneNumber = @phoneNumber";
            using (var connection = new SqlConnection(_connectionString))
            {
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userName", userName);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@phoneNumber", phoneNumber);

                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User
                            {
                                UserId = reader["UserID"].ToString(),
                                UserName = reader["UserName"].ToString(),
                                Email = reader["Email"].ToString(),
                                PhoneNumber = reader["PhoneNumber"].ToString(),
                                PasswordHash = reader["PasswordHash"].ToString()
                            };
                        }
                    }
                }
            }

            return null;
        }
    }
}
