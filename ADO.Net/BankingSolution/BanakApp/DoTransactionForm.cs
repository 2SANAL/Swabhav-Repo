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
    public partial class DoTransactionForm : Form
    {
        private DoTransaction _doTransaction;
        private double _amount;
        private String _selectedTransactionType;
        private LoginForm _loginformobj;
        private bool _status;

        public DoTransactionForm()
        {
            InitializeComponent();
            _doTransaction = new DoTransaction();
        }

        private void DoTransactionForm_Load(object sender, EventArgs e)
        {
            usernamelabel.Text = _loginformobj.GetUsername;
        }

        private void SubmitTransactionbtn_Click(object sender, EventArgs e)
        {
            _amount = Convert.ToDouble(amountTB.Text);
            if (amountTB.Text == "")
            {
                MessageBox.Show("Please Enter amount");

            }
            if (_selectedTransactionType.Equals("Deposite"))
            {
                _status = _doTransaction.Transaction(_amount, "Deposite", _loginformobj.GetUsername);
            }
            if (_selectedTransactionType.Equals("Withdraw"))
            {
                _status = _doTransaction.Transaction(_amount, "withdrawal", _loginformobj.GetUsername);
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

        private void depositeRb_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                _selectedTransactionType = ((RadioButton)sender).Text;

        }

        private void withdrowRb_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                _selectedTransactionType = ((RadioButton)sender).Text;
        }
        public void GetObj(LoginForm obj)
        {
            _loginformobj = obj;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeForrm homeForm = new HomeForrm();
            this.Close();
            homeForm.GetObj(_loginformobj);
            homeForm.Show();
        }
    }
}
