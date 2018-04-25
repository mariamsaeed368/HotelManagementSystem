using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WindowsFormsApplication9
{
    public partial class Form2 : Form
    {
        public Form2()
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

       

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 p = new Form1();
            p.Show();
            this.Hide();

        }
    }
}
