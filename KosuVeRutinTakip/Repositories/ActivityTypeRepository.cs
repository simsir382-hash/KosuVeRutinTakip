using System;
using System.Collections.Generic;
using KosuVeRutinTakip.Models;
using MySql.Data.MySqlClient;

namespace KosuVeRutinTakip.Repositories
{
    public class ActivityTypeRepository
    {
        public List<ActivityType> GetAll()
        {
            var list = new List<ActivityType>();
            using (var conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM ActivityTypes ORDER BY TypeName ASC";
                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new ActivityType
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            TypeName = reader["TypeName"].ToString(),
                            Unit = reader["Unit"].ToString()
                        });
                    }
                }
            }
            return list;
        }

        public void Add(ActivityType activityType)
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO ActivityTypes (TypeName, Unit) VALUES (@typeName, @unit)";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@typeName", activityType.TypeName);
                    cmd.Parameters.AddWithValue("@unit", activityType.Unit);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}