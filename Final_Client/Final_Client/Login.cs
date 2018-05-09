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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            localhost.Service1 server = new localhost.Service1();
            bool valid;
            bool validaccess;
            server.isvalid(comboBox1.Text, textBox2.Text, out valid, out validaccess);
            if((comboBox1.Text == "Manager" && textBox2.Text == "manager")  || (comboBox1.Text == "Owner" && textBox2.Text == "owner") || (comboBox1.Text == "Employee" && textBox2.Text == "employee"))
            {
                MessageBox.Show("Welcome.");
            }
            else
            {
                MessageBox.Show("Please Enter your assigned password.");
            }
            if (textBox2.Text == "employee" && comboBox1.Text == "Employee")
            {
                 Add_Guest n = new Add_Guest();
                n.Show();
                this.Hide();
            }
             else if (textBox2.Text == "manager" && comboBox1.Text == "Manager")
            {
                Employee_Details n = new Employee_Details();
                n.Show();
                this.Hide();
            }
            else if (textBox2.Text == "owner" && comboBox1.Text == "Owner")
            {
                Ownerlogedinview u = new Ownerlogedinview();
                u.Show();
                this.Hide();
            }
            comboBox1.Text = " ";
            textBox2.Text = " ";
            textBox1.Text = " ";
        }

       
    }
}
