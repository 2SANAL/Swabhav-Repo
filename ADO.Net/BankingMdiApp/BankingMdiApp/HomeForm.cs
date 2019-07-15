using System;
using System.Windows.Forms;

namespace BankingMdiApp
{
    public partial class HomeForm : Form
    {
        private LoginForm _loginForm;
        private bool _userStatus = false;

        public HomeForm()
        {
            InitializeComponent();
            _loginForm = new LoginForm();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _loginForm.MdiParent = this;
            _loginForm.Text = "LoginForm";
            _loginForm.Show();
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.MdiParent = this;
            registrationForm.Show();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
        }

        private void passBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_loginForm.Status.Equals(true))
            {
                PassBookForm passBookForm = new PassBookForm();
                passBookForm.MdiParent = this;
                passBookForm.Show();
            }
            else
            {
                MessageBox.Show("Please Login");
            }
        }

        private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_loginForm.Status.Equals(true))
            {
                DoTransactionForm doTransactionForm = new DoTransactionForm();
                doTransactionForm.MdiParent = this;
                doTransactionForm.Show();
            }
            else
            {
                MessageBox.Show("Please Login");
            }

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_loginForm.Status.Equals(true))
            {
                BankHomeForm bankHomeForm = new BankHomeForm();
                bankHomeForm.MdiParent = this;
                bankHomeForm.Show();
            }
            else
            {
                MessageBox.Show("Please Login");
            }

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_loginForm.Status.Equals(true))
            {
                _loginForm.Status = false;
                _loginForm.UserName = "";
            }

        }
    }
}
