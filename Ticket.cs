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
    public partial class Ticket : Form
    {
        public Ticket()
        {
            InitializeComponent();
        }
        SqlConnection Conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\db_bus\SDK_BUS_RESERVE_DB.mdf;Integrated Security=True;Connect Timeout=30");


        private void fillPass()
        {
            Conn.Open();
            SqlCommand cmd = new SqlCommand("select PassId from PassengerTP",Conn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            DataTable dT = new DataTable();
            dT.Columns.Add("PassId",typeof(int));
            dT.Load(reader);
            pid.ValueMember = "PassId";
            pid.DataSource = dT;
            Conn.Close();
        
        }
        string pnm, ppt, pad, pnt;
      

        private void fetchPass()
        {
            Conn.Open();
            string query = "select * from PassengerTP where PassId =" + pid.SelectedValue.ToString() + ";";
            SqlCommand cmd = new SqlCommand(query, Conn);
            DataTable dT = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dT);

            foreach(DataRow dRow in dT.Rows)
            {
                name.Text = dRow["PasssName"].ToString();
                pno.Text = dRow["Passport"].ToString();
                add.Text = dRow["PassAd"].ToString();
                nat.Text = dRow["passNat"].ToString();

            }
            Conn.Close();

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Main viewMain = new Main();
            viewMain.Show();
            this.Hide();
        }

        private void fillJourney()
        {
            Conn.Open();
            SqlCommand cmd = new SqlCommand("select jNo from jTable", Conn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            DataTable dT = new DataTable();
            dT.Columns.Add("jNo", typeof(string));
            dT.Load(reader);
            jno.ValueMember = "jNo";
            jno.DataSource = dT;
            Conn.Close();

        }
      private void fetchJourney()
        {
            Conn.Open();
            string query = "select * from jTable where jNo =" + pid.SelectedValue.ToString() + ";";
            SqlCommand cmd = new SqlCommand(query, Conn);
            DataTable dT = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dT);

            foreach (DataRow dRow in dT.Rows)
            {
               pnm  = dRow["PasssName"].ToString();
               ppt = dRow["Passport"].ToString();
               pad  = dRow["PassAd"].ToString();
               pnt = dRow["passNat"].ToString();
                name.Text = pnm;
                pno.Text = ppt;
                add.Text = pad;
                nat.Text = pnt;




            }
            Conn.Close();

        }
        private void populate()
        {
            Conn.Open();
            string query = "select * from TktTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, Conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            TktDGV.DataSource = ds.Tables[0];


            Conn.Close();
        }
        private void Ticket_Load(object sender, EventArgs e)
        {
            fillPass();
            fillJourney();
            populate();


        }
        private void pid_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchPass();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            pno.Text = "";
            jno.Text = "";
            tktid.Text = "";
            nat.Text = "";
            name.Text = "";
            pid.Text = "";
            add.Text = "";
            add.Text = "";
            amount.Text = "";
        }

        private void Book_Click(object sender, EventArgs e)
        {
            if ((pno.Text == "") || (name.Text == "") || (pid.Text == "") || (add.Text == "") || (amount.Text == ""))

            { MessageBox.Show("You are missing Information"); }

            else
            {
                try
                {
                    Conn.Open();
                    string Query = "insert into TktTable values(" + tktid.Text + ",'" + jno.SelectedValue.ToString()+"','" + pid.SelectedValue.ToString() + "','" + name.Text + "','" + pno.Text + "','" + nat.Text + "','" + add.Text + "','" + amount.Text + "')";
                    SqlCommand cmd = new SqlCommand(Query, Conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ticket Recorded Successfully");
                    Conn.Close();
                    populate();


                }
                catch (Exception XX)
                {
                    MessageBox.Show(XX.Message);
                }

            }
        }

        private void TktDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

