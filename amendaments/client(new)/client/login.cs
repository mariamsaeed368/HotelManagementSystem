﻿using System;
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
            
            if (comboBox1.Text == "Employee" && textBox2.Text == "employee")
            {
                MessageBox.Show("Welcome to the system");
            }
            else if (comboBox1.Text == "Owner" && textBox2.Text == "owner")
            {
                MessageBox.Show("Welcome to system");
            }
            else if (comboBox1.Text == "Manager" && textBox2.Text == "manager")
            {
                MessageBox.Show("Welcome to system");
            }
            else
            {
                MessageBox.Show("Please enter your respective password");
            }
            comboBox1.Text= " ";
            textBox2.Text = " ";
            textBox1.Text = " ";
        }
    }
}
