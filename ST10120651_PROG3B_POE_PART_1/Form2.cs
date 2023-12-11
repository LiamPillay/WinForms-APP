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
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    
    public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // List that stores the call numbers
            List<string> callNumbers = new List<string>();
            callNumbers.Add("005.35 JAM");
            callNumbers.Add("045.5 URF");
            callNumbers.Add("123.89 RED");
            callNumbers.Add("234.67 HER");
            callNumbers.Add("335.90 EDC");
            callNumbers.Add("421.11 KIM");
            callNumbers.Add("589.43 TGV");
            callNumbers.Add("678.99 QS");
            callNumbers.Add("781.12 RF");
            callNumbers.Add("813.56 NU");
            callNumbers.Add("956.67 WA");
            callNumbers.Add("125.35 RIF");
            callNumbers.Add("225.67 NU");
            callNumbers.Add("345.45 JU");
            callNumbers.Add("456.21 NP");
            callNumbers.Add("567.32 KKIW");
            callNumbers.Add("673.90 NKJV");
            callNumbers.Add("778.32 NIV");
            callNumbers.Add("890.12 GEN");
            callNumbers.Add("990.50 TO");
            callNumbers.Add("123.60 TMR");

            // randomly generate call numbers
            Random rnd = new Random();
            int index = rnd.Next(callNumbers.Count);
            int index2 = rnd.Next(callNumbers.Count);
            int index3 = rnd.Next(callNumbers.Count);
            int index4 = rnd.Next(callNumbers.Count);
            int index5 = rnd.Next(callNumbers.Count);
            int index6 = rnd.Next(callNumbers.Count);
            int index7 = rnd.Next(callNumbers.Count);
            int index8 = rnd.Next(callNumbers.Count);
            int index9 = rnd.Next(callNumbers.Count);
            int index10 = rnd.Next(callNumbers.Count);

            textBox1.Text = callNumbers[index];
            textBox2.Text = callNumbers[index2];
            textBox3.Text = callNumbers[index3];
            textBox4.Text = callNumbers[index4];
            textBox5.Text = callNumbers[index5];
            textBox6.Text = callNumbers[index6];
            textBox7.Text = callNumbers[index7];
            textBox8.Text = callNumbers[index8];
            textBox9.Text = callNumbers[index9];
            textBox10.Text = callNumbers[index10];

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // return to the home page feature
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // generate list of call numbers
            List<string> callNumbers = new List<string>();
            callNumbers.Add("005.35 JAM");
            callNumbers.Add("045.5 URF");
            callNumbers.Add("123.89 RED");
            callNumbers.Add("234.67 HER");
            callNumbers.Add("335.90 EDC");
            callNumbers.Add("421.11 KIM");
            callNumbers.Add("589.43 TGV");
            callNumbers.Add("678.99 QS");
            callNumbers.Add("781.12 RF");
            callNumbers.Add("813.56 NU");
            callNumbers.Add("956.67 WA");
            callNumbers.Add("125.35 RIF");
            callNumbers.Add("225.67 NU");
            callNumbers.Add("345.45 JU");
            callNumbers.Add("456.21 NP");
            callNumbers.Add("567.32 KKIW");
            callNumbers.Add("673.90 NKJV");
            callNumbers.Add("778.32 NIV");
            callNumbers.Add("890.12 GEN");
            callNumbers.Add("990.50 TO");
            callNumbers.Add("123.60 TMR");

            int Min = 0;
            int Max = 1000;

            // this declares an integer array with 10 elements            
            int[] numbers = new int[10];

            Random randNum = new Random();
            // sort the list in ascending order
            callNumbers.Sort();
            foreach (var i in callNumbers)
            {
                listBox1.Items.Add(i);
            }
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // feature to exit the application
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click on generate to generate ten random call numbers. Fill the call numbers into the blocks next to them into ascending order then click Sort to view the sorted order of the call numbers and compare them to your sorted list!");
        }
    }
}
