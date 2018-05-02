using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            localhost.Service1 server = new localhost.Service1();
            bool valid;
            bool validaccess;
            server.isvalid(comboBox1.Text, textBox2.Text, out valid, out validaccess);
            if(valid)
            {
                MessageBox.Show("Welcome to system");
            }
            else
            {
                MessageBox.Show("Please enter your assigned password.");
            }
            comboBox1.Text= " ";
            textBox2.Text = " ";
            textBox1.Text = " ";
        }
    }
}
