using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BUS_RESERVE
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void log_in_Click(object sender, EventArgs e)
        {
            if((username.Text == "")||(pass.Text == ""))
                MessageBox.Show("You missing some information");
            else if ((username.Text == "admin")&& (pass.Text == "admin"))
            {
                Main viewMain = new Main();
                viewMain.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Username or password is incorrect");
        }

        private void Rst_Click(object sender, EventArgs e)
        {
            username.Text = "";
            pass.Text = "";
        }
    }
}
