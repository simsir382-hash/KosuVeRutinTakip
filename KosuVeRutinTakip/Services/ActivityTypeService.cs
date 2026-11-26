using System;
using System.Collections.Generic;
using KosuVeRutinTakip.Models;
using KosuVeRutinTakip.Repositories;

namespace KosuVeRutinTakip.Services
{
    public class ActivityTypeService
    {
        private readonly ActivityTypeRepository _repo = new ActivityTypeRepository();

        public List<ActivityType> GetAll()
        {
            return _repo.GetAll();
        }

        public void Add(ActivityType type)
        {
            if (string.IsNullOrWhiteSpace(type.TypeName))
                throw new Exception("Aktivite adı boş bırakılamaz.");

            if (string.IsNullOrWhiteSpace(type.Unit))
                throw new Exception("Birim seçilmelidir (km veya dakika).");

            _repo.Add(type);
        }
    }
}