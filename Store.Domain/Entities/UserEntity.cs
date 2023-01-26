namespace Store.Domain.Entities
{
    public class UserEntity : BaseEntity
    {
        public string StoreName { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }

        public List<ProductEntity> productEntities { get; set; }

        public UserEntity(string storeName, string name, string email, string password, string phoneNumber)
        {
            StoreName = storeName.ToUpper();
            Name = name.ToUpper();
            Email = email.ToUpper();
            Password = password;
            PhoneNumber = phoneNumber;
        }
    }
}