using System;
using System.Windows.Forms;
using BankingLib.Repository;
namespace BankingMdiApp
{
    public partial class BankHomeForm : Form
    {

        private LoginForm _loginForm = new LoginForm();
        private readonly GetBalanceRepositry getBalanceRepositry;
        public BankHomeForm()
        {
            InitializeComponent();
            getBalanceRepositry = new GetBalanceRepositry();
        }



        private void BankHomeForm_Load(object sender, EventArgs e)
        {
            usernameLabel.Text = _loginForm.UserName;
            balanceLabel.Text = getBalanceRepositry.GetBalance(_loginForm.UserName);
        }


    }

}
