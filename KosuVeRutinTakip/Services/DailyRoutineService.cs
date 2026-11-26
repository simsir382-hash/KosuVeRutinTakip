using System;
using System.Collections.Generic;
using System.Linq;
using KosuVeRutinTakip.Models;
using KosuVeRutinTakip.Repositories;
using KosuVeRutinTakip.Validators;

namespace KosuVeRutinTakip.Services
{
    public class DailyRoutineService
    {
        private readonly DailyRoutineRepository _repo = new DailyRoutineRepository();
        private readonly DailyRoutineValidator _validator = new DailyRoutineValidator();

        public List<DailyRoutine> GetAllByUser(int userId)
        {
            return _repo.GetAllByUserId(userId);
        }

        public void Add(DailyRoutine routine)
        {
            _validator.Validate(routine);

            if (_repo.ExistsForDate(routine.UserId, routine.RoutineDate))
                throw new Exception("Bu tarih için zaten bir günlük rutin kaydı mevcut. Güncelleme yapabilirsiniz.");

            _repo.Add(routine);
        }

        public void Update(DailyRoutine routine)
        {
            _validator.Validate(routine);

            if (_repo.ExistsForDate(routine.UserId, routine.RoutineDate, routine.Id))
                throw new Exception("Seçilen tarihte başka bir rutin kaydı zaten var.");

            _repo.Update(routine);
        }

        public void Delete(int id)
        {
            _repo.Delete(id);
        }

        // Ortalama uyku süresi hesabı
        public decimal GetAverageSleepHours(int userId)
        {
            var list = _repo.GetAllByUserId(userId);
            if (list.Count == 0) return 0;
            return Math.Round(list.Average(r => r.SleepHours), 1);
        }
    }
}