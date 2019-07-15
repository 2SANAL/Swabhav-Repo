namespace BankingMdiApp
{
    partial class PassBookForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.downloadBtn = new System.Windows.Forms.Button();
            this.PassBookPrint = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(51, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(329, 152);
            this.dataGridView1.TabIndex = 0;
            // 
            // downloadBtn
            // 
            this.downloadBtn.Location = new System.Drawing.Point(386, 22);
            this.downloadBtn.Name = "downloadBtn";
            this.downloadBtn.Size = new System.Drawing.Size(75, 23);
            this.downloadBtn.TabIndex = 1;
            this.downloadBtn.Text = "Download";
            this.downloadBtn.UseVisualStyleBackColor = true;
            this.downloadBtn.Click += new System.EventHandler(this.downloadBtn_Click);
            // 
            // PassBookPrint
            // 
            this.PassBookPrint.Location = new System.Drawing.Point(159, 194);
            this.PassBookPrint.Name = "PassBookPrint";
            this.PassBookPrint.Size = new System.Drawing.Size(114, 23);
            this.PassBookPrint.TabIndex = 2;
            this.PassBookPrint.Text = "PassBookPrint";
            this.PassBookPrint.UseVisualStyleBackColor = true;
            this.PassBookPrint.Click += new System.EventHandler(this.PassBookPrint_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(1, 1);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(0, 13);
            this.usernameLabel.TabIndex = 3;
            // 
            // PassBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 316);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.PassBookPrint);
            this.Controls.Add(this.downloadBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PassBookForm";
            this.Text = "PassBookForm";
            this.Load += new System.EventHandler(this.passBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button downloadBtn;
        private System.Windows.Forms.Button PassBookPrint;
        private System.Windows.Forms.Label usernameLabel;
    }
}