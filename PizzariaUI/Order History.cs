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
    public partial class Order_History : Form
    {
        public Order_History()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Page mp = new Menu_Page();
            mp.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Order_History oh = new Order_History();
            oh.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Account_Details ad = new Account_Details();
            ad.Show();
        }
    }
}
