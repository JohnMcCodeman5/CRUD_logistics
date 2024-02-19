using CRUD_Logistics.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    public partial class PeopleAdd : UserControl
    {
        public AppDbContext context;
        private BaseForm form;
        public PeopleAdd(AppDbContext context, BaseForm form)
        {
            this.form = form;
            this.Visible = false;
            this.context = context;
            InitializeComponent();
            var people = this.context.People.ToList();
            dataGridView_people_add.DataSource = people;
            var jobs = context.Job.ToList();
            foreach (var job in jobs)
            {
                comboBox1.Items.Add(job.name);
            }
            comboBox1.SelectedIndexChanged += assign_job_id;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            var newPerson = new People
            {
                name = textBox1.Text,
                age = int.Parse(textBox2.Text),
                jobTitle = comboBox1.Text,
                //jobTitle = textBox3.Text,
                job = int.Parse(textBox4.Text)
            };

            context.People.Add(newPerson);

            string updateJobEmployeeCount = $"UPDATE Job AS j SET j.num_of_employees = j.num_of_employees + 1 WHERE j.id = {newPerson.job}";

            context.Database.ExecuteSqlRaw(updateJobEmployeeCount);

            context.SaveChanges();

            loadData();
            form.loadData();
        }

        public void loadData()
        {
            var people = this.context.People.ToList();
            dataGridView_people_add.DataSource = people;
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            form.peopleMenu.Visible = true;
        }

        private void assign_job_id(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {

                string selectedOption = comboBox1.SelectedItem.ToString();
                var sqlQuery = $"SELECT * FROM Job AS j WHERE j.name = '{selectedOption}'";
                var job = context.Job.FromSqlRaw(sqlQuery).FirstOrDefault();
                textBox4.Text = job.id.ToString();
            }
            else
            {
                textBox4.Text = string.Empty;
            }
        }
    }
}
