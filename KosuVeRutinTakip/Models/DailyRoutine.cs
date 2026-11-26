using System;

namespace KosuVeRutinTakip.Models
{
    public class DailyRoutine
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime RoutineDate { get; set; }
        public decimal SleepHours { get; set; }
        public bool ColdShowerDone { get; set; }
        public bool MeditationDone { get; set; }
        public bool ReadingDone { get; set; }
    }
}