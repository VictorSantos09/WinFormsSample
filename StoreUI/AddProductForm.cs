using Store.Application.Services;
using Store.Domain.Entities;

namespace StoreUI
{
    public partial class AddProductForm : Form
    {
        private readonly ProductService _productService;
        private readonly UserEntity _user;
        public AddProductForm(UserEntity user)
        {
            _user = user;
            _productService = new(new(),_user);
            InitializeComponent();
        }

        private void saveItemButton_Click(object sender, EventArgs e)
        {
            var result = _productService.Create(itemNameText.Text.ToUpper(), itemPriceValue.Value, Convert.ToInt32(itemAmountValue.Value));

            MessageBox.Show(result._Message.ToLower());
        }
    }
}