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
    public partial class ViewPassenger : Form
    {
        public ViewPassenger()
        {
            InitializeComponent();
        }
        SqlConnection Conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\db_bus\SDK_BUS_RESERVE_DB.mdf;Integrated Security=True;Connect Timeout=30");


        private void populate() 
        {
            Conn.Open();
            string query = "select * from PassengerTP";
            SqlDataAdapter sda = new SqlDataAdapter(query , Conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            DataSet ds = new DataSet();
            sda.Fill(ds, "PassengerTP");
            PassengerDGV.DataSource = ds.Tables["PassengerTP"].DefaultView;
           

            Conn.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PassengerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
            if (PassengerDGV.SelectedRows.Count > 0)
            {
                customid.Text = PassengerDGV.SelectedRows[0].Cells[0].Value.ToString();

                 customname.Text=  PassengerDGV.SelectedRows[0].Cells[1].Value.ToString();
                 passno.Text = PassengerDGV.SelectedRows[0].Cells[2].Value.ToString();
                 address.Text =  PassengerDGV.SelectedRows[0].Cells[3].Value.ToString();
                 nationality.SelectedItem = PassengerDGV.SelectedRows[0].Cells[4].Value.ToString();
                 gender.SelectedItem = PassengerDGV.SelectedRows[0].Cells[5].Value.ToString();
                 phoneee.Text = PassengerDGV.SelectedRows[0].Cells[6].Value.ToString();
      
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            AddPassenger addpass = new AddPassenger();
            addpass.Show();
            this.Hide();
        }

        private void ViewPassenger_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void customid_TextChanged(object sender, EventArgs e)
        {

        }

        private void customname_TextChanged(object sender, EventArgs e)
        {

        }

        private void passno_TextChanged(object sender, EventArgs e)
        {

        }

        private void address_TextChanged(object sender, EventArgs e)
        {

        }

        private void nationality_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void phoneee_TextChanged(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (customid.Text == "")
                MessageBox.Show("Press on passenger you want delete");
            else
                try
                {
                    Conn.Open();
                    string Query = "delete from PassengerTp where passId=" +customid.Text+ ";";
                    SqlCommand cmd = new SqlCommand(Query, Conn) ;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger deleted Successfully");
                    Conn.Close();
                    populate();
                }
                catch(Exception XX)
                {
                    MessageBox.Show(XX.Message);

                }


        }

        private void reset_Click(object sender, EventArgs e)
        {
            customid.Text = "";
            customname.Text = "";
            passno.Text = "";
            address.Text = "";
            phoneee.Text = "";
            nationality.SelectedItem = "";
            gender.SelectedItem = "";
        }

        private void update_Click(object sender, EventArgs e)
        {
            if ((customid.Text == "")||(customname.Text == "") || (passno.Text == "") || (address.Text == "") || (phoneee.Text == "")) 

            {
                MessageBox.Show("You are missing Information");
                
            }
            else
                try 
                {
                    Conn.Open();
                    string Query = "update PassengerTP set PasssName ='" + customname.Text + "',Passport='"+passno.Text +"',PassAd='"+ address.Text + "',PassNat='"+ nationality.SelectedItem + "',PassGend='"+ gender.SelectedItem + "',PassPhone='"+ phoneee.Text +"'where PassId="+ customid.Text + ";";
                    SqlCommand cmd = new SqlCommand(Query,Conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated successfully");
                    Conn.Close();
                    populate();
                }
                catch (Exception XX) 
                {
                    MessageBox.Show(XX.Message);
                }
        }
    }
}
