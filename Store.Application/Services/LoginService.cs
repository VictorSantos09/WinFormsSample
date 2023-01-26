using Store.Application.Dto;
using Store.Repository.Repositories;

namespace Store.Application.Services
{
    public class LoginService
    {
        private readonly UserRepository _userRepository;

        public LoginService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public BaseDto Login(string email, string password)
        {
            var user = _userRepository.GetByEmail(email, password);

            if (user == null)
                return new BaseDto("Usuário não encontrado", false);

            return new BaseDto("Login realizado", user.Id, true);
        }
    }
}