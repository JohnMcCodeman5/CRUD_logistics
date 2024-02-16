using CRUD_Logistics.Models;
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
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            var newPerson = new People
            {
                name = textBox1.Text,
                age = int.Parse(textBox2.Text),
                jobTitle = textBox3.Text,
                job = int.Parse(textBox4.Text)
            };

            context.People.Add(newPerson);
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
    }
}
