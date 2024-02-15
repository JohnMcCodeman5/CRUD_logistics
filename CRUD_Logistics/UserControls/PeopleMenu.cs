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
    public partial class PeopleMenu : UserControl
    {
        public AppDbContext context;
        private BaseForm form;
        public PeopleMenu(AppDbContext context, BaseForm form)
        {
            this.form = form;
            this.context = context;
            InitializeComponent();
        }

        private void button_menu_list_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.form.peopleList.Visible = true;
        }

        private void button_menu_add_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.form.peopleAdd.Visible = true;
        }

        private void button_menu_update_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.form.peopleUpdate.Visible = true;
        }

        private void button_menu_delete_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.form.peopleDelete.Visible = true;
        }
    }
}
