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
    public partial class Cancellation : Form
    {
        public Cancellation()
        {
            InitializeComponent();
        }
        SqlConnection Conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\db_bus\SDK_BUS_RESERVE_DB.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Conn.Open();
            string query = "select * from cancelTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, Conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            cancellationDGV.DataSource = ds.Tables[0];


            Conn.Close();
        }


        private void fillCancellation()
        {
            Conn.Open();
            SqlCommand cmd = new SqlCommand("select tId from TktTable", Conn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            DataTable dT = new DataTable();
            dT.Columns.Add("tId", typeof(string));
            dT.Load(reader);
            Tktid.ValueMember = "tId";
            Tktid.DataSource = dT;
            Conn.Close();

        }
        private void fetchTkt()
        {
            Conn.Open();
            string query = "select * from TktTable where tId =" + Tktid.SelectedValue.ToString() + ";";
            SqlCommand cmd = new SqlCommand(query, Conn);
            DataTable dT = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dT);

            foreach (DataRow dRow in dT.Rows)
            {
                p_id.Text = dRow["pId"].ToString();
               // date.Text = dRow["Passport"].ToString();
                j_no.Text = dRow["jNo"].ToString();
                

            }
            Conn.Close();

        }
        /*private void fetchJourney()
        {
            Conn.Open();
            string query = "select * from jTable where jNo =" + pid.SelectedValue.ToString() + ";";
            SqlCommand cmd = new SqlCommand(query, Conn);
            DataTable dT = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dT);

            foreach (DataRow dRow in dT.Rows)
            {
                pnm = dRow["PasssName"].ToString();
                ppt = dRow["Passport"].ToString();
                pad = dRow["PassAd"].ToString();
                pnt = dRow["passNat"].ToString();
                name.Text = pnm;
                pno.Text = ppt;
                add.Text = pad;
                nat.Text = pnt;




            }
            Conn.Close();

        }*/
        private void saveInTable()
        {
            if ((p_id.Text == "") || (j_no.Text == "") || (Tktid.Text == ""))

            { MessageBox.Show("You are missing Information"); }



            else
            {
                try
                {
                    Conn.Open();
                    string query = "insert into cancelTable values(" + Tktid.SelectedValue.ToString() + ",'" + p_id.Text + "','" + j_no.Text + "','" + Canceldate.Value.Date + "')";
                    SqlCommand cmd = new SqlCommand(query, Conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Save in cancelTable Successfully");
                    Conn.Close();
                    populate();


                }
                catch (Exception XX)
                {
                    MessageBox.Show(XX.Message);
                }

            }
        }
        private void deleteJ()
        {

            if ((p_id.Text == "") || (j_no.Text == "") || (Tktid.Text == ""))

            { MessageBox.Show("You are missing Information"); }

            else
            {
                try
                {
                    Conn.Open();

                    string Query = "delete from TktTable where tId=" + Tktid.Text + ";";
                    SqlCommand cmd = new SqlCommand(Query, Conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("The Ticket deleted Successfully");
                    Conn.Close();
                    populate();

                }
                catch (Exception XX)
                {
                    MessageBox.Show(XX.Message);
                }

            }
        }
        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Cancellation_Load(object sender, EventArgs e)
        {
            fillCancellation();
            
            populate();
        }


        private void cancellationDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Main viewMain = new Main();
            viewMain.Show();
            this.Hide();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            p_id.Text = "";
            Canceldate.Text = "";
            j_no.Text = "";
            Tktid.Text = "";

        }

        private void Cancel_Click(object sender, EventArgs e)
        {

            saveInTable();
            deleteJ();


    }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchTkt();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
