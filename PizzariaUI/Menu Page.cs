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
    public partial class Menu_Page : Form
    {
        public Menu_Page()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Page_Load(object sender, EventArgs e)
        {

        }

        private void button36_Click(object sender, EventArgs e)
        {

        }

        private void button37_Click(object sender, EventArgs e)
        {

        }

        private void button38_Click(object sender, EventArgs e)
        {

        }

        private void button35_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button49_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Page mp = new Menu_Page();
            mp.Show();
        }

        private void orderHistoryButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Order_History oh = new Order_History();
            oh.Show();
        }

        private void accountDetailsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Account_Details ad = new Account_Details();
            ad.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
