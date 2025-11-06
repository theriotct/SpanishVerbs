using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SpanishVerbs
{
    public partial class Quiz : Form
    {
        ArrayList array;
        int intAnswer = 0;
        int correctAns = 0;
        int totalQues = 1;
        Stack stackQuest = new Stack();

        Button btnSubmit = new Button();
        Label lblQues = new Label();
        RadioButton radD = new RadioButton(); 
        RadioButton radC = new RadioButton(); 
        RadioButton radB = new RadioButton(); 
        RadioButton radA = new RadioButton();



        public Quiz()
        {
            InitializeComponent();
        }



        private void radChanged(object sender, EventArgs e)
        {
            RadioButton rad = sender as RadioButton;
            if (rad.Name.Equals("radA"))
            {
                intAnswer = 0;
            }
            if (rad.Name.Equals("radB"))
            {
                intAnswer = 1;
            }
            if (rad.Name.Equals("radC"))
            {
                intAnswer = 2;
            }
            if (rad.Name.Equals("radD"))
            {
                intAnswer = 3;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            /*
            // 
            // lblQues
            // 
            this.lblQues.Location = new System.Drawing.Point(12, 41);
            this.lblQues.Name = "lblQues";
            this.lblQues.Size = new System.Drawing.Size(260, 23);
            this.lblQues.TabIndex = 0;
            this.lblQues.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radA
            // 
            this.radA.AutoSize = true;
            this.radA.Location = new System.Drawing.Point(96, 93);
            this.radA.Name = "radA";
            this.radA.Size = new System.Drawing.Size(38, 17);
            this.radA.TabIndex = 1;
            this.radA.TabStop = true;
            this.radA.Text = "A) ";
            this.radA.UseVisualStyleBackColor = true;
            // 
            // radB
            // 
            this.radB.AutoSize = true;
            this.radB.Location = new System.Drawing.Point(96, 116);
            this.radB.Name = "radB";
            this.radB.Size = new System.Drawing.Size(38, 17);
            this.radB.TabIndex = 2;
            this.radB.TabStop = true;
            this.radB.Text = "B) ";
            this.radB.UseVisualStyleBackColor = true;
            // 
            // radC
            // 
            this.radC.AutoSize = true;
            this.radC.Location = new System.Drawing.Point(96, 139);
            this.radC.Name = "radC";
            this.radC.Size = new System.Drawing.Size(35, 17);
            this.radC.TabIndex = 3;
            this.radC.TabStop = true;
            this.radC.Text = "C)";
            this.radC.UseVisualStyleBackColor = true;
            // 
            // radD
            // 
            this.radD.AutoSize = true;
            this.radD.Location = new System.Drawing.Point(96, 162);
            this.radD.Name = "radD";
            this.radD.Size = new System.Drawing.Size(36, 17);
            this.radD.TabIndex = 4;
            this.radD.TabStop = true;
            this.radD.Text = "D)";
            this.radD.UseVisualStyleBackColor = true;
            this.radD.CheckedChanged += new System.EventHandler(this.radChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;*/

            btnStart.Hide();

            array = (ArrayList)SpanishVerbs.array.Clone();

            Random random = new Random();
            for (int i = 0; i < SpanishVerbs.questAmt; i++)
            {
                int index = random.Next(0, array.Count);


                /*if (SpanishVerbs.intChoice != 0)
                {
                    string[] stringAry = (string[])array[index];
                    string temp = stringAry[0];
                    stringAry[0] = stringAry[1];
                    stringAry[1] = temp;
                    stackQuest.Push(stringAry);
                }
                else
                {
                    string[] stringAry = (string[])array[index];
                    stackQuest.Push(stringAry);
                }*/

                string[] stringAry = (string[])array[index];
                stackQuest.Push(stringAry);
                array.RemoveAt(index);
            }


            radA.AutoSize = true;
            radA.CheckedChanged += new System.EventHandler(this.radChanged);
            radA.Location = new System.Drawing.Point(96, 95);
            radA.Name = "radA";
            radA.Size = new System.Drawing.Size(38, 17);
            radA.TabIndex = 1;
            radA.TabStop = true;
            radA.Text = "A)   ";
            radA.UseVisualStyleBackColor = true;


            radB.AutoSize = true;
            radB.CheckedChanged += new System.EventHandler(this.radChanged);
            radB.Location = new System.Drawing.Point(96, 121);
            radB.Name = "radB";
            radB.Size = new System.Drawing.Size(38, 17);
            radB.TabIndex = 2;
            radB.TabStop = true;
            radB.Text = "B)   ";
            radB.UseVisualStyleBackColor = true;


            radC.AutoSize = true;
            radC.CheckedChanged += new System.EventHandler(this.radChanged);
            radC.Location = new System.Drawing.Point(96, 149);
            radC.Name = "radC";
            radC.Size = new System.Drawing.Size(35, 17);
            radC.TabIndex = 3;
            radC.TabStop = true;
            radC.Text = "C)   ";
            radC.UseVisualStyleBackColor = true;


            radD.AutoSize = true;
            radD.Location = new System.Drawing.Point(96, 177);
            radD.Name = "radD";
            radD.Size = new System.Drawing.Size(36, 17);
            radD.TabIndex = 4;
            radD.TabStop = true;
            radD.Text = "D)   ";
            radD.UseVisualStyleBackColor = true;
            radD.CheckedChanged += new System.EventHandler(this.radChanged);

            lblQues.Font = new Font(lblQues.Font.FontFamily, 12);
            lblQues.Text = "Question " + totalQues + "\n";
            lblQues.Location = new System.Drawing.Point(12, 41);
            lblQues.Name = "lblQues";
            lblQues.Size = new System.Drawing.Size(260, 50);
            lblQues.TabIndex = 0;
            lblQues.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;


            btnSubmit.Location = new System.Drawing.Point(96, 204);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new System.Drawing.Size(75, 23);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;

            questionSetupSpanToEng();

        }

        private void questionSetupSpanToEng()
        {
            this.Controls.Clear();
            if (stackQuest.Count == 0)
            {
                MessageBox.Show("Ran out of questions!");
                this.Hide();

            }
            else
            {
                int spot = 1;
                if (SpanishVerbs.intChoice != 0)
                {
                    spot = 0;
                }

                string[] currentQuestion = (string[])stackQuest.Pop();




                if (SpanishVerbs.intChoice != 0)
                {
                    lblQues.Text = "Question " + totalQues + "\n" + currentQuestion[1];
                }
                else
                {
                    lblQues.Text = "Question " + totalQues + "\n" + currentQuestion[0];
                }

                    this.Controls.Add(lblQues);
                totalQues += 1;


                
                Random random = new Random();
                int correctAns = random.Next(0, 4);

                



                if (correctAns == 0)
                {
                    radA.Text = "A) " + currentQuestion[spot];
                }
                else
                {
                    string[] rndAns = (string[])SpanishVerbs.array[random.Next(0, SpanishVerbs.array.Count)];
                    radA.Text = "A) " + rndAns[spot];
                }

                this.Controls.Add(radA);

                if (correctAns == 1)
                {
                    radB.Text = "B) " + currentQuestion[spot];
                }
                else
                {
                    string[] rndAns = (string[])SpanishVerbs.array[random.Next(0, SpanishVerbs.array.Count)];
                    radB.Text = "B) " + rndAns[spot];
                }

                this.Controls.Add(radB);

                if (correctAns == 2)
                {
                    radC.Text = "C) " + currentQuestion[spot];
                }
                else
                {
                    string[] rndAns = (string[])SpanishVerbs.array[random.Next(0, SpanishVerbs.array.Count)];
                    radC.Text = "C) " + rndAns[spot];
                }

                this.Controls.Add(radC);

                if (correctAns == 3)
                {
                    radD.Text = "D) " + currentQuestion[spot];
                }
                else
                {
                    string[] rndAns = (string[])SpanishVerbs.array[random.Next(0, SpanishVerbs.array.Count)];
                    radD.Text = "D) " + rndAns[spot];
                }

                this.Controls.Add(radD);

                btnSubmit.Tag = correctAns;
                btnSubmit.Click += showCorrectAns;
                this.Controls.Add(btnSubmit);
            }
        }

        private void showCorrectAns(object sender, EventArgs e)
        {
            int correctAns = (int)(sender as Button).Tag;
            switch (correctAns)
            {
                case 0:
                    radA.Font = new Font(radA.Font, FontStyle.Bold);
                    break;
                case 1:
                    radB.Font = new Font(radA.Font, FontStyle.Bold);
                    break;
                case 2:
                    radC.Font = new Font(radA.Font, FontStyle.Bold);
                    break;
                case 3:
                    radD.Font = new Font(radA.Font, FontStyle.Bold);
                    break;
            }
            btnSubmit.Text = "Next";
            btnSubmit.Click -= showCorrectAns;
            btnSubmit.Click += nextQuestion;
            
        }

        

        private void nextQuestion(object sender, EventArgs e)
        {
            


            btnSubmit.Text = "Submit";
            btnSubmit.Click -= nextQuestion;
            radA.Font = new Font(radA.Font, FontStyle.Regular);
            radB.Font = new Font(radB.Font, FontStyle.Regular);
            radC.Font = new Font(radC.Font, FontStyle.Regular);
            radD.Font = new Font(radD.Font, FontStyle.Regular);
            radA.Checked = false;
            radB.Checked = false;
            radC.Checked = false;
            radD.Checked = false;
            
                questionSetupSpanToEng();

        }
    }
}
