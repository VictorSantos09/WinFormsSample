using Store.Application.Services;
using Store.Repository.Repositories;

namespace StoreUI
{
    public partial class RegisterForm : Form
    {
        private readonly RegisterService _register;
        private readonly UserRepository _userRepository;
        private readonly Form1 _loginForm;

        public RegisterForm(Form1 loginForm)
        {
            _loginForm = loginForm;
            _userRepository = new UserRepository();
            _register = new RegisterService(_userRepository);
            InitializeComponent();

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            var result = _register.Register(userNameText.Text, storeNameText.Text, emailText.Text, passwordText.Text, phoneNumberText.Text);

            if (result._Condition)
            {
                MessageBox.Show(result._Message.ToUpper());

                Hide();

                _loginForm.Show();
            }

            else
            {
                MessageBox.Show(result._Message.ToUpper());
            }
        }
    }
}