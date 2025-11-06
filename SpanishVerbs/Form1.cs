using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpanishVerbs
{
    public partial class SpanishVerbs : Form
    {

        public static int questAmt = 0;
        public static ArrayList array = new ArrayList();

        public static int intChoice = 0;


        public SpanishVerbs()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_LostFocus(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            int.TryParse(s, out int value);
            if (value <= 0)
            {
                textBox1.Text = "0";
                value = 0;
            }
            if (value > 464)
            {
                textBox1.Text = "464";
                value = 464;
            }

            questAmt = value;


        }

        private void SpanishVerbs_Load(object sender, EventArgs e)
        {
            StreamReader input = new StreamReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "verbs.csv"));
            
            while (input.Peek() != -1)
            {
                string line = input.ReadLine();
                string[] parts = line.Split(',');


                if (parts[0].Contains('#'))
                {
                    string[] strArray = parts[0].Split('#');
                    int.TryParse(strArray[1], out int value);
                    char chr = (char)value;
                    string str = strArray[0] + chr.ToString() + strArray[2];

                    parts[0] = str;
                }
                array.Add(parts);
                
            }

            Console.WriteLine(((string[])array[378])[0]);

            
        }

        private void radEng_CheckedChanged(object sender, EventArgs e)
        {
            if (radEng.Checked)
            {
                intChoice = 0;
            }
            if (radSpan.Checked)
            {
                intChoice = 1;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (questAmt == 0)
            {
                MessageBox.Show("Please enter a valid number of questions.");
            }
            else
            {
                Quiz frmQuiz = new Quiz();
                frmQuiz.ShowDialog();
            }
        }

        private void SpanishVerbs_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
