using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ST10120651_PROG3B_POE_PART_1.TreeComponent;

namespace ST10120651_PROG3B_POE_PART_1
{
    public partial class Form4 : Form
    {
        /// <summary>
        /// Declares the dictionaries and Timer + score- for score feature
        /// </summary>

        Dictionary<string, string> FirstQuestion;
        Dictionary<string, string> SecondQuestion;
        Dictionary<string, string> Answer;
        Timer timer = new Timer();
        int score;

        public Form4()
        {
            InitializeComponent();
        }
        private void Form4_Load_1(object sender, EventArgs e)
        {
            // Add values to the dictionaries

            FirstQuestion = new Dictionary<string, string>();
            FirstQuestion.Add("Bibliographies and catalogs of individuals", "000 Computer Science, Information, General Works");
            FirstQuestion.Add("Colour", "700 The Arts");
            FirstQuestion.Add("Human Figures", "700 The Arts");
            FirstQuestion.Add("General encylopedic works in English", "000 Computer Science, Information, General Works");
            FirstQuestion.Add("Comparative psychology", "100 Philosophy");
            FirstQuestion.Add("Dreams and mystery", "100 Philosophy");
            FirstQuestion.Add("Old Testament", "200 Religion");
            FirstQuestion.Add("God", "200 Religion");
            FirstQuestion.Add("Procedure and courts", "300 Social Sciences");
            FirstQuestion.Add("Primary education", "300 Social Sciences");
            FirstQuestion.Add("Standard usage", "400 Language");
            FirstQuestion.Add("Afro-Asiatic languages", "400 Language");
            FirstQuestion.Add("Algebra", "500 Science and Mathematics");
            FirstQuestion.Add("Seedless plants", "500 Science and Mathematics");
            FirstQuestion.Add("Personal health and safety", "600 Technology");
            FirstQuestion.Add("Food and drink", "600 Technology");
            FirstQuestion.Add("Leather and fur processing", "600 Technology");
            FirstQuestion.Add("Latin poetry", "800 Literature");
            FirstQuestion.Add("English drama", "800 Literature");
            FirstQuestion.Add("Japan", "900 History and Geography");
            FirstQuestion.Add("Algeria", "900 History and Geography");
            FirstQuestion.Add("Canada", "900 History and Geography");


            SecondQuestion = new Dictionary<string, string>();
            SecondQuestion.Add("Bibliographies and catalogs of individuals 000", "010 Bibliography");
            SecondQuestion.Add("Colour 700", "750 Painting and Paintings");
            SecondQuestion.Add("Human Figures 700", "750 Painting and Paintings");
            SecondQuestion.Add("General encylopedic works in English 000", "030 General Encyclopedic Works");
            SecondQuestion.Add("Comparative psychology 100", "150 Psychology");
            SecondQuestion.Add("Dreams and mystery 100", "130 Parapsychology and occulitism");
            SecondQuestion.Add("Old Testament 200", "220 Bible");
            SecondQuestion.Add("God 200", "230 Christianity");
            SecondQuestion.Add("Procedure and courts 300", "340 Law");
            SecondQuestion.Add("Primary education 300", "370 Education");
            SecondQuestion.Add("Standard usage 400", "410 Linguistics");
            SecondQuestion.Add("Afro-Asiatic languages 400", "490 Other languages");
            SecondQuestion.Add("Algebra 500", "510 Mathematics");
            SecondQuestion.Add("Seedless plants 500", "580 Plants");
            SecondQuestion.Add("Personal health and safety 600", "610 Medicine and health");
            SecondQuestion.Add("Food and drink 600", "640 Home and family management");
            SecondQuestion.Add("Leather and fur processing 600", "670 Manufacturing");
            SecondQuestion.Add("Latin poetry 800", "870 Latin");
            SecondQuestion.Add("English drama 800", "820 English");
            SecondQuestion.Add("Japan 900", "950 History of Asia");
            SecondQuestion.Add("Algeria 900", "960 History of Africa");
            SecondQuestion.Add("Canada 900", "970 History of North America");

            Answer = new Dictionary<string, string>();
            Answer.Add("Computer Sciences, Information, General Works 010", " 010 Bibliography");
            Answer.Add("The Arts 750", "750 Painting and Paintings ");
            Answer.Add("Computer Sciences, Information, General Works 030", "030 General Encyclopedic Works ");
            Answer.Add("Philosophy 150", "150 Psychology");
            Answer.Add("Philosophy 130", "130 Parapsychology and occulitism");
            Answer.Add("Religion 220", "220 Bible");
            Answer.Add("Religion 230 Christianity", "230 Christianity");
            Answer.Add("Social Sciences 340", "340 Law ");
            Answer.Add("Social Sciences 370", "370 Education");
            Answer.Add("Language 410", "410 Linguistics");
            Answer.Add("Language 490", "490 Other languages");
            Answer.Add("Science and Mathematics 510", "510 Mathematics");
            Answer.Add("Science and Mathematics 580", "580 Plants");
            Answer.Add("Technology 610", "610 Medicine and health");
            Answer.Add("Technology 640", "640 Home and family management");
            Answer.Add("Technology 670", "670 Manufacturing");
            Answer.Add("Literature 870 Latin", "870 Latin");
            Answer.Add("Literature 820", "820 English");
            Answer.Add("History and Geography 950", "950 History of Asia");
            Answer.Add("History and Geography 960", "960 History of Africa");
            Answer.Add("History and Geography 970", "970 History of North America");
            


        }
        private void Form4_Load(object sender, EventArgs e)
        {
           
            

        }

            private void button1_Click(object sender, EventArgs e)
        {
            // Declare new random
            
            Random rd = new Random();

            // Create arrays for the call descriptions that need be randomly generated into the fields
            
            string[] callNumbers = { "Colour", "Bibliographies and catalogs of individuals", "Human Figures", "General encylopedic works in English"
            , "Comparative psychology", "Dreams and mystery", "Old Testament", "God", "Procedure and courts", "Primary education", "Standard usage",
            "Afro-Asiatic languages", "Seedless plants", "Personal health and safety", "Food and drink", "Latin poetry", "English drama", "Japan"
            , "Algeria", "Canada", "Leather and fur processing"};
            int index = rd.Next(callNumbers.Length);
            textBox2.Text = callNumbers[index];
            string NameOnUi = textBox2.Text;

            string[] descriptions = { "000 Computer Science, Information, General Works", "700 The Arts", "100 Philosophy", "200 Religion", "300 Social Sciences", "400 Language", "500 Science and Mathematics", "600 Technology"
            ,"800 Literature", "900 History and Geography"};
            int descriptionIndex = rd.Next(descriptions.Length);

            string[] descriptions2 = { "000 Computer Science, Information, General Works", "700 The Arts", "100 Philosophy", "200 Religion", "300 Social Sciences", "400 Language", "500 Science and Mathematics", "600 Technology"
            ,"800 Literature", "900 History and Geography"};
            int descriptionIndex2 = rd.Next(descriptions2.Length);

            string[] descriptions3 = { "000 Computer Science, Information, General Works", "700 The Arts", "100 Philosophy", "200 Religion", "300 Social Sciences", "400 Language", "500 Science and Mathematics", "600 Technology"
            ,"800 Literature", "900 History and Geography"};
            int descriptionIndex3 = rd.Next(descriptions3.Length);

            // if statement that generates the corresponding Key from the dictionary into one of the Top-Level options and three random Top-Level options

            if (FirstQuestion.ContainsKey(NameOnUi))
            {
                secondAnswer.Text = FirstQuestion[NameOnUi];
                firstAnswer.Text = descriptions[descriptionIndex];
                thirdAnswer.Text = descriptions2[descriptionIndex2];
                fourthAnswer.Text = descriptions3[descriptionIndex3];
                MessageBox.Show("Good luck!");
            }

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Function that closes the application
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            // Create Trees to store the call numbers and descriptions
            Tree<Employee> Arts = new Tree<Employee>(new Node<Employee>(new(700, "The Arts"), null))
                .CreateBranch(new(750, "Painting and Paintings"))
                    .CreateBranch(new(752, "Colour"))                                           
                    .CloseBranch()
                .CloseBranch();

            Tree<Employee> computerScience = new Tree<Employee>(new Node<Employee>(new(000, "Computer Science, Information, General Works"), null))
               .CreateBranch(new(010, "Bibliography"))
                   .CreateBranch(new(012, "Bibliographies and catalogs of individuals"))
                   .CloseBranch()
               .CloseBranch();

            Tree<Employee> Arts2 = new Tree<Employee>(new Node<Employee>(new(700, "The Arts"), null))
                .CreateBranch(new(750, "Painting and Paintings"))
                    .CreateBranch(new(757, "Human Figures"))                      
                    .CloseBranch()
                .CloseBranch();

            Tree<Employee> computerScience2 = new Tree<Employee>(new Node<Employee>(new(000, "Computer Science, Information, General Works"), null))
                .CreateBranch(new(030, "General encyclopedic works"))
                    .CreateBranch(new(032, "General encyclopedic works in English"))                   
                    .CloseBranch()
                .CloseBranch();

            Tree<Employee> philosophy = new Tree<Employee>(new Node<Employee>(new(100, "Philosophy"), null))
                .CreateBranch(new(150, "Psychology"))
                    .CreateBranch(new(032, "Comparative psychology"))
                    .CloseBranch()
                .CloseBranch();

            Tree<Employee> philosophy1 = new Tree<Employee>(new Node<Employee>(new(100, "Philosophy"), null))
               .CreateBranch(new(130, "Parapsychology and occulitism"))
                   .CreateBranch(new(135, "Dreams and mystery"))
                   .CloseBranch()
               .CloseBranch();

            Tree<Employee> religion = new Tree<Employee>(new Node<Employee>(new(200, "Religion"), null))
               .CreateBranch(new(220, "Bible"))
                   .CreateBranch(new(221, "Old Testament"))
                   .CloseBranch()
               .CloseBranch();

            Tree<Employee> religion1 = new Tree<Employee>(new Node<Employee>(new(200, "Religion"), null))
               .CreateBranch(new(230, "Christianity"))
                   .CreateBranch(new(231, "God"))
                   .CloseBranch()
               .CloseBranch();

            Tree<Employee> socialSciences = new Tree<Employee>(new Node<Employee>(new(300, "Social Sciences"), null))
               .CreateBranch(new(340, "Law"))
                   .CreateBranch(new(347, "Procedure and courts"))
                   .CloseBranch()
               .CloseBranch();

            Tree<Employee> socialSciences2 = new Tree<Employee>(new Node<Employee>(new(300, "Social Sciences"), null))
               .CreateBranch(new(370, "Education"))
                   .CreateBranch(new(372, "Primary education"))
                   .CloseBranch()
               .CloseBranch();

            Tree<Employee> language = new Tree<Employee>(new Node<Employee>(new(400, "Language"), null))
               .CreateBranch(new(410, "Linguistics"))
                   .CreateBranch(new(418, "Standard usage"))
                   .CloseBranch()
               .CloseBranch();

            Tree<Employee> language2 = new Tree<Employee>(new Node<Employee>(new(400, "Language"), null))
               .CreateBranch(new(490, "Other languages"))
                   .CreateBranch(new(492, "Afro-Asiatic languages"))
                   .CloseBranch()
               .CloseBranch();

            Tree<Employee> mathsPhysics = new Tree<Employee>(new Node<Employee>(new(500, "Science and Mathematics"), null))
               .CreateBranch(new(510, "Mathematics"))
                   .CreateBranch(new(512, "Algebra"))
                   .CloseBranch()
               .CloseBranch();

            Tree<Employee> mathsPhysics2 = new Tree<Employee>(new Node<Employee>(new(500, "Science and Mathematics"), null))
               .CreateBranch(new(580, "Plants"))
                   .CreateBranch(new(586, "Seedless plants"))
                   .CloseBranch()
               .CloseBranch();

            Tree<Employee> technology = new Tree<Employee>(new Node<Employee>(new(600, "Technology"), null))
               .CreateBranch(new(610, "Medicine and health"))
                   .CreateBranch(new(613, "Personal health and safety"))
                   .CloseBranch()
               .CloseBranch();
            
            Tree<Employee> technology2 = new Tree<Employee>(new Node<Employee>(new(600, "Technology"), null))
               .CreateBranch(new(640, "Home and family management"))
                   .CreateBranch(new(641, "Food and drink"))
                   .CloseBranch()
               .CloseBranch();

            Tree<Employee> technology3 = new Tree<Employee>(new Node<Employee>(new(600, "Technology"), null))
               .CreateBranch(new(670, "Manufacturing"))
                   .CreateBranch(new(675, "Leather and fur processing"))
                   .CloseBranch()
               .CloseBranch();

            Tree<Employee> literature = new Tree<Employee>(new Node<Employee>(new(800, "Literature"), null))
               .CreateBranch(new(870, "Latin"))
                   .CreateBranch(new(871, "Latin poetry"))
                   .CloseBranch()
               .CloseBranch();

            Tree<Employee> literature2 = new Tree<Employee>(new Node<Employee>(new(800, "Literature"), null))
               .CreateBranch(new(820, "English"))
                   .CreateBranch(new(822, "English drama"))
                   .CloseBranch()
               .CloseBranch();

            Tree<Employee> historyGeo = new Tree<Employee>(new Node<Employee>(new(900, "History and Geography"), null))
              .CreateBranch(new(950, "History of Asia"))
                  .CreateBranch(new(952, "Japan"))
                  .CloseBranch()
              .CloseBranch();

            Tree<Employee> historyGeo2 = new Tree<Employee>(new Node<Employee>(new(900, "History and Geography"), null))
              .CreateBranch(new(960, "History of Africa"))
                  .CreateBranch(new(965, "Algeria"))
                  .CloseBranch()
              .CloseBranch();

            Tree<Employee> historyGeo3 = new Tree<Employee>(new Node<Employee>(new(900, "History and Geography"), null))
              .CreateBranch(new(970, "History of North America"))
                  .CreateBranch(new(971, "Canada"))
                  .CloseBranch()
              .CloseBranch();

            //foreach to display the parent values in the tree 
            foreach (Node<Employee> em in Arts.Nodes)
            {
                Display(Arts.Root, 0);
            }
           
            Random rnd = new Random(); //000 - 999
            int randomArts = rnd.Next(100, 1125);

            while (randomArts % 100 == 0 || randomArts % 10 == 0)
            {
                randomArts = rnd.Next(100, 1125);
            }
            randomArts =752;

            foreach (Node<Employee> em in Arts2.Nodes)
            {
                Display(Arts2.Root, 0);
            }

            int randomArts2 = rnd.Next(100, 1125);

            while (randomArts2 % 100 == 0 || randomArts2 % 10 == 0)
            {
                randomArts2 = rnd.Next(100, 1125);
            }
            randomArts2 = 757;

            foreach (Node<Employee> em in computerScience.Nodes)
            {
                Display(computerScience.Root, 0);
            }
           
            int randomComputer = rnd.Next(100, 1125);

            while (randomComputer % 100 == 0 || randomComputer % 10 == 0)
            {
                randomComputer = rnd.Next(100, 1125);
            }
            randomComputer = 012;

            foreach (Node<Employee> em in computerScience2.Nodes)
            {
                Display(computerScience2.Root, 0);
            }

            int randomComputer2 = rnd.Next(100, 1125);

            while (randomComputer2 % 100 == 0 || randomComputer2 % 10 == 0)
            {
                randomComputer2 = rnd.Next(100, 1125);
            }
            randomComputer2 = 032;

            foreach (Node<Employee> em in philosophy.Nodes)
            {
                Display(philosophy.Root, 0);
            }

            int randomPhilosophy = rnd.Next(100, 1125);

            while (randomPhilosophy % 100 == 0 || randomPhilosophy % 10 == 0)
            {
                randomPhilosophy = rnd.Next(100, 1125);
            }
            randomPhilosophy = 032;
            
            foreach (Node<Employee> em in philosophy1.Nodes)
            {
                Display(philosophy1.Root, 0);
            }

            int randomPhilosophy2 = rnd.Next(100, 1125);

            while (randomPhilosophy2 % 100 == 0 || randomPhilosophy2 % 10 == 0)
            {
                randomPhilosophy2 = rnd.Next(100, 1125);
            }
            randomPhilosophy2 = 135;

            foreach (Node<Employee> em in religion.Nodes)
            {
                Display(religion.Root, 0);
            }

            int randomReligion = rnd.Next(100, 1125);

            while (randomReligion % 100 == 0 || randomReligion % 10 == 0)
            {
                randomReligion = rnd.Next(100, 1125);
            }
            randomReligion = 221;

            foreach (Node<Employee> em in religion1.Nodes)
            {
                Display(religion1.Root, 0);
            }

            int randomReligion1 = rnd.Next(100, 1125);

            while (randomReligion1 % 100 == 0 || randomReligion1 % 10 == 0)
            {
                randomReligion1 = rnd.Next(100, 1125);
            }
            randomReligion1 = 231;

            foreach (Node<Employee> em in socialSciences.Nodes)
            {
                Display(socialSciences.Root, 0);
            }

            int randomSocialSciences = rnd.Next(100, 1125);

            while (randomSocialSciences % 100 == 0 || randomSocialSciences % 10 == 0)
            {
                randomSocialSciences = rnd.Next(100, 1125);
            }
            randomSocialSciences = 347;

            foreach (Node<Employee> em in socialSciences2.Nodes)
            {
                Display(socialSciences2.Root, 0);
            }

            int randomSocialSciences2 = rnd.Next(100, 1125);

            while (randomSocialSciences2 % 100 == 0 || randomSocialSciences2 % 10 == 0)
            {
                randomSocialSciences2 = rnd.Next(100, 1125);
            }
            randomSocialSciences2 = 372;

            foreach (Node<Employee> em in language.Nodes)
            {
                Display(language.Root, 0);
            }

            int randomLanguage = rnd.Next(100, 1125);

            while (randomLanguage % 100 == 0 || randomLanguage % 10 == 0)
            {
                randomLanguage = rnd.Next(100, 1125);
            }
            randomLanguage = 418;

            foreach (Node<Employee> em in language2.Nodes)
            {
                Display(language2.Root, 0);
            }

            int randomLanguage2 = rnd.Next(100, 1125);

            while (randomLanguage2 % 100 == 0 || randomLanguage2 % 10 == 0)
            {
                randomLanguage2 = rnd.Next(100, 1125);
            }
            randomLanguage2 = 492;

            foreach (Node<Employee> em in mathsPhysics.Nodes)
            {
                Display(mathsPhysics.Root, 0);
            }

            int randomPhysics = rnd.Next(100, 1125);

            while (randomPhysics % 100 == 0 || randomPhysics % 10 == 0)
            {
                randomPhysics = rnd.Next(100, 1125);
            }
            randomPhysics = 512;

            foreach (Node<Employee> em in mathsPhysics2.Nodes)
            {
                Display(mathsPhysics2.Root, 0);
            }

            int randomPhysics2 = rnd.Next(100, 1125);

            while (randomPhysics2 % 100 == 0 || randomPhysics2 % 10 == 0)
            {
                randomPhysics2 = rnd.Next(100, 1125);
            }
            randomPhysics2 = 586;

            foreach (Node<Employee> em in technology.Nodes)
            {
                Display(technology.Root, 0);
            }

            int randomTech = rnd.Next(100, 1125);

            while (randomTech % 100 == 0 || randomTech % 10 == 0)
            {
                randomTech = rnd.Next(100, 1125);
            }
            randomTech = 613;

            foreach (Node<Employee> em in technology2.Nodes)
            {
                Display(technology2.Root, 0);
            }

            int randomTech2 = rnd.Next(100, 1125);

            while (randomTech2 % 100 == 0 || randomTech2 % 10 == 0)
            {
                randomTech2 = rnd.Next(100, 1125);
            }
            randomTech2 = 641;

            foreach (Node<Employee> em in technology3.Nodes)
            {
                Display(technology3.Root, 0);
            }

            int randomTech3 = rnd.Next(100, 1125);

            while (randomTech3 % 100 == 0 || randomTech3 % 10 == 0)
            {
                randomTech3 = rnd.Next(100, 1125);
            }
            randomTech3 = 675;

            foreach (Node<Employee> em in literature.Nodes)
            {
                Display(literature.Root, 0);
            }

            int randomLit = rnd.Next(100, 1125);

            while (randomLit % 100 == 0 || randomLit % 10 == 0)
            {
                randomLit = rnd.Next(100, 1125);
            }
            randomLit = 871;

            foreach (Node<Employee> em in literature2.Nodes)
            {
                Display(literature2.Root, 0);
            }

            int randomLit2 = rnd.Next(100, 1125);

            while (randomLit2 % 100 == 0 || randomLit2 % 10 == 0)
            {
                randomLit2 = rnd.Next(100, 1125);
            }
            randomLit2 = 822;

            foreach (Node<Employee> em in historyGeo.Nodes)
            {
                Display(historyGeo.Root, 0);
            }

            int randomHistory = rnd.Next(100, 1125);

            while (randomHistory % 100 == 0 || randomHistory % 10 == 0)
            {
                randomHistory = rnd.Next(100, 1125);
            }
            randomHistory = 952;

            foreach (Node<Employee> em in historyGeo2.Nodes)
            {
                Display(historyGeo2.Root, 0);
            }

            int randomHistory2 = rnd.Next(100, 1125);

            while (randomHistory2 % 100 == 0 || randomHistory2 % 10 == 0)
            {
                randomHistory2 = rnd.Next(100, 1125);
            }
            randomHistory2 = 965;

            foreach (Node<Employee> em in historyGeo3.Nodes)
            {
                Display(historyGeo3.Root, 0);
            }

            int randomHistory3 = rnd.Next(100, 1125);

            while (randomHistory3 % 100 == 0 || randomHistory3 % 10 == 0)
            {
                randomHistory3 = rnd.Next(100, 1125);
            }
            randomHistory3 = 971;

            // Function to create the search feature to display the parents of the children in the tree

            Node<Employee> search = Arts.Find(Arts.Root, x => x.Data.EmpNo == randomArts);
            Node<Employee> ComputerSearch = computerScience.Find(computerScience.Root, x => x.Data.EmpNo == randomComputer);
            Node<Employee> ComputerSearch2 = computerScience2.Find(computerScience2.Root, x => x.Data.EmpNo == randomComputer2);
            Node<Employee> ArtSearch = Arts2.Find(Arts2.Root, x => x.Data.EmpNo == randomArts2);
            Node<Employee> PhilosophySearch = philosophy.Find(philosophy.Root, x => x.Data.EmpNo == randomPhilosophy);
            Node<Employee> PhilosophySearch2 = philosophy1.Find(philosophy1.Root, x => x.Data.EmpNo == randomPhilosophy2);
            Node<Employee> ReligionSearch = religion.Find(religion.Root, x => x.Data.EmpNo == randomReligion);
            Node<Employee> ReligionSearch2 = religion1.Find(religion1.Root, x => x.Data.EmpNo == randomReligion1);
            Node<Employee> SocialSearch = socialSciences.Find(socialSciences.Root, x => x.Data.EmpNo == randomSocialSciences);
            Node<Employee> SocialSearch2 = socialSciences2.Find(socialSciences2.Root, x => x.Data.EmpNo == randomSocialSciences2);
            Node<Employee> LangSearch = language.Find(language.Root, x => x.Data.EmpNo == randomLanguage);
            Node<Employee> LangSearch2 = language2.Find(language2.Root, x => x.Data.EmpNo == randomLanguage2);
            Node<Employee> PhysicsSearch = mathsPhysics.Find(mathsPhysics.Root, x => x.Data.EmpNo == randomPhysics);
            Node<Employee> PhysicsSearch2 = mathsPhysics2.Find(mathsPhysics2.Root, x => x.Data.EmpNo == randomPhysics2);
            Node<Employee> TechSearch = technology.Find(technology.Root, x => x.Data.EmpNo == randomTech);
            Node<Employee> TechSearch2 = technology2.Find(technology2.Root, x => x.Data.EmpNo == randomTech2);
            Node<Employee> TechSearch3 = technology3.Find(technology3.Root, x => x.Data.EmpNo == randomTech3);
            Node<Employee> LitSearch = literature.Find(literature.Root, x => x.Data.EmpNo == randomLit);
            Node<Employee> LitSearch2 = literature2.Find(literature2.Root, x => x.Data.EmpNo == randomLit2);
            Node<Employee> HistorySearch = historyGeo.Find(historyGeo.Root, x => x.Data.EmpNo == randomHistory);
            Node<Employee> HistorySearch2 = historyGeo2.Find(historyGeo2.Root, x => x.Data.EmpNo == randomHistory2);
            Node<Employee> HistorySearch3 = historyGeo3.Find(historyGeo3.Root, x => x.Data.EmpNo == randomHistory3);


            // if statements to display the parents (top-level and second-level of the selected child from the tree
            if (textBox1.Text == search.Data.Name)
            {
                MessageBox.Show($" Second level for {search.Data.Name} is {search.Parent.Data.Name}. " + $" Top level for {search.Data.Name} is {search.Parent.Parent.Data.Name}. ");
               
            }
            else if (textBox1.Text == ComputerSearch.Data.Name)
            {
                MessageBox.Show($" Second level for {ComputerSearch.Data.Name} is {ComputerSearch.Parent.Data.Name}. " + $" Top level for {ComputerSearch.Data.Name} is {ComputerSearch.Parent.Parent.Data.Name}. ");
            }
            else if (textBox1.Text == ArtSearch.Data.Name)
            {
                MessageBox.Show($" Second level for {ArtSearch.Data.Name} is {ArtSearch.Parent.Data.Name}. " + $" Top level for {ArtSearch.Data.Name} is {ArtSearch.Parent.Parent.Data.Name}. ");
            }
            else if (textBox1.Text == ComputerSearch2.Data.Name)
            {
                MessageBox.Show($" Second level for {ComputerSearch2.Data.Name} is {ComputerSearch2.Parent.Data.Name}. " + $" Top level for {ComputerSearch2.Data.Name} is {ComputerSearch2.Parent.Parent.Data.Name}. ");
            }
            else if (textBox1.Text == PhilosophySearch.Data.Name)
            {
                MessageBox.Show($" Second level for {PhilosophySearch.Data.Name} is {PhilosophySearch.Parent.Data.Name}. " + $" Top level for {PhilosophySearch.Data.Name} is {PhilosophySearch.Parent.Parent.Data.Name}. ");
            }
            else if (textBox1.Text == PhilosophySearch2.Data.Name)
            {
                MessageBox.Show($" Second level for {PhilosophySearch2.Data.Name} is {PhilosophySearch2.Parent.Data.Name}. " + $" Top level for {PhilosophySearch2.Data.Name} is {PhilosophySearch2.Parent.Parent.Data.Name}. ");
            }
            else if (textBox1.Text == ReligionSearch.Data.Name)
            {
                MessageBox.Show($" Second level for {ReligionSearch.Data.Name} is {ReligionSearch.Parent.Data.Name}. " + $" Top level for {ReligionSearch.Data.Name} is {ReligionSearch.Parent.Parent.Data.Name}. ");
            }
            else if (textBox1.Text == ReligionSearch2.Data.Name)
            {
                MessageBox.Show($" Second level for {ReligionSearch2.Data.Name} is {ReligionSearch2.Parent.Data.Name}. " + $" Top level for {ReligionSearch2.Data.Name} is {ReligionSearch2.Parent.Parent.Data.Name}. ");
            }
            else if (textBox1.Text == SocialSearch.Data.Name)
            {
                MessageBox.Show($" Second level for {SocialSearch.Data.Name} is {SocialSearch.Parent.Data.Name}. " + $" Top level for {SocialSearch.Data.Name} is {SocialSearch.Parent.Parent.Data.Name}. ");
            }
            else if (textBox1.Text == SocialSearch2.Data.Name)
            {
                MessageBox.Show($" Second level for {SocialSearch2.Data.Name} is {SocialSearch2.Parent.Data.Name}. " + $" Top level for {SocialSearch2.Data.Name} is {SocialSearch2.Parent.Parent.Data.Name}. ");
            }
            else if (textBox1.Text == LangSearch.Data.Name)
            {
                MessageBox.Show($" Second level for {LangSearch.Data.Name} is {LangSearch.Parent.Data.Name}. " + $" Top level for {LangSearch.Data.Name} is {LangSearch.Parent.Parent.Data.Name}. ");
            }
            else if (textBox1.Text == LangSearch2.Data.Name)
            {
                MessageBox.Show($" Second level for {LangSearch2.Data.Name} is {LangSearch2.Parent.Data.Name}. " + $" Top level for {LangSearch2.Data.Name} is {LangSearch2.Parent.Parent.Data.Name}. ");
            }
            else if (textBox1.Text == PhysicsSearch.Data.Name)
            {
                MessageBox.Show($" Second level for {PhysicsSearch.Data.Name} is {PhysicsSearch.Parent.Data.Name}. " + $" Top level for {PhysicsSearch.Data.Name} is {PhysicsSearch.Parent.Parent.Data.Name}. ");
            }
            else if (textBox1.Text == PhysicsSearch2.Data.Name)
            {
                MessageBox.Show($" Second level for {PhysicsSearch2.Data.Name} is {PhysicsSearch2.Parent.Data.Name}. " + $" Top level for {PhysicsSearch2.Data.Name} is {PhysicsSearch2.Parent.Parent.Data.Name}. ");
            }
            else if (textBox1.Text == TechSearch.Data.Name)
            {
                MessageBox.Show($" Second level for {TechSearch.Data.Name} is {TechSearch.Parent.Data.Name}. " + $" Top level for {TechSearch.Data.Name} is {TechSearch.Parent.Parent.Data.Name}. ");
            }
            else if (textBox1.Text == TechSearch2.Data.Name)
            {
                MessageBox.Show($" Second level for {TechSearch2.Data.Name} is {TechSearch2.Parent.Data.Name}. " + $" Top level for {TechSearch2.Data.Name} is {TechSearch2.Parent.Parent.Data.Name}. ");
            }
            else if (textBox1.Text == TechSearch3.Data.Name)
            {
                MessageBox.Show($" Second level for {TechSearch3.Data.Name} is {TechSearch3.Parent.Data.Name}. " + $" Top level for {TechSearch3.Data.Name} is {TechSearch3.Parent.Parent.Data.Name}. ");
            }
            else if (textBox1.Text == LitSearch.Data.Name)
            {
                MessageBox.Show($" Second level for {LitSearch.Data.Name} is {LitSearch.Parent.Data.Name}. " + $" Top level for {LitSearch.Data.Name} is {LitSearch.Parent.Parent.Data.Name}. ");
            }
            else if (textBox1.Text == LitSearch2.Data.Name)
            {
                MessageBox.Show($" Second level for {LitSearch2.Data.Name} is {LitSearch2.Parent.Data.Name}. " + $" Top level for {LitSearch2.Data.Name} is {LitSearch2.Parent.Parent.Data.Name}. ");
            }
            else if (textBox1.Text == HistorySearch.Data.Name)
            {
                MessageBox.Show($" Second level for {HistorySearch.Data.Name} is {HistorySearch.Parent.Data.Name}. " + $" Top level for {HistorySearch.Data.Name} is {HistorySearch.Parent.Parent.Data.Name}. ");
            }
            else if (textBox1.Text == HistorySearch2.Data.Name)
            {
                MessageBox.Show($" Second level for {HistorySearch2.Data.Name} is {HistorySearch2.Parent.Data.Name}. " + $" Top level for {HistorySearch2.Data.Name} is {HistorySearch2.Parent.Parent.Data.Name}. ");
            }
            else if (textBox1.Text == HistorySearch3.Data.Name)
            {
                MessageBox.Show($" Second level for {HistorySearch3.Data.Name} is {HistorySearch3.Parent.Data.Name}. " + $" Top level for {HistorySearch3.Data.Name} is {HistorySearch3.Parent.Parent.Data.Name}. ");
            }
        }

        static void Display(Node<Employee> node, int level)
        {
           // Display function for parents in tree
           
            level++;
            foreach (Node<Employee> n in node.Children)
            {
                Display(n, level);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // New random created as well as arrays with values that need to be randomly generated into the Second-Level options
            Random rd = new Random();
            string[] callNumbers = { "010 Bibliography", "750 Painting and Paintings", "030 General Encyclopedic Works", "150 Psychology",
            "130 Parapsychology and occulitism", "220 Bible", "230 Christianity", "340 Law", "370 Education", "410 Linguistics", "490 Other languages"
            , "510 Mathematics", "580 Plants", "Medicine and health", "640 Home and family management", "870 Latin", "820 English", "950 History of Asia"
            , "960 History of Africa", "970 History of North America", "670 Manufacturing"};
            int index = rd.Next(callNumbers.Length);
           
            
            string[] callNumbers2 = { "010 Bibliography", "750 Painting and Paintings", "030 General Encyclopedic Works", "150 Psychology",
                "130 Parapsychology and occulitism", "220 Bible", "230 Christianity", "340 Law", "370 Education", "410 Linguistics", "492 Afro-Asiatic languages"
            , "512 Algebra", "580 Plants", "Medicine and health", "640 Home and family management", "870 Latin", "820 English", "950 History of Asia"
            , "960 History of Africa", "970 History of North America", "670 Manufacturing"};
            int index2 = rd.Next(callNumbers2.Length);

            string[] callNumbers3 = { "010 Bibliography", "750 Painting and Paintings", "030 General Encyclopedic Works", "150 Psychology",
             "130 Parapsychology and occulitism", "220 Bible", "230 Christianity", "340 Law", "370 Education", "410 Linguistics", "492 Afro-Asiatic languages"
            , "512 Algebra", "580 Plants", "Medicine and health", "640 Home and family management", "870 Latin", "820 English", "950 History of Asia"
            , "960 History of Africa", "970 History of North America", "670 Manufacturing"};
            int index3 = rd.Next(callNumbers3.Length);

            // If statement that displays the corresponding dictionary value if textBox11 contains its Key Value
            if (SecondQuestion.ContainsKey(userFirstAnswer.Text))
            {
                textBox11.Text = SecondQuestion[userFirstAnswer.Text];
                textBox12.Text = callNumbers[index];
                textBox10.Text = callNumbers2[index2];
                textBox4.Text = callNumbers3[index3];
                // Score count increasing if answer is correct
                score++;
                label9.Text = "Score: " + score;
            }
            // statement displayed if the user gets the answer wrong
            else
            {
                MessageBox.Show("Incorrect answer! Please start test again.");
                score++;
                label9.Text = "Score: " + (score-1);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // function to go to the home page
            Form1 home = new Form1();
            home.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // if statement for when the user enters the final answer. System checks if the Key Value is correct and displays the answer in textBox3 and a custom message.
            if (Answer.ContainsKey(textBox5.Text))
            {
                textBox3.Text = Answer[textBox5.Text];
                MessageBox.Show("Congratulations! " + Answer[textBox5.Text]+ " is correct! Test completed.");
                // score count increase
                score++;
                label9.Text = "Score: " + score;
            }
            // statment if the user gets the answer wrong
            else
            {
                MessageBox.Show("Incorrect answer! Please start test again.");
                score++;
                label9.Text = "Score: " + (score - 1);
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Instructions on how to use the feature
            MessageBox.Show("Click on Load Question to load a third-level option as well as four possible top-level options. These will be displayed in the boxes below");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Instructions on how to use the feature
            MessageBox.Show("Choose the top-level option you think is correct. In the box below First Answer; first type in the first level option (case sensitive) followed by the answer's CALL NUMBER ONLY, then click submit. Sample: Old Testament 200");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Instructions on how to use the feature
            MessageBox.Show("Choose the second-level option you think is correct. In the box below Second Answer; first type in the top-level answer (case sensitive) followed by the answer's CALL NUMBER ONLY, then click submit. Sample: Philosophy 150 ");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Instructions on how to use the feature
            MessageBox.Show("In this section you can view the second-level and top-level of a specified third-level option. Simply type in the third-level name and click View Levels.");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
