using System;

namespace KosuVeRutinTakip.Models
{
    public class Workout
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ActivityTypeId { get; set; }
        public DateTime WorkoutDate { get; set; }
        public decimal DistanceKm { get; set; }
        public int DurationMinutes { get; set; }
        public string Notes { get; set; }

        // JOIN sorgularından gelecek yardımcı alanlar
        public string ActivityTypeName { get; set; }
        public string Unit { get; set; }
    }
}