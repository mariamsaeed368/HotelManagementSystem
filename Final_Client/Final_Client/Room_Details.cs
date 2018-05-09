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
    public partial class Room_Details : Form
    {
        public Room_Details()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            localhost.Service1 server = new localhost.Service1();
            BindingSource source = new BindingSource();
            source.DataSource = server.show_room();
            dataGridView1.DataSource = source;
            dataGridView1.Columns[2].Visible = false;
        }


        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Reservation o = new Reservation();
            o.Show();
            this.Hide();
        }
    }
}
