using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using BankingLib;
using System.Windows.Forms;

namespace BanakApp
{
    public partial class RegistrationForm : Form
    {
        private RegistrationRepositry _registration;
        private bool _flage;
        public RegistrationForm()
        {
            InitializeComponent();
            _registration = new RegistrationRepositry();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {

            string username = usernameTB.Text;
            string password = passwordTB.Text;
            string repassword = rePasswordTB.Text;
            double balance = Convert.ToDouble(balanceTB.Text);

            if (balance < 500)
            {
                MessageBox.Show("Please first deposite must be minimum Rs 500");
            }

            if (password.Equals(repassword))
            {
                _flage = _registration.Registor(username, password, balance, "Deposite");
                checkRegistration(_flage);
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
                loginForm.Show();
            }
            else
            {
                MessageBox.Show("Login Failed");
                usernameTB.Text = " ";
                passwordTB.Text = "";
                rePasswordTB.Text = "";
                balanceTB.Text = "";
            }

        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();       
            loginForm.Show();
        }

        private void passwordTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
