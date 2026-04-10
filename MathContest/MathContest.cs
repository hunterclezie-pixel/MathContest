/* 
Hunter Clezie 
Spring 2026
RCET2265
MathContest
github url: https://github.com/hunterclezie-pixel/MathContest.git
*/
using System.Diagnostics.Eventing.Reader;

namespace MathContest
{
    /* 
    ToDo List:
    [x] Enter the child's name, grade (1-4), and age (7-11)
    [x] Choose a math problem type (add, subtract, multiply, divide) using radio buttons (add selected by default)
    [x] Validate all required information. Change the textbox color to light yellow for missing/incorrect fields
    [x] Lock the Submit button until all required fields are filled in correctly
    [x] Lock the Summary button until the Submit button has been clicked at least once
    [x] If the clear button is clicked, reset all fields to their default state
    [x] If any of the student information fields are changed reset the summary to its default state and consider it a new student
    [x] Generate new random numbers for each problem or whenever the problem type is changed
    [x] Do not allow the user to enter their own numbers
    [x] Allow the contestant to enter their answer and submit
    [x] Show a congratulations message if correct, or the correct answer if not
    [x] Keep a total of correct/incorrect responses for the current student and show a summary when requested
    */

    public partial class MathContest : Form
    {
        public MathContest()
        {
            InitializeComponent();
            SetDefaults();
            FirstNumberGenerator();
            SecondNumberGenerator();
        }

        int submitPushedNumber = 0;
        int correctAnswer = 0;
        int correctAnswerNumber = 0;

        //Custom Methids below here --------------------------------------------------------------

        //Sets defaults
        void SetDefaults()
        {
            StudentNameTextBox.Text = "";
            StudentNameTextBox.BackColor = Color.LightYellow;
            AgeTextBox.Text = "";
            AgeTextBox.BackColor = Color.LightYellow;
            GradeTextBox.Text = "";
            GradeTextBox.BackColor = Color.LightYellow;
            FirstNumberTextBox.Text = "";
            FirstNumberTextBox.Enabled = false;
            SecondNumberTextBox.Text = "";
            SecondNumberTextBox.Enabled = false;
            StudentAnswerTextBox.Text = "";
            StudentAnswerTextBox.BackColor = Color.LightYellow;
            AdditionRadioButton.Checked = true;
            SubmitButton.Enabled = false;
            SummaryButton.Enabled = false;
        }

        //Validates the contestant's information to unlock the submit button
        private bool ValidateFields()
        {
            bool valid = true;

            if (StudentNameTextBox.Text != "")
            {
                StudentNameTextBox.BackColor = Color.White;
            }
            else
            {
                StudentNameTextBox.BackColor = Color.LightYellow;
                valid = false;
            }

            try
            {
                if (int.Parse(AgeTextBox.Text) >= 7 && int.Parse(AgeTextBox.Text) <= 11)
                {
                    AgeTextBox.BackColor = Color.White;
                }
                else
                {
                    AgeTextBox.BackColor = Color.LightYellow;
                    valid = false;
                }
            }
            catch (Exception)
            {
                AgeTextBox.BackColor = Color.LightYellow;
                valid = false;
            }

            try
            {
                if (int.Parse(GradeTextBox.Text) >= 1 && int.Parse(GradeTextBox.Text) <= 4)
                {
                    GradeTextBox.BackColor = Color.White;
                }
                else
                {
                    GradeTextBox.BackColor = Color.LightYellow;
                    valid = false;
                }
            }
            catch (Exception)
            {
                GradeTextBox.BackColor = Color.LightYellow;
                valid = false;
            }

            if (StudentAnswerTextBox.Text != "")
            {
                StudentAnswerTextBox.BackColor = Color.White;
            }
            else
            {
                StudentAnswerTextBox.BackColor = Color.LightYellow;
                valid = false;
            }

            return valid;
        }

        //Random number generator for the first number in the math problem
        private void FirstNumberGenerator()
        {
            Random random = new Random();
            int firstNumber = random.Next(1, 11);
            FirstNumberTextBox.Text = firstNumber.ToString();
        }

        //Random number generator for the second number in the math problem
        private void SecondNumberGenerator()
        {
            Random random = new Random();
            int secondNumber = random.Next(1, 11);
            SecondNumberTextBox.Text = secondNumber.ToString();
        }

        //Provides the function to each math type offored by the radio buttons
        void MathFunction()
        {
            int firstNumber = int.Parse(FirstNumberTextBox.Text);
            int secondNumber = int.Parse(SecondNumberTextBox.Text);
            int studentAnswer = int.Parse(StudentAnswerTextBox.Text);

            if (AdditionRadioButton.Checked)
            {
                correctAnswer = firstNumber + secondNumber;
            }
            else if (SubtractionRadioButton.Checked)
            {
                correctAnswer = firstNumber - secondNumber;
            }
            else if (MultiplicationRadioButton.Checked)
            {
                correctAnswer = firstNumber * secondNumber;
            }
            else if (DivisionRadioButton.Checked)
            {
                correctAnswer = firstNumber / secondNumber;
            }
        }

        //Event Handlers below here --------------------------------------------------------------

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            MathFunction();
            if (int.Parse(StudentAnswerTextBox.Text) == correctAnswer)
            {
                MessageBox.Show("Congratulations! Your answer is correct.");
                correctAnswerNumber++;
            }
            else
            {
                MessageBox.Show($"Sorry, the correct answer is {correctAnswer}.");
            }
            //generate new random numbers for the next problem
            FirstNumberGenerator();
            SecondNumberGenerator();
            //finish function to check if the student's answer is correct and update the summary
            SummaryButton.Enabled = true;
            submitPushedNumber++;
        }

        private void SummaryButton_Click(object sender, EventArgs e)
        { 
            MessageBox.Show($"You have answered {correctAnswerNumber} problems correctly out of {submitPushedNumber}.");
            SetDefaults();
        }

        private void StudentNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (submitPushedNumber >= 1)
            {
                SetDefaults();
            }
            else
            {
                if (ValidateFields())
                {
                    SubmitButton.Enabled = true;
                }
                else
                {
                    SubmitButton.Enabled = false;
                }
            }
        }

        private void AgeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (submitPushedNumber >= 1)
            {
                SetDefaults();
            }
            else
            {
                if (ValidateFields())
                {
                    SubmitButton.Enabled = true;
                }
                else
                {
                    SubmitButton.Enabled = false;
                }
            }
        }

        private void GradeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (submitPushedNumber >= 1)
            {
                SetDefaults();
            }
            else
            {
                if (ValidateFields())
                {
                    SubmitButton.Enabled = true;
                }
                else
                {
                    SubmitButton.Enabled = false;
                }
            }
        }

        private void StudentAnswerTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                SubmitButton.Enabled = true;
            }
            else
            {
                SubmitButton.Enabled = false;
            }
        }
    }
}
