using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var input = textBox1.Text;
            
            int num = Convert.ToInt32(input);
            if (num % 3 == 0 && num % 5 == 0)
            {
                //MessageBox.Show("FizzBuzz!");
                label1.Text = "FizzBuzz!";
                label1.TextAlign = ContentAlignment.MiddleCenter;
                this.Controls.Add(label1);
            }
            else if (num % 3 != 0 && num % 5 == 0)
            {
                //MessageBox.Show("Buzz!");
                label1.Text = "Buzz";
                label1.TextAlign = ContentAlignment.MiddleCenter;
                this.Controls.Add(label1);
            }
            else if (num % 3 == 0 && num % 5 != 0)
            {
                //MessageBox.Show("Fizz!");
                label1.Text = "Fizz!";
                label1.TextAlign = ContentAlignment.MiddleCenter;
                this.Controls.Add(label1);
            }
            else if (num % 3 != 0 && num % 5 != 0)
            {
                //MessageBox.Show(input);
                label1.Text = input;
                label1.TextAlign = ContentAlignment.MiddleCenter;
                this.Controls.Add(label1);
            }
            else
            {
                //MessageBox.Show("Invalid Entry!");
                label1.Text = "Invalid";
                label1.TextAlign = ContentAlignment.MiddleCenter;
                this.Controls.Add(label1);
            } 
                


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
