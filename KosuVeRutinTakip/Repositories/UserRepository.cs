using System;
using KosuVeRutinTakip.Models;
using MySql.Data.MySqlClient;

namespace KosuVeRutinTakip.Repositories
{
    public class UserRepository
    {
        public User Login(string username, string password)
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Users WHERE Username = @username AND PasswordHash = @password";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Username = reader["Username"].ToString(),
                                PasswordHash = reader["PasswordHash"].ToString(),
                                FullName = reader["FullName"].ToString()
                            };
                        }
                    }
                }
            }
            return null;
        }

        public void Add(User user)
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO Users (Username, PasswordHash, FullName) VALUES (@username, @password, @fullName)";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", user.Username);
                    cmd.Parameters.AddWithValue("@password", user.PasswordHash);
                    cmd.Parameters.AddWithValue("@fullName", user.FullName);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}