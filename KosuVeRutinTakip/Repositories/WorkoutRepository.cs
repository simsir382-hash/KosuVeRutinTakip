using System;
using System.Collections.Generic;
using KosuVeRutinTakip.Models;
using MySql.Data.MySqlClient;

namespace KosuVeRutinTakip.Repositories
{
    public class WorkoutRepository
    {
        public List<Workout> GetAllByUserId(int userId)
        {
            var list = new List<Workout>();
            using (var conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT w.*, a.TypeName AS ActivityTypeName, a.Unit 
                    FROM Workouts w
                    INNER JOIN ActivityTypes a ON w.ActivityTypeId = a.Id
                    WHERE w.UserId = @userId
                    ORDER BY w.WorkoutDate DESC, w.Id DESC";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Workout
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                UserId = Convert.ToInt32(reader["UserId"]),
                                ActivityTypeId = Convert.ToInt32(reader["ActivityTypeId"]),
                                WorkoutDate = Convert.ToDateTime(reader["WorkoutDate"]),
                                DistanceKm = Convert.ToDecimal(reader["DistanceKm"]),
                                DurationMinutes = Convert.ToInt32(reader["DurationMinutes"]),
                                Notes = reader["Notes"]?.ToString(),
                                ActivityTypeName = reader["ActivityTypeName"].ToString(),
                                Unit = reader["Unit"].ToString()
                            });
                        }
                    }
                }
            }
            return list;
        }

        public void Add(Workout workout)
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();
                string query = @"INSERT INTO Workouts 
                    (UserId, ActivityTypeId, WorkoutDate, DistanceKm, DurationMinutes, Notes) 
                    VALUES (@userId, @activityTypeId, @workoutDate, @distanceKm, @durationMinutes, @notes)";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", workout.UserId);
                    cmd.Parameters.AddWithValue("@activityTypeId", workout.ActivityTypeId);
                    cmd.Parameters.AddWithValue("@workoutDate", workout.WorkoutDate.Date);
                    cmd.Parameters.AddWithValue("@distanceKm", workout.DistanceKm);
                    cmd.Parameters.AddWithValue("@durationMinutes", workout.DurationMinutes);
                    cmd.Parameters.AddWithValue("@notes", workout.Notes ?? "");
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Update(Workout workout)
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();
                string query = @"UPDATE Workouts SET 
                    ActivityTypeId = @activityTypeId, 
                    WorkoutDate = @workoutDate, 
                    DistanceKm = @distanceKm, 
                    DurationMinutes = @durationMinutes, 
                    Notes = @notes 
                    WHERE Id = @id";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", workout.Id);
                    cmd.Parameters.AddWithValue("@activityTypeId", workout.ActivityTypeId);
                    cmd.Parameters.AddWithValue("@workoutDate", workout.WorkoutDate.Date);
                    cmd.Parameters.AddWithValue("@distanceKm", workout.DistanceKm);
                    cmd.Parameters.AddWithValue("@durationMinutes", workout.DurationMinutes);
                    cmd.Parameters.AddWithValue("@notes", workout.Notes ?? "");
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id)
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM Workouts WHERE Id = @id";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}