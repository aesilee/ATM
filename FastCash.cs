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

namespace ATM
{
    public partial class FastCash: Form
    {
        public FastCash()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ashbs\source\repos\ATM\ATM\ATMDB.mdf;Integrated Security=True;Connect Timeout=30");
        string Acc = Login.accountNum;
        int Balance, NewBalance, Amount = 0;

        public void GetBalanceMethod()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Balance from AccountTbl where AccNum= '" + Acc + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            BalanceLbl.Text = "Balance: " + dt.Rows[0][0].ToString();
            Balance = Convert.ToInt32(dt.Rows[0][0].ToString());
            con.Close();
        }
        private void AddTransactionmethod()
        {
            string TransactionType = "Fast Cash";
            try
            {
                con.Open();
                string query = "INSERT INTO TransactionTbl VALUES('" + Acc + "','" + TransactionType + "', " + Amount + ",'" + DateTime.Today.ToString("yyyy-MM-dd") + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FastCash_Load(object sender, EventArgs e)
        {
            GetBalanceMethod();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void FiveHBtn_Click(object sender, EventArgs e)
        {
            if (Balance < 500)
            {
                MessageBox.Show("Not Enough Balance");
            }
            else
            {
                Amount = 500;
                NewBalance = Balance - 500;
                try
                {
                    con.Open();
                    string query = "UPDATE AccountTbl SET Balance = @NewBalance WHERE AccNum = @AccNum";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@NewBalance", NewBalance);
                    cmd.Parameters.AddWithValue("@AccNum", Acc);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Amount Withdrawed Successfully");

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

        private void OneKBtn_Click(object sender, EventArgs e)
        {
            if (Balance < 1000)
            {
                MessageBox.Show("Not Enough Balance");
            }
            else
            {
                Amount = 1000;
                NewBalance = Balance - 1000;
                try
                {
                    con.Open();
                    string query = "UPDATE AccountTbl SET Balance = @NewBalance WHERE AccNum = @AccNum";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@NewBalance", NewBalance);
                    cmd.Parameters.AddWithValue("@AccNum", Acc);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Amount Withdrawed Successfully");

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
        private void TwoKBtn_Click(object sender, EventArgs e)
        {
            if (Balance < 2000)
            {
                MessageBox.Show("Not Enough Balance");
            }
            else
            {
                Amount = 2000;
                NewBalance = Balance - 2000;
                try
                {
                    con.Open();
                    string query = "UPDATE AccountTbl SET Balance = @NewBalance WHERE AccNum = @AccNum";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@NewBalance", NewBalance);
                    cmd.Parameters.AddWithValue("@AccNum", Acc);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Amount Withdrawed Successfully");

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

        private void ThreeKBtn_Click(object sender, EventArgs e)
        {
            if (Balance < 3000)
            {
                MessageBox.Show("Not Enough Balance");
            }
            else
            {
                Amount = 3000;
                NewBalance = Balance - 3000;
                try
                {
                    con.Open();
                    string query = "UPDATE AccountTbl SET Balance = @NewBalance WHERE AccNum = @AccNum";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@NewBalance", NewBalance);
                    cmd.Parameters.AddWithValue("@AccNum", Acc);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Amount Withdrawed Successfully");

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

        private void FiveKBtn_Click(object sender, EventArgs e)
        {
            if (Balance < 5000)
            {
                MessageBox.Show("Not Enough Balance");
            }
            else
            {
                Amount = 5000;
                NewBalance = Balance - 5000;
                try
                {
                    con.Open();
                    string query = "UPDATE AccountTbl SET Balance = @NewBalance WHERE AccNum = @AccNum";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@NewBalance", NewBalance);
                    cmd.Parameters.AddWithValue("@AccNum", Acc);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Amount Withdrawed Successfully");

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

        private void SixKBtn_Click(object sender, EventArgs e)
        {
            if (Balance < 6000)
            {
                MessageBox.Show("Not Enough Balance");
            }
            else
            {
                Amount = 6000;
                NewBalance = Balance - 6000;
                try
                {
                    con.Open();
                    string query = "UPDATE AccountTbl SET Balance = @NewBalance WHERE AccNum = @AccNum";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@NewBalance", NewBalance);
                    cmd.Parameters.AddWithValue("@AccNum", Acc);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Amount Withdrawed Successfully");

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

        private void EightKBtn_Click(object sender, EventArgs e)
        {
            if (Balance < 8000)
            {
                MessageBox.Show("Not Enough Balance");
            }
            else
            {
                Amount = 8000;
                NewBalance = Balance - 8000;
                try
                {
                    con.Open();
                    string query = "UPDATE AccountTbl SET Balance = @NewBalance WHERE AccNum = @AccNum";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@NewBalance", NewBalance);
                    cmd.Parameters.AddWithValue("@AccNum", Acc);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Amount Withdrawed Successfully");

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
        private void TenKBtn_Click(object sender, EventArgs e)
        {
            if (Balance < 10000)
            {
                MessageBox.Show("Not Enough Balance");
            }
            else
            {
                Amount = 10000;
                NewBalance = Balance - 10000;
                try
                {
                    con.Open();
                    string query = "UPDATE AccountTbl SET Balance = @NewBalance WHERE AccNum = @AccNum";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@NewBalance", NewBalance);
                    cmd.Parameters.AddWithValue("@AccNum", Acc);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Amount Withdrawed Successfully");

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

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
