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
    public partial class Splash: Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        int starting = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            starting++;
            myProgress.Value = starting;
            PercentageLbl.Text = starting.ToString() + "%";  

            if (starting >= 100)
            {
                timer1.Stop();
                myProgress.Value = 100;  

                Task.Delay(300).ContinueWith(t =>
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        Login login = new Login();
                        login.Show();
                        this.Hide();
                    });
                });
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            starting = 0;
            myProgress.Value = 0;
            PercentageLbl.Text = "0%";

            timer1.Interval = 50;  
            timer1.Start();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
