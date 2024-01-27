using System;
using System.Security.Cryptography;

namespace GuessANumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int incorrectOption = new Random().Next(1, 5);
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DisableRadioButtons(object sender, EventArgs e)
        {



        }
        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNum = random.Next(1, 5);
            

            if (radioButton1.Checked && randomNum == 1 ||
                radioButton2.Checked && randomNum == 2 ||
                radioButton3.Checked && randomNum == 3 ||
                radioButton4.Checked && randomNum == 4 ||
                radioButton5.Checked && randomNum == 5)
            {
                label1.Text = "Correct!";
            }
            else
            {
                label1.Text = "Incorrect. The correct number was " + randomNum.ToString();
            }


           





            switch (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked || radioButton5.Checked)
            {

                case false:
                    label1.Text = "Select a number";
                    break;
                case true:
                    foreach (RadioButton radioButton in groupBox1.Controls.OfType<RadioButton>())
                    {
                        radioButton.Enabled = false;
                        button1.Enabled = false;


                    }
                    break;
            }



        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LabelHint(int incorrectOption)
        {
            toolTip1.SetToolTip(label2, incorrectOption.ToString() + " is an incorrect.");
            
        }
        private void label2_MouseHover(object sender, EventArgs e)
        {
            LabelHint(incorrectOption);
        }
    }
}
