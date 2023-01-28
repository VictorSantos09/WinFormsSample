using Store.Application.Services;
using Store.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreUI
{
    public partial class RegisterForm : Form
    {
        private readonly RegisterService _register;
        private readonly UserRepository _userRepository;

        public RegisterForm()
        {
            _userRepository = new UserRepository();
            _register = new RegisterService(_userRepository);
            InitializeComponent();

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            var result = _register.Register(userNameText.Text, storeNameText.Text, emailText.Text, passwordText.Text, phoneNumberText.Text);

            MessageBox.Show(result._Message);
        }
    }
}