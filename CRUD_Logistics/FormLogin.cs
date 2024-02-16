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
    public partial class FormLogin : Form
    {
        private string username;
        private string password;
        private string table;
        public FormLogin()
        {
            InitializeComponent();
        }

        /*private void Form2_Load(object sender, EventArgs e)
        {

        }*/

        private void button1Log_Click(object sender, EventArgs e)
        {
            this.username = textBox1Log.Text;
            this.password = textBox2Log.Text;
            this.table = textBox3Log.Text;

            switch (this.table)
            {
                case "other":
                    Form1 form1 = new Form1(this.username, this.password);
                    this.Hide();
                    form1.Show();
                    break;

                case "people":
                    BaseForm form = new BaseForm(this.username, this.password, this);
                    this.Hide();
                    form.Show();
                    break;

                default:
                    break;
            }



        }
    }
}
