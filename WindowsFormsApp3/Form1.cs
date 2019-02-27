using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        
        public static double gradeToGradebook = 0;
        
        double[] grades = new double[100];
        int gradeCounter = 0;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            double test = 0;

            if (double.TryParse(textBox1.Text, out test))
            {

            if(textBox1.Text != "") {
                double newGrade = Convert.ToDouble(textBox1.Text);
                if (newGrade > 0 && newGrade < 6.1)
                {
                    richTextBox1.Text = "Your current grades are:";
                    grades[gradeCounter] = newGrade;
                    gradeCounter += 1;
                    for (int x = 0; x < 100; x++)
                    {
                        if (grades[x] == 0) { break; }
                        else
                        {
                            richTextBox1.AppendText(Environment.NewLine + grades[x]);
                        }
                    }
                }

                else
                {
                    textBox1.Text = "Enter Valid Grade Here";
                }


            }

                else
                {
                    textBox1.Text = "Enter Valid Grade Here";
                }










            }


            else
            {
                textBox1.Text = "Enter Grade Here";
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double adder = 0;
            for (int x = 0; x < 100; x++)
            {
                if (grades[x] == 0) { break; }
                else
                {
                    adder = adder + grades[x];
                }
            }
            double average = adder / gradeCounter;

            if (average >= 4)
            {
                richTextBox2.ForeColor = Color.Green;
            }
            else { richTextBox2.ForeColor = Color.Red;
            };
            richTextBox2.Text = "The Average Grade Is:" + Environment.NewLine + Environment.NewLine + average;



        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


            double test = 0;

            if (double.TryParse(richTextBox5.Text, out test) && double.TryParse(richTextBox3.Text, out test))
            {
                if (richTextBox5.Text == "" || richTextBox3.Text == "")
                {
                if (richTextBox5.Text == "") { richTextBox5.Text = "Enter Maximum Score Here"; }
                else { richTextBox3.Text = "Enter Score Here"; }

                if (richTextBox3.Text == "") { richTextBox3.Text = "Enter Score Here"; }
                else { richTextBox5.Text = "Enter Maximum Score Here"; }
                }
                else
                {
                double score = Convert.ToDouble(richTextBox3.Text);
                double max = Convert.ToDouble(richTextBox5.Text);


                double grade = score / max * 5 + 1;

                if(grade >= 4) { richTextBox4.ForeColor = Color.Green; }
                else { richTextBox4.ForeColor = Color.Red;  }

                richTextBox4.Text = "The grade is:" + Environment.NewLine + Environment.NewLine + grade + Environment.NewLine + Environment.NewLine + "Rounded: " + Math.Round(grade, 2);
                gradeToGradebook = Math.Round(grade, 2);
                }

                button4.Enabled = true;
                
            }


            else if (!double.TryParse(richTextBox5.Text, out test))
            {

                richTextBox5.Text = "Enter VALID Maximum Score Here";
                if (!double.TryParse(richTextBox3.Text, out test))
                {
                    richTextBox3.Text = "Enter VALID  Score Here";

                }
                else { }

            }
            else if (!double.TryParse(richTextBox3.Text, out test))
            {
                richTextBox3.Text = "Enter VALID  Score Here";

            }





        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {



            if (gradeToGradebook > 0 && gradeToGradebook < 6.1)
            {
                richTextBox1.Text = "Your current grades are:";
                grades[gradeCounter] = gradeToGradebook;
                gradeCounter += 1;
                for (int x = 0; x < 100; x++)
                {
                    if (grades[x] == 0) { break; }
                    else
                    {
                        richTextBox1.AppendText(Environment.NewLine + grades[x]);
                    }
                }
            }

            else
            {
                richTextBox4.Text = "Calculate a Grade First";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox4.Text = "";
            richTextBox3.Text = "";
            richTextBox5.Text = "";
            button4.Enabled = false;
        }
    }
}
