using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson8averages
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //read values, add the values, divide by 2
            //display the average back to user
            //"10" can be converted to numerical form
            //ten cannot be converted
            decimal firstValue = decimal.Parse(textBox1.Text);
            decimal secondValue = decimal.Parse(textBox2.Text);
            //(firstValue+secondValue) runs first because it's enclosed in parenthesis
            //so this forces the correct order of execution
            //then the division by 2 happens
            decimal average = (firstValue + secondValue) / 2;
            //:C has the effect of adding a dollar symbol in the output
            //also has the effect of rounding the output to two decimal places
            label1.Text = $"Average Salary={average:C}"; 
        }
    }
}
