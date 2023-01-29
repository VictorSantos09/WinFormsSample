using Store.Domain.Entities;

namespace StoreUI
{
    public  partial class HomeForm : Form
    {
        private UserEntity _user;
        public HomeForm(UserEntity user)
        {
            _user = user;
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            helloLabel.Text = $"OLÁ, {_user.Name}";
            PhoneNumberLabel.Text = $"Telefone: {_user.PhoneNumber}";
            emailLabel.Text = $"Email: {_user.Email}";
        }

        private void viewProductsButton_Click(object sender, EventArgs e)
        {
            new ViewProductsForm(_user).Show();
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            new AddProductForm(_user).Show();
        }
    }
}