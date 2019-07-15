using System;
using System.Windows.Forms;
using BankingLib;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.IO;


namespace BanakApp
{
    class PassBookForm : Form
    {
        private Button printbtn;
        private DataGridView dataGridView1;
        private PassBookRepositry _passbook = new PassBookRepositry();
        private Label username;
        private Label usernamelabel;
        BindingSource bsource = new BindingSource();
        private LoginForm _loginUser;
        private Button downloadBtn;
        private List<TransactionData> _listTransaction;
        private BindingSource bindingSource1;
        private System.ComponentModel.IContainer components;
        private Button homeBtn;
        private string _filePath = @"E:/SwabhavTech/ADO.Net/transaction.csv";

        public PassBookForm()
        {
            InitializeComponent();
        }


        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.printbtn = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.Label();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.downloadBtn = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.homeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(354, 161);
            this.dataGridView1.TabIndex = 0;
            // 
            // printbtn
            // 
            this.printbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printbtn.Location = new System.Drawing.Point(182, 197);
            this.printbtn.Name = "printbtn";
            this.printbtn.Size = new System.Drawing.Size(75, 23);
            this.printbtn.TabIndex = 1;
            this.printbtn.Text = "Print PassBook";
            this.printbtn.UseVisualStyleBackColor = true;
            this.printbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(257, 4);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(0, 13);
            this.username.TabIndex = 2;
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.Location = new System.Drawing.Point(221, 4);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(0, 13);
            this.usernamelabel.TabIndex = 3;
            // 
            // downloadBtn
            // 
            this.downloadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadBtn.Location = new System.Drawing.Point(402, 30);
            this.downloadBtn.Name = "downloadBtn";
            this.downloadBtn.Size = new System.Drawing.Size(75, 23);
            this.downloadBtn.TabIndex = 4;
            this.downloadBtn.Text = "Download";
            this.downloadBtn.UseVisualStyleBackColor = true;
            this.downloadBtn.Click += new System.EventHandler(this.downloadBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.Location = new System.Drawing.Point(2, 4);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(75, 23);
            this.homeBtn.TabIndex = 5;
            this.homeBtn.Text = "Home";
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // PassBookForm
            // 
            this.ClientSize = new System.Drawing.Size(480, 261);
            this.Controls.Add(this.homeBtn);
            this.Controls.Add(this.downloadBtn);
            this.Controls.Add(this.usernamelabel);
            this.Controls.Add(this.username);
            this.Controls.Add(this.printbtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PassBookForm";
            this.Load += new System.EventHandler(this.PassBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _listTransaction = _passbook.GetTransaction(_loginUser.GetUsername);

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
            usernamelabel.Text = _loginUser.GetUsername;
        }

        public void SetObj(LoginForm loginuser)
        {
            _loginUser = loginuser;
        }

        private void downloadBtn_Click(object sender, EventArgs e)
        {
            var csv = new StringBuilder();
            csv.AppendLine(string.Format("{0},{1},{2},{3}", "Name", "Amount", "Transaction Type", "Transaction Date"));
            foreach (TransactionData transactionData in _listTransaction)
            {
                var newLine = string.Format("{0},{1},{2},{3}",
                    transactionData.Name, transactionData.Amount, transactionData.Type, transactionData.Date);
                csv.AppendLine(newLine);
            }
            File.WriteAllText(_filePath, csv.ToString());
            MessageBox.Show("Download Complete");
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            HomeForrm homeForm = new HomeForrm();
            homeForm.GetObj(_loginUser);
            this.Close();
            homeForm.Show();
        }
    }
}

