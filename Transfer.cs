using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Transfer: Form
    {
        private readonly SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ashbs\source\repos\ATM\ATM\ATMDB.mdf;Integrated Security=True;Connect Timeout=30");
        private readonly string Acc = Login.accountNum;
        private int CurrentBalance;

        public Transfer()
        {
            InitializeComponent();

            ExitBtn.MouseEnter += ExitBtn_MouseEnter;
            ExitBtn.MouseLeave += ExitBtn_MouseLeave;
        }

        // ============= EXIT BUTTON ANIMATIONS ONLY =============
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
        // ============= END OF EXIT BUTTON ANIMATIONS =============


        private void GetBalance()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                using (SqlCommand cmd = new SqlCommand("SELECT Balance FROM AccountTbl WHERE AccNum = @AccNum", con))
                {
                    cmd.Parameters.AddWithValue("@AccNum", Acc);
                    CurrentBalance = Convert.ToInt32(cmd.ExecuteScalar());
                    BalanceLbl.Text = $"Current Balance: {CurrentBalance}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving balance: {ex.Message}");
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private bool AccountExists(string accountNumber)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM AccountTbl WHERE AccNum = @AccNum", con))
                {
                    cmd.Parameters.AddWithValue("@AccNum", accountNumber);
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void AddTransaction(string recipientAccNum, int amount, SqlTransaction transaction)
        {
            try
            {
                string senderQuery = "INSERT INTO TransactionTbl (AccNum, Type, Amount, TDate) " +
                           "VALUES (@AccNum, @Type, @Amount, @TDate)";
                using (SqlCommand senderCmd = new SqlCommand(senderQuery, con, transaction))
                {
                    senderCmd.Parameters.AddWithValue("@AccNum", Acc);
                    senderCmd.Parameters.AddWithValue("@Type", "Sent to " + recipientAccNum);
                    senderCmd.Parameters.AddWithValue("@Amount", amount);
                    senderCmd.Parameters.AddWithValue("@TDate", DateTime.Today.ToString("yyyy-MM-dd"));
                    senderCmd.ExecuteNonQuery();
                }

                // Record incoming transfer for recipient (Type = "Received")
                string recipientQuery = "INSERT INTO TransactionTbl (AccNum, Type, Amount, TDate) " +
                                      "VALUES (@RecipientAccNum, @RecipientType, @RecipientAmount, @RecipientTDate)";
                using (SqlCommand recipientCmd = new SqlCommand(recipientQuery, con, transaction))
                {
                    recipientCmd.Parameters.AddWithValue("@RecipientAccNum", recipientAccNum);
                    recipientCmd.Parameters.AddWithValue("@RecipientType", "Received from " + Acc);
                    recipientCmd.Parameters.AddWithValue("@RecipientAmount", amount);
                    recipientCmd.Parameters.AddWithValue("@RecipientTDate", DateTime.Today.ToString("yyyy-MM-dd"));
                    recipientCmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to record transaction: " + ex.Message);
            }
        }

        private void Transfer_Load(object sender, EventArgs e)
        {
            GetBalance();
            ExitBtn.ForeColor = Color.DarkSlateGray;
        }

        private void TransferBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RecipientAccNumTb.Text) || string.IsNullOrWhiteSpace(AmountTb.Text))
            {
                MessageBox.Show("Please enter recipient account number and amount");
                return;
            }

            if (RecipientAccNumTb.Text == Acc)
            {
                MessageBox.Show("You cannot transfer to your own account");
                return;
            }

            if (!int.TryParse(AmountTb.Text, out int amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid positive amount");
                return;
            }

            if (amount > CurrentBalance)
            {
                MessageBox.Show("Insufficient balance for this transfer");
                return;
            }

            // Check if recipient exists
            if (!AccountExists(RecipientAccNumTb.Text))
            {
                MessageBox.Show("Recipient account does not exist");
                return;
            }

            // Perform transfer
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                using (SqlTransaction transaction = con.BeginTransaction())
                {
                    try
                    {
                        // Deduct from sender
                        using (SqlCommand deductCmd = new SqlCommand(
                            "UPDATE AccountTbl SET Balance = Balance - @Amount WHERE AccNum = @SenderAccNum",
                            con, transaction))
                        {
                            deductCmd.Parameters.AddWithValue("@Amount", amount);
                            deductCmd.Parameters.AddWithValue("@SenderAccNum", Acc);
                            deductCmd.ExecuteNonQuery();
                        }

                        // Add to recipient
                        using (SqlCommand addCmd = new SqlCommand(
                            "UPDATE AccountTbl SET Balance = Balance + @Amount WHERE AccNum = @RecipientAccNum",
                            con, transaction))
                        {
                            addCmd.Parameters.AddWithValue("@Amount", amount);
                            addCmd.Parameters.AddWithValue("@RecipientAccNum", RecipientAccNumTb.Text);
                            addCmd.ExecuteNonQuery();
                        }

                        // Record transactions
                        AddTransaction(RecipientAccNumTb.Text, amount, transaction);

                        transaction.Commit();
                        MessageBox.Show($"Successfully transferred {amount} to account {RecipientAccNumTb.Text}");

                        Home home = new Home();
                        home.Show();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Transfer failed: {ex.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error: {ex.Message}");
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
