namespace Store.Domain.Entities
{
    public class ProductEntity
    {
        public string Name { get; set; }
        public decimal Value { get; set; }
        public int AmountInStock { get; set; }

        public ProductEntity(string name, decimal value, int amountInStock)
        {
            Name = name.ToUpper();
            Value = value;
            AmountInStock = amountInStock;
        }
    }
}