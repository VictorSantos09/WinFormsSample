using Store.Application.Dto;
using Store.Domain.Entities;
using Store.Repository.Repositories;
using System.Net.Http.Headers;

namespace Store.Application.Services
{
    public class ProductService
    {
        private readonly UserRepository _userRepository;

        public ProductService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public BaseDto CreateItem(string itemName, decimal itemValue, int amountInStock, string email, string password)
        {
            if (string.IsNullOrEmpty(itemName))
                return new BaseDto("Digite o nome do item", false);

            if (string.IsNullOrEmpty(itemValue.ToString()))
                return new BaseDto("Valor do item não permitido", false);

            if (string.IsNullOrEmpty(amountInStock.ToString()))
                return new BaseDto("Quantidade não permitida", false);

            var product = new ProductEntity(itemName, itemValue, amountInStock);

            var user = _userRepository.GetByEmail(email, password);

            if (user == null)
                return new BaseDto("Usuário não encontado", false);

            user.productEntities.Add(product);

            return new BaseDto($"Item {product.Name} adicionado", true);
        }

        public void RemoveItem()
        {

        }
    }
}