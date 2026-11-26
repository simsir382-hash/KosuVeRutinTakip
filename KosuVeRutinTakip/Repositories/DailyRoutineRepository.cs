using System;
using System.Collections.Generic;
using KosuVeRutinTakip.Models;
using MySql.Data.MySqlClient;

namespace KosuVeRutinTakip.Repositories
{
    public class DailyRoutineRepository
    {
        public List<DailyRoutine> GetAllByUserId(int userId)
        {
            var list = new List<DailyRoutine>();
            using (var conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM DailyRoutines WHERE UserId = @userId ORDER BY RoutineDate DESC";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new DailyRoutine
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                UserId = Convert.ToInt32(reader["UserId"]),
                                RoutineDate = Convert.ToDateTime(reader["RoutineDate"]),
                                SleepHours = Convert.ToDecimal(reader["SleepHours"]),
                                ColdShowerDone = Convert.ToBoolean(reader["ColdShowerDone"]),
                                MeditationDone = Convert.ToBoolean(reader["MeditationDone"]),
                                ReadingDone = Convert.ToBoolean(reader["ReadingDone"])
                            });
                        }
                    }
                }
            }
            return list;
        }

        public bool ExistsForDate(int userId, DateTime date, int excludeId = 0)
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM DailyRoutines WHERE UserId = @userId AND RoutineDate = @date AND Id != @excludeId";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@date", date.Date);
                    cmd.Parameters.AddWithValue("@excludeId", excludeId);
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
        }

        public void Add(DailyRoutine routine)
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();
                string query = @"INSERT INTO DailyRoutines 
                    (UserId, RoutineDate, SleepHours, ColdShowerDone, MeditationDone, ReadingDone) 
                    VALUES (@userId, @routineDate, @sleepHours, @coldShower, @meditation, @reading)";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", routine.UserId);
                    cmd.Parameters.AddWithValue("@routineDate", routine.RoutineDate.Date);
                    cmd.Parameters.AddWithValue("@sleepHours", routine.SleepHours);
                    cmd.Parameters.AddWithValue("@coldShower", routine.ColdShowerDone);
                    cmd.Parameters.AddWithValue("@meditation", routine.MeditationDone);
                    cmd.Parameters.AddWithValue("@reading", routine.ReadingDone);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Update(DailyRoutine routine)
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();
                string query = @"UPDATE DailyRoutines SET 
                    RoutineDate = @routineDate, 
                    SleepHours = @sleepHours, 
                    ColdShowerDone = @coldShower, 
                    MeditationDone = @meditation, 
                    ReadingDone = @reading 
                    WHERE Id = @id";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", routine.Id);
                    cmd.Parameters.AddWithValue("@routineDate", routine.RoutineDate.Date);
                    cmd.Parameters.AddWithValue("@sleepHours", routine.SleepHours);
                    cmd.Parameters.AddWithValue("@coldShower", routine.ColdShowerDone);
                    cmd.Parameters.AddWithValue("@meditation", routine.MeditationDone);
                    cmd.Parameters.AddWithValue("@reading", routine.ReadingDone);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id)
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM DailyRoutines WHERE Id = @id";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}