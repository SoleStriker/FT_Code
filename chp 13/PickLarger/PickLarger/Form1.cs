using System.Drawing.Text;

namespace PickLarger
{
    public partial class Form1 : Form
    {
        private int[] array1;
        private int[] array2;
        private int index;
        private int correctGuesses;
        private int incorrectGuesses;

        public Form1()
        {
            InitializeComponent();
            array1 = GenerateRandomArray();
            array2 = GenerateRandomArray();
            index = 0;
            correctGuesses = 0;
            incorrectGuesses = 0;

            DisplayValues();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            


        }

        private void DisplayValues()
        {
            int value1 = array1[index];
            int value2 = array2[index];

            label1.Text = $"Array 1: {value1} | Array 2: {value2}";
            label2.Text = $"Correct Guesses: {correctGuesses} | Incorrect Guesses: {incorrectGuesses}";

            button1.Enabled = true;
            button2.Enabled = true;
        }

        private void MakeGuess(int chosenArray)
        {
            int value1 = array1[index];
            int value2 = array2[index];

            if ((value1 > value2 && chosenArray == 1) || (value2 > value1 && chosenArray == 2))
            {
                correctGuesses++;
            }
            else
            {
                incorrectGuesses++;
            }

            DisplayValues();
            button1.Enabled = false;
            button2.Enabled = false;
        }
        private void NextGuess()
        {
            index++;
            if (index >= 100)
            {
                index = 0;
            }

            DisplayValues();
        }

        private int[] GenerateRandomArray()
        {
            Random random = new Random();
            return new int[100].Select(_ => random.Next(1, 100)).ToArray();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MakeGuess(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MakeGuess(2);
        }

         private void buttonNext_Click(object sender, EventArgs e)
        {
            NextGuess();
        }
    }

}
