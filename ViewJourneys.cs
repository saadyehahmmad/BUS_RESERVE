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
    public partial class ViewJourneys : Form
    {
        public ViewJourneys()
        {
            InitializeComponent();
        }
        SqlConnection Conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\db_bus\SDK_BUS_RESERVE_DB.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            Conn.Open();
            string query = "select * from jTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, Conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            DataSet ds = new DataSet();
            sda.Fill(ds, "jTable");
            journeysDGV.DataSource = ds.Tables["jTable"].DefaultView;


            Conn.Close();
        }

        private void ViewJourneys_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void journeysDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (journeysDGV.SelectedRows.Count > 0)
            {
                Jno.Text = journeysDGV.SelectedRows[0].Cells[0].Value.ToString();

                Jsrc.SelectedItem = journeysDGV.SelectedRows[0].Cells[1].Value.ToString();
                Jdest.SelectedItem = journeysDGV.SelectedRows[0].Cells[2].Value.ToString();
                dateTimePicker.Text = journeysDGV.SelectedRows[0].Cells[3].Value.ToString();
                Jcap.Text = journeysDGV.SelectedRows[0].Cells[4].Value.ToString();


            }


        }

        private void update_Click(object sender, EventArgs e)
        {

            if (Jno.Text == "")

            {
                MessageBox.Show("You are missing Information");

            }
            else
                try
                {
                    Conn.Open();
                    string Query = "update jTable set  jSrc='" + Jsrc.SelectedItem.ToString() + "',jDest='" + Jdest.SelectedItem.ToString() + "',jTime='" + dateTimePicker.Value.Date.ToString() + "',jCap='" + Jcap.Text + "'where jNo=" + Jno.Text + ";";
                    SqlCommand cmd = new SqlCommand(Query, Conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("journey Updated successfully");
                    Conn.Close();
                    populate();
                }
                catch (Exception XX)
                {
                    MessageBox.Show(XX.Message);
                }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (Jno.Text == "")
                MessageBox.Show("Press on passenger you want delete");
            else
                try
                {
                    Conn.Open();
                    string Query = "delete from jTable where jNo=" + Jno.Text + ";";
                    SqlCommand cmd = new SqlCommand(Query, Conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("journey deleted Successfully");
                    Conn.Close();
                    populate();
                }
                catch (Exception XX)
                {
                    MessageBox.Show(XX.Message);

                }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            Jno.Text = "";
            Jsrc.SelectedItem = "";
            Jdest.SelectedItem = "";
            Jcap.Text = "";

        }

        private void back_Click(object sender, EventArgs e)
        {
            AddJourneys addj = new AddJourneys();
            addj.Show();
            this.Hide();
        }
    }
}
