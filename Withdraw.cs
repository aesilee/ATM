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
    public partial class Withdraw: Form
    {
        public Withdraw()
        {
            InitializeComponent();
        }
        
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ashbs\source\repos\ATM\ATM\ATMDB.mdf;Integrated Security=True;Connect Timeout=30");
        string Acc = Login.accountNum;
        int Balance;
        int NewBalance;

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
            string TransactionType = "Withdraw";
            try
            {
                con.Open();
                string query = "INSERT INTO TransactionTbl VALUES('" + Acc + "','" + TransactionType + "', " + WithdrawAmtTb.Text + ",'" + DateTime.Today.ToString("yyyy-MM-dd") + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Withdraw_Load(object sender, EventArgs e)
        {
            GetBalanceMethod();
        }

        private void Withdraw_Click(object sender, EventArgs e)
        {
            if (WithdrawAmtTb.Text == "")
            {
                MessageBox.Show("Please enter the amount to withdraw.");
            }
            else if (Convert.ToInt32(WithdrawAmtTb.Text) <= 0)
            { 
                MessageBox.Show("Please enter a valid amount.");
            }
            else if (Convert.ToInt32(WithdrawAmtTb.Text) > Balance)
            {
                MessageBox.Show("Not Enough Balance");
            }
            else
            {
                NewBalance = Balance - Convert.ToInt32(WithdrawAmtTb.Text);
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

                    Home log = new Home();
                    log.Show();
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
