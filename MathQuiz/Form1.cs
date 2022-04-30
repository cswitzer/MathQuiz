using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace MathQuiz
{
    public partial class Form1 : Form
    {
        // used to generate random numbers
        Random randomizer = new Random();
        SoundPlayer soundPlayer = new SoundPlayer();

        // integer variables for addition
        int addend1;
        int addend2;

        // integer variables for subtraction
        int minuend;
        int subtrahend;

        // integer variables for multiplication
        int multiplicand;
        int multiplier;

        // integer variables for division
        int dividend;
        int divisor;

        // keep track of the amount of time left
        int timeLeft;

        public Form1()
        {
            InitializeComponent();
            // Set the date label
            DateTime currentDate = DateTime.Now;
            dateLabel.Text = currentDate.ToString("d MMMM yyyy");
        }

        public void StartTheQuiz()
        {
            // generate case for addition
            addend1 = randomizer.Next(51); // a random number between 0-50
            addend2 = randomizer.Next(51);

            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();
            sum.Value = 0;

            // generate case for subtraction
            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend); // subtrahend must be lower than minuend
            
            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahend.ToString();
            difference.Value = 0;

            // generate case for multiplication
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);

            productLeftLabel.Text = multiplicand.ToString();
            productRightLabel.Text = multiplier.ToString();
            product.Value = 0;

            // generate case for division
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient; // ensure the answer is a whole number

            divideLeftLabel.Text = dividend.ToString();
            divideRightLabel.Text = divisor.ToString();
            quotient.Value = 0;

            // Start the timer
            timeLeft = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;
        }

        private bool CheckTheAnswer()
        {
            if (addend1 + addend2 == sum.Value
                && minuend - subtrahend == difference.Value
                && multiplicand * multiplier == product.Value
                && dividend / divisor == quotient.Value)
                return true;
            else
                return false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                timer1.Stop();

                soundPlayer.SoundLocation = "C:\\Users\\Chase\\source\\repos\\MathQuiz\\MathQuiz\\Sounds\\tada.wav";
                soundPlayer.Play();

                MessageBox.Show("You got all the answers right!",
                                "Congratulations!");
                startButton.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + " seconds";
                if (timeLeft < 6) timeLabel.BackColor = Color.Red;
            }
            else
            {
                timer1.Stop();

                soundPlayer.SoundLocation = "C:\\Users\\Chase\\source\\repos\\MathQuiz\\MathQuiz\\Sounds\\game_over.wav";
                soundPlayer.Play();

                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");

                sum.Value = addend1 + addend2;
                difference.Value = minuend - subtrahend;
                product.Value = multiplicand * multiplier;
                quotient.Value = dividend / divisor;
                startButton.Enabled = true;
            }
        }

        private void sum_ValueChanged(object sender, EventArgs e)
        {
            bool correct = addend1 + addend2 == sum.Value ? true : false;
            if (correct)
            {
                soundPlayer.SoundLocation = "C:\\Users\\Chase\\source\\repos\\MathQuiz\\MathQuiz\\Sounds\\success.wav";
                soundPlayer.Play();
            }
        }

        private void difference_ValueChanged(object sender, EventArgs e)
        {
            bool correct = minuend - subtrahend == difference.Value ? true : false;
            if (correct)
            {
                soundPlayer.SoundLocation = "C:\\Users\\Chase\\source\\repos\\MathQuiz\\MathQuiz\\Sounds\\success.wav";
                soundPlayer.Play();
            }
        }

        private void product_ValueChanged(object sender, EventArgs e)
        {
            bool correct = multiplicand * multiplier == product.Value ? true : false;
            if (correct)
            {
                soundPlayer.SoundLocation = "C:\\Users\\Chase\\source\\repos\\MathQuiz\\MathQuiz\\Sounds\\success.wav";
                soundPlayer.Play();
            }
        }

        private void quotient_ValueChanged(object sender, EventArgs e)
        {
            bool correct = dividend * divisor == quotient.Value ? true : false;
            if (correct)
            {
                soundPlayer.SoundLocation = "C:\\Users\\Chase\\source\\repos\\MathQuiz\\MathQuiz\\Sounds\\success.wav";
                soundPlayer.Play();
            }
        }
    }
}
