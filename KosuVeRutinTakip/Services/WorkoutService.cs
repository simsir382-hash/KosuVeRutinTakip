using System.Collections.Generic;
using System.Linq;
using KosuVeRutinTakip.Models;
using KosuVeRutinTakip.Repositories;
using KosuVeRutinTakip.Validators;

namespace KosuVeRutinTakip.Services
{
    public class WorkoutService
    {
        private readonly WorkoutRepository _repo = new WorkoutRepository();
        private readonly WorkoutValidator _validator = new WorkoutValidator();

        public List<Workout> GetAllByUser(int userId)
        {
            return _repo.GetAllByUserId(userId);
        }

        public void Add(Workout workout)
        {
            _validator.Validate(workout);
            _repo.Add(workout);
        }

        public void Update(Workout workout)
        {
            _validator.Validate(workout);
            _repo.Update(workout);
        }

        public void Delete(int id)
        {
            _repo.Delete(id);
        }

        // İş Kuralı / İstatistik Hesaplamaları
        public decimal GetTotalDistanceKm(int userId)
        {
            var list = _repo.GetAllByUserId(userId);
            return list.Sum(w => w.DistanceKm);
        }

        public int GetTotalDurationMinutes(int userId)
        {
            var list = _repo.GetAllByUserId(userId);
            return list.Sum(w => w.DurationMinutes);
        }
    }
}