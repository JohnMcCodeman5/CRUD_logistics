using CRUD_Logistics.UserControls;
using CRUD_Logistics.UserControls.Job;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Logistics
{
    public partial class BaseFormJob : Form
    {
        private string username;
        private string password;
        private string db_name;
        public AppDbContext context;

        public JobMenu jobMenu;
        public JobList jobList;
        public JobAdd jobAdd;
        public JobDelete jobDelete;
        public JobUpdate jobUpdate;

        private List<UserControl> userControls;

        public BaseFormJob(string username, string password, string db_name, FormLogin loginForm)
        {
            this.username = username;
            this.password = password;
            this.db_name = db_name;
            this.userControls = new List<UserControl>();

            this.context = new AppDbContext(username, password, db_name);

            this.jobMenu = new JobMenu(context, this, loginForm);
            this.jobList = new JobList(context, this);
            this.jobAdd = new JobAdd(context, this);
            this.jobUpdate = new JobUpdate(context, this);
            this.jobDelete = new JobDelete(context, this);

            InitializeComponent();

            this.Controls.Add(jobMenu);
            this.Controls.Add(jobList);
            this.Controls.Add(jobAdd);
            this.Controls.Add(jobDelete);
            this.Controls.Add(jobUpdate);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            //check if app closing is intentional
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Terminate the application
                Application.Exit();
            }
        }

        public void loadData()
        {
            this.jobList.loadData();
            this.jobAdd.loadData();
            this.jobDelete.loadData();
            this.jobUpdate.loadData();
        }
    }
}
