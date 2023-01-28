using Store.Application.Services;
using Store.Repository.Repositories;

namespace StoreUI
{
    public partial class Form1 : Form
    {

        private readonly LoginService _login;
        private readonly UserRepository _userRepository;

        public Form1()
        {
            _userRepository = new UserRepository();
            _login = new LoginService(_userRepository);

            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var result = _login.Login(emailText.Text.ToUpper(), passwordText.Text);

            MessageBox.Show(result._Message);
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            var registerForm = new RegisterForm();

            registerForm.Show();
        }
    }
}