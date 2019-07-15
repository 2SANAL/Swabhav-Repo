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
    public partial class RegistrationForm : Form
    {
        private RegistrationRepository _registrationRepository;
        private HomeForm _homeForm;
        private bool _flag;

        public RegistrationForm()
        {
            InitializeComponent();
            _registrationRepository = new RegistrationRepository();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = usernameTb.Text;
            string password = passwordTb.Text;
            string repassword = rePasswordTb.Text;
            double balance = Convert.ToDouble(amountTb.Text);

            if (balance < 500)
            {
                MessageBox.Show("Please first deposite must be minimum Rs 500");
            }

            if (password.Equals(repassword))
            {
                _flag = _registrationRepository.Registor(username, password, balance, "Deposite");
                checkRegistration(_flag);
            }
            else
            {
                MessageBox.Show("Please Enter correct password");
            }

        }
        private void checkRegistration(bool flag)
        {
            if (flag == true)
            {

                this.Close();
                MessageBox.Show("Registore Suceesfull");
                LoginForm loginForm = new LoginForm();
                loginForm.MdiParent = _homeForm;
                this.Close();
                loginForm.Show();

            }
            else
            {
                MessageBox.Show("Login Failed");
                usernameTb.Text = " ";
                passwordTb.Text = "";
                rePasswordTb.Text = "";
                amountTb.Text = "";
            }

        }

        public void GetHomeFormObj(HomeForm homeForm)
        {
            _homeForm = homeForm;
        }
    }
}
