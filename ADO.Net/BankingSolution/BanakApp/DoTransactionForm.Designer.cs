namespace BanakApp
{
    partial class DoTransactionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.amountTB = new System.Windows.Forms.TextBox();
            this.TransactionGroupBox = new System.Windows.Forms.GroupBox();
            this.withdrowRb = new System.Windows.Forms.RadioButton();
            this.depositeRb = new System.Windows.Forms.RadioButton();
            this.SubmitTransactionbtn = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.Label();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.showBalance = new System.Windows.Forms.Button();
            this.TransactionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount";
            // 
            // amountTB
            // 
            this.amountTB.Location = new System.Drawing.Point(206, 58);
            this.amountTB.Name = "amountTB";
            this.amountTB.Size = new System.Drawing.Size(100, 20);
            this.amountTB.TabIndex = 1;
            // 
            // TransactionGroupBox
            // 
            this.TransactionGroupBox.Controls.Add(this.withdrowRb);
            this.TransactionGroupBox.Controls.Add(this.depositeRb);
            this.TransactionGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionGroupBox.Location = new System.Drawing.Point(131, 100);
            this.TransactionGroupBox.Name = "TransactionGroupBox";
            this.TransactionGroupBox.Size = new System.Drawing.Size(189, 68);
            this.TransactionGroupBox.TabIndex = 2;
            this.TransactionGroupBox.TabStop = false;
            this.TransactionGroupBox.Text = "Transaction Type";
            // 
            // withdrowRb
            // 
            this.withdrowRb.AutoSize = true;
            this.withdrowRb.Location = new System.Drawing.Point(46, 42);
            this.withdrowRb.Name = "withdrowRb";
            this.withdrowRb.Size = new System.Drawing.Size(78, 17);
            this.withdrowRb.TabIndex = 1;
            this.withdrowRb.TabStop = true;
            this.withdrowRb.Text = "Withdraw";
            this.withdrowRb.UseVisualStyleBackColor = true;
            this.withdrowRb.CheckedChanged += new System.EventHandler(this.withdrowRb_CheckedChanged);
            // 
            // depositeRb
            // 
            this.depositeRb.AutoSize = true;
            this.depositeRb.Location = new System.Drawing.Point(46, 19);
            this.depositeRb.Name = "depositeRb";
            this.depositeRb.Size = new System.Drawing.Size(75, 17);
            this.depositeRb.TabIndex = 0;
            this.depositeRb.TabStop = true;
            this.depositeRb.Text = "Deposite";
            this.depositeRb.UseVisualStyleBackColor = true;
            this.depositeRb.CheckedChanged += new System.EventHandler(this.depositeRb_CheckedChanged);
            // 
            // SubmitTransactionbtn
            // 
            this.SubmitTransactionbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitTransactionbtn.Location = new System.Drawing.Point(191, 185);
            this.SubmitTransactionbtn.Name = "SubmitTransactionbtn";
            this.SubmitTransactionbtn.Size = new System.Drawing.Size(75, 23);
            this.SubmitTransactionbtn.TabIndex = 3;
            this.SubmitTransactionbtn.Text = "Submit";
            this.SubmitTransactionbtn.UseVisualStyleBackColor = true;
            this.SubmitTransactionbtn.Click += new System.EventHandler(this.SubmitTransactionbtn_Click);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(366, 20);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(0, 13);
            this.username.TabIndex = 4;
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.Location = new System.Drawing.Point(391, 13);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(0, 13);
            this.usernamelabel.TabIndex = 5;
            // 
            // showBalance
            // 
            this.showBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showBalance.Location = new System.Drawing.Point(3, 3);
            this.showBalance.Name = "showBalance";
            this.showBalance.Size = new System.Drawing.Size(75, 23);
            this.showBalance.TabIndex = 6;
            this.showBalance.Text = "Home";
            this.showBalance.UseVisualStyleBackColor = true;
            this.showBalance.Click += new System.EventHandler(this.button1_Click);
            // 
            // DoTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 324);
            this.Controls.Add(this.showBalance);
            this.Controls.Add(this.usernamelabel);
            this.Controls.Add(this.username);
            this.Controls.Add(this.SubmitTransactionbtn);
            this.Controls.Add(this.TransactionGroupBox);
            this.Controls.Add(this.amountTB);
            this.Controls.Add(this.label1);
            this.Name = "DoTransactionForm";
            this.Text = "DoTransactionForm";
            this.Load += new System.EventHandler(this.DoTransactionForm_Load);
            this.TransactionGroupBox.ResumeLayout(false);
            this.TransactionGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox amountTB;
        private System.Windows.Forms.GroupBox TransactionGroupBox;
        private System.Windows.Forms.RadioButton withdrowRb;
        private System.Windows.Forms.RadioButton depositeRb;
        private System.Windows.Forms.Button SubmitTransactionbtn;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.Button showBalance;
    }
}