﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Logistics
{
    public partial class Form2 : Form
    {
        private string username;
        private string password;
        public Form2()
        {
            InitializeComponent();
        }

        /*private void Form2_Load(object sender, EventArgs e)
        {

        }*/

        private void button1Log_Click(object sender, EventArgs e)
        {
            this.username = textBox1Log.Text;
            this.password = textBox2Log.Text;

            Form1 form1 = new Form1(this.username, this.password);

            this.Hide();

            form1.Show();
        }
    }
}
