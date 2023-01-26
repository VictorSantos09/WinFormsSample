using Store.Application.Dto;
using Store.Domain.Entities;
using Store.Repository.Repositories;

namespace Store.Application.Services
{
    public class RegisterService
    {
        private readonly UserRepository _userRepository;

        public RegisterService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public BaseDto Register(string userName, string storeName, string email, string password, string phoneNumber)
        {
            if (userName.Length <= 5 || string.IsNullOrEmpty(userName))
                return new BaseDto("Nome de usuário inválido", false);

            if (string.IsNullOrEmpty(storeName))
                return new BaseDto("Digite o nome da loja", false);

            if (!email.Contains("@") || string.IsNullOrEmpty(email))
                return new BaseDto("Email inválido", false);

            if (password.Length <= 5 || string.IsNullOrEmpty(password))
                return new BaseDto("Senha muito fraca", false);

            if (phoneNumber.Length <= 5 || string.IsNullOrEmpty(phoneNumber))
                return new BaseDto("Telefone inválido", false);

            var user = new UserEntity(storeName, userName, email, password, phoneNumber);

            _userRepository.Add(user);

            return new BaseDto("Cadastro Efetuado", true);
        }
    }
}