namespace ATM
{
    partial class Account
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitBtn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.FNameTb = new System.Windows.Forms.TextBox();
            this.AddressTb = new System.Windows.Forms.TextBox();
            this.PhoneTb = new System.Windows.Forms.TextBox();
            this.EducationCb = new System.Windows.Forms.ComboBox();
            this.DoBDate = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.OccupationTb = new System.Windows.Forms.TextBox();
            this.AccNumTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NameTb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.PINTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.ExitBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 44);
            this.panel1.TabIndex = 1;
            // 
            // ExitBtn
            // 
            this.ExitBtn.AutoSize = true;
            this.ExitBtn.BackColor = System.Drawing.Color.Transparent;
            this.ExitBtn.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.Location = new System.Drawing.Point(645, 0);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(20, 23);
            this.ExitBtn.TabIndex = 37;
            this.ExitBtn.Text = "x";
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(173, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "ATM MANAGEMENT SYSTEM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(99, 196);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Father\'s Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(100, 256);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Address";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(101, 332);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Phone #";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.label8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label8.Location = new System.Drawing.Point(389, 136);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "Education";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.label9.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label9.Location = new System.Drawing.Point(389, 196);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 23);
            this.label9.TabIndex = 16;
            this.label9.Text = "Occupation";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.label10.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label10.Location = new System.Drawing.Point(389, 256);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 23);
            this.label10.TabIndex = 17;
            this.label10.Text = "Date of Birth";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // FNameTb
            // 
            this.FNameTb.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.FNameTb.Location = new System.Drawing.Point(100, 222);
            this.FNameTb.Margin = new System.Windows.Forms.Padding(2);
            this.FNameTb.Name = "FNameTb";
            this.FNameTb.Size = new System.Drawing.Size(176, 30);
            this.FNameTb.TabIndex = 3;
            // 
            // AddressTb
            // 
            this.AddressTb.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.AddressTb.Location = new System.Drawing.Point(101, 281);
            this.AddressTb.Margin = new System.Windows.Forms.Padding(2);
            this.AddressTb.Multiline = true;
            this.AddressTb.Name = "AddressTb";
            this.AddressTb.Size = new System.Drawing.Size(177, 39);
            this.AddressTb.TabIndex = 4;
            // 
            // PhoneTb
            // 
            this.PhoneTb.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.PhoneTb.Location = new System.Drawing.Point(101, 356);
            this.PhoneTb.Margin = new System.Windows.Forms.Padding(2);
            this.PhoneTb.Name = "PhoneTb";
            this.PhoneTb.Size = new System.Drawing.Size(175, 30);
            this.PhoneTb.TabIndex = 5;
            // 
            // EducationCb
            // 
            this.EducationCb.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.EducationCb.FormattingEnabled = true;
            this.EducationCb.Items.AddRange(new object[] {
            "Non Graduate",
            "Under Graduate",
            "Post Graduate"});
            this.EducationCb.Location = new System.Drawing.Point(391, 161);
            this.EducationCb.Margin = new System.Windows.Forms.Padding(2);
            this.EducationCb.Name = "EducationCb";
            this.EducationCb.Size = new System.Drawing.Size(175, 31);
            this.EducationCb.TabIndex = 7;
            // 
            // DoBDate
            // 
            this.DoBDate.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.DoBDate.Location = new System.Drawing.Point(391, 281);
            this.DoBDate.Margin = new System.Windows.Forms.Padding(2);
            this.DoBDate.Name = "DoBDate";
            this.DoBDate.Size = new System.Drawing.Size(175, 30);
            this.DoBDate.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 412);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(667, 10);
            this.panel2.TabIndex = 34;
            // 
            // OccupationTb
            // 
            this.OccupationTb.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.OccupationTb.Location = new System.Drawing.Point(391, 222);
            this.OccupationTb.Margin = new System.Windows.Forms.Padding(2);
            this.OccupationTb.Name = "OccupationTb";
            this.OccupationTb.Size = new System.Drawing.Size(175, 30);
            this.OccupationTb.TabIndex = 8;
            // 
            // AccNumTb
            // 
            this.AccNumTb.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.AccNumTb.Location = new System.Drawing.Point(101, 101);
            this.AccNumTb.Margin = new System.Windows.Forms.Padding(2);
            this.AccNumTb.Name = "AccNumTb";
            this.AccNumTb.Size = new System.Drawing.Size(175, 30);
            this.AccNumTb.TabIndex = 1;
            this.AccNumTb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(100, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 23);
            this.label5.TabIndex = 43;
            this.label5.Text = "Account Number";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // NameTb
            // 
            this.NameTb.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.NameTb.Location = new System.Drawing.Point(101, 162);
            this.NameTb.Margin = new System.Windows.Forms.Padding(2);
            this.NameTb.Name = "NameTb";
            this.NameTb.Size = new System.Drawing.Size(175, 30);
            this.NameTb.TabIndex = 2;
            this.NameTb.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.label11.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label11.Location = new System.Drawing.Point(100, 136);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 23);
            this.label11.TabIndex = 44;
            this.label11.Text = "Name";
            this.label11.Click += new System.EventHandler(this.label11_Click_1);
            // 
            // PINTb
            // 
            this.PINTb.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.PINTb.Location = new System.Drawing.Point(391, 101);
            this.PINTb.Margin = new System.Windows.Forms.Padding(2);
            this.PINTb.Name = "PINTb";
            this.PINTb.Size = new System.Drawing.Size(175, 30);
            this.PINTb.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(389, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 23);
            this.label2.TabIndex = 47;
            this.label2.Text = "PIN";
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutBtn.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.LogoutBtn.ForeColor = System.Drawing.Color.White;
            this.LogoutBtn.Location = new System.Drawing.Point(480, 332);
            this.LogoutBtn.Margin = new System.Windows.Forms.Padding(2);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(79, 32);
            this.LogoutBtn.TabIndex = 11;
            this.LogoutBtn.Text = "LOGOUT";
            this.LogoutBtn.UseVisualStyleBackColor = false;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.SubmitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitBtn.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.SubmitBtn.ForeColor = System.Drawing.Color.White;
            this.SubmitBtn.Location = new System.Drawing.Point(397, 332);
            this.SubmitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(79, 32);
            this.SubmitBtn.TabIndex = 10;
            this.SubmitBtn.Text = "SUBMIT";
            this.SubmitBtn.UseVisualStyleBackColor = false;
            this.SubmitBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(667, 422);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.PINTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AccNumTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NameTb);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.OccupationTb);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DoBDate);
            this.Controls.Add(this.EducationCb);
            this.Controls.Add(this.PhoneTb);
            this.Controls.Add(this.AddressTb);
            this.Controls.Add(this.FNameTb);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account";
            this.Load += new System.EventHandler(this.Account_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox FNameTb;
        private System.Windows.Forms.TextBox AddressTb;
        private System.Windows.Forms.TextBox PhoneTb;
        private System.Windows.Forms.ComboBox EducationCb;
        private System.Windows.Forms.DateTimePicker DoBDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox OccupationTb;
        private System.Windows.Forms.Label ExitBtn;
        private System.Windows.Forms.TextBox AccNumTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NameTb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox PINTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button SubmitBtn;
    }
}