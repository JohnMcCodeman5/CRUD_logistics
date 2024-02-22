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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRUD_Logistics
{
    public partial class FormLogin : Form
    {
        private string username;
        private string password;
        private string table;
        private string db_name;

        public FormLogin()
        {
            InitializeComponent();

            //comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            AppDbContext context = new AppDbContext(username, password, db_name);
            System.Collections.Generic.List<String> tables = context.Model.GetEntityTypes()
                                   .Select(t => t.GetTableName())
                                   .ToList();

            foreach (var table in tables)
            {
                comboBox1.Items.Add(table);
            }
        }

        private void button1Log_Click(object sender, EventArgs e)
        {
            this.username = textBox1Log.Text;
            this.password = textBox2Log.Text;
            this.db_name = textBox3Log.Text;
            this.table = comboBox1.Text;

            switch (this.db_name)
            {
                case "test_db":
                    switch (this.table)
                    {
                        case "Job":
                            BaseFormJob formJob = new BaseFormJob(this.username, this.password, this.db_name, this);
                            this.Hide();
                            formJob.Show();
                            break;

                        case "People":
                            BaseForm formPeople = new BaseForm(this.username, this.password, this.db_name, this);
                            this.Hide();
                            formPeople.Show();
                            break;

                        default:
                            MessageBox.Show("Database doesn't contain said table", "Error: Invalid table name", MessageBoxButtons.OK);
                            break;
                    }
                    break;

                default:
                    MessageBox.Show($"No known database '{this.db_name}'", "Error: Invalid Database", MessageBoxButtons.OK);
                    break;
            }




        }
    }
}
