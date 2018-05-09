using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Client
{
    public partial class Guest_Details : Form
    {
        public Guest_Details()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            localhost.Service1 server = new localhost.Service1();
            BindingSource source = new BindingSource();
            source.DataSource = server.show_all();
            dataGridView1.DataSource = source;
        }



        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Reservation p = new Reservation();
            p.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Add_Guest p = new Add_Guest();
            p.Show();
            this.Hide();
        }
    }
}
