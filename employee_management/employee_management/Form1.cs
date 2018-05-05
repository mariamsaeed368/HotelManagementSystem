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
                employee t = new employee();
                t.Name = textBox1.Text;
                t.Id1 = int.Parse(textBox2.Text);
                t.Phone_no = textBox3.Text;
                t.Department1 = textBox4.Text;
                 employeedl.employee.Add(t);
                MessageBox.Show("Employee has been added.");
                textBox1.Text = " ";
                textBox2.Text = " ";
                textBox3.Text = " ";
                textBox4.Text = " ";
       }

        private void button2_Click(object sender, EventArgs e)
        {
            BindingSource b = new BindingSource();
            b.DataSource = employeedl.employee;
            dataGridView1.DataSource = b;

        }
    }
    
}
