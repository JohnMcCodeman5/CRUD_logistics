using CRUD_Logistics.UserControls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CRUD_Logistics
{
    public partial class BaseForm : Form
    {
        private string username;
        private string password;
        private string db_name;
        public AppDbContext context;

        public PeopleMenu peopleMenu;
        public PeopleList peopleList;
        public PeopleAdd peopleAdd;
        public PeopleUpdate peopleUpdate;
        public PeopleDelete peopleDelete;

        private List<UserControl> userControls;

        public BaseForm(string username, string password, string db_name, FormLogin loginForm)
        {
            this.username = username;
            this.password = password;
            this.db_name = db_name;
            this.userControls = new List<UserControl>();

            this.context = new AppDbContext(username, password, db_name);

            this.peopleMenu = new PeopleMenu(context, this, loginForm);
            this.peopleList = new PeopleList(context, this);
            this.peopleAdd = new PeopleAdd(context, this);
            this.peopleUpdate = new PeopleUpdate(context, this);
            this.peopleDelete = new PeopleDelete(context, this);

            InitializeComponent();

            this.Controls.Add(peopleMenu);
            this.userControls.Append(peopleList);
            this.Controls.Add(peopleList);
            this.userControls.Append(peopleAdd);
            this.Controls.Add(peopleAdd);
            this.userControls.Append(peopleUpdate);
            this.Controls.Add(peopleUpdate);
            this.userControls.Append(peopleDelete);
            this.Controls.Add(peopleDelete);
            this.peopleList.Visible = false;
            this.peopleAdd.Visible = false;
            this.peopleUpdate.Visible = false;
            this.peopleDelete.Visible = false;
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
            this.peopleList.loadData();
            this.peopleAdd.loadData();
            this.peopleUpdate.loadData();
            this.peopleDelete.loadData();
        }
    }
}
