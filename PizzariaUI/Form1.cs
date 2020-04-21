using System;
using System.Collections.Generic;
using System.ComponentModel;
using .Data;
using System.Drawing;
using System.Linq;
using System.Text;System
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void returnCust_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer_Login cl = new Customer_Login();
            cl.Show();
        }

        private void newCust_Click(object sender, EventArgs e)
        {
            this.Hide();
            New_Customer cl = new New_Customer();
            cl.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
