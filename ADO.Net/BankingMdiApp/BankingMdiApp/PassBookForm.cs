using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text;
using BankingLib.Repository;

namespace BankingMdiApp
{
    public partial class PassBookForm : Form
    {
        private List<TransactionData> _listTransaction;
        private PassBookRepository _passBookRepository;
        private HomeForm _homeForm;
        private string _filePath = @"E:/SwabhavTech/ADO.Net/transaction.csv";
        private LoginForm _loginForm=new LoginForm();
        public PassBookForm()
        {
            InitializeComponent();
            _passBookRepository = new PassBookRepository();
        }

        private void passBook_Load(object sender, EventArgs e)
        {
            usernameLabel.Text = _loginForm.UserName;
        }

        private void PassBookPrint_Click(object sender, EventArgs e)
        {
            _listTransaction = _passBookRepository.GetTransaction(_loginForm.UserName);

            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[4] { new DataColumn("Name", typeof(string)),
                new DataColumn("Amount", typeof(string)),
                new DataColumn("Transaction Type",typeof(string)),
                new DataColumn("Date",typeof(string))
            });
            foreach (TransactionData transactionData in _listTransaction)
            {
                dt.Rows.Add(transactionData.Name, transactionData.Amount, transactionData.Type,
                    transactionData.Date);
            }

            this.dataGridView1.DataSource = dt;
            this.dataGridView1.AllowUserToAddRows = false;
        }

        private void PassBookForm_Load(object sender, EventArgs e)
        {
            usernameLabel.Text = _loginForm.UserName;
        }

        

        private void downloadBtn_Click(object sender, EventArgs e)
        {
            var csv = new StringBuilder();

            foreach (TransactionData transactionData in _listTransaction)
            {
                var newLine = string.Format("{0},{1},{2},{3}",
                    transactionData.Name, transactionData.Amount, transactionData.Type, transactionData.Date);
                csv.AppendLine(newLine);
            }
            File.WriteAllText(_filePath, csv.ToString());
            MessageBox.Show("Download Complete");
        }

       
    }
}
