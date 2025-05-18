using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Home: Form
    {
        public Home()
        {
            InitializeComponent();

            DepositBtn.ForeColor = Color.DarkSlateGray;
            DepositBtn.BackColor = Color.White;
            WithdrawBtn.ForeColor = Color.DarkSlateGray;
            WithdrawBtn.BackColor = Color.White;
            TransferBtn.ForeColor = Color.DarkSlateGray;
            TransferBtn.BackColor = Color.White;
            CheckBalanceBtn.ForeColor = Color.DarkSlateGray;
            CheckBalanceBtn.BackColor = Color.White;
            FastCashBtn.ForeColor = Color.DarkSlateGray;
            FastCashBtn.BackColor = Color.White;
            MiniStatementBtn.ForeColor = Color.DarkSlateGray;
            MiniStatementBtn.BackColor = Color.White;
            ChangePINBtn.ForeColor = Color.DarkSlateGray;
            ChangePINBtn.BackColor = Color.White;
            LogoutBtn.ForeColor = Color.White;
            LogoutBtn.BackColor = Color.DarkSlateGray;
            ExitBtn.ForeColor = Color.White;

            DepositBtn.MouseEnter += DepositBtn_MouseEnter;
            DepositBtn.MouseLeave += DepositBtn_MouseLeave;
            WithdrawBtn.MouseEnter += WithdrawBtn_MouseEnter;
            WithdrawBtn.MouseLeave += WithdrawBtn_MouseLeave;
            TransferBtn.MouseEnter += TransferBtn_MouseEnter;
            TransferBtn.MouseLeave += TransferBtn_MouseLeave;
            CheckBalanceBtn.MouseEnter += CheckBalanceBtn_MouseEnter;
            CheckBalanceBtn.MouseLeave += CheckBalanceBtn_MouseLeave;
            FastCashBtn.MouseEnter += FastCashBtn_MouseEnter;
            FastCashBtn.MouseLeave += FastCashBtn_MouseLeave;
            MiniStatementBtn.MouseEnter += MiniStatementBtn_MouseEnter;
            MiniStatementBtn.MouseLeave += MiniStatementBtn_MouseLeave;
            ChangePINBtn.MouseEnter += ChangePINBtn_MouseEnter;
            ChangePINBtn.MouseLeave += ChangePINBtn_MouseLeave;
            LogoutBtn.MouseEnter += LogoutBtn_MouseEnter;
            LogoutBtn.MouseLeave += LogoutBtn_MouseLeave;
            ExitBtn.MouseEnter += ExitBtn_MouseEnter;
            ExitBtn.MouseLeave += ExitBtn_MouseLeave;
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
        private void CheckBalanceBtn_Click(object sender, EventArgs e)
        {
            Balance bal = new Balance();
            bal.Show();
            this.Hide();
        }

        private void MiniStatementBtn_Click(object sender, EventArgs e)
        {
            MiniStatement Min = new MiniStatement();
            Min.Show();
            this.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            AccNumLbl.Text = Login.accountNum;
            ExitBtn.ForeColor = Color.White;
        }

        private void DepositBtn_Click(object sender, EventArgs e)
        {
            Deposit dep = new Deposit();
            dep.Show();
            this.Hide();
        }

        private void ChangePINBtn_Click(object sender, EventArgs e)
        {
            ChangePin CPin = new ChangePin();
            CPin.Show();
            this.Hide();
        }

        private void WithdrawBtn_Click(object sender, EventArgs e)
        {
            Withdraw wd = new Withdraw();
            wd.Show();
            this.Hide();
        }

        private void FastCashBtn_Click(object sender, EventArgs e)
        {
            FastCash fc = new FastCash();
            fc.Show();
            this.Hide();
        }
        private void TransferBtn_Click(object sender, EventArgs e)
        {
            Transfer transfer = new Transfer();
            transfer.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void DepositBtn_MouseEnter(object sender, EventArgs e)
        {
            DepositBtn.BackColor = ColorTranslator.FromHtml("#203737");
            DepositBtn.ForeColor = Color.White;
        }

        private void DepositBtn_MouseLeave(object sender, EventArgs e)
        {
            DepositBtn.BackColor = Color.White;
            DepositBtn.ForeColor = Color.DarkSlateGray;
        }

        private void WithdrawBtn_MouseEnter(object sender, EventArgs e)
        {
            WithdrawBtn.BackColor = ColorTranslator.FromHtml("#203737");
            WithdrawBtn.ForeColor = Color.White;
        }

        private void WithdrawBtn_MouseLeave(object sender, EventArgs e)
        {
            WithdrawBtn.BackColor = Color.White;
            WithdrawBtn.ForeColor = Color.DarkSlateGray;
        }

        private void TransferBtn_MouseEnter(object sender, EventArgs e)
        {
            TransferBtn.BackColor = ColorTranslator.FromHtml("#203737");
            TransferBtn.ForeColor = Color.White;
        }

        private void TransferBtn_MouseLeave(object sender, EventArgs e)
        {
            TransferBtn.BackColor = Color.White;
            TransferBtn.ForeColor = Color.DarkSlateGray;
        }

        private void CheckBalanceBtn_MouseEnter(object sender, EventArgs e)
        {
            CheckBalanceBtn.BackColor = ColorTranslator.FromHtml("#203737");
            CheckBalanceBtn.ForeColor = Color.White;
        }

        private void CheckBalanceBtn_MouseLeave(object sender, EventArgs e)
        {
            CheckBalanceBtn.BackColor = Color.White;
            CheckBalanceBtn.ForeColor = Color.DarkSlateGray;
        }

        private void FastCashBtn_MouseEnter(object sender, EventArgs e)
        {
            FastCashBtn.BackColor = ColorTranslator.FromHtml("#203737");
            FastCashBtn.ForeColor = Color.White;
        }

        private void FastCashBtn_MouseLeave(object sender, EventArgs e)
        {
            FastCashBtn.BackColor = Color.White;
            FastCashBtn.ForeColor = Color.DarkSlateGray;
        }

        private void MiniStatementBtn_MouseEnter(object sender, EventArgs e)
        {
            MiniStatementBtn.BackColor = ColorTranslator.FromHtml("#203737");
            MiniStatementBtn.ForeColor = Color.White;
        }

        private void MiniStatementBtn_MouseLeave(object sender, EventArgs e)
        {
            MiniStatementBtn.BackColor = Color.White;
            MiniStatementBtn.ForeColor = Color.DarkSlateGray;
        }

        private void ChangePINBtn_MouseEnter(object sender, EventArgs e)
        {
            ChangePINBtn.BackColor = ColorTranslator.FromHtml("#203737");
            ChangePINBtn.ForeColor = Color.White;
        }

        private void ChangePINBtn_MouseLeave(object sender, EventArgs e)
        {
            ChangePINBtn.BackColor = Color.White;
            ChangePINBtn.ForeColor = Color.DarkSlateGray;
        }

        private void LogoutBtn_MouseEnter(object sender, EventArgs e)
        {
            LogoutBtn.BackColor = Color.White;
            LogoutBtn.ForeColor = Color.DarkSlateGray;
        }

        private void LogoutBtn_MouseLeave(object sender, EventArgs e)
        {
            LogoutBtn.BackColor = Color.DarkSlateGray;
            LogoutBtn.ForeColor = Color.White;
        }

        private async void ExitBtn_MouseEnter(object sender, EventArgs e)
        {
            Color originalColor = Color.White; // Start from White
            for (int i = 0; i <= 10; i++)
            {
                int r = originalColor.R + (int)((Color.LightCoral.R - originalColor.R) * (i / 10f));
                int g = originalColor.G + (int)((Color.LightCoral.G - originalColor.G) * (i / 10f));
                int b = originalColor.B + (int)((Color.LightCoral.B - originalColor.B) * (i / 10f));
                ExitBtn.ForeColor = Color.FromArgb(r, g, b);
                await Task.Delay(15);
            }
        }

        private async void ExitBtn_MouseLeave(object sender, EventArgs e)
        {
            Color hoverColor = ExitBtn.ForeColor;
            Color targetColor = Color.White; // Return to White
            for (int i = 0; i <= 10; i++)
            {
                int r = hoverColor.R + (int)((targetColor.R - hoverColor.R) * (i / 10f));
                int g = hoverColor.G + (int)((targetColor.G - hoverColor.G) * (i / 10f));
                int b = hoverColor.B + (int)((targetColor.B - hoverColor.B) * (i / 10f));
                ExitBtn.ForeColor = Color.FromArgb(r, g, b);
                await Task.Delay(15);
            }
        }

        private async void ExitBtn_Click(object sender, EventArgs e)
        {
            // Click animation
            Size originalSize = ExitBtn.Size;
            Point originalLocation = ExitBtn.Location;
            Color originalColor = ExitBtn.ForeColor;

            for (int i = 0; i < 5; i++)
            {
                ExitBtn.Size = new Size(originalSize.Width - 4, originalSize.Height - 2);
                ExitBtn.Location = new Point(originalLocation.X + 2, originalLocation.Y + 1);
                ExitBtn.ForeColor = Color.LightCoral;
                await Task.Delay(10);
            }

            await Task.Delay(50);

            // Restore original appearance
            ExitBtn.Size = originalSize;
            ExitBtn.Location = originalLocation;
            ExitBtn.ForeColor = Color.White; // Return to White after click

            Application.Exit();
        }
    }
}
