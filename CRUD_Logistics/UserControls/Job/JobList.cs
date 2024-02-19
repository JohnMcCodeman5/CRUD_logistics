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
    public partial class JobList : UserControl
    {
        public AppDbContext context;
        private BaseFormJob form;
        public JobList(AppDbContext context, BaseFormJob form)
        {
            this.form = form;
            this.Visible = false;
            this.context = context;
            InitializeComponent();
            var jobs = this.context.Job.ToList();
            dataGridView_job_list.DataSource = jobs;
        }

        public void turnVisible()
        {
            this.Visible = true;
        }

        public void loadData()
        {
            var jobs = this.context.Job.ToList();
            dataGridView_job_list.DataSource = jobs;
        }

        private void button_list_back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            form.jobMenu.Visible = true;

            form.loadData();
        }
    }
}
