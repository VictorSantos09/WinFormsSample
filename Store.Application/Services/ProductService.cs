using Store.Application.Dto;
using Store.Domain.Entities;
using Store.Repository.Repositories;

namespace Store.Application.Services
{
    public class ProductService
    {
        private readonly UserRepository _userRepository;
        private readonly UserEntity _user;

        public ProductService(UserRepository userRepository, UserEntity user)
        {
            _userRepository = userRepository;
            _user = user;
        }

        public BaseDto Create(string productName, decimal productValue, int amountInStock)
        {
            if (string.IsNullOrEmpty(productName))
                return new BaseDto("Digite o nome do produto", false);

            if (productValue <= 0)
                return new BaseDto("Valor do produto não permitido", false);

            if (amountInStock <= 0)
                return new BaseDto("Quantidade não permitida", false);

            var product = new ProductEntity(productName, productValue, amountInStock);

            if (_user == null)
                return new BaseDto("Usuário não encontado", false);

            if (_user.Products.Exists(x => x.Name == productName.ToUpper()))
                return new BaseDto($"{productName} já existe na sua lista", false);

            _user.Products.Add(product);

            _userRepository.Update(_user.Id, _user);

            return new BaseDto($"{product.Name} adicionado", true);
        }

        public BaseDto Remove(List<string> itens)
        {
            if (_user == null)
                return new BaseDto("Usuário não encontrado", false);

            var products = new List<ProductEntity>();

            foreach (var item in itens)
            {
                var userItem = _user.Products.Find(x => x.Name == item);

                if (userItem != null)
                    products.Add(userItem);
            }

            if (products.Count == 0 || products == null)
                return new BaseDto("produtos não encontrados", false);

            foreach (var item in products)
            {
                _user.Products.Remove(item);
            }


            _userRepository.Update(_user.Id, _user);


            return new BaseDto($"{products.Count} foram removidos", false);
        }
    }
}