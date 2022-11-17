using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaShop
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        String size, toppings, crust, place;

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void order(string a,string  b ,string c , string d )
        {
            size = a;
            toppings = b;
            crust = c;
            place = d;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            label1.Text = "Size is : " + size;
            label2.Text = "Toppings are : " + toppings;
            label3.Text = "Crust is : " + crust;
            label4.Text =  place;
        }
    }
}
