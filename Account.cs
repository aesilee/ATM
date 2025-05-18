using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ATM
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();

            ExitBtn.MouseEnter += ExitBtn_MouseEnter;
            ExitBtn.MouseLeave += ExitBtn_MouseLeave;
            SubmitBtn.MouseEnter += SubmitBtn_MouseEnter;
            SubmitBtn.MouseLeave += SubmitBtn_MouseLeave;
            LogoutBtn.MouseEnter += LogoutBtn_MouseEnter;
            LogoutBtn.MouseLeave += LogoutBtn_MouseLeave;
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ashbs\source\repos\ATM\ATM\ATMDB.mdf;Integrated Security=True;Connect Timeout=30");

        private bool isFormLoading = true;

        private void Account_Load(object sender, EventArgs e)
        {
            if (isFormLoading)
            {
                isFormLoading = false;
                return;
            }
        }

        // ============= BUTTON ANIMATIONS =============
        private async void SubmitBtn_MouseEnter(object sender, EventArgs e)
        {
            await AnimateButtonColors(SubmitBtn, Color.White, Color.DarkSlateGray);
        }

        private async void SubmitBtn_MouseLeave(object sender, EventArgs e)
        {
            await AnimateButtonColors(SubmitBtn, Color.DarkSlateGray, Color.White);
        }

        private async void LogoutBtn_MouseEnter(object sender, EventArgs e)
        {
            await AnimateButtonColors(LogoutBtn, Color.White, Color.DarkSlateGray);
        }

        private async void LogoutBtn_MouseLeave(object sender, EventArgs e)
        {
            await AnimateButtonColors(LogoutBtn, Color.DarkSlateGray, Color.White);
        }
        private async void ExitBtn_MouseEnter(object sender, EventArgs e)
        {
            Color originalColor = Color.White; // Start from White instead of DarkSlateGray
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
            Color targetColor = Color.White; // Return to White instead of DarkSlateGray
            for (int i = 0; i <= 10; i++)
            {
                int r = hoverColor.R + (int)((targetColor.R - hoverColor.R) * (i / 10f));
                int g = hoverColor.G + (int)((targetColor.G - hoverColor.G) * (i / 10f));
                int b = hoverColor.B + (int)((targetColor.B - hoverColor.B) * (i / 10f));
                ExitBtn.ForeColor = Color.FromArgb(r, g, b);
                await Task.Delay(15);
            }
        }

        private async Task AnimateButtonColors(Button button, Color targetBackColor, Color targetForeColor)
        {
            Color originalBackColor = button.BackColor;
            Color originalForeColor = button.ForeColor;

            for (int i = 0; i <= 10; i++)
            {
                int backR = originalBackColor.R + (int)((targetBackColor.R - originalBackColor.R) * (i / 10f));
                int backG = originalBackColor.G + (int)((targetBackColor.G - originalBackColor.G) * (i / 10f));
                int backB = originalBackColor.B + (int)((targetBackColor.B - originalBackColor.B) * (i / 10f));

                int foreR = originalForeColor.R + (int)((targetForeColor.R - originalForeColor.R) * (i / 10f));
                int foreG = originalForeColor.G + (int)((targetForeColor.G - originalForeColor.G) * (i / 10f));
                int foreB = originalForeColor.B + (int)((targetForeColor.B - originalForeColor.B) * (i / 10f));

                button.BackColor = Color.FromArgb(backR, backG, backB);
                button.ForeColor = Color.FromArgb(foreR, foreG, foreB);

                await Task.Delay(15);
            }
        }
        // ============= END OF BUTTON ANIMATIONS =============

        int bal = 0;

        private void CreateAccount()
        {
            if (string.IsNullOrWhiteSpace(AccNumTb.Text) ||
                string.IsNullOrWhiteSpace(NameTb.Text) ||
                string.IsNullOrWhiteSpace(FNameTb.Text) ||
                string.IsNullOrWhiteSpace(AddressTb.Text) ||
                string.IsNullOrWhiteSpace(PINTb.Text) ||
                string.IsNullOrWhiteSpace(OccupationTb.Text) ||
                string.IsNullOrWhiteSpace(PhoneTb.Text))
            {
                MessageBox.Show("Missing Information");
                return;
            }

            try
            {
                con.Open();
                string education = EducationCb.SelectedItem != null ? EducationCb.SelectedItem.ToString() : "";
                string formattedDate = DoBDate.Value.ToString("yyyy-MM-dd");
                string query = "INSERT INTO AccountTbl (AccNum, Name, FName, DoBDate, Phone, Address, Education, Occupation, PIN, Balance) " +
                               "VALUES (@AccNum, @Name, @FName, @DoBDate, @Phone, @Address, @Education, @Occupation, @PIN, @Balance)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@AccNum", AccNumTb.Text);
                    cmd.Parameters.AddWithValue("@Name", NameTb.Text);
                    cmd.Parameters.AddWithValue("@FName", FNameTb.Text);
                    cmd.Parameters.AddWithValue("@DoBDate", formattedDate);
                    cmd.Parameters.AddWithValue("@Phone", PhoneTb.Text);
                    cmd.Parameters.AddWithValue("@Address", AddressTb.Text);
                    cmd.Parameters.AddWithValue("@Education", education);
                    cmd.Parameters.AddWithValue("@Occupation", OccupationTb.Text);
                    cmd.Parameters.AddWithValue("@PIN", int.Parse(PINTb.Text));
                    cmd.Parameters.AddWithValue("@Balance", 0);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Account Created Successfully");
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

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            CreateAccount();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
        private async void ExitBtn_Click(object sender, EventArgs e)
        {
            // Click animation (updated to return to White)
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
            ExitBtn.ForeColor = Color.White; // Return to White after click

            Application.Exit();
        }


        // IRRELEVANT FUCKING PIECES OF SHIT
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }
    }
}
