using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS_RESERVE
{
    public partial class waiting : Form
    {
        public waiting()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }



        private void exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int start_point = 0;
        private void timer_Tick(object sender, EventArgs e)
        {
            start_point += 1;
            progress.Value = start_point;
            if (progress.Value == 100)
            {
                progress.Value = 0;
                timer.Stop();
                Login log = new Login();

                log.Show();
                this.Hide();
            }
        }

        private void waiting_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}
