using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment02._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            double weight = double.Parse(txtWeight.Text);
            double height = double.Parse(txtHeight.Text);

            double BMI = weight / (height * height);

            MessageBox.Show("Your BMI Value is: "+ BMI);
            
        }

        public void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double weight = double.Parse(txtWeight.Text);
                double height = double.Parse(txtHeight.Text);

                double bmi = weight / (height * height);

                bool hasDiabates = Yes.Checked;
                int age = int.Parse(txtAge.Text);

                if(bmi > 25)
                {
                    txtTest.Text = "Take an initial Blood screen test immediately";
                }
                else if (hasDiabates)
                {
                    txtTest.Text = "Take a Blood screen test per every year";
                }
                else if(age > 25)
                {
                    txtTest.Text = "Take an initial Blood screen test per every three years";
                }
                else
                {
                    txtTest.Text = "You do not need to have a Blood screen test";
                }

            }
            catch(FormatException e1)
            {
                MessageBox.Show(e1.ToString(), "Enter a Numarical Value to the Age");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtWeight.Clear();
            txtHeight.Clear();
            txtAge.Clear();

            Yes.Checked = false;
            No.Checked = false;

            txtTest.Clear();
        }
    }
}
