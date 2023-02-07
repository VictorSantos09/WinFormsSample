using Store.Domain.Entities;

namespace StoreUI
{
    public partial class ViewProductsForm : Form
    {
        private readonly UserEntity _user;

        public ViewProductsForm(UserEntity user)
        {
            _user = user;
            InitializeComponent();
        }

        private void ViewProductsForm_Load(object sender, EventArgs e)
        {
            listProductsBox.Items.Clear();

            foreach (var item in _user.Products)
            {
                var pattern = $"ITEM: {item.Name} | VALOR: R${item.Value} | UNIDADES: {item.AmountInStock}".ToUpper();
                listProductsBox.Items.Add(pattern);
            }

            this.Controls.Add(listProductsBox);
        }
    }
}