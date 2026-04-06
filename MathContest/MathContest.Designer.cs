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
            CurrentMathGroupBox = new GroupBox();
            MathTypeGroupBox = new GroupBox();
            SubmitButton = new Button();
            ClearButton = new Button();
            SummaryButton = new Button();
            ExitButton = new Button();
            ButtonGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // StudentInfoGroupBox
            // 
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
            // CurrentMathGroupBox
            // 
            CurrentMathGroupBox.Location = new Point(26, 156);
            CurrentMathGroupBox.Name = "CurrentMathGroupBox";
            CurrentMathGroupBox.Size = new Size(266, 282);
            CurrentMathGroupBox.TabIndex = 2;
            CurrentMathGroupBox.TabStop = false;
            CurrentMathGroupBox.Text = "Current Math Problem";
            // 
            // MathTypeGroupBox
            // 
            MathTypeGroupBox.Location = new Point(298, 156);
            MathTypeGroupBox.Name = "MathTypeGroupBox";
            MathTypeGroupBox.Size = new Size(238, 282);
            MathTypeGroupBox.TabIndex = 3;
            MathTypeGroupBox.TabStop = false;
            MathTypeGroupBox.Text = "Math Problem Type ";
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
            // ClearButton
            // 
            ClearButton.Location = new Point(6, 94);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(234, 68);
            ClearButton.TabIndex = 1;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
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
            // ExitButton
            // 
            ExitButton.Location = new Point(6, 242);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(234, 68);
            ExitButton.TabIndex = 3;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
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
            Text = "Form1";
            ButtonGroupBox.ResumeLayout(false);
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
    }
}
