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
    public partial class Form3 : Form
    {
        private string username;
        private string password;
        public AppDbContext context;
        public Form3(string username, string password)
        {
            this.username = username;
            this.password = password;
            this.context = new AppDbContext(this.username, this.password);

            InitializeComponent();
        }
    }
}
