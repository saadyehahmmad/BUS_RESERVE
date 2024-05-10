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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Pass_Click(object sender, EventArgs e)
        {
            AddPassenger viewpass = new AddPassenger();
            viewpass.Show();
            this.Hide();
        }

        private void Jour_Click(object sender, EventArgs e)
        {
            AddJourneys viewAddJourneys = new AddJourneys();
            viewAddJourneys.Show();
            this.Hide();
        }

        private void Tkt_Click(object sender, EventArgs e)
        {
            Ticket viewTicket = new Ticket();
            viewTicket.Show();
            this.Hide();
        }

        private void Canc_Click(object sender, EventArgs e)
        {
            Cancellation viewcanc = new Cancellation();
            viewcanc.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
