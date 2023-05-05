using System.Diagnostics.Eventing.Reader;

namespace MathQuiz
{
    public partial class Form1 : Form
    {
        Random randomizer = new Random();

        int addend1;
        int addend2;

        int minuend;
        int subtrahend;

        int multiplcationEnd;
        int multiplier;

        int dividend;
        int divisor;

        int timeLeft;

        public Form1()
        {
            InitializeComponent();
            dateLabel.Text = DateTime.Now.ToString("dd MMM yyyy");
        }

        public void StartTheQuiz()
        {

            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            // Random number put into each label so we can add them. But needs to be recognized as a string for the label.
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();

            sum.Value = 0;


            //Subtraction
            minuend = randomizer.Next(1, 51);
            subtrahend = randomizer.Next(1, minuend);

            subtractionLeftLabel.Text = minuend.ToString();
            subtractionRightLabel.Text = subtrahend.ToString();

            difference.Value = 0;

            //Multiplication
            multiplcationEnd = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            timesLeftLabel.Text = multiplcationEnd.ToString();
            timesRightLabel.Text = multiplier.ToString();

            product.Value = 0;

            //Division
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            dividedLeftLabel.Text = dividend.ToString();
            dividedRightLabel.Text = divisor.ToString();
            quotient.Value = 0;

            //Start timer.
            timeLeft = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;
            CheckTheAnswer();
        }
        private bool CheckTheAnswer()
        {
            if ((addend1 + addend2 == sum.Value)
                && (minuend - subtrahend == difference.Value)
                && (multiplcationEnd * multiplier == product.Value)
                && (dividend / divisor == quotient.Value))
                return true;
            else
                return false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                timer1.Stop();
                MessageBox.Show("Hooray! You got all the answers correct!  Great Job!!");
                startButton.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + " " + "Seconds";
                if (timeLeft <= 5)
                {
                    timeLabel.BackColor = Color.Red;
                }else
                {
                    timeLabel.BackColor = Control.DefaultBackColor;
                }
            }
            else
            {
                timer1.Stop();
                timeLabel.Text = "Your time is Up";
                MessageBox.Show("Sorry, you didn't finish in time.");
                sum.Value = addend1 + addend2;
                difference.Value = minuend - subtrahend;
                product.Value = multiplcationEnd * multiplier;
                quotient.Value = dividend / divisor;
                startButton.Enabled = true;

            }
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown; ;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }
    }
}