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

        public BaseDto Create(string itemName, decimal itemValue, int amountInStock)
        {
            if (string.IsNullOrEmpty(itemName))
                return new BaseDto("Digite o nome do item", false);

            if (string.IsNullOrEmpty(itemValue.ToString()))
                return new BaseDto("Valor do item não permitido", false);

            if (string.IsNullOrEmpty(amountInStock.ToString()))
                return new BaseDto("Quantidade não permitida", false);

            var product = new ProductEntity(itemName, itemValue, amountInStock);

            if (_user == null)
                return new BaseDto("Usuário não encontado", false);

            _user.Products.Add(product);

            _userRepository.Update(_user.Id, _user);

            return new BaseDto($"Item {product.Name} adicionado", true);
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

            var counter = 0;

            foreach (var item in products)
            {
                _user.Products.Remove(item);
                counter++;
            }

            _userRepository.Update(_user.Id, _user);


            return new BaseDto($"{counter} foram removidos", false);
        }
    }
}