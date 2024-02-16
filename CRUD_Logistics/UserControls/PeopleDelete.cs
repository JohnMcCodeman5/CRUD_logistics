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
    public partial class PeopleDelete : UserControl
    {
        public AppDbContext context;
        private BaseForm form;
        public PeopleDelete(AppDbContext context, BaseForm form)
        {
            this.form = form;
            this.Visible = false;
            this.context = context;
            InitializeComponent();
            var people = this.context.People.ToList();
            dataGridView_people_delete.DataSource = people;
            dataGridView_people_delete.CellClick += update_cell_click;
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            form.peopleMenu.Visible = true;
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);

            string sqlQuery = $"DELETE FROM People WHERE Id = {id}";

            context.Database.ExecuteSqlRaw(sqlQuery);

            context.SaveChanges();

            var people = this.context.People.ToList();
            dataGridView_people_delete.DataSource = people;
            form.loadData();
        }

        private void update_cell_click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView_people_delete.Rows.Count)
            {
                int id = Convert.ToInt32(dataGridView_people_delete.Rows[e.RowIndex].Cells["id"].Value);

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

        public void loadData()
        {
            var people = this.context.People.ToList();
            dataGridView_people_delete.DataSource = people;
        }
    }
}
