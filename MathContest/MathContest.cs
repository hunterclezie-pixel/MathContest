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
            AgeTextBox.Text = "";
            GradeTextBox.Text = "";
            FirstNumberTextBox.Text = "";
            SecondNumberTextBox.Text = "";
            StudentAnswerTextBox.Text = "";
            AdditionRadioButton.Checked = true;
            SubmitButton.Enabled = false;
            SummaryButton.Enabled = false;
        }

        private void ValidateSubmit(object sender, EventArgs e)
        {
            if (StudentNameTextBox.Text != "" && AgeTextBox.Text != "" && GradeTextBox.Text != "" && StudentAnswerTextBox.Text != "");
            {
                SubmitButton.Enabled = true;
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
