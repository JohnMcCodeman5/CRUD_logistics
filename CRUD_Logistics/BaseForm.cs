using CRUD_Logistics.UserControls;
using System;
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
        public AppDbContext context;

        public PeopleMenu peopleMenu;
        public PeopleList peopleList;
        public PeopleAdd peopleAdd;
        public PeopleUpdate peopleUpdate;
        public PeopleDelete peopleDelete;

        public BaseForm(string username, string password)
        {
            this.username = username;
            this.password = password;

            this.context = new AppDbContext(username, password);

            this.peopleMenu = new PeopleMenu(context, this);
            this.peopleList = new PeopleList(context, this);
            this.peopleAdd = new PeopleAdd(context, this);
            this.peopleUpdate = new PeopleUpdate(context, this);
            this.peopleDelete = new PeopleDelete(context, this);

            InitializeComponent();

            this.Controls.Add(peopleMenu);
            this.Controls.Add(peopleList);
            this.Controls.Add(peopleAdd);
            this.Controls.Add(peopleUpdate);
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
    }
}
