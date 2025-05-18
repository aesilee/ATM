using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.NetworkInformation;


namespace ATM
{
    public partial class Deposit: Form
    {
        public Deposit()
        {
            InitializeComponent();

            DepositBtn.BackColor = Color.White;
            DepositBtn.ForeColor = Color.DarkSlateGray;
            BackBtn.BackColor = Color.White;
            BackBtn.ForeColor = Color.DarkSlateGray;
            ExitBtn.ForeColor = Color.DarkSlateGray;

            DepositBtn.MouseEnter += DepositBtn_MouseEnter;
            DepositBtn.MouseLeave += DepositBtn_MouseLeave;
            BackBtn.MouseEnter += BackBtn_MouseEnter;
            BackBtn.MouseLeave += BackBtn_MouseLeave;
            ExitBtn.MouseEnter += ExitBtn_MouseEnter;
            ExitBtn.MouseLeave += ExitBtn_MouseLeave;
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ashbs\source\repos\ATM\ATM\ATMDB.mdf;Integrated Security=True;Connect Timeout=30");

        string Acc = Login.accountNum;
        int OldBalance, NewBalance;

        public void GetBalanceMethod()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Balance from AccountTbl where AccNum= '" + Acc + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            OldBalance = Convert.ToInt32(dt.Rows[0][0].ToString());
            con.Close();
        }

        private void AddTransactionmethod()
        {
            string TransactionType = "Deposit";
            try
            {
                con.Open();
                string query = "INSERT INTO TransactionTbl VALUES('" + Acc + "','" + TransactionType + "', " + DepositAmtLbl.Text + ",'" + DateTime.Today.ToString("yyyy-MM-dd") + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Deposit_Load(object sender, EventArgs e)
        {
            GetBalanceMethod();
        }
        private void DepositBtn_Click(object sender, EventArgs e)
        {
            if (DepositAmtLbl.Text == "" || Convert.ToInt32(DepositAmtLbl.Text) <= 0)
            {
                MessageBox.Show("Enter Amount To Deposit");
            }
            else
            {
                NewBalance = OldBalance + Convert.ToInt32(DepositAmtLbl.Text);
                try
                {
                    con.Open();
                    string query = "UPDATE AccountTbl SET Balance = @NewBalance WHERE AccNum = @AccNum";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@NewBalance", NewBalance);
                    cmd.Parameters.AddWithValue("@AccNum", Acc);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Amount Deposited Successfully");

                    con.Close();

                    AddTransactionmethod();

                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }   


        private void BackBtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private async void ExitBtn_MouseEnter(object sender, EventArgs e)
        {
            Color originalColor = Color.DarkSlateGray; // Start from DarkSlateGray
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
            Color targetColor = Color.DarkSlateGray; // Return to DarkSlateGray
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

            ExitBtn.Size = originalSize;
            ExitBtn.Location = originalLocation;
            ExitBtn.ForeColor = Color.DarkSlateGray; // Return to DarkSlateGray after click

            // Original exit code remains unchanged
            Application.Exit();
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

        private void BackBtn_MouseEnter(object sender, EventArgs e)
        {
            BackBtn.BackColor = ColorTranslator.FromHtml("#203737");
            BackBtn.ForeColor = Color.White;
        }

        private void BackBtn_MouseLeave(object sender, EventArgs e)
        {
            BackBtn.BackColor = Color.White;
            BackBtn.ForeColor = Color.DarkSlateGray;
        }
    }
}
