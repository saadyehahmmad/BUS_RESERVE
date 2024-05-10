using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BUS_RESERVE
{
    public partial class AddJourneys : Form
    {
        public AddJourneys()
        {
            InitializeComponent();
        }
        SqlConnection Conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\db_bus\SDK_BUS_RESERVE_DB.mdf;Integrated Security=True;Connect Timeout=30");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void jRecord_Click(object sender, EventArgs e)
        {
            if ((Jno.Text == "") || (Jsrc.SelectedItem.ToString() == "") || (Jdest.SelectedItem.ToString() == "") || (Jdate.Text == "") || (Jcap.Text == ""))

            { MessageBox.Show("You are missing Information"); }

            else
            {
                try
                {
                    Conn.Open();
                    string Query = "insert into jTable values(" + Jno.Text + ",'" + Jsrc.SelectedItem.ToString() + "','" + Jdest.SelectedItem.ToString() + "','" + Jdate.Value.ToString() + "','" + Jcap.Text +  "')";
                    SqlCommand cmd = new SqlCommand(Query, Conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Journey Recorded Successfully");
                    Conn.Close();
                }
                catch (Exception XX)
                {
                    MessageBox.Show(XX.Message);
                }

            }
        }

        private void jReset_Click(object sender, EventArgs e)
        {
            Jno.Text = "";
            Jsrc.SelectedItem = "";
            Jdest.SelectedItem = "";
            Jdate.Text = "";
            Jcap.Text = "";

        }

        private void View_Click(object sender, EventArgs e)
        {
            ViewJourneys viewj = new ViewJourneys();
            viewj.Show();
            this.Hide();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Main viewMain = new Main();
            viewMain.Show();
            this.Hide();
        }

        private void Jno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
