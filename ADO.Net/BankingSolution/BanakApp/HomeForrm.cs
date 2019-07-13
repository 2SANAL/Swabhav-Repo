using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BankingLib;

namespace BanakApp
{
    public partial class HomeForrm : Form
    {
        private LoginForm _loginuser;
        private GetBalanceRepositry _getBalance;
        public HomeForrm()
        {
            InitializeComponent();
            _getBalance = new GetBalanceRepositry();

        }
        public void GetObj(LoginForm loginuser)
        {
            _loginuser = loginuser;
        }

        private void HomeForrm_Load(object sender, EventArgs e)
        {
            usernameLabel.Text = _loginuser.GetUsername;
            balanceLabel.Text = _getBalance.GetBalance(_loginuser.GetUsername);
        }

        private void doTransactionbtn_Click(object sender, EventArgs e)
        {
            DoTransactionForm doTransactionFrom = new DoTransactionForm();
            doTransactionFrom.GetObj(_loginuser);
            this.Close();
            doTransactionFrom.Show();
        }

        private void passBookBtn_Click(object sender, EventArgs e)
        {
            PassBookForm passBookFrom = new PassBookForm();
            passBookFrom.SetObj(_loginuser);
            this.Close();
            passBookFrom.Show();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginFrom = new LoginForm();
            loginFrom.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
