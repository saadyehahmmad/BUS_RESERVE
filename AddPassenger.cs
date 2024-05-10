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
    public partial class AddPassenger : Form
    {
        public AddPassenger()
        {
            InitializeComponent();
        }
         SqlConnection Conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\db_bus\SDK_BUS_RESERVE_DB.mdf;Integrated Security=True;Connect Timeout=30");
            
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void x_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

   



        private void PassId_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasssName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Passport_TextChanged(object sender, EventArgs e)
        {

        }

        private void PassAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void PassNat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PassGend_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PassPhone_TextChanged(object sender, EventArgs e)
        {

        }


        private void RecordPassBtn_Click(object sender, EventArgs e)
        {
            if ((pass_id_.Text == "") || (pass_name_.Text == "") || (passport_no_.Text == "") || (address_.Text == "") || (pass_phone_.Text == ""))

            { MessageBox.Show("You are missing Information"); }

            else
            {
                try
                {
                    Conn.Open();
                    string Query = "insert into PassengerTP values(" + pass_id_.Text + ",'" + pass_name_.Text + "','" + passport_no_.Text + "','" + address_.Text + "','" + pass_nat_.SelectedItem.ToString() + "','" + pass_gend_.SelectedItem.ToString() + "','" + pass_phone_.Text + "')";
                    SqlCommand cmd = new SqlCommand(Query, Conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Recorded Successfully");
                    Conn.Close();
                }
                catch (Exception XX)
                {
                    MessageBox.Show(XX.Message);
                }

            }
        }

        private void view_pass_Click(object sender, EventArgs e)
        {
            ViewPassenger viewpass = new ViewPassenger();
            viewpass.Show();
            this.Hide();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            pass_id_.Text = "";
            pass_name_.Text = "";
            passport_no_.Text = "";
            address_.Text = "";
            pass_phone_.Text = "";
        }

        private void AddPassenger_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main viewMain = new Main();
            viewMain.Show();
            this.Hide();
        }
    }
}
