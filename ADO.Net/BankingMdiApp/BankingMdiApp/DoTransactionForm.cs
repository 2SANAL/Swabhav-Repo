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
    public partial class DoTransactionForm : Form
    {
        private double _amount;
        private string _selectedTransactionType;
        private bool _status;
        private DoTransactionRepository _doTransactionRepository;
        private LoginForm _loginForm=new LoginForm();
        private HomeForm _homeForm;

        public DoTransactionForm()
        {
            InitializeComponent();
            _doTransactionRepository = new DoTransactionRepository();

        }

        private void transactionBtn_Click(object sender, EventArgs e)
        {
            _amount = Convert.ToDouble(amountTb.Text);
            if (amountTb.Text == "")
            {
                MessageBox.Show("Please Enter amount");
            }

            if (_selectedTransactionType.Equals("Deposite"))
            {
                _status = _doTransactionRepository.Transaction(_amount, "Deposite", _loginForm.UserName);
            }

            if (_selectedTransactionType.Equals("Withdraw"))
            {
                _status = _doTransactionRepository.Transaction(_amount, "withdrawal", _loginForm.UserName);
            }

            if (_selectedTransactionType.Equals(""))
            {
                MessageBox.Show("Please select Transaction Type");
            }

            if (_status == true)
            {
                MessageBox.Show("Transaction Succesfull");
            }

            if (_status == false)
            {
                MessageBox.Show("Transaction Failed");
            }
        }

        private void DoTransactionForm_Load(object sender, EventArgs e)
        {
            usernameLabel.Text = _loginForm.UserName;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void depositeRB_CheckedChanged_1(object sender, EventArgs e)
        {

            if (((RadioButton)sender).Checked)
                _selectedTransactionType = ((RadioButton)sender).Text;
        }

        private void withdrawTB_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                _selectedTransactionType = ((RadioButton)sender).Text;
        }
    }
}
