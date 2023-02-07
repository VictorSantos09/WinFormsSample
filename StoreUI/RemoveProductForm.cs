using Store.Application.Services;
using Store.Domain.Entities;

namespace StoreUI
{
    public partial class RemoveProductForm : Form
    {
        private readonly UserEntity _user;
        private readonly ProductService _productService;

        public RemoveProductForm(UserEntity user)
        {
            _user = user;
            _productService = new(new(), _user);
            InitializeComponent();
        }

        private void removeItemButton_Click(object sender, EventArgs e)
        {
            if (itensCheckBox.CheckedItems.Count == 0)
                MessageBox.Show("NENHUM ITEM ESCOLHIDO");

            else
            {
                var myOtherList = itensCheckBox.CheckedItems.Cast<string>().ToList();

                var result = _productService.Remove(myOtherList);

                MessageBox.Show(result._Message.ToUpper());

                itensCheckBox.Items.Clear();

                RemoveProductForm_Load(sender, e);
            }
        }

        private void RemoveProductForm_Load(object sender, EventArgs e)
        {
            foreach (var item in _user.Products)
            {
                itensCheckBox.Items.Add(item.Name);
            }

            this.Controls.Add(itensCheckBox);
        }
    }
}