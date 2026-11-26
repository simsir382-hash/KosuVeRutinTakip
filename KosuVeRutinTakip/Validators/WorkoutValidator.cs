using System;
using KosuVeRutinTakip.Models;

namespace KosuVeRutinTakip.Validators
{
    public class WorkoutValidator
    {
        public void Validate(Workout workout)
        {
            if (workout.ActivityTypeId <= 0)
                throw new Exception("Lütfen geçerli bir aktivite türü seçiniz.");

            if (workout.WorkoutDate.Date > DateTime.Now.Date)
                throw new Exception("Gelecek bir tarih için tamamlanmış antrenman giremezsiniz.");

            if (workout.DurationMinutes <= 0)
                throw new Exception("Antrenman süresi 0 dakikadan büyük olmalıdır.");

            if (workout.DistanceKm < 0)
                throw new Exception("Mesafe negatif bir değer olamaz.");
        }
    }
}
