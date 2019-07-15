using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BankingLib.Repository;

namespace BankingMdiApp
{

    public partial class LoginForm : Form
    {
        private readonly LoginRepository _loginRepository;
        private static bool _status = false;
        private bool _flag;
        private string _username;
        private static string _user = "";
        private HomeForm _homeForm;
        public LoginForm()
        {
            InitializeComponent();
            _loginRepository = new LoginRepository();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            _username = userNameTb.Text;
            string password = passwordTb.Text;
            _flag = _loginRepository.LoginValidation(_username, password);
            if (_flag == true)
            {
                userNameTb.Text = "";
                passwordTb.Text = "";
                MessageBox.Show("Login succesful");
                _status = true;
                _user = _username;

            }
            if (_flag == false)
            {
                userNameTb.Text = "";
                passwordTb.Text = "";
                MessageBox.Show("Please check Your username and Password");
            }
        }
        public void Get(HomeForm homeForm)
        {
            _homeForm = homeForm;
        }


        public string UserName
        {
            get
            {
                return _user;
            }
            set { _user = value; }
        }

        public bool Status
        {
            get { return _status; }
            set { _status = value; }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
