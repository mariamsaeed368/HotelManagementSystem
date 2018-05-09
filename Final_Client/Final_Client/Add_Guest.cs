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
    public partial class Add_Guest : Form
    {
        public Add_Guest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            localhost.Service1 server = new localhost.Service1();
            localhost.guest p = new localhost.guest();
            p.Name = textBox8.Text;
            p.Address = textBox7.Text;
            p.Phone_no = textBox6.Text;
            p.Email = textBox5.Text;
            p.Cnic = textBox4.Text;
            p.Gender = textBox9.Text;
            p.Rooms = int.Parse(textBox1.Text);
            p.Checkin = textBox2.Text;
            p.Checkout = textBox3.Text;
            server.Add_guest(p);
            MessageBox.Show("Guest has been added.");
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
            textBox6.Text = " ";
            textBox7.Text = "  ";
            textBox8.Text = " ";
            textBox9.Text = " ";

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Guest_Details b = new Guest_Details();
            b.Show();
            this.Hide();
        }
    }
}
