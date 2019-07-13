using System;
using System.Windows.Forms;
using BankingLib;

namespace BanakApp
{
    public partial class LoginForm : Form
    {
        private static bool _status = false;
        private readonly LoginRepositry _login;
        private bool _flag;
        private string username;

        public LoginForm()
        {
            InitializeComponent();
            _login = new LoginRepositry();

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            username = usernameTB.Text;
            var password = passwordTB.Text;

            _flag = _login.LoginValidation(username, password);
            if (_flag == true)
            {

                usernameTB.Text = "";
                passwordTB.Text = "";
                _status = true;
                usernamelabel.Text = username;
                HomeForrm homeForm = new HomeForrm();
                homeForm.GetObj(this);
                this.Hide();
                homeForm.Show();
            }
            if (_flag == false)
            {
                usernameTB.Text = "";
                passwordTB.Text = "";
                MessageBox.Show("Please check Your username and Password");
            }

        }

        private void registorbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm registrationFrom = new RegistrationForm();
            registrationFrom.Show();

        }



        public string GetUsername
        {
            get
            {
                return username;
            }
        }
    }
}
