using CRUD_Logistics.Models.JobClass;
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

namespace CRUD_Logistics.UserControls.Job
{
    public partial class JobAdd : UserControl
    {
        public AppDbContext context;
        private BaseFormJob form;
        public JobAdd(AppDbContext context, BaseFormJob form)
        {
            this.form = form;
            this.Visible = false;
            this.context = context;
            InitializeComponent();
            var jobs = this.context.Job.ToList();
            dataGridView_job_add.DataSource = jobs;
            textBox2.Text = "0";
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            form.jobMenu.Visible = true;
            textBox1.Clear();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            var newJob = new CRUD_Logistics.Models.JobClass.Job
            {
                name = textBox1.Text,
                num_of_employees = int.Parse(textBox2.Text)
            };

            context.Job.Add(newJob);

            context.SaveChanges();

            loadData();
            form.loadData();
        }

        public void loadData()
        {
            var jobs = this.context.Job.ToList();
            dataGridView_job_add.DataSource = jobs;
        }
    }
}
