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
            if (_user.Products.Count == 0)
            {
                listProductsBox.Text = "Nenhum item registrado";
            }

            else
            {
                listProductsBox.Items.AddRange(_user.Products.ToArray());
            }
        }
    }
}