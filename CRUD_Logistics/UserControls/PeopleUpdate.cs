using CRUD_Logistics.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Logistics.UserControls
{
    public partial class PeopleUpdate : UserControl
    {
        public AppDbContext context;
        private BaseForm form;
        public PeopleUpdate(AppDbContext context, BaseForm form)
        {
            this.form = form;
            this.Visible = false;
            this.context = context;
            InitializeComponent();
            var people = this.context.People.ToList();
            dataGridView_people_update.DataSource = people;
            dataGridView_people_update.CellClick += update_cell_click;
        }

        private void load_data()
        {
            var people = this.context.People.ToList();
            dataGridView_people_update.DataSource = people;
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            form.peopleMenu.Visible = true;
        }

        private void button_change_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        MessageBox.Show("All fields must be filled!");
                    }
                }
            }

            int id = int.Parse(textBox1.Text);

             string sqlQuery = $"SELECT * FROM People WHERE Id = {id}";

             People person = context.People.FromSqlRaw(sqlQuery).FirstOrDefault();

             person.name = textBox2.Text;
             person.age = int.Parse(textBox3.Text);
             person.jobTitle = textBox4.Text;
             person.job = int.Parse(textBox5.Text);

             context.Entry(person).State = EntityState.Modified;

             context.SaveChanges();

             var people = this.context.People.ToList();
             dataGridView_people_update.DataSource = people;
        }

        private void update_cell_click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView_people_update.Rows.Count)
            {
                int id = Convert.ToInt32(dataGridView_people_update.Rows[e.RowIndex].Cells["id"].Value);

                string sqlQuery = $"SELECT * FROM People WHERE Id = {id}";

                People person = context.People.FromSqlRaw(sqlQuery).FirstOrDefault();

                textBox1.Text = person.id.ToString();
                textBox2.Text = person.name;
                textBox3.Text = person.age.ToString();
                textBox4.Text = person.jobTitle.ToString();
                textBox5.Text = person.job.ToString();
                //MessageBox.Show($"It is: {person.name}!");
            }
        }
    }
}
