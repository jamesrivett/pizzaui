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
            listBox1.Items.Add("Small Cheese Pizza");
        }

        private void Menu_Page_Load(object sender, EventArgs e)
        {

        }

        private void button36_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("XL ML Pizza");
        }

        private void button37_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("XL Veggie Pizza");
        }

        private void button38_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("XL Pepperoni Pizza");
        }

        private void button35_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("XL Cheese Pizza");
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button49_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("+ Onions");
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

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label68_Click(object sender, EventArgs e)
        {

        }

        private void label65_Click(object sender, EventArgs e)
        {

        }

        private void label56_Click(object sender, EventArgs e)
        {

        }

        private void label47_Click(object sender, EventArgs e)
        {

        }

        private void label46_Click(object sender, EventArgs e)
        {

        }

        private void label45_Click(object sender, EventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label67_Click(object sender, EventArgs e)
        {

        }

        private void label64_Click(object sender, EventArgs e)
        {

        }

        private void label59_Click(object sender, EventArgs e)
        {

        }

        private void label48_Click(object sender, EventArgs e)
        {

        }

        private void label49_Click(object sender, EventArgs e)
        {

        }

        private void label50_Click(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void label66_Click(object sender, EventArgs e)
        {

        }

        private void label63_Click(object sender, EventArgs e)
        {

        }

        private void label62_Click(object sender, EventArgs e)
        {

        }

        private void label51_Click(object sender, EventArgs e)
        {

        }

        private void label52_Click(object sender, EventArgs e)
        {

        }

        private void label53_Click(object sender, EventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cheeseMediumButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Medium Cheese Pizza");
        }

        private void cheeseLargeButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Large Cheese Pizza");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Small ML Pizza");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Medium ML Pizza");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Large ML Pizza");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Small Veggie Pizza");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Medium Veggie Pizza");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Large Veggie Pizza");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Small Pepperoni Pizza");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Medium Pepperoni Pizza");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Large Pepperoni Pizza");
        }

        private void button42_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("SMALL BYO");
            listBox1.Items.Add("---------------");
        }

        private void button41_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("MEDIUM BYO");
            listBox1.Items.Add("---------------");
        }

        private void button40_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("LARGE BYO");
            listBox1.Items.Add("---------------");
        }

        private void button39_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("XL BYO");
            listBox1.Items.Add("---------------");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("- Regular Crust");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("- Thin Crust");
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Add("- Stuffed Crust");
        }

        private void button46_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("+ Cheese");
        }

        private void button45_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("+ Canadian Bacon");
        }

        private void button44_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("+ Bacon");
        }

        private void button43_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("+ Italina Sausage");
        }

        private void button50_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("+ Peppers");
        }

        private void button48_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("+ Black Olives");
        }

        private void button47_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("+ Banana Peppers");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Cheese Sticks");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Mozzarela Sticks");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Bread Sticks");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Small Coke Product");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Medium Coke Product");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Large Coke Product");
        }

        private void button33_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Small Tea/Lemonade");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Medium Tea/Lemonade");
        }

        private void button29_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Large Tea/Lemonade");
        }

        private void button32_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Small Beer");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Medium Beer");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Large Beer");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
