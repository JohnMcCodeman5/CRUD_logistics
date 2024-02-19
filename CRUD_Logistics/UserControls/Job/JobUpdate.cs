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
    public partial class JobUpdate : UserControl
    {
        public AppDbContext context;
        private BaseFormJob form;
        public JobUpdate(AppDbContext context, BaseFormJob form)
        {
            this.form = form;
            this.Visible = false;
            this.context = context;
            InitializeComponent();
            var jobs = this.context.Job.ToList();
            dataGridView_job_update.DataSource = jobs;
            dataGridView_job_update.CellClick += update_cell_click;
        }

        private void update_cell_click(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView_job_update.Rows.Count)
            {
                int id = Convert.ToInt32(dataGridView_job_update.Rows[e.RowIndex].Cells["id"].Value);

                string sqlQuery = $"SELECT * FROM Job WHERE Id = {id}";

                CRUD_Logistics.Models.JobClass.Job job = context.Job.FromSqlRaw(sqlQuery).FirstOrDefault();

                textBox1.Text = job.id.ToString();
                textBox2.Text = job.name;
                textBox3.Text = job.num_of_employees.ToString();
            }
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

            string sqlQuery = $"SELECT * FROM Job WHERE Id = {id}";

            CRUD_Logistics.Models.JobClass.Job job = context.Job.FromSqlRaw(sqlQuery).FirstOrDefault();

            job.name = textBox2.Text;
            job.num_of_employees = int.Parse(textBox3.Text);

            context.Entry(job).State = EntityState.Modified;

            context.SaveChanges();

            form.loadData();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.form.jobMenu.Visible = true;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        public void loadData()
        {
            var people = this.context.Job.ToList();
            dataGridView_job_update.DataSource = people;
        }
    }
}
