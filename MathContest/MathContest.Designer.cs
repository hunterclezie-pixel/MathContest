namespace MathContest
{
    partial class MathContest
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            StudentInfoGroupBox = new GroupBox();
            ButtonGroupBox = new GroupBox();
            ExitButton = new Button();
            SummaryButton = new Button();
            ClearButton = new Button();
            SubmitButton = new Button();
            CurrentMathGroupBox = new GroupBox();
            MathTypeGroupBox = new GroupBox();
            StudentNameTextBox = new TextBox();
            GradeTextBox = new TextBox();
            AgeTextBox = new TextBox();
            StudentNameLabel = new Label();
            AgeLabel = new Label();
            GradeLabel = new Label();
            FirstNumberTextBox = new TextBox();
            SecondNumberTextBox = new TextBox();
            FirstNumberLabel = new Label();
            SecondNumberLabel = new Label();
            StudentAnswerLabel = new Label();
            textBox1 = new TextBox();
            AdditionRadioButton = new RadioButton();
            SubtractionRadioButton = new RadioButton();
            MultiplicationRadioButton = new RadioButton();
            DivisionRadioButton = new RadioButton();
            StudentInfoGroupBox.SuspendLayout();
            ButtonGroupBox.SuspendLayout();
            CurrentMathGroupBox.SuspendLayout();
            MathTypeGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // StudentInfoGroupBox
            // 
            StudentInfoGroupBox.Controls.Add(GradeLabel);
            StudentInfoGroupBox.Controls.Add(AgeLabel);
            StudentInfoGroupBox.Controls.Add(StudentNameLabel);
            StudentInfoGroupBox.Controls.Add(AgeTextBox);
            StudentInfoGroupBox.Controls.Add(GradeTextBox);
            StudentInfoGroupBox.Controls.Add(StudentNameTextBox);
            StudentInfoGroupBox.Location = new Point(26, 22);
            StudentInfoGroupBox.Name = "StudentInfoGroupBox";
            StudentInfoGroupBox.Size = new Size(510, 128);
            StudentInfoGroupBox.TabIndex = 0;
            StudentInfoGroupBox.TabStop = false;
            StudentInfoGroupBox.Text = "Student Information";
            // 
            // ButtonGroupBox
            // 
            ButtonGroupBox.Controls.Add(ExitButton);
            ButtonGroupBox.Controls.Add(SummaryButton);
            ButtonGroupBox.Controls.Add(ClearButton);
            ButtonGroupBox.Controls.Add(SubmitButton);
            ButtonGroupBox.Location = new Point(542, 22);
            ButtonGroupBox.Name = "ButtonGroupBox";
            ButtonGroupBox.Size = new Size(246, 416);
            ButtonGroupBox.TabIndex = 1;
            ButtonGroupBox.TabStop = false;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(6, 242);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(234, 68);
            ExitButton.TabIndex = 3;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            // 
            // SummaryButton
            // 
            SummaryButton.Location = new Point(6, 168);
            SummaryButton.Name = "SummaryButton";
            SummaryButton.Size = new Size(234, 68);
            SummaryButton.TabIndex = 2;
            SummaryButton.Text = "Summary";
            SummaryButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(6, 94);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(234, 68);
            ClearButton.TabIndex = 1;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(6, 20);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(234, 68);
            SubmitButton.TabIndex = 0;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            // 
            // CurrentMathGroupBox
            // 
            CurrentMathGroupBox.Controls.Add(StudentAnswerLabel);
            CurrentMathGroupBox.Controls.Add(textBox1);
            CurrentMathGroupBox.Controls.Add(SecondNumberLabel);
            CurrentMathGroupBox.Controls.Add(FirstNumberLabel);
            CurrentMathGroupBox.Controls.Add(SecondNumberTextBox);
            CurrentMathGroupBox.Controls.Add(FirstNumberTextBox);
            CurrentMathGroupBox.Location = new Point(26, 156);
            CurrentMathGroupBox.Name = "CurrentMathGroupBox";
            CurrentMathGroupBox.Size = new Size(266, 282);
            CurrentMathGroupBox.TabIndex = 2;
            CurrentMathGroupBox.TabStop = false;
            CurrentMathGroupBox.Text = "Current Math Problem";
            // 
            // MathTypeGroupBox
            // 
            MathTypeGroupBox.Controls.Add(DivisionRadioButton);
            MathTypeGroupBox.Controls.Add(MultiplicationRadioButton);
            MathTypeGroupBox.Controls.Add(SubtractionRadioButton);
            MathTypeGroupBox.Controls.Add(AdditionRadioButton);
            MathTypeGroupBox.Location = new Point(298, 156);
            MathTypeGroupBox.Name = "MathTypeGroupBox";
            MathTypeGroupBox.Size = new Size(238, 282);
            MathTypeGroupBox.TabIndex = 3;
            MathTypeGroupBox.TabStop = false;
            MathTypeGroupBox.Text = "Math Problem Type ";
            // 
            // StudentNameTextBox
            // 
            StudentNameTextBox.Location = new Point(6, 78);
            StudentNameTextBox.Name = "StudentNameTextBox";
            StudentNameTextBox.Size = new Size(260, 27);
            StudentNameTextBox.TabIndex = 0;
            // 
            // GradeTextBox
            // 
            GradeTextBox.Location = new Point(334, 78);
            GradeTextBox.Name = "GradeTextBox";
            GradeTextBox.Size = new Size(31, 27);
            GradeTextBox.TabIndex = 1;
            // 
            // AgeTextBox
            // 
            AgeTextBox.Location = new Point(281, 78);
            AgeTextBox.Name = "AgeTextBox";
            AgeTextBox.Size = new Size(31, 27);
            AgeTextBox.TabIndex = 2;
            // 
            // StudentNameLabel
            // 
            StudentNameLabel.AutoSize = true;
            StudentNameLabel.Location = new Point(6, 55);
            StudentNameLabel.Name = "StudentNameLabel";
            StudentNameLabel.Size = new Size(113, 20);
            StudentNameLabel.TabIndex = 3;
            StudentNameLabel.Text = "Student's Name";
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Location = new Point(281, 55);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(36, 20);
            AgeLabel.TabIndex = 4;
            AgeLabel.Text = "Age";
            // 
            // GradeLabel
            // 
            GradeLabel.AutoSize = true;
            GradeLabel.Location = new Point(325, 55);
            GradeLabel.Name = "GradeLabel";
            GradeLabel.Size = new Size(49, 20);
            GradeLabel.TabIndex = 5;
            GradeLabel.Text = "Grade";
            // 
            // FirstNumberTextBox
            // 
            FirstNumberTextBox.Location = new Point(6, 64);
            FirstNumberTextBox.Name = "FirstNumberTextBox";
            FirstNumberTextBox.Size = new Size(254, 27);
            FirstNumberTextBox.TabIndex = 0;
            // 
            // SecondNumberTextBox
            // 
            SecondNumberTextBox.Location = new Point(6, 128);
            SecondNumberTextBox.Name = "SecondNumberTextBox";
            SecondNumberTextBox.Size = new Size(254, 27);
            SecondNumberTextBox.TabIndex = 1;
            // 
            // FirstNumberLabel
            // 
            FirstNumberLabel.AutoSize = true;
            FirstNumberLabel.Location = new Point(6, 41);
            FirstNumberLabel.Name = "FirstNumberLabel";
            FirstNumberLabel.Size = new Size(94, 20);
            FirstNumberLabel.TabIndex = 2;
            FirstNumberLabel.Text = "First Number";
            // 
            // SecondNumberLabel
            // 
            SecondNumberLabel.AutoSize = true;
            SecondNumberLabel.Location = new Point(6, 105);
            SecondNumberLabel.Name = "SecondNumberLabel";
            SecondNumberLabel.Size = new Size(116, 20);
            SecondNumberLabel.TabIndex = 3;
            SecondNumberLabel.Text = "Second Number";
            // 
            // StudentAnswerLabel
            // 
            StudentAnswerLabel.AutoSize = true;
            StudentAnswerLabel.Location = new Point(6, 174);
            StudentAnswerLabel.Name = "StudentAnswerLabel";
            StudentAnswerLabel.Size = new Size(121, 20);
            StudentAnswerLabel.TabIndex = 5;
            StudentAnswerLabel.Text = "Student's Answer";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 197);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(254, 27);
            textBox1.TabIndex = 4;
            // 
            // AdditionRadioButton
            // 
            AdditionRadioButton.AutoSize = true;
            AdditionRadioButton.Location = new Point(9, 51);
            AdditionRadioButton.Name = "AdditionRadioButton";
            AdditionRadioButton.Size = new Size(88, 24);
            AdditionRadioButton.TabIndex = 0;
            AdditionRadioButton.TabStop = true;
            AdditionRadioButton.Text = "Addition";
            AdditionRadioButton.UseVisualStyleBackColor = true;
            // 
            // SubtractionRadioButton
            // 
            SubtractionRadioButton.AutoSize = true;
            SubtractionRadioButton.Location = new Point(9, 92);
            SubtractionRadioButton.Name = "SubtractionRadioButton";
            SubtractionRadioButton.Size = new Size(106, 24);
            SubtractionRadioButton.TabIndex = 1;
            SubtractionRadioButton.TabStop = true;
            SubtractionRadioButton.Text = "Subtraction";
            SubtractionRadioButton.UseVisualStyleBackColor = true;
            // 
            // MultiplicationRadioButton
            // 
            MultiplicationRadioButton.AutoSize = true;
            MultiplicationRadioButton.Location = new Point(9, 131);
            MultiplicationRadioButton.Name = "MultiplicationRadioButton";
            MultiplicationRadioButton.Size = new Size(122, 24);
            MultiplicationRadioButton.TabIndex = 2;
            MultiplicationRadioButton.TabStop = true;
            MultiplicationRadioButton.Text = "Multiplication";
            MultiplicationRadioButton.UseVisualStyleBackColor = true;
            // 
            // DivisionRadioButton
            // 
            DivisionRadioButton.AutoSize = true;
            DivisionRadioButton.Location = new Point(9, 170);
            DivisionRadioButton.Name = "DivisionRadioButton";
            DivisionRadioButton.Size = new Size(83, 24);
            DivisionRadioButton.TabIndex = 3;
            DivisionRadioButton.TabStop = true;
            DivisionRadioButton.Text = "Division";
            DivisionRadioButton.UseVisualStyleBackColor = true;
            // 
            // MathContest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MathTypeGroupBox);
            Controls.Add(CurrentMathGroupBox);
            Controls.Add(ButtonGroupBox);
            Controls.Add(StudentInfoGroupBox);
            Name = "MathContest";
            Text = "Math Contest";
            StudentInfoGroupBox.ResumeLayout(false);
            StudentInfoGroupBox.PerformLayout();
            ButtonGroupBox.ResumeLayout(false);
            CurrentMathGroupBox.ResumeLayout(false);
            CurrentMathGroupBox.PerformLayout();
            MathTypeGroupBox.ResumeLayout(false);
            MathTypeGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox StudentInfoGroupBox;
        private GroupBox ButtonGroupBox;
        private GroupBox CurrentMathGroupBox;
        private GroupBox MathTypeGroupBox;
        private Button ExitButton;
        private Button SummaryButton;
        private Button ClearButton;
        private Button SubmitButton;
        private Label AgeLabel;
        private Label StudentNameLabel;
        private TextBox AgeTextBox;
        private TextBox GradeTextBox;
        private TextBox StudentNameTextBox;
        private Label GradeLabel;
        private TextBox FirstNumberTextBox;
        private Label StudentAnswerLabel;
        private TextBox textBox1;
        private Label SecondNumberLabel;
        private Label FirstNumberLabel;
        private TextBox SecondNumberTextBox;
        private RadioButton DivisionRadioButton;
        private RadioButton MultiplicationRadioButton;
        private RadioButton SubtractionRadioButton;
        private RadioButton AdditionRadioButton;
    }
}
