namespace BankingMdiApp
{
    partial class RegistrationForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.usernameTb = new System.Windows.Forms.TextBox();
            this.passwordTb = new System.Windows.Forms.TextBox();
            this.rePasswordTb = new System.Windows.Forms.TextBox();
            this.amountTb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Re-Enter Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(179, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Deposite Amount";
            // 
            // usernameTb
            // 
            this.usernameTb.Location = new System.Drawing.Point(283, 98);
            this.usernameTb.Name = "usernameTb";
            this.usernameTb.Size = new System.Drawing.Size(100, 20);
            this.usernameTb.TabIndex = 5;
            // 
            // passwordTb
            // 
            this.passwordTb.Location = new System.Drawing.Point(283, 124);
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.PasswordChar = '*';
            this.passwordTb.Size = new System.Drawing.Size(100, 20);
            this.passwordTb.TabIndex = 6;
            // 
            // rePasswordTb
            // 
            this.rePasswordTb.Location = new System.Drawing.Point(283, 164);
            this.rePasswordTb.Name = "rePasswordTb";
            this.rePasswordTb.PasswordChar = '*';
            this.rePasswordTb.Size = new System.Drawing.Size(100, 20);
            this.rePasswordTb.TabIndex = 7;
            // 
            // amountTb
            // 
            this.amountTb.Location = new System.Drawing.Point(283, 192);
            this.amountTb.Name = "amountTb";
            this.amountTb.Size = new System.Drawing.Size(100, 20);
            this.amountTb.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Registor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 341);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.amountTb);
            this.Controls.Add(this.rePasswordTb);
            this.Controls.Add(this.passwordTb);
            this.Controls.Add(this.usernameTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox usernameTb;
        private System.Windows.Forms.TextBox passwordTb;
        private System.Windows.Forms.TextBox rePasswordTb;
        private System.Windows.Forms.TextBox amountTb;
        private System.Windows.Forms.Button button1;
    }
}