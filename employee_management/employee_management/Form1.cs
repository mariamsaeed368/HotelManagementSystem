using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace employee_management
{
    public partial class Form1 : Form
    {
    

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
                localhost.Service1 server = new localhost.Service1();
                localhost.Employee t = new localhost.Employee();
                t.Name = textBox1.Text;
                t.Id1 = int.Parse(textBox2.Text);
                t.Phone_no = textBox3.Text;
                t.Department1 = textBox4.Text;
                server.Add_employee(t);
                MessageBox.Show("Employee has been added.");
                textBox1.Text = " ";
                textBox2.Text = " ";
                textBox3.Text = " ";
                textBox4.Text = " ";
       }

        private void button2_Click(object sender, EventArgs e)
        {
            localhost.Service1 server = new localhost.Service1();
            BindingSource b = new BindingSource();
            b.DataSource = server.show();
            dataGridView1.DataSource = b;

        }
    }
    
}
