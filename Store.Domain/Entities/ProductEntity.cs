namespace Store.Domain.Entities
{
    public class ProductEntity : BaseEntity
    {
        public string Name { get; set; }
        public decimal Value { get; set; }
        public int AmountInStock { get; set; }

        public ProductEntity(string name, decimal value, int amountInStock)
        {
            Id = Guid.NewGuid();
            Name = name.ToUpper();
            Value = value;
            AmountInStock = amountInStock;
        }
    }
}