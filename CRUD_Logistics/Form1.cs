using System;
using System.Windows.Forms;
using CRUD_Logistics.Models;

namespace CRUD_Logistics
{
    public partial class Form1 : Form
    {
        private string username;
        private string password;

        public Form1(string username, string password)
        {
            this.username = username;
            this.password = password;
            InitializeComponent();
            LoadData(username, password);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext(this.username, this.password))
            {
                var newPerson = new People
                {
                    name = textBox1.Text,
                    age = int.Parse(textBox2.Text)
                };

                context.People.Add(newPerson);
                context.SaveChanges();

                LoadData(this.username, this.password);
            }
        }

        private void LoadData(string username, string password)
        {
            using (var context = new AppDbContext(username, password))
            {
                var people = context.People.ToList();
                dataGridView1.DataSource = people;
            }
        }
    }
}