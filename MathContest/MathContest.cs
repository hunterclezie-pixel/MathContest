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
