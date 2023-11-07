using System;
using System.Windows.Forms;
using CRUD_Logistics.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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
            panel_update.Visible = false;
            panel_delete.Visible = false;
            panel_menu.Visible = true;

            dataGridViewUpdate.CellClick += update_cell_click;
            dataGridViewDelete.CellClick += delete_cell_click;
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
            panel_list.Visible = true;
            panel_menu.Visible = false;
            panel_update.Visible = false;
            panel_delete.Visible = false;
            var data = this.context.People.ToList();
            dataGridViewList.DataSource = data;
            this.Invalidate();
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
            panel_list.Visible = false;
            panel_menu.Visible = true;
        }

        private void button_update_back_Click(object sender, EventArgs e)
        {
            panel_update.Visible = false;
            panel_menu.Visible = true;
        }

        private void button_delete_back_Click(object sender, EventArgs e)
        {
            panel_delete.Visible = false;
            panel_menu.Visible = true;
        }

        private void menu_button_update_Click(object sender, EventArgs e)
        {
            panel_menu.Visible = false;
            panel_list.Visible = false;
            panel_delete.Visible = false;
            panel_update.Visible = true;
            var people = this.context.People.ToList();
            dataGridViewUpdate.DataSource = people;
        }

        private void menu_button_delete_Click(object sender, EventArgs e)
        {
            panel_delete.Visible = true;
            panel_menu.Visible = false;
            panel_list.Visible = false;
            panel_update.Visible = false;
            var people = this.context.People.ToList();
            dataGridViewDelete.DataSource = people;
        }

        private void button_update_change_Click(object sender, EventArgs e)
        {
            if (textBox_update_name.Text != null && textBox_update_age.Text != null)
            {
                int id = int.Parse(textBox_update_id.Text);

                string sqlQuery = $"SELECT * FROM People WHERE Id = {id}";

                People person = context.People.FromSqlRaw(sqlQuery).FirstOrDefault();

                person.name = textBox_update_name.Text;
                person.age = int.Parse(textBox_update_age.Text);

                context.Entry(person).State = EntityState.Modified;

                context.SaveChanges();

                var people = this.context.People.ToList();
                dataGridViewUpdate.DataSource = people;
            }
            else
            {
                MessageBox.Show($"All fields must be filled!");
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (textBox_update_name.Text != null && textBox_update_age.Text != null)
            {
                int id = int.Parse(textBox_delete_id.Text);

                string sqlQuery = $"DELETE FROM People WHERE Id = {id}";

                context.Database.ExecuteSqlRaw(sqlQuery);

                context.SaveChanges();

                var people = this.context.People.ToList();
                dataGridViewDelete.DataSource = people;
            }
            else
            {
                MessageBox.Show($"All fields must be filled!");
            }
        }

        private void update_cell_click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewUpdate.Rows.Count)
            {
                int id = Convert.ToInt32(dataGridViewUpdate.Rows[e.RowIndex].Cells["id"].Value);

                string sqlQuery = $"SELECT * FROM People WHERE Id = {id}";

                People person = context.People.FromSqlRaw(sqlQuery).FirstOrDefault();

                textBox_update_id.Text = person.id.ToString();
                textBox_update_name.Text = person.name;
                textBox_update_age.Text = person.age.ToString();

                //MessageBox.Show($"It is: {person.name}!");
            }
        }

        private void delete_cell_click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewDelete.Rows.Count)
            {
                int id = Convert.ToInt32(dataGridViewDelete.Rows[e.RowIndex].Cells["id"].Value);

                string sqlQuery = $"SELECT * FROM People WHERE Id = {id}";

                People person = context.People.FromSqlRaw(sqlQuery).FirstOrDefault();

                textBox_delete_id.Text = person.id.ToString();
                textBox_delete_name.Text = person.name;
                textBox_delete_age.Text = person.age.ToString();
            }
        }
    }
}