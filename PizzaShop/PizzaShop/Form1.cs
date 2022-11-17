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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string size, toppings, crust, place;

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {

            //*************************************************************************************************************
            if (radioButton6.Checked)
            {
                place = "Eat In";
            }
            if (radioButton7.Checked)
            {
                place = "Take Out";
            }
            if (radioButton4.Checked)
            {
                crust = "Thin Crust";
                Console.WriteLine(crust);
            }
            if (radioButton5.Checked)
            {
                crust = "thick crust";
            }
           if (sender == checkBox1)
            {
                toppings += " " + " Extra Cheese";
            }
            if (checkBox2.Checked)
            {
                toppings += " " + " Mushrooms";
            }
            if (checkBox3.Checked)
            {
                toppings += " " + " Onions";
            }
            if (checkBox4.Checked)
            {
                toppings += " " + " Tomatoes";
            }
           if (radioButton1.Checked)
            {
                size = "Small";
            }
            if (radioButton2.Checked)
            {
                size = "Medium";
            }
            if (radioButton3.Checked)
            {
                size = "Large";
            }

            //****************************************************************************************************************



            Form2 test = new Form2();
            test.order(size,toppings,crust,place);
            this.Hide();
            test.Show();
            toppings = "";
           
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
           
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
