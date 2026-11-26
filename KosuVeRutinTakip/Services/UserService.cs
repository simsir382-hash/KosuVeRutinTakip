using KosuVeRutinTakip.Models;
using KosuVeRutinTakip.Repositories;
using KosuVeRutinTakip.Validators;

namespace KosuVeRutinTakip.Services
{
    public class UserService
    {
        private readonly UserRepository _userRepo = new UserRepository();
        private readonly UserValidator _validator = new UserValidator();

        public User Login(string username, string password)
        {
            _validator.ValidateLogin(username, password);
            return _userRepo.Login(username, password);
        }

        public void Register(User user)
        {
            _validator.ValidateRegister(user);
            _userRepo.Add(user);
        }
    }
}
