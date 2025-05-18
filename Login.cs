using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Drawing;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ATM
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            ExitBtn.MouseEnter += ExitBtn_MouseEnter;
            ExitBtn.MouseLeave += ExitBtn_MouseLeave;
            LoginBtn.MouseEnter += LoginBtn_MouseEnter;
            LoginBtn.MouseLeave += LoginBtn_MouseLeave;
            SignUpBtn.MouseEnter += SignUpBtn_MouseEnter;
            SignUpBtn.MouseLeave += SignUpBtn_MouseLeave;
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ashbs\source\repos\ATM\ATM\ATMDB.mdf;Integrated Security=True;Connect Timeout=30");

        public static string accountNum;

        private void Login_Load(object sender, EventArgs e)
        {
            ExitBtn.ForeColor = Color.DarkSlateGray;
            LoginBtn.BackColor = Color.DarkSlateGray;
            LoginBtn.ForeColor = Color.White;
            SignUpBtn.BackColor = Color.DarkSlateGray;
            SignUpBtn.ForeColor = Color.White;
        }

        // ============= BUTTON ANIMATIONS =============
        private async void LoginBtn_MouseEnter(object sender, EventArgs e)
        {
            await AnimateButtonColors(LoginBtn, Color.White, Color.DarkSlateGray);
        }

        private async void LoginBtn_MouseLeave(object sender, EventArgs e)
        {
            await AnimateButtonColors(LoginBtn, Color.DarkSlateGray, Color.White);
        }

        private async void SignUpBtn_MouseEnter(object sender, EventArgs e)
        {
            await AnimateButtonColors(SignUpBtn, Color.White, Color.DarkSlateGray);
        }

        private async void SignUpBtn_MouseLeave(object sender, EventArgs e)
        {
            await AnimateButtonColors(SignUpBtn, Color.DarkSlateGray, Color.White);
        }

        private async Task AnimateButtonColors(Button button, Color targetBackColor, Color targetForeColor)
        {
            Color originalBackColor = button.BackColor;
            Color originalForeColor = button.ForeColor;

            for (int i = 0; i <= 10; i++)
            {
                // Animate BackColor
                int backR = originalBackColor.R + (int)((targetBackColor.R - originalBackColor.R) * (i / 10f));
                int backG = originalBackColor.G + (int)((targetBackColor.G - originalBackColor.G) * (i / 10f));
                int backB = originalBackColor.B + (int)((targetBackColor.B - originalBackColor.B) * (i / 10f));

                // Animate ForeColor
                int foreR = originalForeColor.R + (int)((targetForeColor.R - originalForeColor.R) * (i / 10f));
                int foreG = originalForeColor.G + (int)((targetForeColor.G - originalForeColor.G) * (i / 10f));
                int foreB = originalForeColor.B + (int)((targetForeColor.B - originalForeColor.B) * (i / 10f));

                button.BackColor = Color.FromArgb(backR, backG, backB);
                button.ForeColor = Color.FromArgb(foreR, foreG, foreB);

                await Task.Delay(15);
            }
        }
        // ============= END OF BUTTON ANIMATIONS =============

        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ATMdbConnection"].ConnectionString;
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

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            Account acc = new Account();
            acc.Show();
            this.Hide();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AccNumTb.Text) || string.IsNullOrWhiteSpace(PINTb.Text))
            {
                MessageBox.Show("Please enter both Account Number and PIN.");
                return;
            }

            try
            {
                con.Open();
                string query = "SELECT COUNT(*) FROM AccountTbl WHERE AccNum = @AccNum AND PIN = @PIN";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@AccNum", AccNumTb.Text);
                    cmd.Parameters.AddWithValue("@PIN", PINTb.Text);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count == 1)
                    {
                        accountNum = AccNumTb.Text;
                        Home home = new Home();
                        home.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Account Number/PIN");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
