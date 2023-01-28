using Store.Domain.Entities;

namespace StoreUI
{
    public partial class HomeForm : Form
    {
        private readonly UserEntity _user;
        public HomeForm(UserEntity user)
        {
            _user = user;
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            userNameLabel.Text = _user.Name;
            PhoneNumberLabel.Text = _user.PhoneNumber;
            emailLabel.Text = _user.Email;
        }
    }
}