using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
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



      

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 p = new Form2();
            p.Show();
            this.Hide();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
