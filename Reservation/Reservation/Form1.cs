using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservation
{
    public partial class Form1 : Form
    {
        double itax, inet_total, itotal;

        private void button1_Click(object sender, EventArgs e)
        {
            roomdl b = new roomdl();
            person p = new person();
            p.Name = textBox1.Text;
            p.Checkin = DateTime.Parse(textBox2.Text);
            p.Checkout = DateTime.Parse(textBox3.Text);
            room k = new room();
            k.Number = int.Parse(textBox4.Text);
            k.Isfree = checkBox1.Checked;
            if(k.Isfree)
            {
                k.Status = "Free";
            }
            else
            {
                k.Status = "Busy";
            }
            roomdl.room.Add(k);
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = "  ";
            MessageBox.Show("Room is reserved");


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 o = new Form2();
            o.Show();
            this.Hide();
        }

        public Form1()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            tax room = new tax();
            room.Room_charges1 = double.Parse(textBox5.Text);
            room.Service_charges1 = double.Parse(textBox6.Text);
            inet_total = room.Getamount();
            itax = room.findtax(inet_total);
            itotal = inet_total + itax;

            textBox7.Text = string.Format("{0:C}", inet_total);
            textBox8.Text = string.Format("{0:C}", itax);
            textBox9.Text = string.Format("{0:C}", itotal);




        }
    }
}
