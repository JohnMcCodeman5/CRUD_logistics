using System;
using System.Windows.Forms;
using CRUD_Logistics.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Logistics
{
    public partial class Form1 : Form
    {
        private string username;
        private string password;
        public AppDbContext context;
        public Form1(string username, string password)
        {
            this.username = username;
            this.password = password;
            this.context = new AppDbContext(this.username, this.password);
            InitializeComponent();
            panel_list.Visible = false;
            panel_menu.Visible = true;
            

            //LoadData(username, password);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newPerson = new People
            {
                name = textBox1.Text,
                age = int.Parse(textBox2.Text)
            };

            context.People.Add(newPerson);
            context.SaveChanges();

            load_data_add();

        }

        private void load_data_add()
        {
            var people = this.context.People.ToList();
            dataGridView1.DataSource = people;

        }

        private void menu_list_button_Click(object sender, EventArgs e)
        {
            panel_menu.Visible = false;
            panel_list.Visible = true;
            var data = this.context.People.ToList();
            dataGridViewList.DataSource = data;
        }

        private void menu_add_button_Click(object sender, EventArgs e)
        {
            panel_menu.Visible = false;
            load_data_add();
        }

        private void add_button_back_Click(object sender, EventArgs e)
        {
            panel_menu.Visible = true;
        }

        private void list_button_back_Click(object sender, EventArgs e)
        {
            panel_list.Visible=false;
            panel_menu.Visible = true;
        }
    }
}