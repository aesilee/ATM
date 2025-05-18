namespace ATM
{
    partial class Home
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
            this.ExitBtn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DepositBtn = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.CheckBalanceBtn = new System.Windows.Forms.Button();
            this.MiniStatementBtn = new System.Windows.Forms.Button();
            this.WithdrawBtn = new System.Windows.Forms.Button();
            this.FastCashBtn = new System.Windows.Forms.Button();
            this.ChangePINBtn = new System.Windows.Forms.Button();
            this.AccNumLbl = new System.Windows.Forms.Label();
            this.TransferBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExitBtn
            // 
            this.ExitBtn.AutoSize = true;
            this.ExitBtn.BackColor = System.Drawing.Color.Transparent;
            this.ExitBtn.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.Location = new System.Drawing.Point(647, 0);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(20, 23);
            this.ExitBtn.TabIndex = 11;
            this.ExitBtn.Text = "x";
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "CHOOSE A TRANSACTION";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DepositBtn
            // 
            this.DepositBtn.BackColor = System.Drawing.Color.White;
            this.DepositBtn.Font = new System.Drawing.Font("Bahnschrift", 20F);
            this.DepositBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.DepositBtn.Location = new System.Drawing.Point(46, 108);
            this.DepositBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DepositBtn.Name = "DepositBtn";
            this.DepositBtn.Size = new System.Drawing.Size(253, 46);
            this.DepositBtn.TabIndex = 9;
            this.DepositBtn.Text = "Deposit";
            this.DepositBtn.UseVisualStyleBackColor = false;
            this.DepositBtn.Click += new System.EventHandler(this.DepositBtn_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.LogoutBtn.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.LogoutBtn.ForeColor = System.Drawing.Color.White;
            this.LogoutBtn.Location = new System.Drawing.Point(566, 370);
            this.LogoutBtn.Margin = new System.Windows.Forms.Padding(2);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(80, 32);
            this.LogoutBtn.TabIndex = 42;
            this.LogoutBtn.Text = "LOGOUT";
            this.LogoutBtn.UseVisualStyleBackColor = false;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // CheckBalanceBtn
            // 
            this.CheckBalanceBtn.BackColor = System.Drawing.Color.White;
            this.CheckBalanceBtn.Font = new System.Drawing.Font("Bahnschrift", 20F);
            this.CheckBalanceBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.CheckBalanceBtn.Location = new System.Drawing.Point(378, 182);
            this.CheckBalanceBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CheckBalanceBtn.Name = "CheckBalanceBtn";
            this.CheckBalanceBtn.Size = new System.Drawing.Size(253, 46);
            this.CheckBalanceBtn.TabIndex = 48;
            this.CheckBalanceBtn.Text = "Check Balance";
            this.CheckBalanceBtn.UseVisualStyleBackColor = false;
            this.CheckBalanceBtn.Click += new System.EventHandler(this.CheckBalanceBtn_Click);
            // 
            // MiniStatementBtn
            // 
            this.MiniStatementBtn.BackColor = System.Drawing.Color.White;
            this.MiniStatementBtn.Font = new System.Drawing.Font("Bahnschrift", 20F);
            this.MiniStatementBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.MiniStatementBtn.Location = new System.Drawing.Point(378, 256);
            this.MiniStatementBtn.Margin = new System.Windows.Forms.Padding(2);
            this.MiniStatementBtn.Name = "MiniStatementBtn";
            this.MiniStatementBtn.Size = new System.Drawing.Size(253, 46);
            this.MiniStatementBtn.TabIndex = 49;
            this.MiniStatementBtn.Text = "Mini Statement";
            this.MiniStatementBtn.UseVisualStyleBackColor = false;
            this.MiniStatementBtn.Click += new System.EventHandler(this.MiniStatementBtn_Click);
            // 
            // WithdrawBtn
            // 
            this.WithdrawBtn.BackColor = System.Drawing.Color.White;
            this.WithdrawBtn.Font = new System.Drawing.Font("Bahnschrift", 20F);
            this.WithdrawBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.WithdrawBtn.Location = new System.Drawing.Point(378, 108);
            this.WithdrawBtn.Margin = new System.Windows.Forms.Padding(2);
            this.WithdrawBtn.Name = "WithdrawBtn";
            this.WithdrawBtn.Size = new System.Drawing.Size(253, 46);
            this.WithdrawBtn.TabIndex = 50;
            this.WithdrawBtn.Text = "Withdraw";
            this.WithdrawBtn.UseVisualStyleBackColor = false;
            this.WithdrawBtn.Click += new System.EventHandler(this.WithdrawBtn_Click);
            // 
            // FastCashBtn
            // 
            this.FastCashBtn.BackColor = System.Drawing.Color.White;
            this.FastCashBtn.Font = new System.Drawing.Font("Bahnschrift", 20F);
            this.FastCashBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.FastCashBtn.Location = new System.Drawing.Point(46, 256);
            this.FastCashBtn.Margin = new System.Windows.Forms.Padding(2);
            this.FastCashBtn.Name = "FastCashBtn";
            this.FastCashBtn.Size = new System.Drawing.Size(253, 46);
            this.FastCashBtn.TabIndex = 51;
            this.FastCashBtn.Text = "Fast Cash";
            this.FastCashBtn.UseVisualStyleBackColor = false;
            this.FastCashBtn.Click += new System.EventHandler(this.FastCashBtn_Click);
            // 
            // ChangePINBtn
            // 
            this.ChangePINBtn.BackColor = System.Drawing.Color.White;
            this.ChangePINBtn.Font = new System.Drawing.Font("Bahnschrift", 20F);
            this.ChangePINBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ChangePINBtn.Location = new System.Drawing.Point(46, 331);
            this.ChangePINBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ChangePINBtn.Name = "ChangePINBtn";
            this.ChangePINBtn.Size = new System.Drawing.Size(253, 46);
            this.ChangePINBtn.TabIndex = 52;
            this.ChangePINBtn.Text = "Change PIN";
            this.ChangePINBtn.UseVisualStyleBackColor = false;
            this.ChangePINBtn.Click += new System.EventHandler(this.ChangePINBtn_Click);
            // 
            // AccNumLbl
            // 
            this.AccNumLbl.AutoSize = true;
            this.AccNumLbl.BackColor = System.Drawing.Color.Transparent;
            this.AccNumLbl.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.AccNumLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AccNumLbl.Location = new System.Drawing.Point(42, 57);
            this.AccNumLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AccNumLbl.Name = "AccNumLbl";
            this.AccNumLbl.Size = new System.Drawing.Size(69, 19);
            this.AccNumLbl.TabIndex = 53;
            this.AccNumLbl.Text = "AccNum";
            // 
            // TransferBtn
            // 
            this.TransferBtn.BackColor = System.Drawing.Color.White;
            this.TransferBtn.Font = new System.Drawing.Font("Bahnschrift", 20F);
            this.TransferBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.TransferBtn.Location = new System.Drawing.Point(46, 182);
            this.TransferBtn.Margin = new System.Windows.Forms.Padding(2);
            this.TransferBtn.Name = "TransferBtn";
            this.TransferBtn.Size = new System.Drawing.Size(253, 46);
            this.TransferBtn.TabIndex = 54;
            this.TransferBtn.Text = "Transfer";
            this.TransferBtn.UseVisualStyleBackColor = false;
            this.TransferBtn.Click += new System.EventHandler(this.TransferBtn_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(667, 422);
            this.Controls.Add(this.TransferBtn);
            this.Controls.Add(this.AccNumLbl);
            this.Controls.Add(this.ChangePINBtn);
            this.Controls.Add(this.FastCashBtn);
            this.Controls.Add(this.WithdrawBtn);
            this.Controls.Add(this.MiniStatementBtn);
            this.Controls.Add(this.CheckBalanceBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.DepositBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ExitBtn;
        private System.Windows.Forms.Button DepositBtn;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button CheckBalanceBtn;
        private System.Windows.Forms.Button MiniStatementBtn;
        private System.Windows.Forms.Button WithdrawBtn;
        private System.Windows.Forms.Button FastCashBtn;
        private System.Windows.Forms.Button ChangePINBtn;
        private System.Windows.Forms.Label AccNumLbl;
        private System.Windows.Forms.Button TransferBtn;
    }
}