using Store.Application.Dto;
using Store.Domain.Entities;
using Store.Repository.Repositories;

namespace Store.Application.Services
{
    public class ProductService
    {
        private readonly UserRepository _userRepository;

        public ProductService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public BaseDto Create(string itemName, decimal itemValue, int amountInStock, Guid userId)
        {
            if (string.IsNullOrEmpty(itemName))
                return new BaseDto("Digite o nome do item", false);

            if (string.IsNullOrEmpty(itemValue.ToString()))
                return new BaseDto("Valor do item não permitido", false);

            if (string.IsNullOrEmpty(amountInStock.ToString()))
                return new BaseDto("Quantidade não permitida", false);

            var product = new ProductEntity(itemName, itemValue, amountInStock);

            var user = _userRepository.GetById(userId);

            if (user == null)
                return new BaseDto("Usuário não encontado", false);

            user.Products.Add(product);

            _userRepository.Update(userId, user);

            return new BaseDto($"Item {product.Name} adicionado", true);
        }

        public BaseDto Remove(string itemName, Guid userID)
        {
            var user = _userRepository.GetById(userID);

            if (user == null)
                return new BaseDto("Usuário não encontrado", false);

            var product = user.Products.Find(x => x.Name == itemName.ToUpper());

            if (product == null)
                return new BaseDto("produto não encontrado", false);

            user.Products.Remove(product);

            _userRepository.Update(userID, user);

            return new BaseDto($"produto {product.Name} removido", false);
        }
    }
}