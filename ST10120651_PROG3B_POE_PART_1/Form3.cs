using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ST10120651_PROG3B_POE_PART_1
{
    public partial class Form3 : Form
    {
        Dictionary<string, string> Library;
        Dictionary<string, string> AlternateLibrary;
        int i = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Library = new Dictionary<string, string>();
            Library.Add("000-099", "General Works");
            Library.Add("100-199", "Philosophy and Psychology");
            Library.Add("200-299", "Religion");
            Library.Add("300-399", "Social Sciences");
            Library.Add("400-499", "Language");
            Library.Add("500-599", "Natural Sciences and Mathematics");
            Library.Add("600-699", "Technology");
            Library.Add("700-799", "The Arts");
            Library.Add("800-899", "Literature and Rhetoric");
            Library.Add("900-999", "History, Biography and Geography");

            AlternateLibrary = new Dictionary<string, string>();
            AlternateLibrary.Add( "General Works","000-099");
            AlternateLibrary.Add( "Philosophy and Psychology", "100-199");
            AlternateLibrary.Add("Religion", "200-299");
            AlternateLibrary.Add( "Social Sciences", "300-399");
            AlternateLibrary.Add("Language", "400-499");
            AlternateLibrary.Add("Natural Sciences and Mathematics", "500-599");
            AlternateLibrary.Add("Technology", "600-699");
            AlternateLibrary.Add("The Arts", "700-799");
            AlternateLibrary.Add("Literature and Rhetoric", "800-899");
            AlternateLibrary.Add("History, Biography and Geography", "900-999");

            pictureBox1.Image = iconsImageList.Images[i];
        }

        

        private void button_home_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void start_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string[] callNumbers = { "600-699", "700-799" };
            int index = rnd.Next(callNumbers.Length);
            string[] callNumbers2 = {"300-399", "400-499", "500-599"};
            int index2 = rnd.Next(callNumbers2.Length);
            string[] callNumbers3 = { "000-099", "100-199", "200-299"};
            int index3 = rnd.Next(callNumbers3.Length);
            string[] callNumbers4 = {"800-899", "900-999" };
            int index4 = rnd.Next(callNumbers4.Length);
            firstValue.Text = callNumbers[index];
            secondValue.Text = callNumbers2[index2];
            thirdValue.Text = callNumbers3[index3];
            fourthValue.Text = callNumbers4[index4];

            string NameOnUi = firstValue.Text;

            if (Library.ContainsKey(NameOnUi))
            {
                userAnswer3.Text = Library[NameOnUi];
            }
            string NameOnUi2 = secondValue.Text;

            if (Library.ContainsKey(NameOnUi2))
            {
                userAnswer5.Text = Library[NameOnUi2];
            }
            string NameOnUi3 = thirdValue.Text;

            if (Library.ContainsKey(NameOnUi3))
            {
                userAnswer1.Text = Library[NameOnUi3];
            }
            string NameOnUi4 = fourthValue.Text;

            if (Library.ContainsKey(NameOnUi4))
            {
                userAnswer7.Text = Library[NameOnUi4];
            }


            string[] descriptions = { "General Works", "Philosophy", "History, Biography and Geography" };
            int description_index = rnd.Next(descriptions.Length);
            string[] descriptions2 = { "Social Sciences", "Language", "Natural Sciences and Mathematics" };
            int description_index2 = rnd.Next(descriptions2.Length);
            string[] description3 = { "Technology", "The Arts", "Religion", "Literature and Rhetoric" };
            int description_index3 = rnd.Next(description3.Length);
            
            userAnswer6.Text = descriptions[description_index];
            userAnswer2.Text = descriptions2[description_index2];
            userAnswer4.Text = description3[description_index3];
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string NameOnUi = firstValue.Text;

            if (Library.ContainsKey(NameOnUi))
            {
                firstAnswer.Text = Library[NameOnUi];
            }
            string NameOnUi2 = secondValue.Text;

            if (Library.ContainsKey(NameOnUi2))
            {
                secondAnswer.Text = Library[NameOnUi2];
            }
            string NameOnUi3 = thirdValue.Text;

            if (Library.ContainsKey(NameOnUi3))
            {
                thirdAnswer.Text = Library[NameOnUi3];
            }
            string NameOnUi4 = fourthValue.Text;

            if (Library.ContainsKey(NameOnUi4))
            {
                fourthAnswer.Text = Library[NameOnUi4];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label50_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void alternate_button_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string[] altcallNumbers = { "Technology", "The Arts" };
            int index = rnd.Next(altcallNumbers.Length);
            string[] altcallNumbers2 = { "Religion", "Language", "Natural Sciences and Mathematics" };
            int index2 = rnd.Next(altcallNumbers2.Length);
            string[] altcallNumbers3 = { "General Works", "Philosophy and Psychology" };
            int index3 = rnd.Next(altcallNumbers3.Length);
            string[] altcallNumbers4 = { "Literature and Rhetoric", "History, Biography and Geography" };
            int index4 = rnd.Next(altcallNumbers4.Length);
            altFirrstValue.Text = altcallNumbers[index];
            altSecondValue.Text = altcallNumbers2[index2];
            altThirdValue.Text = altcallNumbers3[index3];
            altFourthValue.Text = altcallNumbers4[index4];

            string NameOnUi = altFirrstValue.Text;

            if (AlternateLibrary.ContainsKey(NameOnUi))
            {
                altUserAnswer3.Text = AlternateLibrary[NameOnUi];
            }
            string NameOnUi2 = altSecondValue.Text;

            if (AlternateLibrary.ContainsKey(NameOnUi2))
            {
                altUserAnswer5.Text = AlternateLibrary[NameOnUi2];
            }
            string NameOnUi3 = altThirdValue.Text;

            if (AlternateLibrary.ContainsKey(NameOnUi3))
            {
                altUserAnswer.Text = AlternateLibrary[NameOnUi3];
            }
            string NameOnUi4 = altFourthValue.Text;

            if (AlternateLibrary.ContainsKey(NameOnUi4))
            {
                altUserAnswer7.Text = AlternateLibrary[NameOnUi4];
            }


            string[] altDescriptions = { "000-099", "200-299", "900-999" };
            int altDescription_index = rnd.Next(altDescriptions.Length);
            string[] altDescriptions2 = { "300-399", "400-499", "500-599" };
            int altDescription_index2 = rnd.Next(altDescriptions2.Length);
            string[] altDescription3 = { "600-699", "700-799", "800-899", "100-199" };
            int altDescription_index3 = rnd.Next(altDescription3.Length);

            altUserAnswer6.Text = altDescriptions[altDescription_index];
            altUserAnswer2.Text = altDescriptions2[altDescription_index2];
            altUserAnswer4.Text = altDescription3[altDescription_index3];
        }

        private void altCheck_Button_Click(object sender, EventArgs e)
        {
            string NameOnUi = altFirrstValue.Text;

            if (AlternateLibrary.ContainsKey(NameOnUi))
            {
                altFirstAnswer.Text = AlternateLibrary[NameOnUi];
            }
            string NameOnUi2 = altSecondValue.Text;

            if (AlternateLibrary.ContainsKey(NameOnUi2))
            {
                altSecondAnswer.Text = AlternateLibrary[NameOnUi2];
            }
            string NameOnUi3 = altThirdValue.Text;

            if (AlternateLibrary.ContainsKey(NameOnUi3))
            {
                altThirdAnswer.Text = AlternateLibrary[NameOnUi3];
            }
            string NameOnUi4 = altFourthValue.Text;

            if (AlternateLibrary.ContainsKey(NameOnUi4))
            {
                altFourthAnswer.Text = AlternateLibrary[NameOnUi4];
            }
        }

        private void iconButton_Click(object sender, EventArgs e)
        {
            if (i != 32)
            {
                i++;                
            }
            else
            {
                 i = 0;
            }

            pictureBox1.Image = iconsImageList.Images[i];
        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
