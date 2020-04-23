using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaUI
{
    public partial class Employee_Login : Form
    {
        public Employee_Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Page mp = new Menu_Page();
            mp.Show();
        }
    }
}
