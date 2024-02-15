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
        public AppDbContext context;
        public BaseFormJob(string username, string password)
        {
            FormJob userControl = new FormJob(username, password);
            InitializeComponent();

            this.Controls.Add(userControl);
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
