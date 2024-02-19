using CRUD_Logistics.Models.JobClass;
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

namespace CRUD_Logistics.UserControls.Job
{
    public partial class JobDelete : UserControl
    {
        public AppDbContext context;
        private BaseFormJob form;
        public JobDelete(AppDbContext context, BaseFormJob form)
        {
            this.form = form;
            this.Visible = false;
            this.context = context;
            InitializeComponent();
            var jobs = this.context.Job.ToList();
            dataGridView_job_delete.DataSource = jobs;
            dataGridView_job_delete.CellClick += update_delete_cell;
        }

        private void update_delete_cell(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView_job_delete.Rows.Count)
            {
                int id = Convert.ToInt32(dataGridView_job_delete.Rows[e.RowIndex].Cells["id"].Value);

                string sqlQuery = $"SELECT * FROM Job WHERE Id = {id}";

                CRUD_Logistics.Models.JobClass.Job person = context.Job.FromSqlRaw(sqlQuery).FirstOrDefault();

                textBox1.Text = person.id.ToString();
                textBox2.Text = person.name;
                textBox3.Text = person.num_of_employees.ToString();
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            form.jobMenu.Visible = true;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);

            string name = textBox2.Text;

            string sqlQuery = $"DELETE FROM Job WHERE Id = {id}";

            foreach(People p in context.People)
            {
                if (p.job == id)
                {
                    MessageBox.Show("You can't delete a job which still has employees", "Error:Employees still present", MessageBoxButtons.OK);
                    return;
                }
            }

            context.Database.ExecuteSqlRaw(sqlQuery);

            context.SaveChanges();

            form.loadData();
        }

        public void loadData()
        {
            var people = this.context.Job.ToList();
            dataGridView_job_delete.DataSource = people;
        }

    }
}
