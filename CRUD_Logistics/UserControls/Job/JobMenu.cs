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
    public partial class JobMenu : UserControl
    {
        public AppDbContext context;
        private BaseFormJob form;
        private FormLogin loginForm;
        public JobMenu(AppDbContext context, BaseFormJob form, FormLogin loginForm)
        {
            this.form = form;
            this.context = context;
            this.loginForm = loginForm;
            InitializeComponent();

            richTextBox1.Text = $"Welcome, user {context.username}";
            int startIndex = richTextBox1.Text.IndexOf(context.username);
            int length = context.username.Length;

            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox1.SelectionStart = startIndex;
            richTextBox1.SelectionLength = length;
            richTextBox1.SelectionColor = Color.Red;

            richTextBox2.Text = "Description of menu option:\n";
        }

        private void button_menu_list_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.form.jobList.Visible = true;
        }

        private void button_menu_list_Hover(object sender, EventArgs e)
        {
            richTextBox2.AppendText("Get a list of all current table entries");
        }

        private void reset_description(object sender, EventArgs e)
        {
            richTextBox2.Text = "Description of menu option:\n";
        }

        private void button_menu_add_Hover(object sender, EventArgs e)
        {
            richTextBox2.AppendText("Fill a form to add a new entry");
        }

        private void button_menu_update_Hover(object sender, EventArgs e)
        {
            richTextBox2.AppendText("Fill a form to update an existing entry");
        }

        private void button_menu_delete_Hover(object sender, EventArgs e)
        {
            richTextBox2.AppendText("Select an already existing entry to delete");
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            this.loginForm.Show();
            form.Hide();
        }

        private void button_menu_add_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.form.loadData();
            this.form.jobAdd.Visible = true;
        }

        private void button_menu_delete_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.form.jobDelete.Visible = true;
        }

        private void button_menu_update_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.form.jobUpdate.Visible = true;
        }
    }
}
