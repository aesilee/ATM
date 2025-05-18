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
    public partial class ChangePin: Form
    {
        public ChangePin()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ashbs\source\repos\ATM\ATM\ATMDB.mdf;Integrated Security=True;Connect Timeout=30");
        
        string Acc = Login.accountNum;
        int OldPIN;

        private void ChangePin_Load(object sender, EventArgs e)
        {
            GetOldPIN();
        }
        private void GetOldPIN()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select PIN from AccountTbl where AccNum= '" + Acc + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            OldPIN = Convert.ToInt32(dt.Rows[0][0].ToString());
            con.Close();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ChangeBtn_Click(object sender, EventArgs e)
        {
            if (Pin1Tb.Text == "" || Pin2Tb.Text == "")
            {
                MessageBox.Show("Enter New and Confirm PIN Number");
            }
            else if (Pin1Tb.Text != Pin2Tb.Text)
            {
                MessageBox.Show("PIN Number Does Not Match");
            }
            else if (Convert.ToInt32(Pin1Tb.Text) == OldPIN)
            {
                MessageBox.Show("You cannot use your previous PIN");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "UPDATE AccountTbl SET PIN = @PIN WHERE AccNum = @AccNum";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@PIN", Pin1Tb.Text);
                    cmd.Parameters.AddWithValue("@AccNum", Login.accountNum);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("PIN Changed Successfully");
                    con.Close();


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
    }
}
