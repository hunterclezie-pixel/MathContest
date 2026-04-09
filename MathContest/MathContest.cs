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
    [] Enter the child's name, grade (1-4), and age (7-11)
    [] Choose a math problem type (add, subtract, multiply, divide) using radio buttons (add selected by default)
    [] Validate all required information. Change the textbox color to light yellow for missing/incorrect fields
    [] Lock the Submit button until all required fields are filled in correctly
    [] Lock the Summary button until the Submit button has been clicked at least once
    [] If the clear button is clicked, reset all fields to their default state
    [] If any of the student information fields are changed reset the summary to its default state and consider it a new student
    [] Generate new random numbers for each problem or whenever the problem type is changed
    [] Do not allow the user to enter their own numbers
    [] Allow the contestant to enter their answer and submit
    [] Show a congratulations message if correct, or the correct answer if not
    [] Keep a total of correct/incorrect responses for the current student and show a summary when requested
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

        //Custom Methids below here --------------------------------------------------------------

        void SetDefaults()
        {
            StudentNameTextBox.Text = "";
            StudentNameTextBox.BackColor = Color.LightYellow;
            AgeTextBox.Text = "";
            AgeTextBox.BackColor = Color.LightYellow;
            GradeTextBox.Text = "";
            GradeTextBox.BackColor = Color.LightYellow;
            FirstNumberTextBox.Text = "";
            SecondNumberTextBox.Text = "";
            StudentAnswerTextBox.Text = "";
            StudentAnswerTextBox.BackColor = Color.LightYellow;
            AdditionRadioButton.Checked = true;
            SubmitButton.Enabled = false;
            SummaryButton.Enabled = false;
        }

        private void ValidateFields(object sender, EventArgs e)
        {
            bool valid = true;

            try
            {
                StudentNameTextBox.Text = "";
                StudentNameTextBox.BackColor = Color.White;
            }
            catch (Exception)
            {
                StudentNameTextBox.BackColor = Color.LightYellow;
                valid = false;
            }

            try
            {
                AgeTextBox.Text = "";
                AgeTextBox.BackColor = Color.White;
            }
            catch (Exception)
            {
                AgeTextBox.BackColor = Color.LightYellow;
                valid = false;
            }

            try
            {
                GradeTextBox.Text = "";
                GradeTextBox.BackColor = Color.White;
            }
            catch (Exception)
            {
                GradeTextBox.BackColor = Color.LightYellow;
                valid = false;
            }

            try
            {
                StudentAnswerTextBox.Text = "";
                StudentAnswerTextBox.BackColor = Color.White;
            }
            catch (Exception)
            {
                StudentAnswerTextBox.BackColor = Color.LightYellow;
                valid = false;
            }

            SubmitButton.Enabled = valid;
        }

        private void GradeCheck()
        {
            if (int.Parse(GradeTextBox.Text) >= 1 || int.Parse(GradeTextBox.Text) <= 4)
            {
                GradeTextBox.BackColor = Color.White;
                SubmitButton.Enabled = true;
            }
            else
            {
                GradeTextBox.BackColor = Color.LightYellow;
                SubmitButton.Enabled = false;
            }
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

        void MathFunction()
        {
            int firstNumber = int.Parse(FirstNumberTextBox.Text);
            int secondNumber = int.Parse(SecondNumberTextBox.Text);
            int studentAnswer = int.Parse(StudentAnswerTextBox.Text);
            int correctAnswer = 0;
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
    }
}
