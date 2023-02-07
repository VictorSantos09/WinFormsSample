using Store.Application.Services;
using Store.Repository.Repositories;

namespace StoreUI
{
    public partial class Form1 : Form
    {

        private readonly LoginService _login;
        private readonly UserRepository _userRepository;
        private HomeForm _home;

        public Form1()
        {
            _userRepository = new UserRepository();
            _login = new LoginService(_userRepository);

            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var result = _login.Login(emailText.Text.ToUpper(), passwordText.Text);

            if (result._Condition)
            {
                var user = _userRepository.GetByEmail(emailText.Text.ToUpper(), passwordText.Text);

                _home = new HomeForm(user);

                Hide();

                _home.Show();
            }

            else
            {
                MessageBox.Show(result._Message.ToUpper());
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            var registerForm = new RegisterForm(this);

            Hide();

            registerForm.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}