using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ST10120651_PROG3B_POE_PART_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string newLine = Environment.NewLine;
            int nums = rnd.Next(0, 1001);
            textBox1.Text = nums.ToString();

            for (int i = 1; i <= 9; i++)
            {
                nums = rnd.Next(0, 1001);
                textBox1.Text = textBox1.Text + newLine + nums.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Min = 0;
            int Max = 1000;

            // this declares an integer array with 10 elements            
            int[] numbers = new int[10];

            Random randNum = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = randNum.Next(Min, Max);
            }
            Array.Sort(numbers);
            foreach (var i in numbers)
            {
                listBox1.Items.Add(i);
            }
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Call numbers are correctly sorted in ascending order!");
        }
    }
}
