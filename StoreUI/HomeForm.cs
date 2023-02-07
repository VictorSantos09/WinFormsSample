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

            helloLabel.Text = $"OLÁ, {_user.Name}".ToUpper();
            PhoneNumberLabel.Text = $"Telefone: {_user.PhoneNumber}".ToUpper();
            emailLabel.Text = $"Email: {_user.Email}".ToUpper();
        }

        private void viewProductsButton_Click(object sender, EventArgs e)
        {
            new ViewProductsForm(_user).Show();
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            new AddProductForm(_user).Show();
        }

        private void removeProductButton_Click(object sender, EventArgs e)
        {
            new RemoveProductForm(_user).Show();
        }

        private void HomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Até a próxima :)");
            Application.Exit();
        }
    }
}