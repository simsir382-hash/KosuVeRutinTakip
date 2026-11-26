using System;
using KosuVeRutinTakip.Models;

namespace KosuVeRutinTakip.Validators
{
    public class UserValidator
    {
        public void ValidateLogin(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new Exception("Kullanıcı adı boş bırakılamaz.");

            if (string.IsNullOrWhiteSpace(password))
                throw new Exception("Şifre boş bırakılamaz.");
        }

        public void ValidateRegister(User user)
        {
            if (string.IsNullOrWhiteSpace(user.FullName))
                throw new Exception("Ad Soyad alanı boş bırakılamaz.");

            ValidateLogin(user.Username, user.PasswordHash);

            if (user.PasswordHash.Length < 4)
                throw new Exception("Şifre en az 4 karakter olmalıdır.");
        }
    }
}