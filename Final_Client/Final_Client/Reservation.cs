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
    public partial class Reservation : Form
    {
        public double mctax = 0.65;
        double inet_total, itax, itotal;
        public Reservation()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Room_Details p = new Room_Details();
            p.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            localhost.Service1 server = new localhost.Service1();
            localhost.tax1 room = new localhost.tax1();
            room.Room_charges1 = double.Parse(textBox5.Text);
            room.Service_charges1 = double.Parse(textBox6.Text);
            inet_total = server.Getamount(room);//room.Room_charges1 + room.Service_charges1; 
            itax = server.findtax(inet_total); //inet_total - (inet_total * mctax);
            itotal = inet_total + itax;

            textBox7.Text = string.Format("{0:C}", inet_total);
            textBox8.Text = string.Format("{0:C}", itax);
            textBox9.Text = string.Format("{0:C}", itotal);


        }

        private void button1_Click(object sender, EventArgs e)
        {

            localhost.Service1 server = new localhost.Service1();
            localhost.reservation1 p = new localhost.reservation1();
            p.Name = textBox1.Text;
            p.Checkin = DateTime.Parse(textBox2.Text);
            p.Checkout = DateTime.Parse(textBox3.Text);
            localhost.room1 k = new localhost.room1();
            k.Number = int.Parse(textBox4.Text);
            k.Isfree = checkBox1.Checked;
            if (k.Isfree)
            {
                k.Status = "Free";
            }
            else
            {
                k.Status = "Busy";
            }
            server.Add_room(k);
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = "  ";
            MessageBox.Show("Room is reserved");

        }
    }
}
