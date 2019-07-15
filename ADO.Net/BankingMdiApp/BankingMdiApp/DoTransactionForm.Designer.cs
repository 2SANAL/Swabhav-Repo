namespace BankingMdiApp
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
            this.amountTb = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.withdrawTB = new System.Windows.Forms.RadioButton();
            this.depositeRB = new System.Windows.Forms.RadioButton();
            this.transactionBtn = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount";
            // 
            // amountTb
            // 
            this.amountTb.Location = new System.Drawing.Point(223, 57);
            this.amountTb.Name = "amountTb";
            this.amountTb.Size = new System.Drawing.Size(100, 20);
            this.amountTb.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.withdrawTB);
            this.groupBox1.Controls.Add(this.depositeRB);
            this.groupBox1.Location = new System.Drawing.Point(151, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 71);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transaction Type";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // withdrawTB
            // 
            this.withdrawTB.AutoSize = true;
            this.withdrawTB.Location = new System.Drawing.Point(38, 43);
            this.withdrawTB.Name = "withdrawTB";
            this.withdrawTB.Size = new System.Drawing.Size(70, 17);
            this.withdrawTB.TabIndex = 1;
            this.withdrawTB.TabStop = true;
            this.withdrawTB.Text = "Withdraw";
            this.withdrawTB.UseVisualStyleBackColor = true;
            this.withdrawTB.CheckedChanged += new System.EventHandler(this.withdrawTB_CheckedChanged);
            // 
            // depositeRB
            // 
            this.depositeRB.AutoSize = true;
            this.depositeRB.Location = new System.Drawing.Point(38, 19);
            this.depositeRB.Name = "depositeRB";
            this.depositeRB.Size = new System.Drawing.Size(67, 17);
            this.depositeRB.TabIndex = 0;
            this.depositeRB.TabStop = true;
            this.depositeRB.Text = "Deposite";
            this.depositeRB.UseVisualStyleBackColor = true;
            this.depositeRB.CheckedChanged += new System.EventHandler(this.depositeRB_CheckedChanged_1);
            // 
            // transactionBtn
            // 
            this.transactionBtn.Location = new System.Drawing.Point(189, 172);
            this.transactionBtn.Name = "transactionBtn";
            this.transactionBtn.Size = new System.Drawing.Size(75, 23);
            this.transactionBtn.TabIndex = 3;
            this.transactionBtn.Text = "Transaction";
            this.transactionBtn.UseVisualStyleBackColor = true;
            this.transactionBtn.Click += new System.EventHandler(this.transactionBtn_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(13, 13);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(35, 13);
            this.usernameLabel.TabIndex = 4;
            this.usernameLabel.Text = "label2";
            // 
            // DoTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 297);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.transactionBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.amountTb);
            this.Controls.Add(this.label1);
            this.Name = "DoTransactionForm";
            this.Text = "DoTransactionForm";
            this.Load += new System.EventHandler(this.DoTransactionForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox amountTb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton withdrawTB;
        private System.Windows.Forms.RadioButton depositeRB;
        private System.Windows.Forms.Button transactionBtn;
        private System.Windows.Forms.Label usernameLabel;
    }
}