using System;
using KosuVeRutinTakip.Models;

namespace KosuVeRutinTakip.Validators
{
    public class DailyRoutineValidator
    {
        public void Validate(DailyRoutine routine)
        {
            if (routine.RoutineDate.Date > DateTime.Now.Date)
                throw new Exception("Gelecek bir tarih için günlük rutin kaydı oluşturulamaz.");

            if (routine.SleepHours <= 0 || routine.SleepHours > 24)
                throw new Exception("Uyku süresi 0 ile 24 saat arasında olmalıdır.");
        }
    }
}