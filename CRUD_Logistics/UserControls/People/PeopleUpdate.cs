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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            var jobs = context.Job.ToList();
            foreach (var job in jobs)
            {
                comboBox1.Items.Add(job.name);
            }
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndexChanged += assign_job_id;

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
                if (control is System.Windows.Forms.TextBox textBox)
                {
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        MessageBox.Show("All fields must be filled!", "Empty Fields Detected", MessageBoxButtons.OK);
                    }
                }
            }

            int id = int.Parse(textBox1.Text);

            string sqlQuery = $"SELECT * FROM People WHERE Id = {id}";

            People person = context.People.FromSqlRaw(sqlQuery).FirstOrDefault();

            int jobID = person.job;

            person.name = textBox2.Text;
            person.age = int.Parse(textBox3.Text);
            person.jobTitle = comboBox1.Text;
            person.job = int.Parse(textBox5.Text);

            context.Entry(person).State = EntityState.Modified;

            if (person.job != jobID)
            {
                context.Database.BeginTransaction();
                string increaseJobEmployeeCount = $"UPDATE Job AS j SET j.num_of_employees = j.num_of_employees + 1 WHERE j.id = {person.job}";
                context.Database.ExecuteSqlRaw(increaseJobEmployeeCount);
                string decreaseJobEmployeeCount = $"UPDATE Job AS j SET j.num_of_employees = j.num_of_employees - 1 WHERE j.id = {jobID}";
                context.Database.ExecuteSqlRaw(decreaseJobEmployeeCount);
                context.Database.CommitTransaction();
            }

            context.SaveChanges();

            var people = this.context.People.ToList();
            dataGridView_people_update.DataSource = people;

            form.loadData();
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
                comboBox1.Text = person.jobTitle.ToString();
                textBox5.Text = person.job.ToString();
                //MessageBox.Show($"It is: {person.name}!");
            }
        }

        public void loadData()
        {
            var people = this.context.People.ToList();
            dataGridView_people_update.DataSource = people;
        }

        private void assign_job_id(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {

                string selectedOption = comboBox1.SelectedItem.ToString();
                var sqlQuery = $"SELECT * FROM Job AS j WHERE j.name = '{selectedOption}'";
                var job = context.Job.FromSqlRaw(sqlQuery).FirstOrDefault();
                textBox5.Text = job.id.ToString();
            }
            else
            {
                textBox5.Text = string.Empty;
            }
        }
    }
}
