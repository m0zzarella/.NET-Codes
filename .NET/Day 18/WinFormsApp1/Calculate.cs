using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Calculate : Form
    {
        public Calculate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);

            if(comboBox1.Text == "Addition")
            {
                MessageBox.Show("Addition " + (num1 + num2));
            }
            if (comboBox1.Text == "Subtraction")
            {
                MessageBox.Show("Subtraction " + (num1 - num2));
            }
            if (comboBox1.Text == "Multiplication")
            {
                MessageBox.Show("Multiplication " + (num1 * num2));
            }
            if (comboBox1.Text == "Division")
            {
                MessageBox.Show("Division " + (num1 + num2));
            }
        }
    }
}
