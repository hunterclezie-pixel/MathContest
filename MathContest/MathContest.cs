/* 
Hunter Clezie 
Spring 2026
RCET2265
MathContest
github url: https://github.com/hunterclezie-pixel/MathContest.git
*/
namespace MathContest
{
    public partial class MathContest : Form
    {
        public MathContest()
        {
            InitializeComponent();
            SetDefaults();
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
        }

        //Event Handlers below here --------------------------------------------------------------

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
