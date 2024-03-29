﻿using System;
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
    public partial class PeopleList : UserControl
    {
        public AppDbContext context;
        private BaseForm form;
        public PeopleList(AppDbContext context,BaseForm form)
        {
            this.form = form;
            this.Visible = false;
            this.context = context;
            InitializeComponent();
            var people = this.context.People.ToList();
            dataGridView_people_list.DataSource = people;
        }

        public void turnVisible()
        {
            this.Visible = true;
        }

        private void button_list_back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            form.peopleMenu.Visible = true;

            form.loadData();
        }

        public void loadData()
        {
            var people = this.context.People.ToList();
            dataGridView_people_list.DataSource = people;
        }
    }
}
